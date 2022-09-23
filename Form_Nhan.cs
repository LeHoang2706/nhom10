using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapnhom
{
    public partial class Form_Nhan : Form
    {
        public Form_Nhan()
        {
            InitializeComponent();
        }
        float soA, soB, Ketqua;

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_soA.Text = null;
            txt_soB.Text = null;
            txt_ketqua.Text = null;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn Có Muốn Đóng không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                Application.Exit();
        }

        public bool Nhap()
        {
            if (float.TryParse(txt_soA.Text, out soA))
            {
                if (float.TryParse(txt_soB.Text, out soB))
                {
                    return true;

                }
                else
                {
                    MessageBox.Show("Số B vừa nhập không đúng dịnh dạng");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Số A vừa nhập không đúng dịnh dạng");
                return false;
            }
        }

        private void btn_giai_Click(object sender, EventArgs e)
        {
            if (Nhap() == true)
            {
                soA = float.Parse(txt_soA.Text);
                soB = float.Parse(txt_soB.Text);
                txt_ketqua.Text = (soA * soB).ToString();
            }
        }
    }
}
