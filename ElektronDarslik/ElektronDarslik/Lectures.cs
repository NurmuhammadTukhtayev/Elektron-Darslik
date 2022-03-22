using System;
using System.Windows.Forms;

namespace ElektronDarslik
{
    public partial class Lectures : Form
    {
        private string Path = "C:\\Program Files (x86)\\Elektron darslik\\Data\\Lecture\\";
        public Lectures()
        {
            InitializeComponent();
        }

        private void Lec1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 1);
            showpage.Show();
        }

        private void Lec2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 2);
            showpage.Show();
        }

        private void Lex3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 3);
            showpage.Show();
        }

        private void Lec4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 4);
            showpage.Show();
        }

        private void Lec5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 5);
            showpage.Show();
        }

        private void Lec6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 6);
            showpage.Show();
        }

        private void Lec7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 7);
            showpage.Show();
        }

        private void Lec8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 8);
            showpage.Show();
        }

        private void Lec9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 9);
            showpage.Show();
        }

        private void Lec10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 10);
            showpage.Show();
        }

        private void Lec11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 11);
            showpage.Show();
        }

        private void Lec12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 12);
            showpage.Show();
        }

        // Lec18 is 13
        private void Lec18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 13);
            showpage.Show();
        }

        private void Lec13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 14);
            showpage.Show();
        }

        private void Lec14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 15);
            showpage.Show();
        }

        private void Lec15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 16);
            showpage.Show();
        }

        private void Lec16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 17);
            showpage.Show();
        }

        private void Lec17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPage showpage = new ShowPage(Path, 18);
            showpage.Show();
        }

        private void Lectures_Load(object sender, EventArgs e)
        {

        }
    }
}
