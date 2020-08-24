namespace CakeFuiry1
{
    partial class map1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(map1));
            this.track = new System.Windows.Forms.Timer(this.components);
            this.OHero = new System.Windows.Forms.Label();
            this.OMap = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy3 = new System.Windows.Forms.PictureBox();
            this.hero = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            this.SuspendLayout();
            // 
            // track
            // 
            this.track.Enabled = true;
            this.track.Interval = 1;
            this.track.Tick += new System.EventHandler(this.track_Tick);
            // 
            // OHero
            // 
            resources.ApplyResources(this.OHero, "OHero");
            this.OHero.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OHero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OHero.Name = "OHero";
            // 
            // OMap
            // 
            resources.ApplyResources(this.OMap, "OMap");
            this.OMap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.OMap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OMap.Name = "OMap";
            // 
            // Result
            // 
            resources.ApplyResources(this.Result, "Result");
            this.Result.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Result.Name = "Result";
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.BackgroundImage = global::CakeFuiry1.Properties.Resources.MENYu;
            resources.ApplyResources(this.btnMenu, "btnMenu");
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.UseVisualStyleBackColor = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.enemy2, "enemy2");
            this.enemy2.Name = "enemy2";
            this.enemy2.TabStop = false;
            this.enemy2.Tag = "2";
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.enemy1, "enemy1");
            this.enemy1.Name = "enemy1";
            this.enemy1.TabStop = false;
            this.enemy1.Tag = "2";
            // 
            // enemy3
            // 
            this.enemy3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.enemy3, "enemy3");
            this.enemy3.Name = "enemy3";
            this.enemy3.TabStop = false;
            this.enemy3.Tag = "2";
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.hero, "hero");
            this.hero.Image = global::CakeFuiry1.Properties.Resources.babka2;
            this.hero.Name = "hero";
            this.hero.TabStop = false;
            // 
            // map1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.enemy3);
            this.Controls.Add(this.OMap);
            this.Controls.Add(this.OHero);
            this.Controls.Add(this.hero);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "map1";
            this.Load += new System.EventHandler(this.map1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.map1_KeyPress_1);
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.Timer track;
        private System.Windows.Forms.Label OHero;
        private System.Windows.Forms.Label OMap;
        private System.Windows.Forms.PictureBox enemy3;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Button btnMenu;
    }
}