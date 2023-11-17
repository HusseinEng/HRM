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
    public partial class frm_AddFamilyMother : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        DataTable tbl = new DataTable();
        public frm_AddFamilyMother()
        {
            InitializeComponent();
        }
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (ID) from Relative_Mo where ID_Name= " + Properties.Settings.Default.ID_Name + " ", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtName.Clear();
            txt_Address.Clear();
            txt_Age.Clear();
            txt_Jop.Clear();
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnDeleteAll.Enabled = false;
            btnSave.Enabled = false;
            btnNew.Enabled = true;
        }

        int row;
        private void Show()
        {
            tbl.Clear();
            tbl = db.readData("select * from Relative_Mo where ID_Name= " + Properties.Settings.Default.ID_Name + "", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
            }
            else
            {
                txtID.Text = tbl.Rows[row][0].ToString();
                txtName.Text = tbl.Rows[row][1].ToString();
                txt_Age.Text = tbl.Rows[row][2].ToString();
                txt_Address.Text = tbl.Rows[row][3].ToString();
                txt_Jop.Text = tbl.Rows[row][4].ToString();

            }
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnDeleteAll.Enabled = true;
            btnSave.Enabled = true;
            btnNew.Enabled = true;
        }
        private void frm_AddDivide_Load(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.readData("update Relative_Mo set Name=N'" + txtName.Text + "',Age=N'"+txt_Age.Text+"',Address= N'"+txt_Address.Text+"',Jop =N'"+txt_Jop.Text+"' where ID ='" + txtID.Text + "' ", "تم تعديل البيانات بنجاح");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف اسم الفرد", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Relative_Mo where ID='" + txtID.Text + "'", "تم مسح النوع بنجاح");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(ID) from Relative_Mo where ID_Name= " + Properties.Settings.Default.ID_Name + "", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(ID) from Relative_Mo where ID_Name= " + Properties.Settings.Default.ID_Name + "", "");
            if (Convert.ToInt32(tbl.Rows[0][0]) - 1 == row)
            {
                row = 0;
                Show();
            }
            else
            {
                row++;
                Show();
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (row == 0)
            {
                tbl.Clear();
                tbl = db.readData("select count(ID) from Relative_Mo where ID_Name= " + Properties.Settings.Default.ID_Name + "", "");
                row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
                Show();
            }
            else
            {
                row--;
                Show();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            row = 0;
            Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("يجب ادخال اسم الفرد");
                return;
            }

            db.exceuteData("insert into Relative_Mo Values (" + txtID.Text + " ,N'" + txtName.Text + "',N'"+txt_Age.Text+"',N'"+txt_Address.Text+"',N'"+txt_Jop.Text+"',"+Properties.Settings.Default.ID_Name+")", "تم الادخال بنجاح");
            AutoNumber();
            MessageBox.Show("تم بنجاح");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}