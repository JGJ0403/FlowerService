using FlowerService.DB;
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
    public partial class frmItem : Form
    {
        DataTable dtImage;

        public frmItem(int pid, string pname)
        {
            InitializeComponent();
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            ItemDB db = new ItemDB();
            dgvItem.DataSource = db.GetProductList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //유효성체크
            if (lblItemID.Text.Length < 1 || txtName.Text.Length < 1)
            {
                MessageBox.Show("이미지 추가를 할 제품을 선택하세요.");
                return;
            }

            //제품명, 제품번호를 같이 생성자에 보내준다.
            int pid = int.Parse(lblItemID.Text);
            string pname = txtName.Text;

            frmItem frmItem = new frmItem(pid, pname);
            if (frmItem.ShowDialog() == DialogResult.OK)
            {
                //이미지목록을 조회해서 listBox에 바인딩
                BindProductImageList(pid);
            }
        }

        private void BindProductImageList(int pid)
        {
            listBox1.Items.Clear();
            pictureBox1.Image = null;

            ItemDB db = new ItemDB();
            dtImage = db.GetProductImageList(pid);
            db.Dispose();

            foreach (DataRow dr in dtImage.Rows)
            {
                listBox1.Items.Add(dr["productImgFileName"].ToString());
            }
        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //선택된 제품정보를 컨트롤에 바인딩
            //productID, productName, productPrice
            lblItemID.Text = dgvItem["item_ID", e.RowIndex].Value.ToString();
            txtName.Text = dgvItem["item_Name", e.RowIndex].Value.ToString();
            txtPrice.Text = dgvItem["item_Price", e.RowIndex].Value.ToString();

            //선택된 제품의 등록된 이미지목록을 listbox에 바인딩
            BindProductImageList(int.Parse(lblItemID.Text));
        }
    }
}
