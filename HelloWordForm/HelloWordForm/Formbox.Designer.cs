namespace HelloWordForm
{
    partial class Formbox
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox366 = new System.Windows.Forms.CheckBox();
            this.checkBox365 = new System.Windows.Forms.CheckBox();
            this.checkBox360 = new System.Windows.Forms.CheckBox();
            this.checkBox300 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox366);
            this.groupBox1.Controls.Add(this.checkBox365);
            this.groupBox1.Controls.Add(this.checkBox360);
            this.groupBox1.Controls.Add(this.checkBox300);
            this.groupBox1.Location = new System.Drawing.Point(183, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(338, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Một năm có bao nhiêu ngày";
            // 
            // checkBox366
            // 
            this.checkBox366.AutoSize = true;
            this.checkBox366.Location = new System.Drawing.Point(22, 202);
            this.checkBox366.Name = "checkBox366";
            this.checkBox366.Size = new System.Drawing.Size(67, 29);
            this.checkBox366.TabIndex = 3;
            this.checkBox366.Text = "366";
            this.checkBox366.UseVisualStyleBackColor = true;
            this.checkBox366.Click += new System.EventHandler(this.CheckboxClicked);
            // 
            // checkBox365
            // 
            this.checkBox365.AutoSize = true;
            this.checkBox365.Location = new System.Drawing.Point(22, 154);
            this.checkBox365.Name = "checkBox365";
            this.checkBox365.Size = new System.Drawing.Size(67, 29);
            this.checkBox365.TabIndex = 2;
            this.checkBox365.Text = "365";
            this.checkBox365.UseVisualStyleBackColor = true;
            this.checkBox365.Click += new System.EventHandler(this.CheckboxClicked);
            // 
            // checkBox360
            // 
            this.checkBox360.AutoSize = true;
            this.checkBox360.Location = new System.Drawing.Point(22, 105);
            this.checkBox360.Name = "checkBox360";
            this.checkBox360.Size = new System.Drawing.Size(67, 29);
            this.checkBox360.TabIndex = 1;
            this.checkBox360.Text = "360";
            this.checkBox360.UseVisualStyleBackColor = true;
            this.checkBox360.Click += new System.EventHandler(this.CheckboxClicked);
            // 
            // checkBox300
            // 
            this.checkBox300.AutoSize = true;
            this.checkBox300.Location = new System.Drawing.Point(22, 57);
            this.checkBox300.Name = "checkBox300";
            this.checkBox300.Size = new System.Drawing.Size(67, 29);
            this.checkBox300.TabIndex = 0;
            this.checkBox300.Text = "300";
            this.checkBox300.UseVisualStyleBackColor = true;
            this.checkBox300.Click += new System.EventHandler(this.CheckboxClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox2.Controls.Add(this.radioButton12);
            this.groupBox2.Controls.Add(this.radioButton9);
            this.groupBox2.Controls.Add(this.radioButton11);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox2.Location = new System.Drawing.Point(573, 116);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 292);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Một năm có bao nhiêu tháng";
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(31, 192);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(109, 29);
            this.radioButton12.TabIndex = 3;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12 tháng";
            this.radioButton12.UseVisualStyleBackColor = true;
            this.radioButton12.Click += new System.EventHandler(this.radioButtonClicked);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(31, 104);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(98, 29);
            this.radioButton9.TabIndex = 2;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "9 tháng";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.Click += new System.EventHandler(this.radioButtonClicked);
            // 
            // radioButton11
            // 
            this.radioButton11.AutoSize = true;
            this.radioButton11.Location = new System.Drawing.Point(31, 146);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(109, 29);
            this.radioButton11.TabIndex = 1;
            this.radioButton11.TabStop = true;
            this.radioButton11.Text = "11 tháng";
            this.radioButton11.UseVisualStyleBackColor = true;
            this.radioButton11.Click += new System.EventHandler(this.radioButtonClicked);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(31, 59);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(98, 29);
            this.radioButton6.TabIndex = 0;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6 tháng";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButtonClicked);
            // 
            // Formbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Formbox";
            this.Text = "Formbox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox366;
        private System.Windows.Forms.CheckBox checkBox365;
        private System.Windows.Forms.CheckBox checkBox360;
        private System.Windows.Forms.CheckBox checkBox300;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton6;
    }
}