namespace CakeFuiry1
{
    partial class pause
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
            this.TitlePause = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitlePause
            // 
            this.TitlePause.AutoSize = true;
            this.TitlePause.Location = new System.Drawing.Point(85, 9);
            this.TitlePause.Name = "TitlePause";
            this.TitlePause.Size = new System.Drawing.Size(38, 13);
            this.TitlePause.TabIndex = 0;
            this.TitlePause.Text = "Пауза";
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(63, 47);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(90, 23);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(41, 91);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(132, 23);
            this.btnMenu.TabIndex = 2;
            this.btnMenu.Text = "Назад в меню";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pause
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 320);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.TitlePause);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pause";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitlePause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnMenu;
    }
}