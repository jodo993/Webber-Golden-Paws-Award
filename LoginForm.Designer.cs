namespace Webber_Golden_Paws_Award
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.createNewAccountLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 1;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(266, 153);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(67, 28);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(266, 187);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(67, 28);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // createNewAccountLinkLabel
            // 
            this.createNewAccountLinkLabel.AutoSize = true;
            this.createNewAccountLinkLabel.Location = new System.Drawing.Point(230, 246);
            this.createNewAccountLinkLabel.Name = "createNewAccountLinkLabel";
            this.createNewAccountLinkLabel.Size = new System.Drawing.Size(124, 14);
            this.createNewAccountLinkLabel.TabIndex = 4;
            this.createNewAccountLinkLabel.TabStop = true;
            this.createNewAccountLinkLabel.Text = "Create New Account";
            this.createNewAccountLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewAccountLinkLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 419);
            this.Controls.Add(this.createNewAccountLinkLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.LinkLabel createNewAccountLinkLabel;
    }
}

