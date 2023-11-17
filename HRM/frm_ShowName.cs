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

namespace HRM
{
    public partial class frm_ShowName : DevExpress.XtraEditors.XtraForm
    {
        public frm_ShowName()
        {
            InitializeComponent();
        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void AutoNumber()
        {
            tbl.Clear();
            tbl = db.readData("select max (ID) from Names", "");
            if ((tbl.Rows[0][0].ToString() == DBNull.Value.ToString()))
            {
                txt_ID.Text = "1";
            }
            else
            {
                txt_ID.Text = (Convert.ToInt32(tbl.Rows[0][0]) + 1).ToString();
            }
            //txtName.Clear();
            //btnAdd.Enabled = true;
            //btnDelete.Enabled = false;
            //btnDeleteAll.Enabled = false;
            //btnSave.Enabled = false;
            //btnNew.Enabled = true;
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
            try
            {
                cbx_Zojee.SelectedIndex = 0;
                cbx_Khadme_ask.SelectedIndex = 0;
                cbx_Divide.SelectedIndex = 0;
                cbx_Sectional.SelectedIndex = 0;
                
            }
            catch { }
            cbx_Divide.Text = "القسم";
            cbx_Sectional.Text = "القسم التابع";
        }
        private void tabPane1_Click(object sender, EventArgs e)
        {

        }
        public void LoadItem()
        {
            cbx_Divide.DataSource = db.readData("select * from Divide where ID = "+Properties.Settings.Default.Divide_ID+"", "");
            cbx_Divide.DisplayMember = "Name";
            cbx_Divide.ValueMember = "ID";
            cbx_Sectional.DataSource = db.readData("select * from Sectional where  ID=" + Properties.Settings.Default.Sectional_ID + " ", "");
            cbx_Sectional.DisplayMember = "Name";
            cbx_Sectional.ValueMember = "ID";
            // cbx_Divide.Text = "c";
        }
        private void frm_AddName_Load(object sender, EventArgs e)
        {
            LoadItem();
            //try
            //{
            //    AutoNumber();

            //}
            //catch { }
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
            dialog.Filter = "Choose Image(*.png,*.jpg) |*.png;*.jpg";
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                imgLocationMadne = dialog.FileName.ToString();
                Picture_Madne.ImageLocation = imgLocationMadne;


            }
        }
        string imgLocationMadne;
        string imgLocationAskre;

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.png,*.jpg) |*.png;*.jpg";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imgLocationAskre = dialog.FileName.ToString();
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

        }

        private void simpleButton13_Click_2(object sender, EventArgs e)
        { 
            ////if (txt_Name.Text == "")
            ////{
            ////    MessageBox.Show("يجب كتابة الاسم", "تأكد من المعلومات",MessageBoxButtons.OK,MessageBoxIcon.Error);
            ////    return;
            ////}
            //if(cbx_Divide.SelectedIndex == 0)
            //{
            //    MessageBox.Show("يجب اختيار القسم", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            //if(cbx_Sectional.SelectedIndex == 0)
            //{
            //    MessageBox.Show("يجب اختيار القسم التابع", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            
                for(int i =0; i<= grid_Wife.Rows.Count - 1; i++)
                {
                    db.exceuteData("insert into Wife values(N'"+grid_Wife.Rows[i].Cells[0].Value+"',N'"+grid_Wife.Rows[i].Cells[1].Value+ "',N'" + grid_Wife.Rows[i].Cells[2].Value + "',N'" + grid_Wife.Rows[i].Cells[3].Value + "'," + txt_ID.Text + ")", "");
                }
            for (int i = 0; i <= grid_FMonther.Rows.Count - 1; i++)
            {
                db.exceuteData("insert into Relative_Mo values(N'" + grid_FMonther.Rows[i].Cells[0].Value + "',N'" + grid_FMonther.Rows[i].Cells[1].Value + "',N'" + grid_FMonther.Rows[i].Cells[2].Value + "',N'" + grid_FMonther.Rows[i].Cells[3].Value + "'," + txt_ID.Text + ")", "");
            }
            for (int i = 0; i <= grid_FFather.Rows.Count - 1; i++)
            {
                db.exceuteData("insert into Relative_Fa values(N'" + grid_FFather.Rows[i].Cells[0].Value + "',N'" + grid_FFather.Rows[i].Cells[1].Value + "',N'" + grid_FFather.Rows[i].Cells[2].Value + "',N'" + grid_FFather.Rows[i].Cells[3].Value + "'," + txt_ID.Text + ")", "");
            }
            for (int i = 0; i <= grid_FamilyWife.Rows.Count - 1; i++)
            {
                db.exceuteData("insert into Family_Wife values(N'" + grid_FamilyWife.Rows[i].Cells[0].Value + "',N'" + grid_FamilyWife.Rows[i].Cells[1].Value + "',N'" + grid_FamilyWife.Rows[i].Cells[2].Value + "',N'" + grid_FamilyWife.Rows[i].Cells[3].Value + "'," + txt_ID.Text + ")", "");
            }
            for (int i = 0; i <= grid_Ahkem.Rows.Count - 1; i++)
            {
                db.exceuteData("insert into Ahkem values(N'" + grid_Ahkem.Rows[i].Cells[0].Value + "',N'" + grid_Ahkem.Rows[i].Cells[1].Value + "',N'" + grid_Ahkem.Rows[i].Cells[2].Value + "',N'" + grid_Ahkem.Rows[i].Cells[3].Value + "',N'" + grid_Ahkem.Rows[i].Cells[4].Value + "',N'" + grid_Ahkem.Rows[i].Cells[5].Value + "'," + txt_ID.Text + ")", "");
            }
            for (int i = 0; i <= grid_AD.Rows.Count - 1; i++)
            {
                db.exceuteData("insert into AD values(N'" + grid_AD.Rows[i].Cells[0].Value + "',N'" + grid_AD.Rows[i].Cells[1].Value + "'," + txt_ID.Text + ")", "");
            }
            db.exceuteData("insert into Names values(" + txt_ID.Text + ",N'" + txt_Name.Text + "',N'" + txt_From_Born.Text + "',N'" + txt_Name_Mother.Text + "',N'" + txt_Tahsel_drasi.Text + "',N'" + txt_makan_aldrasa.Text + "',N'" + txt_Tahkases.Text + "',N'" + txt_Year_Tahkreg.Text + "',N'" + txt_Number_Tam.Text + "',N'" + txt_Number_Sakn.Text + "',N'" + txt_Serial.Text + "',N'" + txt_Number_Wat.Text + "',N'" + txt_Date_Wat.Text + "',N'" + txt_Date_End_Wat.Text + "',N'" + txt_Number_Jan.Text + "',N'" + txt_Date_Jan.Text + "',N'" + txt_Sahefa.Text + "',N'" + txt_Sajel.Text + "',N'" + txt_Number_Shah_Jan.Text + "',N'" + txt_Date_Shah_Jan.Text + "',N'" + txt_Khadhaa.Text + "',N'" + txt_Mahafda.Text + "',N'" + txt_Khadhaa.Text + "',N'" + txt_Mandake.Text + "',N'" + txt_Akrab.Text + "',N'" + txt_Mokhtar.Text + "',N'" + txt_Number_Asasi.Text + "',N'" + txt_Number_Two.Text + "',N'" + txt_Number_Akarb.Text + "',N'" + cbx_Zojee.Text + "',N'" + txt_Number_Zojat.Text + "',N'" + txt_Name_Zojat.Text + "',N'" + cbx_Divide.Text + "'," + cbx_Divide.SelectedValue + ",N'" + cbx_Sectional.Text + "'," + cbx_Sectional.SelectedValue + ",N'" + imgLocationMadne + "',N'" + imgLocationAskre + "')", "تم الاضافة"); ;
             //   db.readData("insert into Ahkem values(N'" + txt_AFrom.Text + "',N'" + txt_ATo.Text + "',N'" + txt_AType.Text + "',N'" + txt_AMada.Text + "',N'" + txt_AMakan.Text + "',N'" + txt_AHakm.Text + "'," + txt_ID.Text + ")", "تم الحفظ");
                //AutoNumber();
            
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
        }

        private void simpleButton15_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("يجب كتابة الاسم", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                grid_AD.Rows.Add(1);
                int indexrow = grid_AD.Rows.Count - 1;
                grid_AD.Rows[indexrow].Cells[0].Value = textBox2.Text;
                grid_AD.Rows[indexrow].Cells[1].Value = textBox3.Text;
            }
            textBox2.Clear();
            textBox3.Clear();
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.png,*.jpg) |*.png;*.jpg";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imgLocationMadne1 = dialog.FileName.ToString();
                Picture_Madne.ImageLocation = imgLocationMadne1;
                textBox3.Text = imgLocationMadne1;

            }
        
    }
        string imgLocationMadne1;

    }
}