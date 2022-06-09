
namespace GamingApp
{
    partial class DinoGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DinoGame));
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.MyTimer = new System.Windows.Forms.Timer(this.components);
            this.lbl_RestartGame = new System.Windows.Forms.Label();
            this.TimerForSearchingRealTime = new System.Windows.Forms.Timer(this.components);
            this.lbl_SpeedOfDino = new System.Windows.Forms.Label();
            this.pb_speedOfDino = new System.Windows.Forms.ProgressBar();
            this.pb_ground = new System.Windows.Forms.PictureBox();
            this.pb_lastChristmasTree = new System.Windows.Forms.PictureBox();
            this.pb_thinTree = new System.Windows.Forms.PictureBox();
            this.PB_TRex = new System.Windows.Forms.PictureBox();
            this.pb_santa = new System.Windows.Forms.PictureBox();
            this.PB_MiddleChristmasTree = new System.Windows.Forms.PictureBox();
            this.PB_SmallChristmasTree = new System.Windows.Forms.PictureBox();
            this.pb_atmosphere2 = new System.Windows.Forms.PictureBox();
            this.pb_atmosphere1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lastChristmasTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thinTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_TRex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_santa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MiddleChristmasTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SmallChristmasTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_atmosphere2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_atmosphere1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_score
            // 
            resources.ApplyResources(this.lbl_score, "lbl_score");
            this.lbl_score.Name = "lbl_score";
            // 
            // lbl_time
            // 
            resources.ApplyResources(this.lbl_time, "lbl_time");
            this.lbl_time.Name = "lbl_time";
            // 
            // MyTimer
            // 
            this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
            // 
            // lbl_RestartGame
            // 
            resources.ApplyResources(this.lbl_RestartGame, "lbl_RestartGame");
            this.lbl_RestartGame.Name = "lbl_RestartGame";
            // 
            // TimerForSearchingRealTime
            // 
            this.TimerForSearchingRealTime.Interval = 1000;
            this.TimerForSearchingRealTime.Tick += new System.EventHandler(this.TimerForSearchingRealTime_Tick);
            // 
            // lbl_SpeedOfDino
            // 
            resources.ApplyResources(this.lbl_SpeedOfDino, "lbl_SpeedOfDino");
            this.lbl_SpeedOfDino.Name = "lbl_SpeedOfDino";
            // 
            // pb_speedOfDino
            // 
            resources.ApplyResources(this.pb_speedOfDino, "pb_speedOfDino");
            this.pb_speedOfDino.Name = "pb_speedOfDino";
            // 
            // pb_ground
            // 
            resources.ApplyResources(this.pb_ground, "pb_ground");
            this.pb_ground.Name = "pb_ground";
            this.pb_ground.TabStop = false;
            // 
            // pb_lastChristmasTree
            // 
            this.pb_lastChristmasTree.BackColor = System.Drawing.SystemColors.Control;
            this.pb_lastChristmasTree.BackgroundImage = global::GamingApp.Properties.Resources.Snowing1;
            resources.ApplyResources(this.pb_lastChristmasTree, "pb_lastChristmasTree");
            this.pb_lastChristmasTree.Image = global::GamingApp.Properties.Resources.imgbin_christmas_tree_gift_new_year_png;
            this.pb_lastChristmasTree.Name = "pb_lastChristmasTree";
            this.pb_lastChristmasTree.TabStop = false;
            this.pb_lastChristmasTree.Tag = "Tree";
            // 
            // pb_thinTree
            // 
            this.pb_thinTree.BackgroundImage = global::GamingApp.Properties.Resources.Snowing1;
            resources.ApplyResources(this.pb_thinTree, "pb_thinTree");
            this.pb_thinTree.Image = global::GamingApp.Properties.Resources.newYearPNG222;
            this.pb_thinTree.Name = "pb_thinTree";
            this.pb_thinTree.TabStop = false;
            this.pb_thinTree.Tag = "Tree";
            // 
            // PB_TRex
            // 
            this.PB_TRex.BackColor = System.Drawing.Color.White;
            this.PB_TRex.BackgroundImage = global::GamingApp.Properties.Resources.Snowing1;
            resources.ApplyResources(this.PB_TRex, "PB_TRex");
            this.PB_TRex.Image = global::GamingApp.Properties.Resources.MyTirexFlying;
            this.PB_TRex.Name = "PB_TRex";
            this.PB_TRex.TabStop = false;
            // 
            // pb_santa
            // 
            this.pb_santa.BackgroundImage = global::GamingApp.Properties.Resources.Snowing1;
            resources.ApplyResources(this.pb_santa, "pb_santa");
            this.pb_santa.Name = "pb_santa";
            this.pb_santa.TabStop = false;
            this.pb_santa.Tag = "Santa";
            // 
            // PB_MiddleChristmasTree
            // 
            this.PB_MiddleChristmasTree.BackColor = System.Drawing.SystemColors.Control;
            this.PB_MiddleChristmasTree.BackgroundImage = global::GamingApp.Properties.Resources.Snowing1;
            resources.ApplyResources(this.PB_MiddleChristmasTree, "PB_MiddleChristmasTree");
            this.PB_MiddleChristmasTree.Image = global::GamingApp.Properties.Resources._95820_christmas_tree_new_year_decoration_for_holiday_2020;
            this.PB_MiddleChristmasTree.Name = "PB_MiddleChristmasTree";
            this.PB_MiddleChristmasTree.TabStop = false;
            this.PB_MiddleChristmasTree.Tag = "Tree";
            // 
            // PB_SmallChristmasTree
            // 
            this.PB_SmallChristmasTree.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PB_SmallChristmasTree.BackgroundImage = global::GamingApp.Properties.Resources.Snowing1;
            resources.ApplyResources(this.PB_SmallChristmasTree, "PB_SmallChristmasTree");
            this.PB_SmallChristmasTree.Image = global::GamingApp.Properties.Resources.newYearPNG;
            this.PB_SmallChristmasTree.Name = "PB_SmallChristmasTree";
            this.PB_SmallChristmasTree.TabStop = false;
            this.PB_SmallChristmasTree.Tag = "Tree";
            // 
            // pb_atmosphere2
            // 
            resources.ApplyResources(this.pb_atmosphere2, "pb_atmosphere2");
            this.pb_atmosphere2.Name = "pb_atmosphere2";
            this.pb_atmosphere2.TabStop = false;
            // 
            // pb_atmosphere1
            // 
            resources.ApplyResources(this.pb_atmosphere1, "pb_atmosphere1");
            this.pb_atmosphere1.Name = "pb_atmosphere1";
            this.pb_atmosphere1.TabStop = false;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DinoGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_SpeedOfDino);
            this.Controls.Add(this.pb_speedOfDino);
            this.Controls.Add(this.pb_ground);
            this.Controls.Add(this.pb_lastChristmasTree);
            this.Controls.Add(this.pb_thinTree);
            this.Controls.Add(this.PB_TRex);
            this.Controls.Add(this.lbl_RestartGame);
            this.Controls.Add(this.pb_santa);
            this.Controls.Add(this.PB_MiddleChristmasTree);
            this.Controls.Add(this.PB_SmallChristmasTree);
            this.Controls.Add(this.pb_atmosphere2);
            this.Controls.Add(this.pb_atmosphere1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DinoGame";
            this.Load += new System.EventHandler(this.DinoGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.WhenKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.WhenKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_lastChristmasTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thinTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_TRex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_santa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MiddleChristmasTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SmallChristmasTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_atmosphere2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_atmosphere1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox PB_MiddleChristmasTree;
        private System.Windows.Forms.PictureBox PB_SmallChristmasTree;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer MyTimer;
        private System.Windows.Forms.PictureBox pb_atmosphere1;
        private System.Windows.Forms.Label lbl_RestartGame;
        private System.Windows.Forms.Timer TimerForSearchingRealTime;
        private System.Windows.Forms.PictureBox pb_atmosphere2;
        private System.Windows.Forms.PictureBox pb_ground;
        private System.Windows.Forms.PictureBox PB_TRex;
        private System.Windows.Forms.PictureBox pb_santa;
        private System.Windows.Forms.Label lbl_SpeedOfDino;
        private System.Windows.Forms.ProgressBar pb_speedOfDino;
        private System.Windows.Forms.PictureBox pb_thinTree;
        private System.Windows.Forms.PictureBox pb_lastChristmasTree;
        private System.Windows.Forms.Label label1;
    }
}

