using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HRM
{
    class Database
    {


        //الاتصال بقاعدة البيانات

    //     SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.SERVERNAME + ";Initial Catalog=" + Properties.Settings.Default.DATABASENAME + ";Integrated Security=True");
           SqlConnection conn = new SqlConnection(@"Data Source=" + Properties.Settings.Default.SERVERNAME + ";Initial Catalog=" + Properties.Settings.Default.DATABASENAME + ";Integrated Security=False ; USER ID =" + Properties.Settings.Default.DATABASEUSERNAME + " ; Password =" + Properties.Settings.Default.DATABASEPASSWORD + "");
       //  SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename="+System.IO.Path.GetFullPath("Sales_System.mdf") + ";Integrated Security=True");
     //    SqlConnection conn = new SqlConnection(@"Data Source=Hussein\SQLEXPRESS,1433;Initial Catalog=" + Properties.Settings.Default.DATABASENAME + ";Integrated Security=False ; USER ID =" + Properties.Settings.Default.DATABASEUSERNAME + " ; Password =" + Properties.Settings.Default.DATABASEPASSWORD + "");

        SqlCommand cmd = new SqlCommand();


        public DataTable readData(string stmt, string message)
        {
            DataTable tbl = new DataTable();
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                //load data from database to tbl 
                tbl.Load(cmd.ExecuteReader());
                conn.Close();
                if (message != "")
                {
                    MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


            return tbl;
        }
        public bool exceuteDataaa(string stmt, string message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (message != "")
                {
                    MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        //تنفيذ الاستعلامات الحذف والتعديل
        // insert update delete 
        public bool exceuteData(string stmt, string message)
        {
            try
            {
                cmd.Connection = conn;
                cmd.CommandText = stmt;
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                if (message != "")
                {
                    MessageBox.Show(message, "تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return true;
            }
            catch (Exception ex)

            {
                return false;
            }
            finally
            {
                conn.Close();
            }

        }


    }
}
