
namespace HRM
{
    partial class frm_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnEmp = new System.Windows.Forms.RadioButton();
            this.rbtnManager = new System.Windows.Forms.RadioButton();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogen = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(223, 152);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(194, 32);
            this.txtPassword.TabIndex = 25;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(285, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "كلمة السر";
            // 
            // rbtnEmp
            // 
            this.rbtnEmp.AutoSize = true;
            this.rbtnEmp.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnEmp.ForeColor = System.Drawing.Color.Black;
            this.rbtnEmp.Location = new System.Drawing.Point(325, 9);
            this.rbtnEmp.Name = "rbtnEmp";
            this.rbtnEmp.Size = new System.Drawing.Size(73, 24);
            this.rbtnEmp.TabIndex = 23;
            this.rbtnEmp.Text = "موظف";
            this.rbtnEmp.UseVisualStyleBackColor = true;
            // 
            // rbtnManager
            // 
            this.rbtnManager.AutoSize = true;
            this.rbtnManager.Checked = true;
            this.rbtnManager.Cursor = System.Windows.Forms.Cursors.Default;
            this.rbtnManager.ForeColor = System.Drawing.Color.Black;
            this.rbtnManager.Location = new System.Drawing.Point(253, 9);
            this.rbtnManager.Name = "rbtnManager";
            this.rbtnManager.Size = new System.Drawing.Size(57, 24);
            this.rbtnManager.TabIndex = 22;
            this.rbtnManager.TabStop = true;
            this.rbtnManager.Text = "مدير";
            this.rbtnManager.UseVisualStyleBackColor = true;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtUserName.Font = new System.Drawing.Font("LBC", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(223, 75);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(194, 32);
            this.txtUserName.TabIndex = 21;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(268, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "اسم المستخدم";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.btnExit.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.ImageOptions.Image")));
            this.btnExit.Location = new System.Drawing.Point(223, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 41);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "خروج";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogen
            // 
            this.btnLogen.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnLogen.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogen.Appearance.Options.UseBackColor = true;
            this.btnLogen.Appearance.Options.UseFont = true;
            this.btnLogen.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogen.ImageOptions.Image")));
            this.btnLogen.Location = new System.Drawing.Point(36, 191);
            this.btnLogen.Name = "btnLogen";
            this.btnLogen.Size = new System.Drawing.Size(181, 41);
            this.btnLogen.TabIndex = 26;
            this.btnLogen.Text = "دخول";
            this.btnLogen.Click += new System.EventHandler(this.btnLogen_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("LBC", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(36, 238);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(381, 41);
            this.simpleButton1.TabIndex = 29;
            this.simpleButton1.Text = "ضبط اعدادت الاتصال المحلي ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(-3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 40);
            this.label3.TabIndex = 30;
            this.label3.Text = "VS:\r\n1.30";
            // 
            // frm_Login
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(453, 283);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogen);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbtnEmp);
            this.Controls.Add(this.rbtnManager);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Login.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnLogen;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnEmp;
        private System.Windows.Forms.RadioButton rbtnManager;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label3;
    }
}