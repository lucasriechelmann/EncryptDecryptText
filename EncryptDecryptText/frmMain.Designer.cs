namespace EncryptDecryptText
{
    partial class frmMain
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
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtInput = new TextBox();
            lblInput = new Label();
            txtOutput = new TextBox();
            lblOutput = new Label();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 9);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 27);
            txtPassword.MaxLength = 32;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(1008, 23);
            txtPassword.TabIndex = 1;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 71);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(1008, 208);
            txtInput.TabIndex = 3;
            // 
            // lblInput
            // 
            lblInput.AutoSize = true;
            lblInput.Location = new Point(12, 53);
            lblInput.Name = "lblInput";
            lblInput.Size = new Size(35, 15);
            lblInput.TabIndex = 2;
            lblInput.Text = "Input";
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(12, 300);
            txtOutput.Multiline = true;
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(1008, 208);
            txtOutput.TabIndex = 5;
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(12, 282);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(45, 15);
            lblOutput.TabIndex = 4;
            lblOutput.Text = "Output";
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnEncrypt.Location = new Point(12, 514);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(285, 85);
            btnEncrypt.TabIndex = 6;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecrypt.Location = new Point(303, 514);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(285, 85);
            btnDecrypt.TabIndex = 7;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 609);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtOutput);
            Controls.Add(lblOutput);
            Controls.Add(txtInput);
            Controls.Add(lblInput);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmMain";
            Text = "Encrypt Decrypt Text";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtInput;
        private Label lblInput;
        private TextBox txtOutput;
        private Label lblOutput;
        private Button btnEncrypt;
        private Button btnDecrypt;
    }
}