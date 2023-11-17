using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void btnLogen_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            if (rbtnManager.Checked == true)
                tbl = db.readData("select * from Users where Users=N'" + txtUserName.Text + "' and Password=N'" + txtPassword.Text + "' and Type=N'مدير'", "");
            else if (rbtnEmp.Checked == true)
                tbl = db.readData("select * from Users where Users=N'" + txtUserName.Text + "' and Password=N'" + txtPassword.Text + "' and Type=N'مستخدم'", "");
            if (tbl.Rows.Count >= 1)
            {
                //bool check;
                //check = Trial();
                //if (check == false)
                //{
                //    return;
                //}

                // هاي مامشتغلها
                Properties.Settings.Default.USER_NAME = txtUserName.Text;
                this.Hide();
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("كلمة السر او اسم المستخدم غير صحيح", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnLogen_Click(null, null);
            }
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtUserName.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //if(Properties.Settings.Default.CheckSHOW == false)
            //{
                frm_Settings frm = new frm_Settings();
                frm.ShowDialog();
            //}
        }
    }
}