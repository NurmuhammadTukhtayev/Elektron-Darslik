using System;
using System.Windows.Forms;

namespace ElektronDarslik
{
    public partial class Glossary : Form
    {
        private string file = "C:\\Elektron darslik\\Data\\Glossary\\1.pdf";
        public Glossary()
        {
            InitializeComponent();
        }

        private void Glossary_Load(object sender, EventArgs e)
        {
            GlossaryPage.LoadFile(file);
        }
    }
}
