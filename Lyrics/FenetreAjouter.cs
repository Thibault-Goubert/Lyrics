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
    public partial class FenetreAjouter : Form
    {
        List<Lyrics> Datas { get; set; }

        public FenetreAjouter(List<Lyrics> ldatas)
        {
            InitializeComponent();
            Datas = ldatas;
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            Lyrics newLyrics = new Lyrics(tbx_Nom.Text, tbx_Titre.Text, string.Empty);
            Datas.Add(newLyrics);
            this.Close();
        }
    }
}
