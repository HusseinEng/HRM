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
    public partial class frm_AddDivide : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        DataTable tbl = new DataTable();
        public frm_AddDivide()
        {
            InitializeComponent();
        }
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (ID) from Divide", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtName.Clear();
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
            tbl = db.readData("select * from Divide", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
            }
            else
            {
                txtID.Text = tbl.Rows[row][0].ToString();
                txtName.Text = tbl.Rows[row][1].ToString();
                // txtAddress.Text = tbl.Rows[row][2].ToString();
                // txt_Phone.Text = tbl.Rows[row][3].ToString();
                // txtNote.Text = tbl.Rows[row][4].ToString();

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
            db.readData("update Divide set Name=N'" + txtName.Text + "' where ID ='" + txtID.Text + "' ", "تم تعديل البيانات بنجاح");
            AutoNumber();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف القسم", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData("delete from Divide where Des_ID='" + txtID.Text + "'", "تم مسح النوع بنجاح");
                AutoNumber();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف القسم", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.readData(" delete from Divide ", "تم مسح جميع الانواع");
                AutoNumber();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(ID) from Divide", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(ID) from Divide", "");
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
                tbl = db.readData("select count(ID) from Divide", "");
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
                MessageBox.Show("يجب ادخال اسم القسم");
                return;
            }

            db.exceuteData("insert into Divide Values (" + txtID.Text + " ,N'" + txtName.Text + "')", "تم الادخال بنجاح");
            // db.exceuteData("insert into Customers Values (" + txtID.Text + " ,'" + txtName.Text + "' ,'" + txtAddress.Text + "'  ,'" + txt_Phone.Text + "' ,'" + txtNote.Text + "')");
            AutoNumber();
            MessageBox.Show("تم بنجاح");
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}