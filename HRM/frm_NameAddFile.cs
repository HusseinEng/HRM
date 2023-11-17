using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRM
{
    public partial class frm_NameAddFile : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_NameAddFile()
        {
            InitializeComponent();
           cbx_Name.DataSource =db.readData("select * from Names", "");
            cbx_Name.DisplayMember = "Name";
            cbx_Name.ValueMember = "ID";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        Database db = new Database();
        DataTable tbl = new DataTable();
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            
            tbl = db.readData("select * from Names where Serial =N'"+txt_serial.Text+"'", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد موظف بهذا الرقم الوظيفي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = Convert.ToInt32(tbl.Rows[0][0]);
                string Name = tbl.Rows[0][1].ToString();
                string Serial = tbl.Rows[0][10].ToString();
                string Divide = tbl.Rows[0][32].ToString();
                string Sectional = tbl.Rows[0][34].ToString();
                dataGridView1.Rows.Add(1);
                int rowindex = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[rowindex].Cells[0].Value = ID;
                dataGridView1.Rows[rowindex].Cells[1].Value = Name;
                dataGridView1.Rows[rowindex].Cells[2].Value = Serial;
                dataGridView1.Rows[rowindex].Cells[3].Value = Divide;
                dataGridView1.Rows[rowindex].Cells[4].Value = Sectional;
                //  gridControl2.DataSource = tbl;
            }
            txt_serial.Clear();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
            tbl = db.readData("select * from Names where Name Like '%"+cbx_Name.Text+"'", "");
            if (tbl.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد موظف بهذا الاسم الوظيفي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int ID = Convert.ToInt32(tbl.Rows[0][0]);
                string Name = tbl.Rows[0][1].ToString();
                string Serial = tbl.Rows[0][10].ToString();
                string Divide = tbl.Rows[0][32].ToString();
                string Sectional = tbl.Rows[0][34].ToString();
                dataGridView1.Rows.Add(1);
                int rowindex = dataGridView1.Rows.Count - 1;
                dataGridView1.Rows[rowindex].Cells[0].Value = ID;
                dataGridView1.Rows[rowindex].Cells[1].Value = Name;
                dataGridView1.Rows[rowindex].Cells[2].Value = Serial;
                dataGridView1.Rows[rowindex].Cells[3].Value = Divide;
                dataGridView1.Rows[rowindex].Cells[4].Value = Sectional;
                //     gridControl2.DataSource = tbl;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton17_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Choose Image(*.png,*.jpg) |*.png;*.jpg";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                imgLocationMadne1 = dialog.FileName.ToString();
                //     Picture_Madne.ImageLocation = imgLocationMadne1;
                path = imgLocationMadne1;
                textBox3.Text = imgLocationMadne1;

            }
        }
        string path;
        string imgLocationMadne1;
        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("يجب ادراج كافة المعلومات", "تأكد من المعلومات", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                grid_AD.Rows.Add(1);
                int indexrow = grid_AD.Rows.Count - 1;
                grid_AD.Rows[indexrow].Cells[0].Value = textBox2.Text;
                grid_AD.Rows[indexrow].Cells[1].Value = path;
                grid_AD.Rows[indexrow].Cells[2].Value = textBox3.Text;
            }
        }

        private void simpleButton14_Click(object sender, EventArgs e)
        {
            if (grid_AD.Rows.Count >= 1)
            {
                grid_AD.Rows.RemoveAt(grid_AD.CurrentCell.RowIndex);
            }
        }

        private void simpleButton16_Click(object sender, EventArgs e)
        {
            if (grid_AD.Rows.Count <= 0)
            {
                MessageBox.Show("لايوجد عناصر", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                frm_ShowFile frm = new frm_ShowFile();
                frm.pictureBox1.Image = new Bitmap(@"" + grid_AD.CurrentRow.Cells[1].Value + "");
                frm.ShowDialog();
            }
        }
        int id;
        private void simpleButton15_Click(object sender, EventArgs e)
        {
            if(dataGridView1.Rows.Count <=0)
            {
                MessageBox.Show("يجب ان تضيف الموظفين الى جدول الموظفين", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (grid_AD.Rows.Count <= 0)
            {
                MessageBox.Show("يجب ان تضيف الملفات الى جدول الملفات", "تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            //  id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID"));
            for (int ii = 0; ii <= dataGridView1.Rows.Count - 1; ii++)
            {
                for (int i = 0; i <= grid_AD.Rows.Count - 1; i++)
                {
                    //  db.exceuteData("insert into AD(Name,Path,ID_Name) values(N'" + grid_AD.Rows[i].Cells[0].Value + "',N'" + grid_AD.Rows[i].Cells[1].Value + "',"+ dataGridView1.Rows[ii].Cells[0].Value + ")", "");
                    saveImage1("insert into AD values(N'" + grid_AD.Rows[i].Cells[0].Value + "',N'" + grid_AD.Rows[i].Cells[2].Value + "',@ImgAD," + dataGridView1.Rows[ii].Cells[0].Value + ",N'" + grid_AD.Rows[i].Cells[1].Value + "')", "ImgAD", "" + grid_AD.Rows[i].Cells[1].Value + "", "");

                }
            }
            MessageBox.Show("تمت الأضافة بنجاح", "", MessageBoxButtons.OK);
        }
        private void saveImage1(string stmt, string AD, string ADA, string message)
        {
            if (grid_AD.Rows.Count >= 1)
            {
                try
                {
                    //connection to DB
                    //    SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=HRM;Integrated Security=True");
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
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            tbl.Clear();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count >= 1)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
        }
    }
}
