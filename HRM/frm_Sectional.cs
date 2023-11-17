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
    public partial class frm_Sectional : DevExpress.XtraEditors.XtraForm
    {
        public frm_Sectional()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void LoadDate()
        {
            tbl.Clear();
            tbl=db.readData("select * from Sectional where Divide_ID="+Properties.Settings.Default.Divide_ID+"", "");
            gridControl1.DataSource = tbl;
        }
        private void frm_Sectional_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = Properties.Settings.Default.Divide;
            LoadDate();
            try
            {
                USER_ID = Convert.ToInt32(db.readData("select * from Users where Users=N'" + Properties.Settings.Default.USER_NAME + "'", "").Rows[0][0]);
            }
            catch (Exception) { }
        }
        int USER_ID;
        private void btn_paymentadd_Click(object sender, EventArgs e)
        {
            frm_AddSectional frm = new frm_AddSectional();
            frm.ShowDialog();
            LoadDate();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataTable tblSearch = new DataTable();
            tblSearch = db.readData("select Aksem from Users where ID=" + USER_ID + "", "");
            if (Convert.ToDecimal(tblSearch.Rows[0][0]) == 0)
            {
                DataTable tblSearch1 = new DataTable();
                tblSearch1 = db.readData("select AddOnly from Users where ID=" + USER_ID + "", "");
                if (Convert.ToDecimal(tblSearch1.Rows[0][0]) == 0)
                {
                    DataTable tblSearch11 = new DataTable();
                    tblSearch11 = db.readData("select Show from Users where ID=" + USER_ID + "", "");
                    if (Convert.ToDecimal(tblSearch11.Rows[0][0]) == 0)
                    {
                        MessageBox.Show("انت لاتملك صلاحية الدخول لهذه الشاشة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        frm_NameDivide frm = new frm_NameDivide();
                        frm.btn_paymentadd.Visible = false;
                        frm.btn_PaymentDelete.Visible = false;
                        frm.btn_paymentEdit.Visible = false;
                        Properties.Settings.Default.Sectional = Convert.ToString(tileView1.GetFocusedRowCellValue("Name"));
                        Properties.Settings.Default.Sectional_ID = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                        frm.ShowDialog();


                    }

                }
                else
                {
                    frm_NameDivide frm = new frm_NameDivide();
                    frm.gridControl1.Visible = false;
                    Properties.Settings.Default.Sectional = Convert.ToString(tileView1.GetFocusedRowCellValue("Name"));
                    Properties.Settings.Default.Sectional_ID = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                    frm.ShowDialog();
                }
            }else
            {
                frm_NameDivide frm = new frm_NameDivide();
                Properties.Settings.Default.Sectional = Convert.ToString(tileView1.GetFocusedRowCellValue("Name"));
                Properties.Settings.Default.Sectional_ID = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                frm.ShowDialog();
            }
        }
        int id;
        private void btn_PaymentDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف قسم الفوج", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db.readData("delete from Sectional where ID='" + id + "'", "تم مسح النوع بنجاح");
                    LoadDate();
                }
            }
        }

        private void btn_paymentEdit_Click(object sender, EventArgs e)
        {
            LoadDate();
        }
    }
}