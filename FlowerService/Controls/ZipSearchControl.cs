using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerService
{
    public partial class ZipSearchControl : UserControl
    {
        public string ZipCode { get { return textBox1.Text; } }
        public string Address1 { get { return textBox2.Text; } }
        public string Address2 { get { return textBox3.Text; } }

        public ZipSearchControl()
        {
            InitializeComponent();
        }

        private void btnJuso_Click(object sender, EventArgs e)
        {
            ZipSearchPopup pop = new ZipSearchPopup();
            if (pop.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = pop.ZipcCode;
                textBox2.Text = pop.Address1;
                textBox3.Text = pop.Address2;
            }
        }
    }
}