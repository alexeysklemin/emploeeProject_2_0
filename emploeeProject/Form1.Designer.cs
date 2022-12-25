
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
            this.SuspendLayout();
            // 
            // logBtn
            // 
            this.logBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logBtn.Location = new System.Drawing.Point(284, 316);
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
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pswBox);
            this.Controls.Add(this.usrBox);
            this.Controls.Add(this.pswdLbn);
            this.Controls.Add(this.userlbn);
            this.Controls.Add(this.logBtn);
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
    }
}

