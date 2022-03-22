using System;
using System.Windows.Forms;

namespace ElektronDarslik
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            string file = "C:\\Program Files (x86)\\Elektron darslik\\Data\\Intro\\Intro.pdf";
            IntroPage.LoadFile(file);
        }
    }
}
