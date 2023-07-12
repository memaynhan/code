using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace nhom_11_buoi_3
{
    public partial class Form2 : Form
    {
        DataGridView dataView = new DataGridView();
        public Form2(DataGridView dataView)
        {
            InitializeComponent();
            this.dataView = dataView;
        }

        private void InsertOrUpdate(int value)
        {
            dataView.Rows[value].Cells[0].Value = txtMANV.Text;
            dataView.Rows[value].Cells[1].Value = txtTenNV.Text;
            dataView.Rows[value].Cells[2].Value = txtLuongCB.Text;
        }
        private int findIdx(string id)
        {
            for(int i=0; i<dataView.Rows.Count; i++)
            {
                if ((string)(dataView.Rows[i].Cells[0].Value) == id)
                {
                    return i;
                }
               
            }
            return -1;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMANV.Text == "" || txtTenNV.Text == "" || txtLuongCB.Text == "")
                {
                    throw new Exception("Vui lòng nhập đầy đủ thông tin");
                    return;
                }
                foreach (char i in txtTenNV.Text)
                {
                    for (char j = '0'; j <= '9'; j++)
                    {
                        if (i == j)
                        {
                            throw new Exception("Vui long khong nhap so !");
                            return;
                        }
                    }
                }
                foreach (char i in txtLuongCB.Text)
                {

                    for (char j = 'a'; j <= 'z'; j++)
                    {
                        if (i == j) { throw new Exception("Vui long khong nhap chu !"); return; }
                    }
                }
                int idx = findIdx(txtMANV.Text);
                if (idx != -1)
                {
                    InsertOrUpdate(idx);
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    idx = dataView.Rows.Add();
                    InsertOrUpdate(idx);
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


