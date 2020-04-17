using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TieqViet
{
    public partial class Main : Form
    {
 
        public Main()
        {
            InitializeComponent();
        }

        private void txtIn_TextChanged(object sender, EventArgs e)
        {
            //Input
            String temp = txtIn.Text;
            //Translate
            #region Don't open!
            temp =
                temp.Replace("x","s");
            temp =
                temp.Replace("X", "S");
            temp =
                temp.Replace("C" + "([^h]|[^H]", "K");
            temp =
                temp.Replace("c"+"([^h]|[^H])", "k");
            temp =
                temp.Replace("q","k");
            temp =
                temp.Replace("Q", "K");
            temp =
                temp.Replace("ch", "c");
            temp =
                temp.Replace("Ch", "C");
            temp =
                temp.Replace("CH", "C");
            temp =
                temp.Replace("cH", "c");
            temp =
                temp.Replace("cH", "c");
            temp =
                temp.Replace("tr", "c");
            temp =
                temp.Replace("Tr", "C");
            temp =
                temp.Replace("TR", "C");
            temp =
                temp.Replace("tR", "c");
            temp =
                temp.Replace("Kh","X");
            temp =
                temp.Replace("KH", "X");
            temp =
                temp.Replace("kH", "x");
            temp =
                temp.Replace("kh", "x");
            temp =
                temp.Replace("Đ","D");
            temp =
               temp.Replace("đ", "d");
            temp =
                temp.Replace("gh","g");
            temp =
                temp.Replace("Gh", "G");
            temp =
                temp.Replace("GH", "G");
            temp =
                temp.Replace("gH", "g");
            temp =
                temp.Replace("ph", "f");
            temp =
                temp.Replace("Ph", "F");
            temp =
                temp.Replace("PH", "F");
            temp =
                temp.Replace("pH", "f");
            temp =
                temp.Replace("ngh", "ng");
            temp =
                temp.Replace("Ngh", "Ng");
            temp =
                temp.Replace("NGh", "Ng");
            temp =
                temp.Replace("NgH", "Ng");
            temp =
                temp.Replace("nGH", "ng");
            temp =
                temp.Replace("nGh", "ng");
            temp =
                temp.Replace("ngH", "ng");
            temp =
                temp.Replace("NGH", "NG");
            temp =
                temp.Replace("ng", "w");
            temp =
                temp.Replace("Ng", "W");
            temp =
                temp.Replace("NG", "W");
            temp =
                temp.Replace("nG", "w");
            temp =
                temp.Replace("th", "q");
            temp =
                temp.Replace("Th", "Q");
            temp =
                temp.Replace("TH", "Q");
            temp =
                temp.Replace("tH", "q");
            temp =
                temp.Replace("([d]|[gi]|[r]|[gI])", "z");
            temp =
                temp.Replace("([D]|[Gi]|[GI]|[R])", "Z");
            temp =
                temp.Replace("([Nh]|[NH])", "N'");
            temp =
                temp.Replace("([nh]|[nH])", "n'");
            #endregion
            //Output
            TxtOut.Text = temp;

        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TxtOut.Text+"___Translate by Huy Trịnh Program");
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtIn.Text = "Credit by Huy Trịnh";
            TxtOut.Text = "";
            Clipboard.SetText(" ");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Form3 about = new Form3();
                about.ShowDialog();       
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thoát?", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
