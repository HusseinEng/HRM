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
using System.IO;
using System.Data.SqlClient;

namespace HRM
{
    public partial class frm_AddName : DevExpress.XtraEditors.XtraForm
    {
        public frm_AddName()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        public void AutoNumber()
        {
            //tbl.Clear();
            //tbl = db.readData("select max (ID) from Names", "");
            //if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            //{
            //    txt_ID.Text = "1";
            //}
            //else
            //{
            //    txt_ID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            //}
            //txtName.Clear();
            //btnAdd.Enabled = true;
            //btnDelete.Enabled = false;
            //btnDeleteAll.Enabled = false;
            //btnSave.Enabled = false;
            //btnNew.Enabled = true;
            txt_Name.Focus();
            txt_Akrab.Clear();
            txt_Date_End_Wat.Clear();
            txt_Date_Jan.Clear();
            txt_Date_Shah_Jan.Clear();
            txt_Date_Wat.Clear();
            txt_From_Born.Clear();
            txt_Khadhaa.Clear();
            txt_Mahafda.Clear();
            txt_makan_aldrasa.Clear();
            txt_Mandake.Clear();
            txt_Name.Clear();
            txt_Name_Mother.Clear();
            txt_Name_Zojat.Clear();
            txt_Number_Asasi.Clear();
            txt_Number_Jan.Clear();
            txt_Number_Sakn.Clear();
            txt_Number_Shah_Jan.Clear();
            txt_Number_Tam.Clear();
            txt_Number_Wat.Clear();
            txt_Number_Zojat.Clear();
            txt_Sahefa.Clear();
            txt_Sajel.Clear();
            txt_Serial.Clear();
            txt_Tahkases.Clear();
            txt_Tahsel_drasi.Clear();
            txt_Year_Tahkreg.Clear();
            txt_Number_Two.Clear();
            txt_Number_Akarb.Clear();
            txt_Mokhtar.Clear();
            txt_NameF.Clear();
            txt_NAmeM.Clear();
            txt_Name_Mother.Clear();
            txtName_Wife.Clear();
            txtName_WifeF.Clear();
            txt_AgeF.Clear();
            txt_AgeM.Clear();
            txt_Age_Wife.Clear();
            txt_Age_WifeF.Clear();
            txt_Address_Wife.Clear();
            txt_Address_WifeF.Clear();
            txt_AdressF.Clear();
            txt_AdressM.Clear();
            txt_AFrom.Clear();
            txt_JobM.Clear();
            txt_JopF.Clear();
            txt_Jop_Wife.Clear();
            txt_Jop_WifeF.Clear();
            txt_ATo.Clear();
            txt_AType.Clear();
            txt_AHakm.Clear();
            txt_AMada.Clear();
            txt_AMakan.Clear();
            btnDelete.Enabled = false;
            btnSave.Enabled = false;
            grid_AD.Rows.Clear();
            grid_Ahkem.Rows.Clear();
            grid_FamilyWife.Rows.Clear();
            grid_FFather.Rows.Clear();
            grid_FMonther.Rows.Clear();
            grid_Wife.Rows.Clear();
            txt_bborn.Clear();
            try
            {
                cbx_Zojee.SelectedIndex = 0;
                cbx_Khadme_ask.SelectedIndex = 0;
                cbx_Divide.SelectedIndex = 0;
                cbx_Sectional.SelectedIndex = 0;
                
            }
            catch { }
            cbx_Divide.Text = "الفوج";
            cbx_Divide.Enabled = false;
            cbx_Sectional.Text = "قسم الفوج";
            cbx_Sectional.Enabled = false;
        }
        private void tabPane1_Click(object sender, EventArgs e)
        {

        }
        public void LoadItem()
        {
            cbx_Divide.DataSource = db.readData("select * from Divide", "");
            cbx_Divide.DisplayMember = "Name";
            cbx_Divide.ValueMember = "ID";
           // cbx_Divide.Text = "c";
        }
         public void LoadItem1()
        {
            cbx_Divide.DataSource = db.readData("select * from Divide where ID = "+Properties.Settings.Default.Divide_ID+"", "");
            cbx_Divide.DisplayMember = "Name";
            cbx_Divide.ValueMember = "ID";
            cbx_Sectional.DataSource = db.readData("select * from Sectional where ID=" + Properties.Settings.Default.Sectional_ID + " ", "");
            cbx_Sectional.DisplayMember = "Name";
            cbx_Sectional.ValueMember = "ID";
            // cbx_Divide.Text = "c";
        }
        int USER_ID;

