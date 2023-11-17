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
    public partial class frm_Users : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_Users()
        {
            InitializeComponent();
            AutoNumber();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        DataTable tblStore = new DataTable();
        private void AutoNumber()
        {
            tblStore.Clear();
            tblStore = db.readData("select * from Users", "");
            gridControl2.DataSource = tblStore;
            tbl.Clear();
            tbl = db.readData("select max (ID) from Users", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txtID.Text = "1";
            }
            else
            {
                txtID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            txtPassword.Clear();
            txtUserNAme.Clear();
      
            try
            {
          
                cbxType.SelectedIndex = 0;
            }
            catch (Exception) { }
    
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            btnNew.Enabled = true;
            checkBoxAdd.Checked = false;
            checkBoxAksem.Checked = false;
            checkBoxName.Checked = false;
            checkBoxSearch.Checked = false;
            checkBoxUsers.Checked = false;
            checkBoxServer.Checked = false;
            checkBoxAddOnly.Checked = false;
            checkBoxShow.Checked = false;
            checkBoxReports.Checked = false;
        }

        int row;
        private void Show()
        {
            tbl.Clear();
            tbl = db.readData("select * from Users", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد بيانات في هذه الشاشة");
            }
            else
            {
                txtID.Text = tbl.Rows[row][0].ToString();
                txtUserNAme.Text = tbl.Rows[row][1].ToString();
                txtPassword.Text = tbl.Rows[row][2].ToString();
                cbxType.Text = tbl.Rows[row][3].ToString();
             
            }
            try
            {
                if (Convert.ToInt32(tbl.Rows[row][4]) == 1)
                {
                    checkBoxAksem.Checked = true;
                }
                else if (Convert.ToInt32(tbl.Rows[row][4]) == 0)
                {
                    checkBoxAksem.Checked = false;

                }
                //====================================================
                if (Convert.ToInt32(tbl.Rows[row][5]) == 1)
                {
                    checkBoxName.Checked = true;
                }
                else if (Convert.ToInt32(tbl.Rows[row][5]) == 0)
                {
                    checkBoxName.Checked = false;

                }
                //====================================================
                if (Convert.ToInt32(tbl.Rows[row][6]) == 1)
                {
                    checkBoxSearch.Checked = true;
                }
                else if (Convert.ToInt32(tbl.Rows[row][6]) == 0)
                {
                    checkBoxSearch.Checked = false;

                }
                //====================================================
                if (Convert.ToInt32(tbl.Rows[row][7]) == 1)
                {
                    checkBoxAdd.Checked = true;
                }
                else if (Convert.ToInt32(tbl.Rows[row][7]) == 0)
                {
                    checkBoxAdd.Checked = false;

                }
                //====================================================
                if (Convert.ToInt32(tbl.Rows[row][8]) == 1)
                {
                    checkBoxUsers.Checked = true;
                }
                else if (Convert.ToInt32(tbl.Rows[row][8]) == 0)
                {
                    checkBoxUsers.Checked = false;

                }
                //====================================================
                if (Convert.ToInt32(tbl.Rows[row][9]) == 1)
                {
                    checkBoxServer.Checked = true;
                }
                else if (Convert.ToInt32(tbl.Rows[row][9]) == 0)
                {
                    checkBoxServer.Checked = false;

                }
                //====================================================
                if (Convert.ToInt32(tbl.Rows[row][10]) == 1)
                {
                    checkBoxReports.Checked = true;
                }
                else if (Convert.ToInt32(tbl.Rows[row][10]) == 0)
                {
                    checkBoxReports.Checked = false;

                }
                //====================================================
                if (Convert.ToInt32(tbl.Rows[row][11]) == 1)
                {
                    checkBoxShow.Checked = true;
                }
                else if (Convert.ToInt32(tbl.Rows[row][11]) == 0)
                {
                    checkBoxShow.Checked = false;

                }
                //====================================================
                if (Convert.ToInt32(tbl.Rows[row][12]) == 1)
                {
                    checkBoxAddOnly.Checked = true;
                }
                else if (Convert.ToInt32(tbl.Rows[row][12]) == 0)
                {
                    checkBoxAddOnly.Checked = false;

                }
            }
            catch (Exception) { }

            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            btnSave.Enabled = true;
            btnNew.Enabled = true;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserNAme.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات اولا");
                return;
            }
            int aksem = 0, Namess = 0, Search = 0, Add = 0, USerss = 0,Server = 0,reports = 0 ,show=0,only=0;
            if (checkBoxAksem.Checked == true)
                aksem = 1;
            else
                aksem = 0;
            if (checkBoxName.Checked == true)
                Namess = 1;
            else
                Namess = 0;
            if (checkBoxSearch.Checked == true)
                Search = 1;
            else
                Search = 0;
            if (checkBoxReports.Checked == true)
                reports = 1;
            else
                reports = 0;
            if (checkBoxShow.Checked == true)
                show = 1;
            else
                show = 0;
            if (checkBoxAddOnly.Checked == true)
                only = 1;
            else
                only = 0;
            if (checkBoxAdd.Checked == true)
                Add = 1;
            else
                Add = 0;
            if (checkBoxUsers.Checked == true)
                USerss = 1;
            else
                USerss = 0;
            if (checkBoxServer.Checked == true)
                Server = 1;
            else
                Server = 0;
            db.exceuteData("insert into Users Values (" + txtID.Text + " ,N'" + txtUserNAme.Text + "',N'" + txtPassword.Text + "',N'" + cbxType.Text + "',"+aksem+","+Namess+","+Search+","+Add+","+USerss+","+ Server + ","+reports+","+show+","+only+")", "تم الادخال بنجاح");
            AutoNumber();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(ID) from Users", "");
            row = Convert.ToInt32(tbl.Rows[0][0]) - 1;
            Show();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = db.readData("select count(ID) from Users", "");
            //checkBoxAksem.Checked = false;
            //checkBoxName.Checked = false;
            //checkBoxSearch.Checked = false;
            //checkBoxAdd.Checked = false;
            //checkBoxUsers.Checked = false;

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
                tbl = db.readData("select count(ID) from Users", "");
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtUserNAme.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("من فضلك اكمل البيانات اولا");
                return;
            }
            int aksem = 0, Namess = 0, Search = 0, Add = 0, USerss = 0, Server=0, reports = 0, show = 0, only = 0;
            if (checkBoxAksem.Checked == true)
                aksem = 1;
            else
                aksem = 0;
            if (checkBoxName.Checked == true)
                Namess = 1;
            else
                Namess = 0;
            if (checkBoxSearch.Checked == true)
                Search = 1;
            else
                Search = 0;
            if (checkBoxAdd.Checked == true)
                Add = 1;
            else
                Add = 0;
            if (checkBoxUsers.Checked == true)
                USerss = 1;
            else
                USerss = 0;
            if (checkBoxServer.Checked == true)
                Server = 1;
            else
                Server = 0;
            if (checkBoxReports.Checked == true)
                reports = 1;
            else
                reports = 0;
            if (checkBoxShow.Checked == true)
                show = 1;
            else
                show = 0;
            if (checkBoxAddOnly.Checked == true)
                only = 1;
            else
                only = 0;
            db.exceuteData("update Users set  Users=N'" + txtUserNAme.Text + "',Password=N'" + txtPassword.Text + "',Type=N'" + cbxType.Text + "',Aksem=" + aksem + ",Names=" + Namess + ",Search=" + Search + ",AddFile=" + Add + ",UserAdd=" + USerss + " ,Server="+ Server + ",Reports=" + reports + ",Show=" + show + ",AddOnly=" + only + " where ID = " + txtID.Text+"", "تم التعديل بنجاح");
            AutoNumber();
        }
        int id;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف الفوج", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db.readData("delete from Users where ID='" + txtID.Text + "'", "تم مسح النوع بنجاح");
                    AutoNumber();
                }
            }
        }
    }
}
