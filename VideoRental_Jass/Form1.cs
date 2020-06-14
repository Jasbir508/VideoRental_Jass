using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRental_Jass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowDialog(Form frm)
        {
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDialog(new AddCustomer() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDialog(new ViewCustomer() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowDialog(new IssueMovie() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowDialog(new AddMovie() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowDialog(new ViewMovie() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowDialog(new ReturnMovie() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowDialog(new ViewBoth() { StartPosition = FormStartPosition.CenterScreen });

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

        }
    }
}
