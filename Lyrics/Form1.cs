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
        BindingList<Lyrics> lDatas = null;
        FenetreAjouter formAjouter = null;
        Lyrics activeLyrics = null;
        string path = @"lyrics.xml";

        public Form1()
        {
            InitializeComponent();
            SetLyricsDatas();
            lDatas.ListChanged += DatasChangeHandler;
        }

        private void DatasChangeHandler(object sender, ListChangedEventArgs e)
        {
            Lyrics lyrics = null;
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                lyrics = lDatas[e.NewIndex];
                cbx_Names.SelectedIndex = e.NewIndex;
            }
            else if(e.ListChangedType == ListChangedType.ItemDeleted)
            {
                if (lDatas.Count == 0)
                {
                    tbx_Titre.Text = string.Empty;
                    rtb_Texte.Rtf = string.Empty;
                    activeLyrics = null;
                    return;
                }
                else
                {
                    lyrics = lDatas[0];
                    cbx_Names.SelectedIndex = 0;
                }
            }

            tbx_Titre.Text = lyrics.Title.ToString();
            rtb_Texte.Rtf = lyrics.Texte;
            activeLyrics = lyrics;
        }

        private void SetLyricsDatas()
        {
            try {
                if (File.Exists(path))
                {
                    // Read data from XML
                    XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Lyrics>));
                    using (FileStream fs = File.OpenRead(path))
                    {
                        lDatas = (BindingList<Lyrics>)serializer.Deserialize(fs);
                    }
                }
                else
                {
                    lDatas = new BindingList<Lyrics>();
                }
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Read failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            SetComboBoxDatas();
        }

        private void SetComboBoxDatas()
        {
            cbx_Names.DataSource = lDatas;
            cbx_Names.DisplayMember = "Name";
            cbx_Names.ValueMember = "Title";
            cbx_Names.DropDownStyle = ComboBoxStyle.DropDown;
            cbx_Names.FormattingEnabled = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lDatas.Count == 0)
            {
                tbx_Titre.Text = string.Empty;
                rtb_Texte.Rtf = string.Empty;
                activeLyrics = null;
                return;
            }
            
            Lyrics lyrics = lDatas[((ComboBox)sender).SelectedIndex];
            
            tbx_Titre.Text = lyrics.Title.ToString();
            rtb_Texte.Rtf = lyrics.Texte;

            activeLyrics = lyrics;
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            string filter = cbx_Names.Text.ToLower();

            if (String.IsNullOrWhiteSpace(filter)) cbx_Names.DataSource = lDatas;
            else cbx_Names.DataSource = lDatas.Where(i => i.Name.ToLower().StartsWith(filter)).ToList();

            cbx_Names.DroppedDown = true;
            cbx_Names.Text = filter;

            cbx_Names.SelectionStart = filter.Length;
            cbx_Names.SelectionLength = 0;
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
            formAjouter = null;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (activeLyrics == null) return;
            activeLyrics.Texte = rtb_Texte.Rtf;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                using (Stream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Lyrics>));
                    serializer.Serialize(fs, lDatas);
                }
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message, "Save failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if(res == DialogResult.Cancel) e.Cancel = true; 
            }            
        }

        private void btn_Bold_Click(object sender, EventArgs e)
        {
            int idxStart = rtb_Texte.SelectionStart;
            int selectLenght = rtb_Texte.SelectionLength;

            //Gras
            rtb_Texte.SelectionFont = (rtb_Texte.SelectionFont.Bold)?
                new Font(rtb_Texte.SelectionFont, FontStyle.Regular) : new Font(rtb_Texte.SelectionFont, FontStyle.Bold);

            rtb_Texte.Focus();
        }

        private void btn_Gray_Click(object sender, EventArgs e)
        {
            int idxStart = rtb_Texte.SelectionStart;
            int selectLenght = rtb_Texte.SelectionLength;

            //Gris
            rtb_Texte.SelectionColor = (rtb_Texte.SelectionColor.Equals(Color.Gray))?
                Color.Black : Color.Gray;

            rtb_Texte.Focus();
        }

        private void btn_Supprimer_Click(object sender, EventArgs e)
        {
            if (activeLyrics == null) return;
            DialogResult res = MessageBox.Show($"Supprimer {activeLyrics.Name} ?", "Read failed", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (res==DialogResult.OK){
                lDatas.Remove(activeLyrics);
            }
        }
    }
}
