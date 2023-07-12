using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nhom_11_buoi_3
{
    public partial class Form1 : Form
    {
        Form2 form;
        public Form1()
        {
            InitializeComponent();
            form = new Form2(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form = new Form2(dataGridView1);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form = new Form2(dataGridView1);
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ask = MessageBox.Show("ban co muon xoa khong ?","exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(ask ==DialogResult.Yes)
            {
                foreach(DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(item.Index);    
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var ask = MessageBox.Show("Dong giao dien ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ask == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
