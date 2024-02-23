﻿namespace SimonSays
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.yellowButton = new System.Windows.Forms.Button();
            this.blueButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.StopWatch = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // yellowButton
            // 
            this.yellowButton.BackColor = System.Drawing.Color.Goldenrod;
            this.yellowButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.yellowButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.yellowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yellowButton.Location = new System.Drawing.Point(40, 149);
            this.yellowButton.Name = "yellowButton";
            this.yellowButton.Size = new System.Drawing.Size(110, 110);
            this.yellowButton.TabIndex = 3;
            this.yellowButton.UseVisualStyleBackColor = false;
            this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
            // 
            // blueButton
            // 
            this.blueButton.BackColor = System.Drawing.Color.DarkBlue;
            this.blueButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.blueButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.blueButton.Location = new System.Drawing.Point(152, 149);
            this.blueButton.Name = "blueButton";
            this.blueButton.Size = new System.Drawing.Size(110, 110);
            this.blueButton.TabIndex = 2;
            this.blueButton.UseVisualStyleBackColor = false;
            this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.DarkRed;
            this.redButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.redButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.redButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redButton.Location = new System.Drawing.Point(152, 37);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(110, 110);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.Click += new System.EventHandler(this.redButton_Click);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.ForestGreen;
            this.greenButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.greenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.greenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.greenButton.Location = new System.Drawing.Point(40, 37);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(110, 110);
            this.greenButton.TabIndex = 0;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
            // 
            // StopWatch
            // 
            this.StopWatch.Tick += new System.EventHandler(this.StopWatch_Tick);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.yellowButton);
            this.Controls.Add(this.blueButton);
            this.Controls.Add(this.redButton);
            this.Controls.Add(this.greenButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(301, 300);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button yellowButton;
        private System.Windows.Forms.Button blueButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Timer StopWatch;
    }
}
