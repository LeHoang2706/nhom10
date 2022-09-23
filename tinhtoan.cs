using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiNhom
{
    public partial class tinhtoan : Form
    {
        public tinhtoan()
        {
            InitializeComponent();
        }
        float soA, soB, Ketqua;

        private void btn_tru_Click(object sender, EventArgs e)
        {
            soA = float.Parse(txt_soA.Text);
            soB = float.Parse(txt_soB.Text);
            txt_KQ.Text = (soA - soB).ToString();
        }

        private void btn_nhan_Click(object sender, EventArgs e)
        {
            soA = float.Parse(txt_soA.Text);
            soB = float.Parse(txt_soB.Text);
            txt_KQ.Text = (soA * soB).ToString();
        }

        private void btn_chia_Click(object sender, EventArgs e)
        {
            if (Nhap() == true)
            {
                if (soB != 0)
                {
                    Ketqua = soA / soB;
                    txt_KQ.Text = Ketqua.ToString();
                }
                else
                {
                    MessageBox.Show("Mời bạn nhập lại số B, Số B không thể bằng 0");
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Bạn Có Muốn Đóng không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_soA.Text = null;
            txt_soB.Text = null;
            txt_KQ.Text = null;
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

        private void btn_cong_Click(object sender, EventArgs e)
        {
            soA = float.Parse(txt_soA.Text);
            soB = float.Parse(txt_soB.Text);
            txt_KQ.Text = (soA + soB).ToString();
        }

        
    }
}
