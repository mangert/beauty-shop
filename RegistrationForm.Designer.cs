namespace BeautyShop
{
    partial class RegistrationForm
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
            this.usernameComboBox = new System.Windows.Forms.ComboBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.fieldsPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.fieldsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameComboBox
            // 
            this.usernameComboBox.DisplayMember = "UserName";
            this.usernameComboBox.FormattingEnabled = true;
            this.usernameComboBox.Location = new System.Drawing.Point(142, 24);
            this.usernameComboBox.Name = "usernameComboBox";
            this.usernameComboBox.Size = new System.Drawing.Size(224, 21);
            this.usernameComboBox.TabIndex = 0;
            this.usernameComboBox.ValueMember = "Id";
            this.usernameComboBox.SelectedIndexChanged += new System.EventHandler(this.usernameComboBox_SelectedIndexChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(30, 27);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(106, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Имя пользователя:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(78, 73);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(48, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль:";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Location = new System.Drawing.Point(142, 69);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(224, 20);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(142, 126);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(115, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Подтвердить";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // fieldsPanel
            // 
            this.fieldsPanel.Controls.Add(this.infoLabel);
            this.fieldsPanel.Controls.Add(this.usernameComboBox);
            this.fieldsPanel.Controls.Add(this.usernameLabel);
            this.fieldsPanel.Controls.Add(this.passwordBox);
            this.fieldsPanel.Controls.Add(this.passwordLabel);
            this.fieldsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.fieldsPanel.Location = new System.Drawing.Point(0, 0);
            this.fieldsPanel.Name = "fieldsPanel";
            this.fieldsPanel.Size = new System.Drawing.Size(433, 120);
            this.fieldsPanel.TabIndex = 3;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(142, 96);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(134, 13);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "инфо о неверном пароле";
            this.infoLabel.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 221);
            this.Controls.Add(this.fieldsPanel);
            this.Controls.Add(this.submitButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(449, 260);
            this.MinimumSize = new System.Drawing.Size(449, 260);
            this.Name = "RegistrationForm";
            this.Opacity = 0.95D;
            this.Text = "Вход в систему";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.fieldsPanel.ResumeLayout(false);
            this.fieldsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox usernameComboBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Panel fieldsPanel;
        private System.Windows.Forms.Label infoLabel;
    }
}