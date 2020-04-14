namespace MonogameXMLGenerator
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
            this.Load_IMG_filetext = new System.Windows.Forms.TextBox();
            this.radioX_Button = new System.Windows.Forms.RadioButton();
            this.radioY_Button = new System.Windows.Forms.RadioButton();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.XPaddingTextBox = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.YPaddingTextBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.SpriteWidthTextBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SpriteHeightTextBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.XPaddingTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPaddingTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteWidthTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteHeightTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Load_IMG_filetext
            // 
            this.Load_IMG_filetext.Location = new System.Drawing.Point(318, 72);
            this.Load_IMG_filetext.Name = "Load_IMG_filetext";
            this.Load_IMG_filetext.Size = new System.Drawing.Size(324, 20);
            this.Load_IMG_filetext.TabIndex = 0;
            this.Load_IMG_filetext.TextChanged += new System.EventHandler(this.Load_IMG_filetext_TextChanged);
            // 
            // radioX_Button
            // 
            this.radioX_Button.AutoSize = true;
            this.radioX_Button.Checked = true;
            this.radioX_Button.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioX_Button.Location = new System.Drawing.Point(318, 98);
            this.radioX_Button.Name = "radioX_Button";
            this.radioX_Button.Size = new System.Drawing.Size(120, 17);
            this.radioX_Button.TabIndex = 1;
            this.radioX_Button.TabStop = true;
            this.radioX_Button.Text = "X Coordinate Priority";
            this.radioX_Button.UseVisualStyleBackColor = true;
            this.radioX_Button.CheckedChanged += new System.EventHandler(this.radioX_Button_CheckedChanged);
            // 
            // radioY_Button
            // 
            this.radioY_Button.AutoSize = true;
            this.radioY_Button.Location = new System.Drawing.Point(522, 98);
            this.radioY_Button.Name = "radioY_Button";
            this.radioY_Button.Size = new System.Drawing.Size(120, 17);
            this.radioY_Button.TabIndex = 2;
            this.radioY_Button.TabStop = true;
            this.radioY_Button.Text = "Y Coordinate Priority";
            this.radioY_Button.UseVisualStyleBackColor = true;
            this.radioY_Button.CheckedChanged += new System.EventHandler(this.radioY_Button_CheckedChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(648, 72);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 20);
            this.BrowseButton.TabIndex = 3;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // XPaddingTextBox
            // 
            this.XPaddingTextBox.Location = new System.Drawing.Point(318, 147);
            this.XPaddingTextBox.Name = "XPaddingTextBox";
            this.XPaddingTextBox.Size = new System.Drawing.Size(36, 20);
            this.XPaddingTextBox.TabIndex = 4;
            this.XPaddingTextBox.TextChanged += new System.EventHandler(this.XPaddingTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X Padding";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // YPaddingTextBox
            // 
            this.YPaddingTextBox.Location = new System.Drawing.Point(522, 147);
            this.YPaddingTextBox.Name = "YPaddingTextBox";
            this.YPaddingTextBox.Size = new System.Drawing.Size(37, 20);
            this.YPaddingTextBox.TabIndex = 6;
            this.YPaddingTextBox.TextChanged += new System.EventHandler(this.YPaddingTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Y Padding";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(513, 366);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(214, 23);
            this.GenerateButton.TabIndex = 8;
            this.GenerateButton.Text = "Generate XML";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // SpriteWidthTextBox
            // 
            this.SpriteWidthTextBox.Location = new System.Drawing.Point(318, 121);
            this.SpriteWidthTextBox.Name = "SpriteWidthTextBox";
            this.SpriteWidthTextBox.Size = new System.Drawing.Size(36, 20);
            this.SpriteWidthTextBox.TabIndex = 9;
            this.SpriteWidthTextBox.TextChanged += new System.EventHandler(this.SpriteWidthTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sprite Width";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // SpriteHeightTextBox
            // 
            this.SpriteHeightTextBox.Location = new System.Drawing.Point(522, 121);
            this.SpriteHeightTextBox.Name = "SpriteHeightTextBox";
            this.SpriteHeightTextBox.Size = new System.Drawing.Size(37, 20);
            this.SpriteHeightTextBox.TabIndex = 11;
            this.SpriteHeightTextBox.TextChanged += new System.EventHandler(this.SpriteHeightTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(565, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sprite Height";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(318, 173);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(205, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Apply X Padding before each Row";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(522, 173);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(205, 18);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Apply Y Padding before each Column";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 360);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(139, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dimensions: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Stretch",
            "Center",
            "Zoom"});
            this.comboBox1.Location = new System.Drawing.Point(12, 373);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 402);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SpriteHeightTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SpriteWidthTextBox);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.YPaddingTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.XPaddingTextBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.radioY_Button);
            this.Controls.Add(this.radioX_Button);
            this.Controls.Add(this.Load_IMG_filetext);
            this.Name = "Form1";
            this.Text = "Monogame Spritesheet XML Generator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XPaddingTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YPaddingTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteWidthTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpriteHeightTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.TextBox Load_IMG_filetext;
        private System.Windows.Forms.RadioButton radioX_Button;
        private System.Windows.Forms.RadioButton radioY_Button;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown XPaddingTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown YPaddingTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.NumericUpDown SpriteWidthTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SpriteHeightTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

