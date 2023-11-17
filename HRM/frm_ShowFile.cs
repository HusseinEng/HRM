using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace HRM
{
    public partial class frm_ShowFile : DevExpress.XtraEditors.XtraForm
    {
        public frm_ShowFile()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.Graphics.DrawImage(pictureBox1.Image, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
        }

        private void btn_editAk_Click(object sender, EventArgs e)
        {
            //821, 1012
            //printPreviewDialog1.ShowDialog();
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += myPrintPage;
            pd.Document = doc;
            if(pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void myPrintPage(object sender , PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
            bm.Dispose();
        }
        System.Timers.Timer Stimer;
        private void frm_ShowFile_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Stimer = new System.Timers.Timer();
            Stimer.Interval = 50;
            Stimer.Elapsed += Stimer_Elapsed;
            Stimer.Start();
            
        }

        private void Stimer_Elapsed(object sender,System.Timers.ElapsedEventArgs e)
        {
            //vScrollBar1.Visible = (panel1.VerticalScroll.Visible == true) ? false : true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += myPrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
    }
}