namespace Game
{
    partial class Game
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
            this.imgView = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.solutionPicker = new System.Windows.Forms.NumericUpDown();
            this.okayButton = new System.Windows.Forms.Button();
            this.health1 = new System.Windows.Forms.PictureBox();
            this.health2 = new System.Windows.Forms.PictureBox();
            this.health3 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.scoreLB = new System.Windows.Forms.Label();
            this.userLb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgView
            // 
            this.imgView.Image = global::Game.Properties.Resources.mathsgame;
            this.imgView.Location = new System.Drawing.Point(12, 69);
            this.imgView.Name = "imgView";
            this.imgView.Size = new System.Drawing.Size(660, 360);
            this.imgView.TabIndex = 0;
            this.imgView.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Control;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(597, 451);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 27);
            this.btn1.TabIndex = 8;
            this.btn1.Text = "Exit";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // solutionPicker
            // 
            this.solutionPicker.Location = new System.Drawing.Point(180, 456);
            this.solutionPicker.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.solutionPicker.Name = "solutionPicker";
            this.solutionPicker.Size = new System.Drawing.Size(120, 20);
            this.solutionPicker.TabIndex = 9;
            // 
            // okayButton
            // 
            this.okayButton.Location = new System.Drawing.Point(320, 449);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(112, 30);
            this.okayButton.TabIndex = 10;
            this.okayButton.Text = "Check Answer";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // health1
            // 
            this.health1.BackColor = System.Drawing.Color.Transparent;
            this.health1.Image = global::Game.Properties.Resources.health;
            this.health1.Location = new System.Drawing.Point(6, 19);
            this.health1.Name = "health1";
            this.health1.Size = new System.Drawing.Size(23, 22);
            this.health1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.health1.TabIndex = 11;
            this.health1.TabStop = false;
            // 
            // health2
            // 
            this.health2.BackColor = System.Drawing.Color.Transparent;
            this.health2.Image = global::Game.Properties.Resources.health;
            this.health2.Location = new System.Drawing.Point(35, 19);
            this.health2.Name = "health2";
            this.health2.Size = new System.Drawing.Size(23, 22);
            this.health2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.health2.TabIndex = 12;
            this.health2.TabStop = false;
            // 
            // health3
            // 
            this.health3.BackColor = System.Drawing.Color.Transparent;
            this.health3.Image = global::Game.Properties.Resources.health;
            this.health3.Location = new System.Drawing.Point(64, 19);
            this.health3.Name = "health3";
            this.health3.Size = new System.Drawing.Size(23, 22);
            this.health3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.health3.TabIndex = 13;
            this.health3.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.health1);
            this.groupBox1.Controls.Add(this.health3);
            this.groupBox1.Controls.Add(this.health2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 50);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Health";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Select your answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Your Score:";
            // 
            // scoreLB
            // 
            this.scoreLB.AutoSize = true;
            this.scoreLB.BackColor = System.Drawing.Color.Transparent;
            this.scoreLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLB.ForeColor = System.Drawing.Color.White;
            this.scoreLB.Location = new System.Drawing.Point(306, 37);
            this.scoreLB.Name = "scoreLB";
            this.scoreLB.Size = new System.Drawing.Size(17, 17);
            this.scoreLB.TabIndex = 17;
            this.scoreLB.Text = "0";
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.BackColor = System.Drawing.Color.Transparent;
            this.userLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLb.ForeColor = System.Drawing.Color.White;
            this.userLb.Location = new System.Drawing.Point(306, 9);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(62, 17);
            this.userLb.TabIndex = 18;
            this.userLb.Text = "Hi User";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 497);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.scoreLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.solutionPicker);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.imgView);
            this.Name = "Game";
            this.Text = " Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.health3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgView;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.NumericUpDown solutionPicker;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.PictureBox health1;
        private System.Windows.Forms.PictureBox health2;
        private System.Windows.Forms.PictureBox health3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label scoreLB;
        private System.Windows.Forms.Label userLb;
    }
}