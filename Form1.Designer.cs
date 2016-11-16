namespace Spelet123
{
    partial class Form_startMeny
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
            this.panel_difficulty = new System.Windows.Forms.Panel();
            this.pBox_Hardcore = new System.Windows.Forms.PictureBox();
            this.pBox_Hard = new System.Windows.Forms.PictureBox();
            this.pBox_Medium = new System.Windows.Forms.PictureBox();
            this.pBox_Easy = new System.Windows.Forms.PictureBox();
            this.panel_StartMenu = new System.Windows.Forms.Panel();
            this.pBox_Exit = new System.Windows.Forms.PictureBox();
            this.pBox_Start = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_difficulty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Hardcore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Medium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Easy)).BeginInit();
            this.panel_StartMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Start)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_difficulty
            // 
            this.panel_difficulty.Controls.Add(this.pBox_Hardcore);
            this.panel_difficulty.Controls.Add(this.pBox_Hard);
            this.panel_difficulty.Controls.Add(this.pBox_Medium);
            this.panel_difficulty.Controls.Add(this.pBox_Easy);
            this.panel_difficulty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_difficulty.Location = new System.Drawing.Point(0, 0);
            this.panel_difficulty.Name = "panel_difficulty";
            this.panel_difficulty.Size = new System.Drawing.Size(784, 361);
            this.panel_difficulty.TabIndex = 1;
            this.panel_difficulty.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_difficulty_Paint);
            // 
            // pBox_Hardcore
            // 
            this.pBox_Hardcore.BackgroundImage = global::Spelet123.Properties.Resources.hardcore;
            this.pBox_Hardcore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_Hardcore.Location = new System.Drawing.Point(350, 220);
            this.pBox_Hardcore.Name = "pBox_Hardcore";
            this.pBox_Hardcore.Size = new System.Drawing.Size(100, 50);
            this.pBox_Hardcore.TabIndex = 3;
            this.pBox_Hardcore.TabStop = false;
            this.pBox_Hardcore.Click += new System.EventHandler(this.pBox_Hardcore_Click);
            // 
            // pBox_Hard
            // 
            this.pBox_Hard.BackgroundImage = global::Spelet123.Properties.Resources.svårt;
            this.pBox_Hard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_Hard.Location = new System.Drawing.Point(350, 160);
            this.pBox_Hard.Name = "pBox_Hard";
            this.pBox_Hard.Size = new System.Drawing.Size(100, 50);
            this.pBox_Hard.TabIndex = 2;
            this.pBox_Hard.TabStop = false;
            this.pBox_Hard.Click += new System.EventHandler(this.pBox_Hard_Click);
            // 
            // pBox_Medium
            // 
            this.pBox_Medium.BackgroundImage = global::Spelet123.Properties.Resources.medium;
            this.pBox_Medium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_Medium.Location = new System.Drawing.Point(350, 100);
            this.pBox_Medium.Name = "pBox_Medium";
            this.pBox_Medium.Size = new System.Drawing.Size(100, 50);
            this.pBox_Medium.TabIndex = 1;
            this.pBox_Medium.TabStop = false;
            this.pBox_Medium.Click += new System.EventHandler(this.pBox_Medium_Click);
            // 
            // pBox_Easy
            // 
            this.pBox_Easy.BackgroundImage = global::Spelet123.Properties.Resources.enkelt;
            this.pBox_Easy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_Easy.Location = new System.Drawing.Point(350, 40);
            this.pBox_Easy.Name = "pBox_Easy";
            this.pBox_Easy.Size = new System.Drawing.Size(100, 50);
            this.pBox_Easy.TabIndex = 0;
            this.pBox_Easy.TabStop = false;
            this.pBox_Easy.Click += new System.EventHandler(this.pBox_Easy_Click);
            // 
            // panel_StartMenu
            // 
            this.panel_StartMenu.BackgroundImage = global::Spelet123.Properties.Resources.lild_strand_1;
            this.panel_StartMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_StartMenu.Controls.Add(this.pBox_Exit);
            this.panel_StartMenu.Controls.Add(this.pBox_Start);
            this.panel_StartMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_StartMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_StartMenu.Name = "panel_StartMenu";
            this.panel_StartMenu.Size = new System.Drawing.Size(784, 361);
            this.panel_StartMenu.TabIndex = 0;
            // 
            // pBox_Exit
            // 
            this.pBox_Exit.BackgroundImage = global::Spelet123.Properties.Resources.exitbre;
            this.pBox_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_Exit.Location = new System.Drawing.Point(350, 200);
            this.pBox_Exit.Name = "pBox_Exit";
            this.pBox_Exit.Size = new System.Drawing.Size(100, 50);
            this.pBox_Exit.TabIndex = 1;
            this.pBox_Exit.TabStop = false;
            this.pBox_Exit.Click += new System.EventHandler(this.pBox_Exit_Click);
            // 
            // pBox_Start
            // 
            this.pBox_Start.BackgroundImage = global::Spelet123.Properties.Resources.start;
            this.pBox_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBox_Start.Location = new System.Drawing.Point(350, 100);
            this.pBox_Start.Name = "pBox_Start";
            this.pBox_Start.Size = new System.Drawing.Size(100, 50);
            this.pBox_Start.TabIndex = 0;
            this.pBox_Start.TabStop = false;
            this.pBox_Start.Click += new System.EventHandler(this.pBox_Start_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_startMeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.panel_difficulty);
            this.Controls.Add(this.panel_StartMenu);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_startMeny";
            this.ShowIcon = false;
            this.Text = "#FREE MY NIGGA FILIP";
            this.Load += new System.EventHandler(this.Form_startMeny_Load);
            this.panel_difficulty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Hardcore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Medium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Easy)).EndInit();
            this.panel_StartMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_Start)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_StartMenu;
        private System.Windows.Forms.PictureBox pBox_Exit;
        private System.Windows.Forms.PictureBox pBox_Start;
        private System.Windows.Forms.Panel panel_difficulty;
        private System.Windows.Forms.PictureBox pBox_Hardcore;
        private System.Windows.Forms.PictureBox pBox_Hard;
        private System.Windows.Forms.PictureBox pBox_Medium;
        private System.Windows.Forms.PictureBox pBox_Easy;
        private System.Windows.Forms.Timer timer1;
    }
}

