using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Net;
using System.Xml;

namespace FlowerService
{
    public partial class ZipSearchPopup : Form
    {
        string zip, add1, add2;

        public string ZipcCode
        {
            get { return zip; }
        }

        public string Address1
        {
            get { return add1; }
        }

        public string Address2
        {
            get { return add2; }
        }
    

        public ZipSearchPopup()
        {
            InitializeComponent();
        }

        private void ZipSearchPopup_Load(object sender, EventArgs e)
        {
            //데이터그리드뷰의 초기셋팅
            CommonUtil.SetInitGridView(dgvZip);

            CommonUtil.AddGridTextColumn(dgvZip, "우편번호", "zipNo", 80);
            CommonUtil.AddGridTextColumn(dgvZip, "주소1", "roadAddr", 200);
            CommonUtil.AddGridTextColumn(dgvZip, "주소2", "jibunAddr", 200);
            CommonUtil.AddGridTextColumn(dgvZip, "주소1", "roadAddrPart1", 10, false); //눈에안보임
            CommonUtil.AddGridTextColumn(dgvZip, "주소1", "roadAddrPart2", 10, false); //눈에안보임
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                MessageBox.Show("검색할 주소를 입력 하세요.");
                return;
            }

            string url = "http://www.juso.go.kr/addrlink/addrLinkApi.do";
            string apiKey = "devU01TX0FVVEgyMDIwMTEwMzEwMzkxNDExMDM2MjA=";

            string apiUrl = $"{url}?confmKey={apiKey}" +
                $"&currentPage=1&countPerPage=1000&keyword={txtSearch.Text.Trim()}";

            WebClient wc = new WebClient();
            XmlReader reader = new XmlTextReader(wc.OpenRead(apiUrl));
            DataSet ds = new DataSet();
            ds.ReadXml(reader);

            if (ds.Tables.Count > 1)
                dgvZip.DataSource = ds.Tables[1];
            else
                MessageBox.Show(ds.Tables[0].Rows[0]["errorMessage"].ToString());
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnSearch.PerformClick();
                //btnSearch_Click(null, null);

            }
        }



        private void dgvZip_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRoadZipcode.Text = dgvZip["ZipNo", e.RowIndex].Value.ToString();
            txtRoadAdder1.Text = dgvZip["roadAddrPart1", e.RowIndex].Value.ToString();
            txtRoadAdder2.Text = dgvZip["roadAddrPart2", e.RowIndex].Value.ToString();

            txtJibunZipcode.Text = dgvZip["ZipNo", e.RowIndex].Value.ToString();
            txtJibunAddr1.Text = dgvZip["jibunAddr", e.RowIndex].Value.ToString();
            txtJibunAddr2.Text = "";
        }

        private void btnRoad_Click(object sender, EventArgs e)
        {
            if (txtRoadAdder2.Text.Length > 0)
            {
                this.zip = txtRoadZipcode.Text;
                this.add1 = txtJibunAddr1.Text;
                this.add2 = txtRoadAdder2.Text;


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("주소를 검색하여 선택해주세요.");
            }
        }

        private void btnJibun_Click(object sender, EventArgs e)
        {
            if (txtRoadAdder1.Text.Length > 0) // txtRoadAdder2는 널값이므로 성립x
            {
                this.zip = txtRoadZipcode.Text;
                this.add1 = txtJibunAddr1.Text;
                this.add2 = txtRoadAdder2.Text;


                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("주소를 검색하여 선택해주세요.");
            }
        }
    }
}