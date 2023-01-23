using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text=="Twanst" && txtpass.Text=="123" && guna2ComboBox1.Text== "Admin")
            {
                Form2 x = new Form2();
                x.ShowDialog();
                this.Hide();
            }
            if (txtuser.Text!="Twanst")
            {
                txtuser.Text = "";
                txtuser.BackColor = Color.Red;
            }
            if (txtpass.Text != "123")
            {
                txtpass.Text = "";
                txtpass.BackColor = Color.Red;
            }
            if (guna2ComboBox1.Text != "Admin")
            {
                MessageBox.Show("Please Choose User Type As 'Admin'","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
