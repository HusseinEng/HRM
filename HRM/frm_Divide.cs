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
    public partial class frm_Divide : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        DataTable tbl = new DataTable();
        int USER_ID;
        public frm_Divide()
        {
            InitializeComponent();
            LoadDate();
            try
            {
                USER_ID = Convert.ToInt32(db.readData("select * from Users where Users=N'" + Properties.Settings.Default.USER_NAME + "'", "").Rows[0][0]);
            }
            catch (Exception) { }
        }
        private void LoadDate()
        {
            tbl.Clear();
            tbl = db.readData("select * from Divide", "");
            gridControl1.DataSource = tbl;
        }

        private void btn_paymentadd_Click(object sender, EventArgs e)
        {
            frm_AddDivide frm = new frm_AddDivide();
            frm.ShowDialog();
            LoadDate();
        }
        int id;
        private void btn_PaymentDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف الفوج", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                id = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db.readData("delete from Divide where ID='" + id + "'", "تم مسح النوع بنجاح");
                    LoadDate();
                }
            }
        }

        private void btn_paymentEdit_Click(object sender, EventArgs e)
        {
            LoadDate();
        }
        string name;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frm_Sectional frm = new frm_Sectional();
            
            Properties.Settings.Default.Divide = Convert.ToString(tileView1.GetFocusedRowCellValue("Name"));
            Properties.Settings.Default.Divide_ID = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
           // frm.lbl_Name.Text = name;
            frm.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frm_AddDivide frm = new frm_AddDivide();
            frm.ShowDialog();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataTable tblSearch = new DataTable();
            tblSearch = db.readData("select Aksem from Users where ID=" + USER_ID + "", "");
            if (Convert.ToDecimal(tblSearch.Rows[0][0]) == 0)
            {
                DataTable tblSearch11 = new DataTable();
                tblSearch11 = db.readData("select Show from Users where ID=" + USER_ID + "", "");
                if (Convert.ToDecimal(tblSearch11.Rows[0][0]) == 0)
                {
                    DataTable tblSearch1 = new DataTable();
                    tblSearch1 = db.readData("select AddOnly from Users where ID=" + USER_ID + "", "");
                    if (Convert.ToDecimal(tblSearch1.Rows[0][0]) == 0)
                    {
                        MessageBox.Show("انت لاتملك صلاحية الدخول لهذه الشاشة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        frm_Sectional frm = new frm_Sectional();
                        Properties.Settings.Default.Divide = Convert.ToString(tileView1.GetFocusedRowCellValue("Name"));
                        Properties.Settings.Default.Divide_ID = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                        // frm.lbl_Name.Text = name;
                        frm.ShowDialog();
                    }
                    
                }
                else
                {

                    frm_Sectional frm = new frm_Sectional();
                    frm.btn_paymentadd.Visible = false;
                    frm.btn_PaymentDelete.Visible = false;
                    frm.btn_paymentEdit.Visible = false;
                    Properties.Settings.Default.Divide = Convert.ToString(tileView1.GetFocusedRowCellValue("Name"));
                    Properties.Settings.Default.Divide_ID = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                    // frm.lbl_Name.Text = name;
                    frm.ShowDialog();

                }
            }else
            {
                frm_Sectional frm = new frm_Sectional();
                Properties.Settings.Default.Divide = Convert.ToString(tileView1.GetFocusedRowCellValue("Name"));
                Properties.Settings.Default.Divide_ID = Convert.ToInt32(tileView1.GetFocusedRowCellValue("ID"));
                // frm.lbl_Name.Text = name;
                frm.ShowDialog();
            }
            
        }
    }
}
