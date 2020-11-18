﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowerService
{
    public partial class pwdSearch : Form
    {
        public pwdSearch()
        {
            InitializeComponent();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            pwdSearch pwd = new pwdSearch();
            pwd.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //유효성 검사
            if (txtIDS.Text.Trim().Length < 1 || txtNameS.Text.Trim().Length < 1
                || txtEmailS.Text.Trim().Length < 1)
                return;

            MemberDB db = new MemberDB();
            //입력정보가 적합한지 체크
            int result = db.SearchPwd(txtIDS.Text.Trim(), txtNameS.Text.Trim(), txtEmailS.Text.Trim());
            if (result < 1)
            {
                MessageBox.Show("회원정보가 없습니다.");
                return;
            }

            //비밀번호 신규생성 로직

            //새로운 비밀번호를 난수로 생성해서
            string newPwd = CreatePassword();

            //새로운 비밀번호로 회원정보를 update하고,
            bool flag = db.UpdatePwd(newPwd, txtIDS.Text.Trim());
            if (flag)
            {
                //새로운 비밀번호를 메일로 발송해주는 것
                flag = SendMail(txtNameS.Text, txtEmailS.Text, txtIDS.Text, newPwd);
                if (flag)
                {
                    MessageBox.Show("초기화된 비밀번호를 Email로 발송하였습니다.");
                }
                else
                {
                    MessageBox.Show("메일 발송 중 오류가 발생했습니다.");
                }
            }
            else
            {
                MessageBox.Show("비밀번호 변경 중 오류가 발생했습니다.");
            }
        }

        private string CreatePassword()
        {
            Random rnd = new Random();

            //신규비밀번호 = 난수8자리(영문대문자 + 숫자)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 8; i++)
            {
                int val = rnd.Next(0, 36); //0~35 (0~9=>숫자, 10~35=>영문자)
                if (val < 10)              //숫자
                    sb.Append(val);
                else                       //영문대문자 (65~90)
                    sb.Append((char)(val + 55));
            }

            return sb.ToString();
        }

        private bool SendMail(string name, string email, string id, string newPwd)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.UseDefaultCredentials = false; //시스템에 설정된 인증 정보를 사용하지 않는다.
                client.EnableSsl = true; //SSL을 사용한다.
                client.DeliveryMethod = SmtpDeliveryMethod.Network; //Gmail 인증
                client.Credentials = new NetworkCredential("gmail계정", "gmail비밀번호");

                MailAddress mailTo = new MailAddress(email);
                MailAddress mailFrom = new MailAddress("gmail계정");

                MailMessage message = new MailMessage(mailFrom, mailTo);
                message.Subject = $"{txtNameS}님의 비밀번호 초기화 안내 메일입니다.";
                message.Body = $"{txtNameS}님의 비밀번호는 {newPwd}으로 초기화 되었습니다.";
                message.BodyEncoding = Encoding.UTF8;
                message.SubjectEncoding = Encoding.UTF8;

                client.Send(message);

                return true;
            }
            catch (Exception err)
            {
                return false;
            }
        }
    }
}
