using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lyrics
{

    public partial class Form1 : Form
    {
        List<Tuple<string, string, string>> lDatas = new List<Tuple<string, string, string>>();
         
        public Form1()
        {
            InitializeComponent();
            SetLyricsDatas();            
        }

        private void SetLyricsDatas()
        {
            lDatas.Add(new Tuple<string, string, string>("Test Title1",  "Test Name1",  "Test Lyrics1"));
            lDatas.Add(new Tuple<string, string, string>("Test Title2",  "Test Name2",  "Test Lyrics2"));
            lDatas.Add(new Tuple<string, string, string>("Test Title3",  "Test Name3",  "Test Lyrics3"));
            lDatas.Add(new Tuple<string, string, string>("Test Title4",  "Test Name4",  "Test Lyrics4"));
            lDatas.Add(new Tuple<string, string, string>("Test Title5",  "Test Name5",  "Test Lyrics5"));
            lDatas.Add(new Tuple<string, string, string>("Test Title6",  "Test Name6",  "Test Lyrics6"));
            lDatas.Add(new Tuple<string, string, string>("Test Title7",  "Test Name7",  "Test Lyrics7"));
            lDatas.Add(new Tuple<string, string, string>("Test Title8",  "Test Name8",  "Test Lyrics8"));
            lDatas.Add(new Tuple<string, string, string>("Test Title9",  "Test Name9",  "Test Lyrics9"));
            lDatas.Add(new Tuple<string, string, string>("Test Title10", "Test Name10", "Test Lyrics10"));
            SetComboBoxDatas();
        }

        private void SetComboBoxDatas()
        {            
            comboBox1.DataSource = lDatas;
            comboBox1.DisplayMember = "Item1";
            comboBox1.ValueMember = "Item2";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDown;
            comboBox1.FormattingEnabled = true;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            int idx = cb.SelectedIndex;

            Tuple<string, string, string> tuple = lDatas[idx];

            string strName = tuple.Item2.ToString();
            textBox1.Text = strName;

            string lyrics = tuple.Item3.ToString();
            richTextBox1.Text = lyrics;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            string filter = comboBox1.Text.ToLower();

            if (String.IsNullOrWhiteSpace(filter)) comboBox1.DataSource = lDatas;
            else comboBox1.DataSource = lDatas.FindAll(i => i.Item1.ToLower().StartsWith(filter)).ToList();

            comboBox1.DroppedDown = true;
            //comboBox1.SelectedIndex = -1;
            comboBox1.Text = filter;

            comboBox1.SelectionStart = filter.Length;
            comboBox1.SelectionLength = 0;
        }
    }
}
