namespace SalesManagement_SysDev
{
    partial class loginTouroku
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonnewLogin = new System.Windows.Forms.Button();
            this.textBoxnewloginID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnewpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(286, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(289, 23);
            this.label6.TabIndex = 32;
            this.label6.Text = "パスワードは10文字以内です。";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(290, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "社員IDは数値6文字以内です";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(27, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "新";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(39, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "新";
            // 
            // buttonnewLogin
            // 
            this.buttonnewLogin.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonnewLogin.Location = new System.Drawing.Point(312, 329);
            this.buttonnewLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonnewLogin.Name = "buttonnewLogin";
            this.buttonnewLogin.Size = new System.Drawing.Size(228, 53);
            this.buttonnewLogin.TabIndex = 28;
            this.buttonnewLogin.Text = "登録";
            this.buttonnewLogin.UseVisualStyleBackColor = true;
            this.buttonnewLogin.Click += new System.EventHandler(this.buttonnewLogin_Click);
            // 
            // textBoxnewloginID
            // 
            this.textBoxnewloginID.Location = new System.Drawing.Point(250, 130);
            this.textBoxnewloginID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxnewloginID.MaxLength = 6;
            this.textBoxnewloginID.Name = "textBoxnewloginID";
            this.textBoxnewloginID.Size = new System.Drawing.Size(427, 22);
            this.textBoxnewloginID.TabIndex = 26;
            this.textBoxnewloginID.TextChanged += new System.EventHandler(this.textBoxnewloginID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(67, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "パスワード";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(75, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "社員ID";
            // 
            // textBoxnewpass
            // 
            this.textBoxnewpass.Location = new System.Drawing.Point(250, 245);
            this.textBoxnewpass.MaxLength = 10;
            this.textBoxnewpass.Name = "textBoxnewpass";
            this.textBoxnewpass.Size = new System.Drawing.Size(427, 22);
            this.textBoxnewpass.TabIndex = 33;
            this.textBoxnewpass.TextChanged += new System.EventHandler(this.textBoxnewpass_TextChanged);
            // 
            // loginTouroku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonnewLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxnewpass);
            this.Controls.Add(this.textBoxnewloginID);
            this.Name = "loginTouroku";
            this.Text = "パスワード登録";
            this.Load += new System.EventHandler(this.loginTouroku_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonnewLogin;
        private System.Windows.Forms.TextBox textBoxnewloginID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnewpass;
    }
}