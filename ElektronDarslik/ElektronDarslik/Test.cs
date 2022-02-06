using System;
using System.Windows.Forms;

namespace ElektronDarslik
{
    public partial class Test : Form
    {
        private int Num = 1;
        private string Path = "C:\\Elektron darslik\\Data\\Test\\";
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            PdfFile.LoadFile(Path+Num.ToString()+".pdf");
        }

        // prev btn
        private void button1_Click(object sender, EventArgs e)
        {
            Num--;
            if (Num > 0 && Num < 3)
                PdfFile.LoadFile(Path + Num.ToString() + ".pdf");
            else
                Num++;
        }

        // next btn
        private void BtnNext_Click(object sender, EventArgs e)
        {
            Num++;
            if (Num > 0 && Num < 3)
                PdfFile.LoadFile(Path + Num.ToString() + ".pdf");
            else
                Num--;
        }
    }
}
