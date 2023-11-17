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
    public partial class frm_Main : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public frm_Main()
        {
            InitializeComponent();
            LoadDate();

        }
        private void LoadDate()
        {
            DataTable tbl = new DataTable();
            tbl = db.readData("select count(ID) from Names", "");
            lbl_Name.Text = Convert.ToString(tbl.Rows[0][0]);
            DataTable tbl1 = new DataTable();
            tbl1 = db.readData("select count(ID) from Users", "");
            lbl_Users.Text = tbl1.Rows[0][0].ToString();
            DataTable tbl2 = new DataTable();
            tbl2 = db.readData("select count(ID) from Divide", "");
            lbl_Divide.Text = tbl2.Rows[0][0].ToString();
            DataTable tbl3 = new DataTable();
            tbl3 = db.readData("select count(ID) from Sectional", "");
            lbl_Sectional.Text = tbl3.Rows[0][0].ToString();

        }
    }
}