        private void frm_AddName_Load(object sender, EventArgs e)
        {
            //LoadItem();
            DataTable tblSearch11 = new DataTable();
            try
            {
                USER_ID = Convert.ToInt32(db.readData("select * from Users where Users=N'" + Properties.Settings.Default.USER_NAME + "'", "").Rows[0][0]);
            }
            catch (Exception) { }
            DataTable tblSearch = new DataTable();
            tblSearch = db.readData("select Names from Users where ID=" + USER_ID + "", "");
            if (Convert.ToDecimal(tblSearch.Rows[0][0]) == 0)
            {
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

                    }
                }
                else
                {

                    groupBox11.Visible = false;

                }
            }
            //LoadDate();
        }
        int idN = 6;
        private void LoadDate()
        {
            DataTable tblWife = new DataTable();
            tblWife.Clear();
            tblWife = db.readData("select * from Wife where ID_Name = "+txt_ID.Text+"", "");
            grid_Wife.DataSource = tblWife;
            DataTable tblFamilyWife = new DataTable();
            tblFamilyWife.Clear();
            tblFamilyWife = db.readData("select * from Family_Wife where ID_Name = " + txt_ID.Text + "", "");
            grid_FamilyWife.DataSource = tblFamilyWife;
            DataTable tblFamilyFather = new DataTable();
            tblFamilyFather.Clear();
            tblFamilyFather = db.readData("select * from Relative_Fa where ID_Name = " + txt_ID.Text + "", "");
            grid_FFather.DataSource = tblFamilyFather;
            DataTable tblFamilyMother = new DataTable();
            tblFamilyMother.Clear();
            tblFamilyMother = db.readData("select * from Relative_Fa where ID_Name = " + txt_ID.Text + "", "");
            grid_FMonther.DataSource = tblFamilyMother;
            DataTable tblAhkem = new DataTable();
            tblAhkem.Clear();
            tblAhkem = db.readData("select * from Ahkem where ID_Name = " + txt_ID.Text + "", "");
            grid_Ahkem.DataSource = tblAhkem;
        }
        private void simpleButton13_Click(object sender, EventArgs e)
        {
           
        }
      

        private void cbx_Divide_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cbx_Sectional.DataSource = db.readData("select * from Sectional where Divide_ID="+cbx_Divide.SelectedValue+" ", "");
            cbx_Sectional.DisplayMember = "Name";
            cbx_Sectional.ValueMember = "ID";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "All Files (*.*) | *.*";
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                imgLocationMadne = dialog.FileName.ToString();
                Picture_Madne.Image = null;
                Picture_Madne.ImageLocation = imgLocationMadne;


            }
        }
       public string imgLocationMadne;
       public string imgLocationAskre;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.png,*.jpg) |*.png;*.jpg";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imgLocationAskre = dialog.FileName.ToString();
                Picture_Askre.Image = null;
                Picture_Askre.ImageLocation = imgLocationAskre;

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {

        }

        private void btn_AddWife_Click(object sender, EventArgs e)
        {
            frm_AddWife frm = new frm_AddWife();
            Properties.Settings.Default.ID_Name = Convert.ToInt32(txt_ID.Text);
            frm.ShowDialog();
            LoadDate();
        }

        private void cbx_Divide_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            
        }

        private void btn_AddFamilyWife_Click(object sender, EventArgs e)
        {
            //frm_AddFamilyWife frm = new frm_AddFamilyWife();
            //Properties.Settings.Default.ID_Name =Convert.ToInt32( txt_ID.Text);
            //frm.ShowDialog();
            //LoadDate();
            if (txtName_WifeF.Text == "")
            {
                MessageBox.Show("يجب كتابة الاسم", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                grid_FamilyWife.Rows.Add(1);
                int indexrow = grid_FamilyWife.Rows.Count - 1;
                grid_FamilyWife.Rows[indexrow].Cells[0].Value = txtName_WifeF.Text;
                grid_FamilyWife.Rows[indexrow].Cells[1].Value = txt_Age_WifeF.Text;
                grid_FamilyWife.Rows[indexrow].Cells[2].Value = txt_Address_WifeF.Text;
                grid_FamilyWife.Rows[indexrow].Cells[3].Value = txt_Jop_WifeF.Text;
            }
            txtName_WifeF.Clear();
            txt_Age_WifeF.Clear();
            txt_Address_WifeF.Clear();
            txt_Jop_WifeF.Clear();
        }

        private void simpleButton13_Click_1(object sender, EventArgs e)
        {
            db.exceuteData("insert into Names values(" + txt_ID.Text + ",N'" + txt_Name.Text + "',N'" + txt_From_Born.Text + "',N'" + txt_Name_Mother.Text + "',N'" + txt_Tahsel_drasi.Text + "',N'" + txt_makan_aldrasa.Text + "',N'" + txt_Tahkases.Text + "',N'" + txt_Year_Tahkreg.Text + "',N'" + txt_Number_Tam.Text + "',N'" + txt_Number_Sakn.Text + "',N'" + txt_Serial.Text + "',N'" + txt_Number_Wat.Text + "',N'" + txt_Date_Wat.Text + "',N'" + txt_Date_End_Wat.Text + "',N'" + txt_Number_Jan.Text + "',N'" + txt_Date_Jan.Text + "',N'" + txt_Sahefa.Text + "',N'" + txt_Sajel.Text + "',N'" + txt_Number_Shah_Jan.Text + "',N'" + txt_Date_Shah_Jan.Text + "',N'" + txt_Khadhaa.Text + "',N'" + txt_Mahafda.Text + "',N'" + txt_Khadhaa.Text + "',N'" + txt_Mandake.Text + "',N'" + txt_Akrab.Text + "',N'" + txt_Mokhtar.Text + "',N'" + txt_Number_Asasi.Text + "',N'" + txt_Number_Two.Text + "',N'" + txt_Number_Akarb.Text + "',N'" + cbx_Zojee.Text + "',N'" + txt_Number_Zojat.Text + "',N'" + txt_Name_Zojat.Text + "',N'" + cbx_Divide.Text + "'," + cbx_Divide.SelectedValue + ",N'" + cbx_Sectional.Text + "'," + cbx_Sectional.SelectedValue + ",N'" + imgLocationMadne + "',N'" + imgLocationAskre + "')", "تم الاضافة"); ;
            AutoNumber();
        }

        private void cbx_Divide_SelectionChangeCommitted_2(object sender, EventArgs e)
        {
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            frm_AddFamilyFather frm = new frm_AddFamilyFather();
            Properties.Settings.Default.ID_Name = Convert.ToInt32(txt_ID.Text);
            frm.ShowDialog();
            LoadDate();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            frm_AddFamilyMother frm = new frm_AddFamilyMother();
            Properties.Settings.Default.ID_Name = Convert.ToInt32(txt_ID.Text);
            frm.ShowDialog();
            LoadDate();

        }

        private void btn_AddHakm_Click(object sender, EventArgs e)
        {
            //db.readData("insert into Ahkem values(N'"+txt_From.Text+"',N'"+txt_To.Text+"',N'"+txt_Type.Text+"',N'"+txt_Mada.Text+"',N'"+txt_Makan.Text+"',N'"+txt_Hakm.Text+"',"+txt_ID.Text+")", "تم الحفظ");
            //txt_From.Clear();
            //txt_To.Clear();
            //txt_Type.Clear();
            //txt_Mada.Clear();
            //txt_Makan.Clear();
            //txt_Hakm.Clear();
            //LoadDate();
            //gridView1.AddNewRow();
            //gridView1.SetRowCellValue(rowhandle, columnName, value);
            //gridView1.UpdateCurrentRow();
            grid_Ahkem.Rows.Add(1);
            int indexrow = grid_Ahkem.Rows.Count - 1;
            grid_Ahkem.Rows[indexrow].Cells[0].Value = txt_AFrom.Text;
            grid_Ahkem.Rows[indexrow].Cells[1].Value = txt_ATo.Text;
            grid_Ahkem.Rows[indexrow].Cells[2].Value = txt_AType.Text;
            grid_Ahkem.Rows[indexrow].Cells[3].Value = txt_AMada.Text;
            grid_Ahkem.Rows[indexrow].Cells[4].Value = txt_AMakan.Text;
            grid_Ahkem.Rows[indexrow].Cells[5].Value = txt_AHakm.Text;
            txt_AFrom.Clear();
            txt_ATo.Clear();
            txt_AType.Clear();
            txt_AMada.Clear();
            txt_AMakan.Clear();
            txt_AHakm.Clear();
        }

        private void simpleButton13_Click_2(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("يجب كتابة الاسم", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbx_Divide.Text == "قسم الفوج")
            {
                MessageBox.Show("يجب اختيار الفوج", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbx_Sectional.Text == "قسم الفوج")
            {
                MessageBox.Show("يجب اختيار قسم الفوج", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Picture_Askre.Image == null || Picture_Madne.Image == null)
            {
                MessageBox.Show("يجب وضع الصور الرسمية والعسكرية", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            saveImage("insert into Names values(N'" + txt_Name.Text + "',N'" + txt_From_Born.Text + "',N'" + txt_Name_Mother.Text + "',N'" + txt_Tahsel_drasi.Text + "',N'" + txt_makan_aldrasa.Text + "',N'" + txt_Tahkases.Text + "',N'" + txt_Year_Tahkreg.Text + "',N'" + txt_Number_Tam.Text + "',N'" + txt_Number_Sakn.Text + "',N'" + txt_Serial.Text + "',N'" + txt_Number_Wat.Text + "',N'" + txt_Date_Wat.Text + "',N'" + txt_Date_End_Wat.Text + "',N'" + txt_Number_Jan.Text + "',N'" + txt_Date_Jan.Text + "',N'" + txt_Sahefa.Text + "',N'" + txt_Sajel.Text + "',N'" + txt_Number_Shah_Jan.Text + "',N'" + txt_Date_Shah_Jan.Text + "',N'" + cbx_Khadme_ask.Text + "',N'" + txt_Mahafda.Text + "',N'" + txt_Khadhaa.Text + "',N'" + txt_Mandake.Text + "',N'" + txt_Akrab.Text + "',N'" + txt_Mokhtar.Text + "',N'" + txt_Number_Asasi.Text + "',N'" + txt_Number_Two.Text + "',N'" + txt_Number_Akarb.Text + "',N'" + cbx_Zojee.Text + "',N'" + txt_Number_Zojat.Text + "',N'" + txt_Name_Zojat.Text + "',N'" + cbx_Divide.Text + "'," + cbx_Divide.SelectedValue + ",N'" + cbx_Sectional.Text + "'," + cbx_Sectional.SelectedValue + ",@Picture_Madne,@Picture_Askre,N'" + imgLocationMadne + "',N'" + imgLocationAskre + "',N'" + txt_bborn.Text + "')", "@Picture_Askre", "@Picture_Madne", imgLocationAskre, imgLocationMadne, "تم الاضافة"); ;
            DataTable tblID = new DataTable();
            tblID = db.readData("select ID from Names where Name =N'"+txt_Name.Text+"' and From_Born=N'"+txt_From_Born.Text+"' and Name_Mother=N'"+txt_Name_Mother.Text+"' and Divide_ID="+cbx_Divide.SelectedValue+" and Sectional_ID="+cbx_Sectional.SelectedValue+"", "");
            DataTable tbl1 = new DataTable();
            tbl1 = db.readData("select * from Names where ID ="+ tblID.Rows[0][0] + "", "");
            if (tbl1.Rows.Count >= 1)
            {


                for (int i = 0; i <= grid_Wife.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Wife values(N'" + grid_Wife.Rows[i].Cells[0].Value + "',N'" + grid_Wife.Rows[i].Cells[1].Value + "',N'" + grid_Wife.Rows[i].Cells[2].Value + "',N'" + grid_Wife.Rows[i].Cells[3].Value + "'," + tblID.Rows[0][0] + ")", "");
                }
                for (int i = 0; i <= grid_FMonther.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Relative_Mo values(N'" + grid_FMonther.Rows[i].Cells[0].Value + "',N'" + grid_FMonther.Rows[i].Cells[1].Value + "',N'" + grid_FMonther.Rows[i].Cells[2].Value + "',N'" + grid_FMonther.Rows[i].Cells[3].Value + "'," + tblID.Rows[0][0] + ")", "");
                }
                for (int i = 0; i <= grid_FFather.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Relative_Fa values(N'" + grid_FFather.Rows[i].Cells[0].Value + "',N'" + grid_FFather.Rows[i].Cells[1].Value + "',N'" + grid_FFather.Rows[i].Cells[2].Value + "',N'" + grid_FFather.Rows[i].Cells[3].Value + "'," + tblID.Rows[0][0] + ")", "");
                }
                for (int i = 0; i <= grid_FamilyWife.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Family_Wife values(N'" + grid_FamilyWife.Rows[i].Cells[0].Value + "',N'" + grid_FamilyWife.Rows[i].Cells[1].Value + "',N'" + grid_FamilyWife.Rows[i].Cells[2].Value + "',N'" + grid_FamilyWife.Rows[i].Cells[3].Value + "'," + tblID.Rows[0][0] + ")", "");
                }
                for (int i = 0; i <= grid_Ahkem.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Ahkem values(N'" + grid_Ahkem.Rows[i].Cells[0].Value + "',N'" + grid_Ahkem.Rows[i].Cells[1].Value + "',N'" + grid_Ahkem.Rows[i].Cells[2].Value + "',N'" + grid_Ahkem.Rows[i].Cells[3].Value + "',N'" + grid_Ahkem.Rows[i].Cells[4].Value + "',N'" + grid_Ahkem.Rows[i].Cells[5].Value + "'," + tblID.Rows[0][0] + ")", "");
                }
                for (int i = 0; i <= grid_AD.Rows.Count - 1; i++)
                {
                    saveImage1("insert into AD values(N'" + grid_AD.Rows[i].Cells[1].Value + "',N'" + grid_AD.Rows[i].Cells[2].Value + "',@ImgAD," + tblID.Rows[0][0] + ",N'" + grid_AD.Rows[i].Cells[3].Value + "')", "ImgAD", "" + grid_AD.Rows[i].Cells[3].Value + "", "");
                }
                AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ في ادخال قواعد البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
            
        }
        
        private void btn_AddWife_Click_1(object sender, EventArgs e)
        {
            if (txtName_Wife.Text == "")
            {
                MessageBox.Show("يجب كتابة الاسم", "تأكد من المعلومات",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                grid_Wife.Rows.Add(1);
                int indexrow = grid_Wife.Rows.Count - 1;
                grid_Wife.Rows[indexrow].Cells[0].Value = txtName_Wife.Text;
                grid_Wife.Rows[indexrow].Cells[1].Value = txt_Age_Wife.Text;
                grid_Wife.Rows[indexrow].Cells[2].Value = txt_Address_Wife.Text;
                grid_Wife.Rows[indexrow].Cells[3].Value = txt_Jop_Wife.Text;
            }
            txtName_Wife.Clear();
            txt_Age_Wife.Clear();
            txt_Address_Wife.Clear();
            txt_Jop_Wife.Clear();
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            if (txt_NameF.Text == "")
            {
                MessageBox.Show("يجب كتابة الاسم", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                grid_FFather.Rows.Add(1);
                int indexrow = grid_FFather.Rows.Count - 1;
                grid_FFather.Rows[indexrow].Cells[0].Value = txt_NameF.Text;
                grid_FFather.Rows[indexrow].Cells[1].Value = txt_AgeF.Text;
                grid_FFather.Rows[indexrow].Cells[2].Value = txt_AdressF.Text;
                grid_FFather.Rows[indexrow].Cells[3].Value = txt_JopF.Text;
            }
            txt_NameF.Clear();
            txt_AgeF.Clear();
            txt_AdressF.Clear();
            txt_JopF.Clear();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (txt_NAmeM.Text == "")
            {
                MessageBox.Show("يجب كتابة الاسم", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                grid_FMonther.Rows.Add(1);
                int indexrow = grid_FMonther.Rows.Count - 1;
                grid_FMonther.Rows[indexrow].Cells[0].Value = txt_NAmeM.Text;
                grid_FMonther.Rows[indexrow].Cells[1].Value = txt_AgeM.Text;
                grid_FMonther.Rows[indexrow].Cells[2].Value = txt_AdressM.Text;
                grid_FMonther.Rows[indexrow].Cells[3].Value = txt_JobM.Text;
            }
            txt_NAmeM.Clear();
            txt_AgeM.Clear();
            txt_AdressM.Clear();
            txt_JobM.Clear();
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("يجب ادراج كافة المعلومات", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                grid_AD.Rows.Add(1);
                int indexrow = grid_AD.Rows.Count - 1;
                grid_AD.Rows[indexrow].Cells[1].Value = textBox2.Text;
                grid_AD.Rows[indexrow].Cells[2].Value = textBox3.Text;
                grid_AD.Rows[indexrow].Cells[3].Value = imageLocationAD;
            }
            textBox2.Clear();
            textBox3.Clear();
        }
        public string imageLocationAD;
        private void simpleButton17_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.png,*.jpg) |*.png;*.jpg";
            dialog.Multiselect = true;
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] files = dialog.FileNames;
                foreach(string img in files)
                {
                    PictureBox pic = new PictureBox();
                    pic.Image = Image.FromFile(img);
                }
                //for(int i = 0 ; i < dialog.FileNames.Count; i++)
                imageLocationAD = dialog.FileName.ToString();
      //          Picture_Madne.Image = null;
              //  Picture_Madne.ImageLocation = imgLocationMadne;
               // = dialog.FileName;
                
            }
        
    }
        public string imgLocationMadne1;

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            if (grid_AD.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد عناصر", "",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }
            else
            {
                tbl.Clear();
                tbl = db.readData("select * from AD where ID ="+ grid_AD.CurrentRow.Cells[0].Value + "", "");
                frm_ShowFile frm = new frm_ShowFile();
                try
                {
                    //retrive image from DB
                    Byte[] byteimage = new Byte[0];
                    byteimage = (Byte[])(tbl.Rows[0][3]);
                    MemoryStream memoryStream = new MemoryStream(byteimage);
                    frm.pictureBox1.Image = null;
                    frm.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

                    frm.pictureBox1.BackgroundImage = Image.FromStream(memoryStream);

                }
                catch (Exception)
                {

                }
                //frm.pictureBox1.Image = new Bitmap(@"" + grid_AD.CurrentRow.Cells[1].Value + "");
                frm.ShowDialog();
            }
        }

        private void brn_RemoveWife_Click(object sender, EventArgs e)
        {
            if (grid_Wife.Rows.Count >= 1)
            {
                grid_Wife.Rows.RemoveAt(grid_Wife.CurrentCell.RowIndex);
            }
            }

        private void btn_ReomveFamilyWife_Click(object sender, EventArgs e)
        {
            if (grid_FamilyWife.Rows.Count >= 1)
            {
                grid_FamilyWife.Rows.RemoveAt(grid_FamilyWife.CurrentCell.RowIndex);
            }
        }

        private void simpleButton7_Click_1(object sender, EventArgs e)
        {
            if (grid_FMonther.Rows.Count >= 1)
            {
                grid_FMonther.Rows.RemoveAt(grid_FMonther.CurrentCell.RowIndex);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (grid_FFather.Rows.Count >= 1)
            {
                grid_FFather.Rows.RemoveAt(grid_FFather.CurrentCell.RowIndex);
            }
        }

        private void btn_RemoveHakm_Click(object sender, EventArgs e)
        {
            if (grid_Ahkem.Rows.Count >= 1)
            {
                grid_Ahkem.Rows.RemoveAt(grid_Ahkem.CurrentCell.RowIndex);
            }
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            if (grid_AD.Rows.Count >= 1)
            {
                grid_AD.Rows.RemoveAt(grid_AD.CurrentCell.RowIndex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "")
            {
                MessageBox.Show("يجب كتابة الاسم", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cbx_Divide.Text == "قسم الفوج")
            {
                MessageBox.Show("يجب اختيار الفوج", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbx_Sectional.Text == "قسم الفوج")
            {
                MessageBox.Show("يجب اختيار قسم الفوج", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //if (Picture_Askre.Image == null || Picture_Madne.Image == null)
            //{
            //    MessageBox.Show("يجب وضع الصور الرسمية والعسكرية", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            saveImage("update Names set Name =N'" + txt_Name.Text + "',From_Born=N'" + txt_From_Born.Text + "',Name_Mother=N'" + txt_Name_Mother.Text + "',Tahsel_drasi=N'" + txt_Tahsel_drasi.Text + "',makan_aldrasa=N'" + txt_makan_aldrasa.Text + "',Tahkases=N'" + txt_Tahkases.Text + "',Year_Tahkreg=N'" + txt_Year_Tahkreg.Text + "',Number_Tam=N'" + txt_Number_Tam.Text + "',Number_Sakn=N'" + txt_Number_Sakn.Text + "',Serial=N'" + txt_Serial.Text + "',Number_Wat=N'" + txt_Number_Wat.Text + "',Date_Wat=N'" + txt_Date_Wat.Text + "',Date_End_Wat=N'" + txt_Date_End_Wat.Text + "',Number_Jan=N'" + txt_Number_Jan.Text + "',Date_Jan=N'" + txt_Date_Jan.Text + "',Sahefa=N'" + txt_Sahefa.Text + "',Sajel=N'" + txt_Sajel.Text + "',Number_Shah_Jan=N'" + txt_Number_Shah_Jan.Text + "',Date_Shah_Jan=N'" + txt_Date_Shah_Jan.Text + "',Khadme_ask=N'" + cbx_Khadme_ask.Text + "',Mahafda=N'" + txt_Mahafda.Text + "',Khadhaa=N'" + txt_Khadhaa.Text + "',Mandake=N'" + txt_Mandake.Text + "',Akrab=N'" + txt_Akrab.Text + "',Mokhtar=N'" + txt_Mokhtar.Text + "',Number_Asasi=N'" + txt_Number_Asasi.Text + "',Number_Two=N'" + txt_Number_Two.Text + "',Number_Akarb=N'" + txt_Number_Akarb.Text + "',Zojee=N'" + cbx_Zojee.Text + "',Number_Zojat=N'" + txt_Number_Zojat.Text + "',Name_Zojat=N'" + txt_Name_Zojat.Text + "',Divide=N'" + cbx_Divide.Text + "',Divide_ID=" + cbx_Divide.SelectedValue + ",Sectional=N'" + cbx_Sectional.Text + "',Sectional_ID=" + cbx_Sectional.SelectedValue + ",Picture_Madne=@Picture_Madne,Picture_Askre=@Picture_Askre,Path_Madne=N'"+imgLocationMadne+ "',Path_Askre=N'"+imgLocationAskre+ "',bborn=N'" + txt_bborn.Text + "' where ID=" + txt_ID.Text + "", "@Picture_Askre", "@Picture_Madne", imgLocationAskre, imgLocationMadne, "تم التعديل");
            DataTable tbl1 = new DataTable();
            tbl1 = db.readData("select * from Names where ID =" + txt_ID.Text + "", "");
            if (tbl1.Rows.Count >= 1)
            {
                db.exceuteData("delete from Wife where ID_Name=" + txt_ID.Text + "", "");
                for (int i = 0; i <= grid_Wife.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Wife values(N'" + grid_Wife.Rows[i].Cells[0].Value + "',N'" + grid_Wife.Rows[i].Cells[1].Value + "',N'" + grid_Wife.Rows[i].Cells[2].Value + "',N'" + grid_Wife.Rows[i].Cells[3].Value + "'," + txt_ID.Text + ")", "");
                }
                db.exceuteData("delete from Relative_Mo where ID_Name=" + txt_ID.Text + "", "");

                for (int i = 0; i <= grid_FMonther.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Relative_Mo values(N'" + grid_FMonther.Rows[i].Cells[0].Value + "',N'" + grid_FMonther.Rows[i].Cells[1].Value + "',N'" + grid_FMonther.Rows[i].Cells[2].Value + "',N'" + grid_FMonther.Rows[i].Cells[3].Value + "'," + txt_ID.Text + ")", "");
                }
                db.exceuteData("delete from Relative_Fa where ID_Name=" + txt_ID.Text + "", "");
                for (int i = 0; i <= grid_FFather.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Relative_Fa values(N'" + grid_FFather.Rows[i].Cells[0].Value + "',N'" + grid_FFather.Rows[i].Cells[1].Value + "',N'" + grid_FFather.Rows[i].Cells[2].Value + "',N'" + grid_FFather.Rows[i].Cells[3].Value + "'," + txt_ID.Text + ")", "");
                }
                db.exceuteData("delete from Family_Wife where ID_Name=" + txt_ID.Text + "", "");
                for (int i = 0; i <= grid_FamilyWife.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Family_Wife values(N'" + grid_FamilyWife.Rows[i].Cells[0].Value + "',N'" + grid_FamilyWife.Rows[i].Cells[1].Value + "',N'" + grid_FamilyWife.Rows[i].Cells[2].Value + "',N'" + grid_FamilyWife.Rows[i].Cells[3].Value + "'," + txt_ID.Text + ")", "");
                }
                db.exceuteData("delete from Ahkem where ID_Name=" + txt_ID.Text + "", "");

                for (int i = 0; i <= grid_Ahkem.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Ahkem values(N'" + grid_Ahkem.Rows[i].Cells[0].Value + "',N'" + grid_Ahkem.Rows[i].Cells[1].Value + "',N'" + grid_Ahkem.Rows[i].Cells[2].Value + "',N'" + grid_Ahkem.Rows[i].Cells[3].Value + "',N'" + grid_Ahkem.Rows[i].Cells[4].Value + "',N'" + grid_Ahkem.Rows[i].Cells[5].Value + "'," + txt_ID.Text + ")", "");
                }
                db.exceuteData("delete from AD where ID_Name=" + txt_ID.Text + "", "");
                for (int i = 0; i <= grid_AD.Rows.Count - 1; i++)
                {
                    saveImage1("insert into AD values(N'" + grid_AD.Rows[i].Cells[1].Value + "',N'" + grid_AD.Rows[i].Cells[2].Value + "',@ImgAD," + txt_ID.Text + ",N'" + grid_AD.Rows[i].Cells[3].Value + "')", "ImgAD", "" + grid_AD.Rows[i].Cells[3].Value + "", "");
                }
                AutoNumber();
            }
            else
            {
                MessageBox.Show("هناك خطأ في ادخال قواعد البيانات", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_editAk_Click(object sender, EventArgs e)
        {
            cbx_Sectional.Enabled = true;
            cbx_Divide.Enabled = true;
            LoadItem();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AutoNumber();
        }

        private void cbx_Divide_SelectionChangeCommitted_3(object sender, EventArgs e)
        {
            cbx_Sectional.DataSource = db.readData("select * from Sectional where Divide_ID=" + cbx_Divide.SelectedValue + " ", "");
            cbx_Sectional.DisplayMember = "Name";
            cbx_Sectional.ValueMember = "ID";
        }

        private void btn_editAk_Click_1(object sender, EventArgs e)
        {
            cbx_Sectional.Enabled = true;
            cbx_Divide.Enabled = true;
            LoadItem();
        }
        //function to convert image to byte and save it in DB
        string imagePath = "";
        private void saveImage(string stmt, string paramaterAskre, string paramaterMadne, string LocationAskre, string LocationMadne, string message)
        {
            //if (Picture_Askre.Image == null || Picture_Madne.Image == null)
            //{

            //}
            //else
            //{
                try
                {
                //connection to DB
                //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HRM;Integrated Security=True");
                SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.SERVERNAME + ";Initial Catalog=" + Properties.Settings.Default.DATABASENAME + ";Integrated Security=False ; USER ID =" + Properties.Settings.Default.DATABASEUSERNAME + " ; Password =" + Properties.Settings.Default.DATABASEPASSWORD + "");
                SqlCommand cmd = new SqlCommand(stmt, conn);

                    //convert image to byte 
                    FileStream filestream = new FileStream(LocationAskre, FileMode.Open, FileAccess.Read);
                    Byte[] bytestream = new Byte[filestream.Length];
                    filestream.Read(bytestream, 0, bytestream.Length);
                    filestream.Close();
                    //convert image to byte 
                    FileStream filestream1 = new FileStream(LocationMadne, FileMode.Open, FileAccess.Read);
                    Byte[] bytestream1 = new Byte[filestream1.Length];
                    filestream1.Read(bytestream1, 0, bytestream1.Length);
                    filestream1.Close();
                    //*************************
                    SqlParameter parameter = new SqlParameter(paramaterAskre, SqlDbType.VarBinary, bytestream.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytestream);
                    SqlParameter parameter1 = new SqlParameter(paramaterMadne, SqlDbType.VarBinary, bytestream1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytestream1);

                    cmd.Parameters.Add(parameter);
                    cmd.Parameters.Add(parameter1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    if (message != "")
                    {
                        MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception) { }
            //}
        }
        private void saveImage1(string stmt, string AD, string ADA, string message)
        {
            if (grid_AD.Rows.Count >= 1)
            {
                try
                {
                    //connection to DB
                    //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HRM;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.SERVERNAME + ";Initial Catalog=" + Properties.Settings.Default.DATABASENAME + ";Integrated Security=False ; USER ID =" + Properties.Settings.Default.DATABASEUSERNAME + " ; Password =" + Properties.Settings.Default.DATABASEPASSWORD + "");
                    SqlCommand cmd = new SqlCommand(stmt, conn);

                    //convert image to byte 
                    FileStream filestream = new FileStream(ADA, FileMode.Open, FileAccess.Read);
                    Byte[] bytestream = new Byte[filestream.Length];
                    filestream.Read(bytestream, 0, bytestream.Length);
                    filestream.Close();

                    //*************************
                    SqlParameter parameter = new SqlParameter(AD, SqlDbType.VarBinary, bytestream.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytestream);
                    //    SqlParameter parameter1 = new SqlParameter(paramaterMadne, SqlDbType.VarBinary, bytestream1.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytestream1);

                    cmd.Parameters.Add(parameter);
                    //   cmd.Parameters.Add(parameter1);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    if (message != "")
                    {
                        MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception) { }
            }
        }
        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //if (imagePath == "")
            //{
            //    MessageBox.Show("من فضلك اختر لوجو", "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    return;
            //}
            //tbl.Clear();
            //tbl = db.readData("select * from OrderPrintData", "");
            //if (tbl.Rows.Count >= 1)
            //{
            //call function to save image
            //saveImage("update OrderPrintData set Logo = @Logo, Name = N'" + txtName.Text + "' ,Address = N'" + txtAddress.Text + "' ,Description = N'" + txtDescription.Text + "' ,Phone1 = N'" + txtPhone1.Text + "' ,Phone2 = N'" + txtPhone2.Text + "'", "@Logo", "تم الحفظ بنجاح");
            saveImage("update Names set Picture_Madne = @Picture_Madne ,Picture_Askre=@Picture_Askre where ID = 6", "@Picture_Askre","@Picture_Madne",imgLocationAskre ,imgLocationMadne,"تم الحفظ بنجاح");

            //}
            //else
            //{
            //    saveImage("insert into  OrderPrintData values (@Logo,N'" + txtName.Text + "' ,N'" + txtAddress.Text + "' ,N'" + txtDescription.Text + "' ,N'" + txtPhone1.Text + "' ,N'" + txtPhone2.Text + "')", "@Logo", "تم الحفظ بنجاح");
            //}
            imagePath = "";
        }

        private void grid_AD_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (grid_AD.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد عناصر", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                tbl.Clear();
                tbl = db.readData("select * from AD where ID =" + grid_AD.CurrentRow.Cells[0].Value + "", "");
                frm_ShowFile frm = new frm_ShowFile();
                try
                {
                    //retrive image from DB
                    Byte[] byteimage = new Byte[0];
                    byteimage = (Byte[])(tbl.Rows[0][3]);
                    MemoryStream memoryStream = new MemoryStream(byteimage);
                    frm.pictureBox1.Image = null;
                    frm.pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

                    frm.pictureBox1.BackgroundImage = Image.FromStream(memoryStream);

                }
                catch (Exception)
                {

                }
                //frm.pictureBox1.Image = new Bitmap(@"" + grid_AD.CurrentRow.Cells[1].Value + "");
                frm.ShowDialog();
            }
        }

        private void grid_Wife_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = grid_Wife.SelectedRows[0].Index;
            txtName_Wife.Text = grid_Wife.Rows[index].Cells[0].Value.ToString();
            txt_Age_Wife.Text = grid_Wife.Rows[index].Cells[1].Value.ToString();
            txt_Address_Wife.Text = grid_Wife.Rows[index].Cells[2].Value.ToString();
            txt_Jop_Wife.Text = grid_Wife.Rows[index].Cells[3].Value.ToString();

        }

        private void grid_FamilyWife_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = grid_FamilyWife.SelectedRows[0].Index;
            txtName_WifeF.Text = grid_FamilyWife.Rows[index].Cells[0].Value.ToString();
            txt_Age_WifeF.Text = grid_FamilyWife.Rows[index].Cells[1].Value.ToString();
            txt_Address_WifeF.Text = grid_FamilyWife.Rows[index].Cells[2].Value.ToString();
            txt_Jop_WifeF.Text = grid_FamilyWife.Rows[index].Cells[3].Value.ToString();
        }

        private void grid_FFather_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = grid_FFather.SelectedRows[0].Index;
            txt_NameF.Text = grid_FFather.Rows[index].Cells[0].Value.ToString();
            txt_AgeF.Text = grid_FFather.Rows[index].Cells[1].Value.ToString();
            txt_AdressF.Text = grid_FFather.Rows[index].Cells[2].Value.ToString();
            txt_JopF.Text = grid_FFather.Rows[index].Cells[3].Value.ToString();
        }

        private void grid_FMonther_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = grid_FMonther.SelectedRows[0].Index;
            txt_NAmeM.Text = grid_FMonther.Rows[index].Cells[0].Value.ToString();
            txt_AgeM.Text = grid_FMonther.Rows[index].Cells[1].Value.ToString();
            txt_AdressM.Text = grid_FMonther.Rows[index].Cells[2].Value.ToString();
            txt_JobM.Text = grid_FMonther.Rows[index].Cells[3].Value.ToString();
        }

        private void grid_Ahkem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = grid_Ahkem.SelectedRows[0].Index;
            txt_AFrom.Text = grid_Ahkem.Rows[index].Cells[0].Value.ToString();
            txt_ATo.Text = grid_Ahkem.Rows[index].Cells[1].Value.ToString();
            txt_AType.Text = grid_Ahkem.Rows[index].Cells[2].Value.ToString();
            txt_AMada.Text = grid_Ahkem.Rows[index].Cells[3].Value.ToString();
            txt_AMakan.Text = grid_Ahkem.Rows[index].Cells[4].Value.ToString();
            txt_AHakm.Text = grid_Ahkem.Rows[index].Cells[5].Value.ToString();

        }
    }
}