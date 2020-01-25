namespace Form1
{
    partial class CompanyName
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.fonttab = new System.Windows.Forms.TabPage();
            this.courier = new System.Windows.Forms.RadioButton();
            this.arial = new System.Windows.Forms.RadioButton();
            this.times_new_roman = new System.Windows.Forms.RadioButton();
            this.sizetab = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.sizetwentyfour = new System.Windows.Forms.RadioButton();
            this.sizetwenty = new System.Windows.Forms.RadioButton();
            this.sizesixteen = new System.Windows.Forms.RadioButton();
            this.colortab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Button();
            this.texttab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.new_value = new System.Windows.Forms.TextBox();
            this.old_value = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1.SuspendLayout();
            this.fonttab.SuspendLayout();
            this.sizetab.SuspendLayout();
            this.colortab.SuspendLayout();
            this.texttab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.fonttab);
            this.tabControl1.Controls.Add(this.sizetab);
            this.tabControl1.Controls.Add(this.colortab);
            this.tabControl1.Controls.Add(this.texttab);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(420, 170);
            this.tabControl1.TabIndex = 0;
            // 
            // fonttab
            // 
            this.fonttab.Controls.Add(this.courier);
            this.fonttab.Controls.Add(this.arial);
            this.fonttab.Controls.Add(this.times_new_roman);
            this.fonttab.Location = new System.Drawing.Point(4, 22);
            this.fonttab.Name = "fonttab";
            this.fonttab.Padding = new System.Windows.Forms.Padding(3);
            this.fonttab.Size = new System.Drawing.Size(412, 144);
            this.fonttab.TabIndex = 0;
            this.fonttab.Text = "Font";
            this.fonttab.UseVisualStyleBackColor = true;
            this.fonttab.Click += new System.EventHandler(this.fonttab_Click);
            // 
            // courier
            // 
            this.courier.AutoSize = true;
            this.courier.Location = new System.Drawing.Point(8, 55);
            this.courier.Name = "courier";
            this.courier.Size = new System.Drawing.Size(58, 17);
            this.courier.TabIndex = 2;
            this.courier.Text = "Courier";
            this.courier.UseVisualStyleBackColor = true;
            this.courier.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // arial
            // 
            this.arial.AutoSize = true;
            this.arial.Location = new System.Drawing.Point(8, 32);
            this.arial.Name = "arial";
            this.arial.Size = new System.Drawing.Size(45, 17);
            this.arial.TabIndex = 1;
            this.arial.Text = "Arial";
            this.arial.UseVisualStyleBackColor = true;
            this.arial.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // times_new_roman
            // 
            this.times_new_roman.AutoSize = true;
            this.times_new_roman.Checked = true;
            this.times_new_roman.Location = new System.Drawing.Point(8, 9);
            this.times_new_roman.Name = "times_new_roman";
            this.times_new_roman.Size = new System.Drawing.Size(115, 17);
            this.times_new_roman.TabIndex = 0;
            this.times_new_roman.TabStop = true;
            this.times_new_roman.Text = "Times New Roman";
            this.times_new_roman.UseVisualStyleBackColor = true;
            this.times_new_roman.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // sizetab
            // 
            this.sizetab.Controls.Add(this.label4);
            this.sizetab.Controls.Add(this.sizetwentyfour);
            this.sizetab.Controls.Add(this.sizetwenty);
            this.sizetab.Controls.Add(this.sizesixteen);
            this.sizetab.Location = new System.Drawing.Point(4, 22);
            this.sizetab.Name = "sizetab";
            this.sizetab.Padding = new System.Windows.Forms.Padding(3);
            this.sizetab.Size = new System.Drawing.Size(412, 144);
            this.sizetab.TabIndex = 1;
            this.sizetab.Text = "Size";
            this.sizetab.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pick the size you want";
            // 
            // sizetwentyfour
            // 
            this.sizetwentyfour.AutoSize = true;
            this.sizetwentyfour.Location = new System.Drawing.Point(11, 76);
            this.sizetwentyfour.Name = "sizetwentyfour";
            this.sizetwentyfour.Size = new System.Drawing.Size(37, 17);
            this.sizetwentyfour.TabIndex = 2;
            this.sizetwentyfour.TabStop = true;
            this.sizetwentyfour.Text = "24";
            this.sizetwentyfour.UseVisualStyleBackColor = true;
            // 
            // sizetwenty
            // 
            this.sizetwenty.AutoSize = true;
            this.sizetwenty.Location = new System.Drawing.Point(11, 53);
            this.sizetwenty.Name = "sizetwenty";
            this.sizetwenty.Size = new System.Drawing.Size(37, 17);
            this.sizetwenty.TabIndex = 1;
            this.sizetwenty.TabStop = true;
            this.sizetwenty.Text = "20";
            this.sizetwenty.UseVisualStyleBackColor = true;
            // 
            // sizesixteen
            // 
            this.sizesixteen.AutoSize = true;
            this.sizesixteen.Location = new System.Drawing.Point(11, 30);
            this.sizesixteen.Name = "sizesixteen";
            this.sizesixteen.Size = new System.Drawing.Size(37, 17);
            this.sizesixteen.TabIndex = 0;
            this.sizesixteen.TabStop = true;
            this.sizesixteen.Text = "16";
            this.sizesixteen.UseVisualStyleBackColor = true;
            // 
            // colortab
            // 
            this.colortab.Controls.Add(this.label3);
            this.colortab.Controls.Add(this.color);
            this.colortab.Location = new System.Drawing.Point(4, 22);
            this.colortab.Name = "colortab";
            this.colortab.Padding = new System.Windows.Forms.Padding(3);
            this.colortab.Size = new System.Drawing.Size(412, 144);
            this.colortab.TabIndex = 2;
            this.colortab.Text = "Color";
            this.colortab.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pick the color you want";
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(11, 28);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(75, 23);
            this.color.TabIndex = 0;
            this.color.Text = "Color";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // texttab
            // 
            this.texttab.Controls.Add(this.label2);
            this.texttab.Controls.Add(this.label1);
            this.texttab.Controls.Add(this.new_value);
            this.texttab.Controls.Add(this.old_value);
            this.texttab.Location = new System.Drawing.Point(4, 22);
            this.texttab.Name = "texttab";
            this.texttab.Padding = new System.Windows.Forms.Padding(3);
            this.texttab.Size = new System.Drawing.Size(412, 144);
            this.texttab.TabIndex = 3;
            this.texttab.Text = "Text";
            this.texttab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "New Value";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old Value";
            // 
            // new_value
            // 
            this.new_value.Location = new System.Drawing.Point(8, 69);
            this.new_value.Name = "new_value";
            this.new_value.Size = new System.Drawing.Size(100, 20);
            this.new_value.TabIndex = 1;
            this.new_value.TextChanged += new System.EventHandler(this.new_value_TextChanged);
            // 
            // old_value
            // 
            this.old_value.Location = new System.Drawing.Point(8, 20);
            this.old_value.Name = "old_value";
            this.old_value.Size = new System.Drawing.Size(100, 20);
            this.old_value.TabIndex = 0;
            this.old_value.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CompanyName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 269);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Name = "CompanyName";
            this.Text = "CompanyName";
            this.tabControl1.ResumeLayout(false);
            this.fonttab.ResumeLayout(false);
            this.fonttab.PerformLayout();
            this.sizetab.ResumeLayout(false);
            this.sizetab.PerformLayout();
            this.colortab.ResumeLayout(false);
            this.colortab.PerformLayout();
            this.texttab.ResumeLayout(false);
            this.texttab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage fonttab;
        private System.Windows.Forms.RadioButton courier;
        private System.Windows.Forms.RadioButton arial;
        private System.Windows.Forms.RadioButton times_new_roman;
        private System.Windows.Forms.TabPage sizetab;
        private System.Windows.Forms.RadioButton sizetwentyfour;
        private System.Windows.Forms.RadioButton sizetwenty;
        private System.Windows.Forms.RadioButton sizesixteen;
        private System.Windows.Forms.TabPage colortab;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.TabPage texttab;
        private System.Windows.Forms.TextBox new_value;
        private System.Windows.Forms.TextBox old_value;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}