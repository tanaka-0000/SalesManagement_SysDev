namespace SalesManagement_SysDev
{
    partial class F_Login
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CleateDabase = new System.Windows.Forms.Button();
            this.btn_InsertSampleData = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxEmployeeID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_CleateDabase
            // 
            this.btn_CleateDabase.Location = new System.Drawing.Point(644, 322);
            this.btn_CleateDabase.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CleateDabase.Name = "btn_CleateDabase";
            this.btn_CleateDabase.Size = new System.Drawing.Size(141, 61);
            this.btn_CleateDabase.TabIndex = 0;
            this.btn_CleateDabase.Text = "データベース生成";
            this.btn_CleateDabase.UseVisualStyleBackColor = true;
            this.btn_CleateDabase.Click += new System.EventHandler(this.btn_CleateDabase_Click);
            // 
            // btn_InsertSampleData
            // 
            this.btn_InsertSampleData.Location = new System.Drawing.Point(644, 418);
            this.btn_InsertSampleData.Margin = new System.Windows.Forms.Padding(4);
            this.btn_InsertSampleData.Name = "btn_InsertSampleData";
            this.btn_InsertSampleData.Size = new System.Drawing.Size(141, 61);
            this.btn_InsertSampleData.TabIndex = 0;
            this.btn_InsertSampleData.Text = "サンプルデータ登録";
            this.btn_InsertSampleData.UseVisualStyleBackColor = true;
            this.btn_InsertSampleData.Click += new System.EventHandler(this.btn_InsertSampleData_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(297, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "※社員IDは数値6文字以内です。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(131, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "パスワード";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxPassword.Location = new System.Drawing.Point(290, 246);
            this.textBoxPassword.MaxLength = 10;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(304, 34);
            this.textBoxPassword.TabIndex = 12;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonLogin.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonLogin.Location = new System.Drawing.Point(332, 332);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(196, 51);
            this.buttonLogin.TabIndex = 11;
            this.buttonLogin.Text = "ログイン";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxEmployeeID
            // 
            this.textBoxEmployeeID.Font = new System.Drawing.Font("MS UI Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxEmployeeID.Location = new System.Drawing.Point(290, 150);
            this.textBoxEmployeeID.MaxLength = 6;
            this.textBoxEmployeeID.Name = "textBoxEmployeeID";
            this.textBoxEmployeeID.Size = new System.Drawing.Size(304, 34);
            this.textBoxEmployeeID.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(129, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "社員ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(293, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(312, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "※パスワードは10文字以内です。";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(332, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 54);
            this.button1.TabIndex = 16;
            this.button1.Text = "パスワード登録";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 487);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxEmployeeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_InsertSampleData);
            this.Controls.Add(this.btn_CleateDabase);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_Login";
            this.Text = "販売管理システムログイン画面";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CleateDabase;
        private System.Windows.Forms.Button btn_InsertSampleData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TextBox textBoxEmployeeID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

