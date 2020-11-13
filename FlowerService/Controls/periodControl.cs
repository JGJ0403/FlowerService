using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerService.Controls
{
    public partial class periodControl : UserControl
    {
        public DateTime PeriodStart { get { return dtpStart.Value; } }
        public DateTime PeriodEnd { get { return dtpEnd.Value; } }

        public periodControl()
        {
            InitializeComponent();
        }

        private void periodControl_Load(object sender, EventArgs e)
        { //기본값
            dtpStart.Value = dtpEnd.Value = DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        { // 1주
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = dtpEnd.Value.AddDays(-7);
        }

        private void button4_Click(object sender, EventArgs e)
        { // 1달
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = dtpEnd.Value.AddMonths(-1);
        }

        private void button5_Click(object sender, EventArgs e)
        { // 3달
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = dtpEnd.Value.AddMonths(-3);
        }

        private void button6_Click(object sender, EventArgs e)
        {// 6달
            dtpEnd.Value = DateTime.Now;
            dtpStart.Value = dtpEnd.Value.AddMonths(-6);
        }

        private void dtpStart_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
                MessageBox.Show("검색기간의 설정이 잘못되었습니다.");
        }

        private void dtpEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpStart.Value > dtpEnd.Value)
                MessageBox.Show("검색기간의 설정이 잘못되었습니다.");
        }
    }
}
