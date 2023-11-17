using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class frm_NameDivide : DevExpress.XtraEditors.XtraForm
    {
        public frm_NameDivide()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void frm_NameDivide_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            tbl.Clear();
            tbl = db.readData("select * from Names where Divide_ID=" + Properties.Settings.Default.Divide_ID + " and Sectional_ID=" + Properties.Settings.Default.Sectional_ID + "", "");
            gridControl1.DataSource = tbl;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_paymentadd_Click(object sender, EventArgs e)
        {
            frm_AddName frm = new frm_AddName();
            frm.LoadItem();
            frm.AutoNumber();
            frm.btn_editAk.Visible = false;
            frm.ShowDialog();
            LoadData();
        }
        int id;
        private void btn_PaymentDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل انت متأكد من حذف الزبون", "تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    db.readData("delete from Names where ID=" + id + "", "");
                    db.readData("delete from Family_Wife where ID_Name=" + id + "", "");
                    db.readData("delete from Relative_Fa where ID_Name=" + id + "", "");
                    db.readData("delete from Relative_Mo where ID_Name=" + id + "", "");
                    db.readData("delete from Wife where ID_Name=" + id + "", "");
                    db.readData("delete from AD where ID_Name=" + id + "", "");
                    db.readData("delete from Ahkem where ID_Name=" + id + "", "");
                }
            }
            LoadData();
        }

        private void btn_paymentEdit_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            if (gridView1.DataRowCount <= 0)
            {
                MessageBox.Show("يجب اختيار ايتم", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {

                int id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                frm_AddName frm = new frm_AddName();
                tbl.Clear();
                tbl = db.readData("select * from Names where ID = " + id + " ", "");
                frm.txt_ID.Text = tbl.Rows[0][0].ToString();
                //  frm.txt_ID.Enabled = false;
                frm.txt_Name.Text = tbl.Rows[0][1].ToString();
                //  frm.txt_Name.Enabled = false;
                frm.txt_From_Born.Text = tbl.Rows[0][2].ToString();
                //  frm.txt_From_Born.Enabled = false;
                frm.txt_Name_Mother.Text = tbl.Rows[0][3].ToString();
                //   frm.txt_Name_Mother.Enabled = false;
                frm.txt_Tahsel_drasi.Text = tbl.Rows[0][4].ToString();
                //  frm.txt_Tahsel_drasi.Enabled = false;
                frm.txt_makan_aldrasa.Text = tbl.Rows[0][5].ToString();
                //     frm.txt_makan_aldrasa.Enabled = false;
                frm.txt_Tahkases.Text = tbl.Rows[0][6].ToString();
                //   frm.txt_Tahkases.Enabled = false;
                frm.txt_Year_Tahkreg.Text = tbl.Rows[0][7].ToString();
                //    frm.txt_Year_Tahkreg.Enabled = false;
                frm.txt_Number_Tam.Text = tbl.Rows[0][8].ToString();
                //    frm.txt_Number_Tam.Enabled = false;
                frm.txt_Number_Sakn.Text = tbl.Rows[0][9].ToString();
                //    frm.txt_Number_Sakn.Enabled = false;
                frm.txt_Serial.Text = tbl.Rows[0][10].ToString();
                //  frm.txt_Serial.Enabled = false;
                frm.txt_Number_Wat.Text = tbl.Rows[0][11].ToString();
                //  frm.txt_Number_Wat.Enabled = false;
                frm.txt_Date_Wat.Text = tbl.Rows[0][12].ToString();
                //  frm.txt_Date_Wat.Enabled = false;
                frm.txt_Date_End_Wat.Text = tbl.Rows[0][13].ToString();
                // frm.txt_Date_End_Wat.Enabled = false;
                frm.txt_Number_Jan.Text = tbl.Rows[0][14].ToString();
                // frm.txt_Number_Jan.Enabled = false;
                frm.txt_Date_Jan.Text = tbl.Rows[0][15].ToString();
                //  frm.txt_Date_Jan.Enabled = false;
                frm.txt_Sahefa.Text = tbl.Rows[0][16].ToString();
                // frm.txt_Sahefa.Enabled = false;
                frm.txt_Sajel.Text = tbl.Rows[0][17].ToString();
                // frm.txt_Sajel.Enabled = false;
                frm.txt_Number_Shah_Jan.Text = tbl.Rows[0][18].ToString();
                //  frm.txt_Number_Shah_Jan.Enabled = false;
                frm.txt_Date_Shah_Jan.Text = tbl.Rows[0][19].ToString();
                // frm.txt_Date_Shah_Jan.Enabled = false;
                frm.cbx_Khadme_ask.Text = tbl.Rows[0][20].ToString();
                // frm.cbx_Khadme_ask.Enabled = false;
                frm.txt_Mahafda.Text = tbl.Rows[0][21].ToString();
                //     frm.txt_Mahafda.Enabled = false;
                frm.txt_Khadhaa.Text = tbl.Rows[0][22].ToString();
                //    frm.txt_Khadhaa.Enabled = false;
                frm.txt_Mandake.Text = tbl.Rows[0][23].ToString();
                //   frm.txt_Mandake.Enabled = false;
                frm.txt_Akrab.Text = tbl.Rows[0][24].ToString();
                //   frm.txt_Akrab.Enabled = false;
                frm.txt_Mokhtar.Text = tbl.Rows[0][25].ToString();
                //    frm.txt_Mokhtar.Enabled = false;
                frm.txt_Number_Asasi.Text = tbl.Rows[0][26].ToString();
                //    frm.txt_Number_Asasi.Enabled = false;
                frm.txt_Number_Two.Text = tbl.Rows[0][27].ToString();
                //   frm.txt_Number_Two.Enabled = false;
                frm.txt_Number_Akarb.Text = tbl.Rows[0][28].ToString();
                //        frm.txt_Number_Akarb.Enabled = false;
                frm.cbx_Zojee.Text = tbl.Rows[0][29].ToString();
                //   frm.cbx_Zojee.Enabled = false;
                frm.txt_Number_Zojat.Text = tbl.Rows[0][30].ToString();
                //   frm.txt_Number_Zojat.Enabled = false;
                frm.txt_Name_Zojat.Text = tbl.Rows[0][31].ToString();
                //   frm.txt_Name_Zojat.Enabled = false;
                Properties.Settings.Default.Divide_ID = Convert.ToInt32(tbl.Rows[0][33]);
                //     frm.cbx_Divide.Enabled = false;
                Properties.Settings.Default.Divide_ID = Convert.ToInt32(tbl.Rows[0][35]);
                Properties.Settings.Default.Save();
                //frm.cbx_Sectional.Enabled = false;
                //frm.txt_NameF.Enabled = false;
                //frm.txt_NAmeM.Enabled = false;
                //frm.txt_Name_Mother.Enabled = false;
                //frm.txtName_Wife.Enabled = false;
                //frm.txtName_WifeF.Enabled = false;
                //frm.txt_AgeF.Enabled = false;
                //frm.txt_AgeM.Enabled = false;
                //frm.txt_Age_Wife.Enabled = false;
                //frm.txt_Age_WifeF.Enabled = false;
                //frm.txt_Address_Wife.Enabled = false;
                //frm.txt_Address_WifeF.Enabled = false;
                //frm.txt_AdressF.Enabled = false;
                //frm.txt_AdressM.Enabled = false;
                //frm.txt_AFrom.Enabled = false;
                //frm.txt_JobM.Enabled = false;
                //frm.txt_JopF.Enabled = false;
                //frm.txt_Jop_Wife.Enabled = false;
                //frm.txt_Jop_WifeF.Enabled = false;
                //frm.txt_ATo.Enabled = false;
                //frm.txt_AType.Enabled = false;
                //frm.txt_AHakm.Enabled = false;
                //frm.txt_AMada.Enabled = false;
                //frm.txt_AMakan.Enabled = false;
                //frm.simpleButton13.Enabled = false;
                //frm.btnNew.Enabled = false;
                frm.cbx_Divide.Enabled = false;
                frm.cbx_Sectional.Enabled = false;
                frm.btnSave.Enabled = true;
                //     frm.LoadItem1();
                frm.btn_editAk.Visible = true;
                frm.simpleButton13.Enabled = false;
                frm.btnNew.Enabled = false;
                try
                {
                    //frm.Picture_Madne.Image = new Bitmap(@"" + tbl.Rows[0][36].ToString() + "");
                    // frm.Picture_Askre.Image = new Bitmap(@"" + tbl.Rows[0][37].ToString() + "");
                    //frm.imgLocationMadne = (tbl.Rows[0][36]).ToString();
                    //frm.imgLocationAskre = (tbl.Rows[0][37]).ToString();
                }
                catch (Exception) { }
                try
                {
                    //retrive image from DB
                    Byte[] byteimage = new Byte[0];
                    byteimage = (Byte[])(tbl.Rows[0][36]);
                    MemoryStream memoryStream = new MemoryStream(byteimage);
                    frm.Picture_Madne.Image = null;
                    frm.Picture_Madne.BackgroundImageLayout = ImageLayout.Stretch;
                    frm.Picture_Madne.BackgroundImage = Image.FromStream(memoryStream);
                    frm.imgLocationMadne = tbl.Rows[0][38].ToString();

                }
                catch (Exception)
                {

                }
                try
                {
                    //retrive image from DB
                    Byte[] byteimage = new Byte[0];
                    byteimage = (Byte[])(tbl.Rows[0][37]);
                    MemoryStream memoryStream = new MemoryStream(byteimage);
                    frm.Picture_Askre.Image = null;
                    frm.Picture_Askre.BackgroundImageLayout = ImageLayout.Stretch;
                    frm.Picture_Askre.BackgroundImage = Image.FromStream(memoryStream);
                    frm.imgLocationAskre = tbl.Rows[0][39].ToString();
                }
                catch (Exception)
                {

                }
                //frm.simpleButton1.Enabled = false;
                //frm.simpleButton2.Enabled = false;
                //   frm.grid_AD.DataSource = db.readData("select * from AD where ID_Name= "+id+"", "");
                try
                {
                    DataTable tblAD = new DataTable();
                    tblAD.Clear();
                    tblAD = db.readData("select * from AD where ID_Name = " + id + "", "");
                    frm.grid_AD.Rows.Clear();
                    if (tblAD.Rows.Count >= 1)
                    {
                        foreach (DataRow row in tblAD.Rows)
                        {
                            frm.grid_AD.Rows.Add(1);
                            int indexrow = frm.grid_AD.Rows.Count - 1;
                            frm.grid_AD.Rows[indexrow].Cells[0].Value = row[0];
                            frm.grid_AD.Rows[indexrow].Cells[1].Value = row[1];
                            frm.grid_AD.Rows[indexrow].Cells[2].Value = row[2];
                            //    frm.grid_AD.Rows[indexrow].Cells[3].Value = row[3];
                            frm.grid_AD.Rows[indexrow].Cells[4].Value = row[5];
                            //frm.grid_AD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            //frm.grid_AD.RowTemplate.Height = 80;
                            //frm.grid_AD.RowTemplate.wi
                            //frm.grid_AD.AllowUserToAddRows = false;
                            //frm.imgLocationMadne1 = tblAD.Rows[indexrow][5].ToString();
                        }
                    }
                }
                catch (Exception) { }
                //  frm.grid_Ahkem.DataSource = db.readData("select * from Ahkem where ID_Name= " + id + "", "");
                try
                {
                    DataTable tblAhkem = new DataTable();
                    tblAhkem.Clear();
                    tblAhkem = db.readData("select * from Ahkem where ID_Name=" + id + "", "");
                    frm.grid_Ahkem.Rows.Clear();
                    if (tblAhkem.Rows.Count >= 1)
                    {
                        foreach (DataRow row in tblAhkem.Rows)
                        {
                            frm.grid_Ahkem.Rows.Add(1);
                            int indexrow = frm.grid_Ahkem.Rows.Count - 1;
                            frm.grid_Ahkem.Rows[indexrow].Cells[0].Value = row[1];
                            frm.grid_Ahkem.Rows[indexrow].Cells[1].Value = row[2];
                            frm.grid_Ahkem.Rows[indexrow].Cells[2].Value = row[3];
                            frm.grid_Ahkem.Rows[indexrow].Cells[3].Value = row[4];
                            frm.grid_Ahkem.Rows[indexrow].Cells[4].Value = row[5];
                            frm.grid_Ahkem.Rows[indexrow].Cells[5].Value = row[6];


                        }
                    }
                }
                catch (Exception) { }
                // frm.grid_FamilyWife.DataSource = db.readData("select * from Family_Wife where ID_Name= " + id + "", "");
                try
                {
                    DataTable tblM1 = new DataTable();
                    tblM1.Clear();
                    tblM1 = db.readData("select * from Family_Wife where ID_Name= " + id + "", "");
                    frm.grid_FamilyWife.Rows.Clear();
                    if (tblM1.Rows.Count >= 1)
                    {
                        foreach (DataRow row in tblM1.Rows)
                        {
                            frm.grid_FamilyWife.Rows.Add(1);
                            int indexrow = frm.grid_FamilyWife.Rows.Count - 1;
                            frm.grid_FamilyWife.Rows[indexrow].Cells[0].Value = row[2];
                            frm.grid_FamilyWife.Rows[indexrow].Cells[1].Value = row[3];
                            frm.grid_FamilyWife.Rows[indexrow].Cells[2].Value = row[4];
                            frm.grid_FamilyWife.Rows[indexrow].Cells[3].Value = row[5];

                        }
                    }
                }
                catch (Exception) { }
                // frm.grid_FFather.DataSource = db.readData("select * from Relative_Fa where ID_Name= " + id + "", "");
                try
                {
                    DataTable tblStore = new DataTable();
                    tblStore.Clear();
                    tblStore = db.readData("select * from Relative_Fa where ID_Name= " + id + "", "");
                    frm.grid_FFather.Rows.Clear();
                    if (tblStore.Rows.Count >= 1)
                    {
                        foreach (DataRow row in tblStore.Rows)
                        {
                            frm.grid_FFather.Rows.Add(1);
                            int indexrow = frm.grid_FFather.Rows.Count - 1;
                            frm.grid_FFather.Rows[indexrow].Cells[0].Value = row[2];
                            frm.grid_FFather.Rows[indexrow].Cells[1].Value = row[3];
                            frm.grid_FFather.Rows[indexrow].Cells[2].Value = row[4];
                            frm.grid_FFather.Rows[indexrow].Cells[3].Value = row[5];

                        }
                    }
                }
                catch (Exception) { }
                // frm.grid_FMonther.DataSource = db.readData("select * from Relative_Mo where ID_Name= " + id + "", "");
                try
                {
                    DataTable tblM = new DataTable();
                    tblM.Clear();
                    tblM = db.readData("select * from Relative_Mo where ID_Name= " + id + "", "");
                    frm.grid_FMonther.Rows.Clear();
                    if (tblM.Rows.Count >= 1)
                    {
                        foreach (DataRow row in tblM.Rows)
                        {
                            frm.grid_FMonther.Rows.Add(1);
                            int indexrow = frm.grid_FMonther.Rows.Count - 1;
                            frm.grid_FMonther.Rows[indexrow].Cells[0].Value = row[2];
                            frm.grid_FMonther.Rows[indexrow].Cells[1].Value = row[3];
                            frm.grid_FMonther.Rows[indexrow].Cells[2].Value = row[4];
                            frm.grid_FMonther.Rows[indexrow].Cells[3].Value = row[5];

                        }
                    }
                }
                catch (Exception) { }
                // frm.grid_Wife.DataSource = db.readData("select * from Wife where ID_Name= " + id + "", "");
                try
                {
                    DataTable tblM = new DataTable();
                    tblM.Clear();
                    tblM = db.readData("select * from Wife where ID_Name= " + id + "", "");
                    frm.grid_Wife.Rows.Clear();
                    if (tblM.Rows.Count >= 1)
                    {
                        foreach (DataRow row in tblM.Rows)
                        {
                            frm.grid_Wife.Rows.Add(1);
                            int indexrow = frm.grid_Wife.Rows.Count - 1;
                            frm.grid_Wife.Rows[indexrow].Cells[0].Value = row[2];
                            frm.grid_Wife.Rows[indexrow].Cells[1].Value = row[3];
                            frm.grid_Wife.Rows[indexrow].Cells[2].Value = row[4];
                            frm.grid_Wife.Rows[indexrow].Cells[3].Value = row[5];

                        }
                    }
                }
                catch (Exception) { }
                Properties.Settings.Default.Divide_ID = Convert.ToInt32(tbl.Rows[0][33]);
                frm.cbx_Divide.SelectedValue = Convert.ToInt32(tbl.Rows[0][33]);
                Properties.Settings.Default.Sectional_ID = Convert.ToInt32(tbl.Rows[0][35]);
                frm.cbx_Sectional.SelectedValue = Convert.ToInt32(tbl.Rows[0][35]);
                frm.LoadItem1();
                frm.ShowDialog();
            }
            LoadData();
        }
    
    }
}