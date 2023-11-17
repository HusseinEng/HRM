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
    public partial class frm_Settings : DevExpress.XtraEditors.XtraForm
    {
        public frm_Settings()
        {
            InitializeComponent();
        }

        private void btnSAve_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.SERVERNAME= txtServer.Text;
            Properties.Settings.Default.DATABASENAME= txtDatabase.Text;
            Properties.Settings.Default.DATABASEUSERNAME = txtID.Text;
            Properties.Settings.Default.DATABASEPASSWORD= txtPassword.Text;
            if(checkBoxDontShow.Checked == false)
            {
                Properties.Settings.Default.CheckSHOW = false;
            }else
            {
                Properties.Settings.Default.CheckSHOW = true;
            }
            Properties.Settings.Default.Save();
            MessageBox.Show("تم الحفظ بنجاح", "تاكيد");
        }

        private void frm_Settings_Load(object sender, EventArgs e)
        {
            txtServer.Text = Properties.Settings.Default.SERVERNAME;
            txtDatabase.Text = Properties.Settings.Default.DATABASENAME;
            txtID.Text = Properties.Settings.Default.DATABASEUSERNAME;
            txtPassword.Text = Properties.Settings.Default.DATABASEPASSWORD;
            if (Properties.Settings.Default.CheckSHOW == false)
            {
                checkBoxDontShow.Checked = false;
            }
            else
            {
                checkBoxDontShow.Checked = true;
            }
        }
    }
}