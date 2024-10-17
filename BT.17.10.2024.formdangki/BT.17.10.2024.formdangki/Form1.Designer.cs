namespace BT._17._10._2024.formdangki
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            TxtName = new TextBox();
            TxtEmail = new TextBox();
            TxtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            BtnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.Location = new Point(276, 41);
            label1.Name = "label1";
            label1.Size = new Size(251, 38);
            label1.TabIndex = 0;
            label1.Text = "Đăng kí tài khoản";
            // 
            // TxtName
            // 
            TxtName.Location = new Point(334, 134);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(224, 27);
            TxtName.TabIndex = 1;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(334, 207);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(224, 27);
            TxtEmail.TabIndex = 2;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(334, 280);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(224, 27);
            TxtPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 141);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 4;
            label2.Text = "Tên :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 210);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(220, 279);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 6;
            label4.Text = "Mật khẩu :";
            // 
            // BtnRegister
            // 
            BtnRegister.Location = new Point(358, 363);
            BtnRegister.Name = "BtnRegister";
            BtnRegister.Size = new Size(94, 29);
            BtnRegister.TabIndex = 7;
            BtnRegister.Text = "Đăng kí";
            BtnRegister.UseVisualStyleBackColor = true;
            BtnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(TxtPassword);
            Controls.Add(TxtEmail);
            Controls.Add(TxtName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Formdangki";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TxtName;
        private TextBox TxtEmail;
        private TextBox TxtPassword;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button BtnRegister;
    }
}
