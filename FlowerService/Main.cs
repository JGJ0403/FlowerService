using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerService
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void 상품ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmItem frm2 = new frmItem();
            frm2.Show();
        }

        private void 회원관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminUser user = new adminUser();
            user.Show();
        }
    }
}
