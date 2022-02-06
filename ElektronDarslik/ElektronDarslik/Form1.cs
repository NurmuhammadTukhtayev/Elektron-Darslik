using System;
using System.Windows.Forms;

namespace ElektronDarslik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIntro_Click(object sender, EventArgs e)
        {
            Intro intro = new Intro();
            intro.ShowDialog();            
        }

        private void BtnLec_Click(object sender, EventArgs e)
        {
            Lectures lectures = new Lectures();
            lectures.ShowDialog();
        }

        private void BtnPrac_Click(object sender, EventArgs e)
        {
            Practice practice = new Practice();
            practice.ShowDialog();
        }

        private void BtnIndepend_Click(object sender, EventArgs e)
        {
            Independ independ = new Independ();
            independ.ShowDialog();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            Test test = new Test();
            test.ShowDialog();
        }

        private void BtnGlos_Click(object sender, EventArgs e)
        {
            Glossary glossary = new Glossary();
            glossary.ShowDialog();
        }
    }
}
