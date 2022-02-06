using System;
using System.Windows.Forms;

namespace ElektronDarslik
{
    public partial class ShowPage : Form
    {
        private int Num;
        private string Path;
        private string FileName;
        public ShowPage(string path, int num)
        {
            //Path includes Path
            Path = path;

            // num is Number of Doc
            Num = num;

            // FileName
            FileName = Path+Num.ToString()+".pdf";

            //MessageBox.Show(Path+num.ToString());

            InitializeComponent();
        }

        private void ShowPage_Load(object sender, EventArgs e)
        {
            // MessageBox.Show(FileName);
            PdfFile.LoadFile(FileName);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            Num++;
            if (Num > 0 && Num < 19)
                FileName = Path + Num.ToString() + ".pdf";
            else
                Num--;

            // MessageBox.Show(FileName);
            PdfFile.LoadFile(FileName);

        }

        // prev button click
        private void button1_Click(object sender, EventArgs e)
        {
           Num--;
            if (Num < 19 && Num > 0)
                FileName = Path + Num.ToString() + ".pdf";
            else
                Num++;

            //MessageBox.Show(FileName);
            PdfFile.LoadFile(FileName);
        }
    }
}
