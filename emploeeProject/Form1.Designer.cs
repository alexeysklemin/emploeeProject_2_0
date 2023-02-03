
namespace emploeeProject
{
    partial class loginForm
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
            this.logBtn = new System.Windows.Forms.Button();
            this.userlbn = new System.Windows.Forms.Label();
            this.pswdLbn = new System.Windows.Forms.Label();
            this.usrBox = new System.Windows.Forms.TextBox();
            this.pswBox = new System.Windows.Forms.TextBox();
            this.txtcaptcha = new System.Windows.Forms.TextBox();
            this.lcaptcha = new System.Windows.Forms.Label();
            this.lbcaptcha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBtn.Location = new System.Drawing.Point(304, 466);
            this.logBtn.Name = "logBtn";
            this.logBtn.Size = new System.Drawing.Size(243, 56);
            this.logBtn.TabIndex = 0;
            this.logBtn.Text = "OK";
            this.logBtn.UseVisualStyleBackColor = true;
            this.logBtn.Click += new System.EventHandler(this.logBtn_Click);
            // 
            // userlbn
            // 
            this.userlbn.AutoSize = true;
            this.userlbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userlbn.Location = new System.Drawing.Point(109, 96);
            this.userlbn.Name = "userlbn";
            this.userlbn.Size = new System.Drawing.Size(78, 29);
            this.userlbn.TabIndex = 1;
            this.userlbn.Text = "Name";
            // 
            // pswdLbn
            // 
            this.pswdLbn.AutoSize = true;
            this.pswdLbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswdLbn.Location = new System.Drawing.Point(111, 171);
            this.pswdLbn.Name = "pswdLbn";
            this.pswdLbn.Size = new System.Drawing.Size(120, 29);
            this.pswdLbn.TabIndex = 2;
            this.pswdLbn.Text = "Password";
            // 
            // usrBox
            // 
            this.usrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usrBox.Location = new System.Drawing.Point(254, 96);
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(176, 34);
            this.usrBox.TabIndex = 3;
            // 
            // pswBox
            // 
            this.pswBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pswBox.Location = new System.Drawing.Point(254, 171);
            this.pswBox.Name = "pswBox";
            this.pswBox.Size = new System.Drawing.Size(176, 34);
            this.pswBox.TabIndex = 4;
            this.pswBox.UseSystemPasswordChar = true;
            // 
            // txtcaptcha
            // 
            this.txtcaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtcaptcha.Location = new System.Drawing.Point(254, 296);
            this.txtcaptcha.Name = "txtcaptcha";
            this.txtcaptcha.Size = new System.Drawing.Size(176, 34);
            this.txtcaptcha.TabIndex = 6;
            this.txtcaptcha.UseSystemPasswordChar = true;
            // 
            // lcaptcha
            // 
            this.lcaptcha.AutoSize = true;
            this.lcaptcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcaptcha.Location = new System.Drawing.Point(111, 296);
            this.lcaptcha.Name = "lcaptcha";
            this.lcaptcha.Size = new System.Drawing.Size(120, 29);
            this.lcaptcha.TabIndex = 5;
            this.lcaptcha.Text = "Password";
            // 
            // lbcaptcha
            // 
            this.lbcaptcha.AutoSize = true;
            this.lbcaptcha.Font = new System.Drawing.Font("OCR A Extended", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcaptcha.Location = new System.Drawing.Point(267, 233);
            this.lbcaptcha.Name = "lbcaptcha";
            this.lbcaptcha.Size = new System.Drawing.Size(117, 25);
            this.lbcaptcha.TabIndex = 7;
            this.lbcaptcha.Text = "captcha";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.ControlBox = false;
            this.Controls.Add(this.lbcaptcha);
            this.Controls.Add(this.txtcaptcha);
            this.Controls.Add(this.lcaptcha);
            this.Controls.Add(this.pswBox);
            this.Controls.Add(this.usrBox);
            this.Controls.Add(this.pswdLbn);
            this.Controls.Add(this.userlbn);
            this.Controls.Add(this.logBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.Text = "LogIn Form";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logBtn;
        private System.Windows.Forms.Label userlbn;
        private System.Windows.Forms.Label pswdLbn;
        private System.Windows.Forms.TextBox usrBox;
        private System.Windows.Forms.TextBox pswBox;
        private System.Windows.Forms.TextBox txtcaptcha;
        private System.Windows.Forms.Label lcaptcha;
        private System.Windows.Forms.Label lbcaptcha;
    }
}

