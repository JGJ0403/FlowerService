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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //유효성검사
            if (txtID.Text.Trim().Length < 1 || txtPwd.Text.Trim().Length < 1)
                return;

            MemberDB db = new MemberDB();
            Member member = db.Login(txtID.Text.Trim(), txtPwd.Text.Trim());
            db.Dispose();

            Main m = new Main();
            if (member == null)
            {
                MessageBox.Show("회원정보가 없습니다. 다시 확인하여 주십시오.");
            }
            else
            {
                //if (member.IsAdmin == "Y")
                //    MessageBox.Show("관리자로 로그인하셨습니다.");
                //else
                //    MessageBox.Show($"{member.Name}님 환영합니다.");
                this.Hide();
                m.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pwdSearch pwd = new pwdSearch();
            pwd.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MemberDB db = new MemberDB();
            DataTable dt = db.GetCodeListByCategory("SCHOOL");

            DataRow dr = dt.NewRow();
            dr["Code"] = "";
            dr["CodeName"] = "선택";
            dt.Rows.InsertAt(dr, 0);
            dt.AcceptChanges();

            comboBox1.DisplayMember = "CodeName";
            comboBox1.ValueMember = "Code";
            comboBox1.DataSource = dt;

            //comboBox1.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string schCode = comboBox1.SelectedValue.ToString();
            string schName = comboBox1.Text;

            MessageBox.Show(schCode + "/" + schName);
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text.Trim().Length < 1 || txtPwd.Text.Trim().Length < 1)
                return;

            MemberDB db = new MemberDB();
            Member member = db.Login(txtID.Text.Trim(), txtPwd.Text.Trim());
            db.Dispose();

            if (member == null)
            {
                MessageBox.Show("회원정보가 없습니다. 다시 확인하여 주십시오.");
            }
            else
            {
                if (member.IsAdmin == "Y")
                    MessageBox.Show("관리자로 로그인하셨습니다.");

                else
                {
                    MessageBox.Show($"{member.Name}님 환영합니다.");
                    Main m = new Main();
                    m.Show();

                    Login login = new Login();
                    login.Close();
                }
                    
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign sign = new Sign();
            sign.Show();
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pwdSearch ps = new pwdSearch();
            ps.Show();
        }
    }
}
