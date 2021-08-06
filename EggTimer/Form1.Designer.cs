namespace EggTimer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.minutesTB = new System.Windows.Forms.NumericUpDown();
            this.goResetButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.secondsTB = new System.Windows.Forms.NumericUpDown();
            this.displayTB = new System.Windows.Forms.TextBox();
            this.hoursTB = new System.Windows.Forms.NumericUpDown();
            this.timerButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.alertAnimationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.minutesTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursTB)).BeginInit();
            this.SuspendLayout();
            // 
            // minutesTB
            // 
            this.minutesTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesTB.Location = new System.Drawing.Point(34, 44);
            this.minutesTB.Name = "minutesTB";
            this.minutesTB.Size = new System.Drawing.Size(139, 26);
            this.minutesTB.TabIndex = 2;
            this.minutesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // goResetButton
            // 
            this.goResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goResetButton.Location = new System.Drawing.Point(54, 108);
            this.goResetButton.Name = "goResetButton";
            this.goResetButton.Size = new System.Drawing.Size(77, 38);
            this.goResetButton.TabIndex = 4;
            this.goResetButton.Text = "Go!";
            this.goResetButton.UseVisualStyleBackColor = true;
            this.goResetButton.Click += new System.EventHandler(this.goResetButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // secondsTB
            // 
            this.secondsTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsTB.Location = new System.Drawing.Point(34, 12);
            this.secondsTB.Name = "secondsTB";
            this.secondsTB.Size = new System.Drawing.Size(139, 26);
            this.secondsTB.TabIndex = 1;
            this.secondsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // displayTB
            // 
            this.displayTB.BackColor = System.Drawing.Color.Black;
            this.displayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.displayTB.Location = new System.Drawing.Point(12, 152);
            this.displayTB.Name = "displayTB";
            this.displayTB.ReadOnly = true;
            this.displayTB.Size = new System.Drawing.Size(161, 38);
            this.displayTB.TabIndex = 4;
            this.displayTB.TabStop = false;
            this.displayTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hoursTB
            // 
            this.hoursTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTB.Location = new System.Drawing.Point(34, 76);
            this.hoursTB.Name = "hoursTB";
            this.hoursTB.Size = new System.Drawing.Size(139, 26);
            this.hoursTB.TabIndex = 3;
            this.hoursTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerButton
            // 
            this.timerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerButton.Location = new System.Drawing.Point(137, 108);
            this.timerButton.Name = "timerButton";
            this.timerButton.Size = new System.Drawing.Size(36, 38);
            this.timerButton.TabIndex = 5;
            this.timerButton.TabStop = false;
            this.timerButton.Text = "T";
            this.timerButton.UseVisualStyleBackColor = true;
            this.timerButton.Click += new System.EventHandler(this.timerButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseButton.Location = new System.Drawing.Point(12, 108);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(36, 38);
            this.pauseButton.TabIndex = 6;
            this.pauseButton.TabStop = false;
            this.pauseButton.Text = "II";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "h";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 196);
            this.progressBar.MarqueeAnimationSpeed = 50;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(161, 23);
            this.progressBar.TabIndex = 12;
            // 
            // alertAnimationTimer
            // 
            this.alertAnimationTimer.Interval = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 228);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursTB);
            this.Controls.Add(this.minutesTB);
            this.Controls.Add(this.secondsTB);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.timerButton);
            this.Controls.Add(this.displayTB);
            this.Controls.Add(this.goResetButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EggTimer";
            ((System.ComponentModel.ISupportInitialize)(this.minutesTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondsTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoursTB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button goResetButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown minutesTB;
        private System.Windows.Forms.NumericUpDown secondsTB;
        private System.Windows.Forms.TextBox displayTB;
        private System.Windows.Forms.NumericUpDown hoursTB;
        private System.Windows.Forms.Button timerButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Timer alertAnimationTimer;

    }
}

