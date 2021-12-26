
namespace SkanerKZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.scannerComboBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.scanButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.contrastScale = new System.Windows.Forms.TrackBar();
            this.brightnessScale = new System.Windows.Forms.TrackBar();
            this.colorButt = new System.Windows.Forms.RadioButton();
            this.blackWhiteButt = new System.Windows.Forms.RadioButton();
            this.contrastLabel = new System.Windows.Forms.Label();
            this.brightnessLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dpiTextBox = new System.Windows.Forms.TextBox();
            this.monoButt = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessScale)).BeginInit();
            this.SuspendLayout();
            // 
            // scannerComboBox
            // 
            this.scannerComboBox.FormattingEnabled = true;
            this.scannerComboBox.Location = new System.Drawing.Point(292, 73);
            this.scannerComboBox.Name = "scannerComboBox";
            this.scannerComboBox.Size = new System.Drawing.Size(224, 28);
            this.scannerComboBox.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(92, 73);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(94, 29);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // scanButton
            // 
            this.scanButton.Location = new System.Drawing.Point(192, 73);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(94, 29);
            this.scanButton.TabIndex = 2;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(92, 122);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(371, 493);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // contrastScale
            // 
            this.contrastScale.LargeChange = 50;
            this.contrastScale.Location = new System.Drawing.Point(626, 202);
            this.contrastScale.Maximum = 100;
            this.contrastScale.Minimum = -100;
            this.contrastScale.Name = "contrastScale";
            this.contrastScale.Size = new System.Drawing.Size(130, 56);
            this.contrastScale.TabIndex = 4;
            this.contrastScale.Scroll += new System.EventHandler(this.cotrastScale_Scroll);
            // 
            // brightnessScale
            // 
            this.brightnessScale.Location = new System.Drawing.Point(626, 284);
            this.brightnessScale.Maximum = 100;
            this.brightnessScale.Minimum = -100;
            this.brightnessScale.Name = "brightnessScale";
            this.brightnessScale.Size = new System.Drawing.Size(130, 56);
            this.brightnessScale.TabIndex = 5;
            this.brightnessScale.Scroll += new System.EventHandler(this.brightnessScale_Scroll);
            // 
            // colorButt
            // 
            this.colorButt.AutoSize = true;
            this.colorButt.Checked = true;
            this.colorButt.Location = new System.Drawing.Point(626, 48);
            this.colorButt.Name = "colorButt";
            this.colorButt.Size = new System.Drawing.Size(66, 24);
            this.colorButt.TabIndex = 6;
            this.colorButt.TabStop = true;
            this.colorButt.Text = "Color";
            this.colorButt.UseVisualStyleBackColor = true;
            this.colorButt.CheckedChanged += new System.EventHandler(this.colorButt_CheckedChanged);
            // 
            // blackWhiteButt
            // 
            this.blackWhiteButt.AutoSize = true;
            this.blackWhiteButt.Location = new System.Drawing.Point(626, 18);
            this.blackWhiteButt.Name = "blackWhiteButt";
            this.blackWhiteButt.Size = new System.Drawing.Size(115, 24);
            this.blackWhiteButt.TabIndex = 7;
            this.blackWhiteButt.Text = "Black - white";
            this.blackWhiteButt.UseVisualStyleBackColor = true;
            this.blackWhiteButt.CheckedChanged += new System.EventHandler(this.blackWhiteButt_CheckedChanged);
            // 
            // contrastLabel
            // 
            this.contrastLabel.AutoSize = true;
            this.contrastLabel.Location = new System.Drawing.Point(662, 178);
            this.contrastLabel.Name = "contrastLabel";
            this.contrastLabel.Size = new System.Drawing.Size(64, 20);
            this.contrastLabel.TabIndex = 8;
            this.contrastLabel.Text = "Contrast";
            // 
            // brightnessLabel
            // 
            this.brightnessLabel.AutoSize = true;
            this.brightnessLabel.Location = new System.Drawing.Point(656, 260);
            this.brightnessLabel.Name = "brightnessLabel";
            this.brightnessLabel.Size = new System.Drawing.Size(77, 20);
            this.brightnessLabel.TabIndex = 9;
            this.brightnessLabel.Text = "Brightness";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(648, 373);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 29);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "DPI";
            // 
            // dpiTextBox
            // 
            this.dpiTextBox.Location = new System.Drawing.Point(648, 136);
            this.dpiTextBox.Name = "dpiTextBox";
            this.dpiTextBox.Size = new System.Drawing.Size(85, 27);
            this.dpiTextBox.TabIndex = 12;
            // 
            // monoButt
            // 
            this.monoButt.AutoSize = true;
            this.monoButt.Location = new System.Drawing.Point(626, 75);
            this.monoButt.Name = "monoButt";
            this.monoButt.Size = new System.Drawing.Size(69, 24);
            this.monoButt.TabIndex = 13;
            this.monoButt.TabStop = true;
            this.monoButt.Text = "Mono";
            this.monoButt.UseVisualStyleBackColor = true;
            this.monoButt.CheckedChanged += new System.EventHandler(this.monoButt_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 766);
            this.Controls.Add(this.monoButt);
            this.Controls.Add(this.dpiTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.brightnessLabel);
            this.Controls.Add(this.contrastLabel);
            this.Controls.Add(this.blackWhiteButt);
            this.Controls.Add(this.colorButt);
            this.Controls.Add(this.brightnessScale);
            this.Controls.Add(this.contrastScale);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.scanButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.scannerComboBox);
            this.Name = "Form1";
            this.Text = "Krasicki-Zawadzka\'s scanner";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessScale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox scannerComboBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button scanButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar contrastScale;
        private System.Windows.Forms.TrackBar brightnessScale;
        private System.Windows.Forms.RadioButton colorButt;
        private System.Windows.Forms.RadioButton blackWhiteButt;
        private System.Windows.Forms.Label contrastLabel;
        private System.Windows.Forms.Label brightnessLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dpiTextBox;
        private System.Windows.Forms.RadioButton monoButt;
    }
}

