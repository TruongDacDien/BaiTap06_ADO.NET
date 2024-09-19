using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace GUI
{
    public partial class Frm_Main : Form
    {
        Bo bo = new Bo();
        Cuu cuu = new Cuu();
        De de = new De();

        GiaSucBUS giaSucBUS = new GiaSucBUS();

        public Frm_Main()
        {
            InitializeComponent();
            HienThi();
            label_FarmName.Location = new Point((this.ClientSize.Width - label_FarmName.Width) / 2, 10);
        }

        public void HienThi()
        {
            dataGridView_GiaSuc.DataSource = giaSucBUS.GetData();
        }

        private void button_Doi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Bò kêu: {bo.TiengKeu} \nCừu kêu: {cuu.TiengKeu} \nDê kêu:{de.TiengKeu}");
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quy tắc sinh con:\n  * 1 con bò 1 lứa sinh 1 hoặc 2 con\n  * 1 con cừu 1 lứa sinh 1-3 con\n  * 1 con dê 1 lứa sinh 1-3 con\n" +
                            "Số lít sữa mỗi gia súc cho là ngẫu nhiên nhưng trong giới hạn sau:\n  *Bò: 0-20 lít\n  *Cừu: 0-5 lít\n  * Dê: 0 - 10 lít");
            bo.SinhCon();
            bo.ChoSua();
            bo.Tong();
            cuu.SinhCon();
            cuu.ChoSua();
            cuu.Tong();
            de.SinhCon();
            de.ChoSua();
            de.Tong();
            giaSucBUS.Update(bo);
            giaSucBUS.Update(cuu);
            giaSucBUS.Update(de);
            MessageBox.Show("Thống kê sau sinh thành công!");

            HienThi();
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            DataTable dt = giaSucBUS.GetData();
            if(dt != null )
            {
                bo.Reset();
                cuu.Reset();
                de.Reset();
                giaSucBUS.Delete();
            }    
            if (int.TryParse(textBox_Bo.Text, out int soLuongBo) && soLuongBo>=0)
            {
                bo.SoLuongBD = soLuongBo;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho bò!");
                return;
            }
            if (int.TryParse(textBox_Cuu.Text, out int soLuongCuu) && soLuongCuu>=0)
            {
                cuu.SoLuongBD = soLuongCuu;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho cừu!");
                return;
            }
            if (int.TryParse(textBox_De.Text, out int soLuongDe) && soLuongDe >=0)
            {
                de.SoLuongBD = soLuongDe;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho dê!");
                return;
            }
            giaSucBUS.Insert(bo);
            giaSucBUS.Insert(cuu);
            giaSucBUS.Insert(de);
            MessageBox.Show("Dữ liệu đã được lưu thành công!");
            HienThi();
        }

        public void XoaText()
        {
            textBox_Bo.Text = String.Empty;
            textBox_Cuu.Text = String.Empty;
            textBox_De.Text = String.Empty;
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn xóa dữ liệu không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            { 
                bo.Reset();
                cuu.Reset();
                de.Reset();
                giaSucBUS.Delete();
                MessageBox.Show("Đã xóa dữ liệu thành công!");
                XoaText();
            }
            HienThi();
        }
    }
}
