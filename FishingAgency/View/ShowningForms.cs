using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishingAgency.View
{
    public partial class ShowningForms : Form
    {
        public ShowningForms()
        {
            InitializeComponent();
        }

        private void ShowningForms_Load(object sender, EventArgs e)
        {
            label1.Text = "zdarsyti";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
    }
}
