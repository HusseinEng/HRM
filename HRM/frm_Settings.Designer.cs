
namespace HRM
{
    partial class frm_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Settings));
            this.txtServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.checkBoxDontShow = new System.Windows.Forms.CheckBox();
            this.btnSAve = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(126, 108);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(289, 27);
            this.txtServer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LBC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(175, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "اعدادت السيرفر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم السيرفر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "قاعدة البيانات :";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Location = new System.Drawing.Point(126, 163);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.PasswordChar = '*';
            this.txtDatabase.Size = new System.Drawing.Size(289, 27);
            this.txtDatabase.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "اسم المستخدم :";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(126, 218);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '*';
            this.txtID.Size = new System.Drawing.Size(289, 27);
            this.txtID.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "الباسورد :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(126, 273);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(289, 27);
            this.txtPassword.TabIndex = 7;
            // 
            // checkBoxDontShow
            // 
            this.checkBoxDontShow.AutoSize = true;
            this.checkBoxDontShow.ForeColor = System.Drawing.Color.White;
            this.checkBoxDontShow.Location = new System.Drawing.Point(126, 317);
            this.checkBoxDontShow.Name = "checkBoxDontShow";
            this.checkBoxDontShow.Size = new System.Drawing.Size(248, 24);
            this.checkBoxDontShow.TabIndex = 9;
            this.checkBoxDontShow.Text = "عدم اظهار هذه الشاشة مره اخرى";
            this.checkBoxDontShow.UseVisualStyleBackColor = true;
            // 
            // btnSAve
            // 
            this.btnSAve.Appearance.Font = new System.Drawing.Font("LBC", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAve.Appearance.Options.UseFont = true;
            this.btnSAve.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSAve.ImageOptions.Image")));
            this.btnSAve.Location = new System.Drawing.Point(143, 365);
            this.btnSAve.Name = "btnSAve";
            this.btnSAve.Size = new System.Drawing.Size(194, 49);
            this.btnSAve.TabIndex = 10;
            this.btnSAve.Text = "حفظ";
            this.btnSAve.Click += new System.EventHandler(this.btnSAve_Click);
            // 
            // frm_Settings
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(424, 426);
            this.Controls.Add(this.btnSAve);
            this.Controls.Add(this.checkBoxDontShow);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtServer);
            this.Font = new System.Drawing.Font("LBC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("frm_Settings.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frm_Settings";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادت السيرفر";
            this.Load += new System.EventHandler(this.frm_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox checkBoxDontShow;
        private DevExpress.XtraEditors.SimpleButton btnSAve;
    }
}