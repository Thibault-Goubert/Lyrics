using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Lyrics
{
    public partial class Form1 : Form
    {
        List<Lyrics> lDatas = null;
        FenetreAjouter formAjouter = null;
        Lyrics activeLyrics = null;
        string path = @"lyrics.xml";

        public Form1()
        {
            InitializeComponent();
            SetLyricsDatas();            
        }

        private void SetLyricsDatas()
        {
            try {
                if (File.Exists(path))
                {
                    // Read data from XML
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Lyrics>));
                    using (FileStream fs = File.OpenRead(path))
                    {
                        lDatas = (List<Lyrics>)serializer.Deserialize(fs);
                    }
                }
                else
                {
                    lDatas = new List<Lyrics>();
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Read failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
            
            SetComboBoxDatas();
        }

        private void SetComboBoxDatas()
        {            
            comboBox1.DataSource = lDatas;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Title";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.FormattingEnabled = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lDatas.Count == 0) return;

            ComboBox cb = (ComboBox)sender;

            int idx = cb.SelectedIndex;
            Lyrics lyrics = lDatas[idx];
            
            textBox1.Text = lyrics.Title.ToString();
            richTextBox1.Text = lyrics.Texte.ToString();

            activeLyrics = lyrics;
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            string filter = comboBox1.Text.ToLower();

            if (String.IsNullOrWhiteSpace(filter)) comboBox1.DataSource = lDatas;
            else comboBox1.DataSource = lDatas.FindAll(i => i.Name.ToLower().StartsWith(filter)).ToList();

            comboBox1.DroppedDown = true;
            comboBox1.Text = filter;

            comboBox1.SelectionStart = filter.Length;
            comboBox1.SelectionLength = 0;
        }

        private void btn_Ajouter_Click(object sender, EventArgs e)
        {
            if(formAjouter == null)
            {
                formAjouter = new FenetreAjouter(lDatas);
                formAjouter.FormClosed += onFenetreAjouterClosed;
                formAjouter.ShowDialog();
            }
        }

        private void onFenetreAjouterClosed(object sender, EventArgs e)
        {
            SetComboBoxDatas();
            formAjouter = null;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            activeLyrics.Texte = richTextBox1.Text;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (Stream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Lyrics>));
                    serializer.Serialize(fs, lDatas);
                }
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message, "Save failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if(res == DialogResult.Cancel) e.Cancel = true; 
            }            
        }
    }
}
