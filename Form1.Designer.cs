namespace BeautyShop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.invitationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // invitationLabel
            // 
            this.invitationLabel.AutoSize = true;
            this.invitationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invitationLabel.Font = new System.Drawing.Font("Book Antiqua", 30.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.invitationLabel.ForeColor = System.Drawing.Color.Blue;
            this.invitationLabel.Location = new System.Drawing.Point(0, 0);
            this.invitationLabel.Name = "invitationLabel";
            this.invitationLabel.Size = new System.Drawing.Size(200, 49);
            this.invitationLabel.TabIndex = 0;
            this.invitationLabel.Text = "Invitation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invitationLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label invitationLabel;
    }
}

