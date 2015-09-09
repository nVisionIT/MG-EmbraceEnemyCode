using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace payroll.Forms
{
    public partial class Deduction : Form
    {
        public Deduction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SSS obj = new SSS();
            obj.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PagIbig obj = new PagIbig();
            obj.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Tax obj = new Tax();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Philheath obj = new Philheath();
            obj.Show();
        }
    }
}
