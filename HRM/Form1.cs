using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HRM
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        frm_Main frm_main = new frm_Main();
        frm_Hashed hashed = new frm_Hashed();
        Database db = new Database();
        int USER_ID = 0;
        public Form1()
        {
            InitializeComponent();
            PnContainer.Controls.Clear();
            PnContainer.Controls.Add(hashed.panel1);
        }
        private bool CheckUser(string filed, string table)
        {
            DataTable tblSearch = new DataTable();
            tblSearch = db.readData("select " + filed + " from " + table + " where ID=" + USER_ID + "", "");
            if (Convert.ToDecimal(tblSearch.Rows[0][0]) == 0)
            {
                MessageBox.Show("انت لاتملك صلاحية الدخول لهذه الشاشة", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            PnContainer.Controls.Clear();
            PnContainer.Controls.Add(hashed.panel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                USER_ID = Convert.ToInt32(db.readData("select * from Users where Users=N'" + Properties.Settings.Default.USER_NAME + "'", "").Rows[0][0]);
            }
            catch (Exception) { }
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
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
                        frm_Divide frm = new frm_Divide();
                        PnContainer.Controls.Clear();
                        frm.btn_paymentadd.Visible = false;
                        frm.btn_PaymentDelete.Visible = false;
                        frm.btn_paymentEdit.Visible = false;
                        PnContainer.Controls.Add(frm.panel1);
                    }
                    
                }
                else
                {
                    frm_Divide frm = new frm_Divide();
                    PnContainer.Controls.Clear();
                    frm.btn_PaymentDelete.Visible = false;
                  //  frm.gridControl2.Visible = false;
                    frm.btn_paymentEdit.Visible = false;
                    PnContainer.Controls.Add(frm.panel1);
                }

            }
            else
            {
                frm_Divide frm = new frm_Divide();
                PnContainer.Controls.Clear();
                PnContainer.Controls.Add(frm.panel1);
            }
        }

        private void accordionControlElement2_Click(object sender, EventArgs e)
        {
            DataTable tblSearch = new DataTable();
            tblSearch = db.readData("select Names from Users where ID=" + USER_ID + "", "");
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
                        frm_Name frm = new frm_Name();
                        PnContainer.Controls.Clear();
                        frm.btn_PaymentDelete.Visible = false;
                        frm.btn_paymentadd.Visible = false;
                        frm.btn_paymentEdit.Visible = false;
                        PnContainer.Controls.Add(frm.panel1);
                    }
                        
                }else
                {
                    frm_Name frm = new frm_Name();
                    PnContainer.Controls.Clear();
                    frm.btn_PaymentDelete.Visible = false;
                    frm.gridControl1.Visible = false;
                    frm.btn_paymentEdit.Visible = false;
                    PnContainer.Controls.Add(frm.panel1);
                }
            }else
            {
                frm_Name frm = new frm_Name();
                PnContainer.Controls.Clear();
                PnContainer.Controls.Add(frm.panel1);
            }
            //bool check = CheckUser("Names", "Users");
            //if (check == true)
            //{
            //    frm_Name frm = new frm_Name();
            //    PnContainer.Controls.Clear();
            //    PnContainer.Controls.Add(frm.panel1);
            //}
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            bool check = CheckUser("Search", "Users");
            if (check == true)
            {
                frm_NameFind frm = new frm_NameFind();
                PnContainer.Controls.Clear();
                PnContainer.Controls.Add(frm.panel1);
            }
        }

        private void accordionControlElement7_Click(object sender, EventArgs e)
        {
            bool check = CheckUser("Server", "Users");
            if (check == true)
            {
                frm_Settings frm = new frm_Settings();
                frm.ShowDialog();
            }
        }

        private void accordionControlElement5_Click(object sender, EventArgs e)
        {
            bool check = CheckUser("AddFile", "Users");
            if (check == true)
            {
                frm_NameAddFile frm = new frm_NameAddFile();
                PnContainer.Controls.Clear();
                PnContainer.Controls.Add(frm.panel1);
            }
        }

        private void accordionControlElement6_Click(object sender, EventArgs e)
        {
            bool check = CheckUser("UserAdd", "Users");
            if (check == true)
            {
                frm_Users frm = new frm_Users();
                PnContainer.Controls.Clear();
                PnContainer.Controls.Add(frm.panel1);
            }
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Hide();
            frm_Login frm = new frm_Login();
            frm.ShowDialog();
        }

        private void accordionControlElement11_Click(object sender, EventArgs e)
        {
            bool check = CheckUser("Reports", "Users");
            if (check == true)
            {
                PnContainer.Controls.Clear();
                PnContainer.Controls.Add(frm_main.panel1);
            }
        }
    }
}
