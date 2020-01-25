namespace Form1
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
            this.Line = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solidToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dottedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rectangle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.colorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crossToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolBar = new System.Windows.Forms.ToolStrip();
            this.ToolBarStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.lineColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Line.SuspendLayout();
            this.Rectangle.SuspendLayout();
            this.ToolBar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Line
            // 
            this.Line.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.styleToolStripMenuItem});
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(104, 48);
            this.Line.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem});
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem.Text = "Color";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // styleToolStripMenuItem
            // 
            this.styleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solidToolStripMenuItem,
            this.dashToolStripMenuItem,
            this.dottedToolStripMenuItem});
            this.styleToolStripMenuItem.Name = "styleToolStripMenuItem";
            this.styleToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.styleToolStripMenuItem.Text = "Style";
            // 
            // solidToolStripMenuItem
            // 
            this.solidToolStripMenuItem.Name = "solidToolStripMenuItem";
            this.solidToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.solidToolStripMenuItem.Text = "Solid";
            this.solidToolStripMenuItem.Click += new System.EventHandler(this.solidToolStripMenuItem_Click);
            // 
            // dashToolStripMenuItem
            // 
            this.dashToolStripMenuItem.Name = "dashToolStripMenuItem";
            this.dashToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.dashToolStripMenuItem.Text = "Dash";
            this.dashToolStripMenuItem.Click += new System.EventHandler(this.dashToolStripMenuItem_Click);
            // 
            // dottedToolStripMenuItem
            // 
            this.dottedToolStripMenuItem.Name = "dottedToolStripMenuItem";
            this.dottedToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.dottedToolStripMenuItem.Text = "Dotted";
            this.dottedToolStripMenuItem.Click += new System.EventHandler(this.dottedToolStripMenuItem_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem1,
            this.styleToolStripMenuItem1});
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(104, 48);
            // 
            // colorToolStripMenuItem1
            // 
            this.colorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem1,
            this.greenToolStripMenuItem1,
            this.blueToolStripMenuItem1});
            this.colorToolStripMenuItem1.Name = "colorToolStripMenuItem1";
            this.colorToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.colorToolStripMenuItem1.Text = "Color";
            // 
            // redToolStripMenuItem1
            // 
            this.redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            this.redToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.redToolStripMenuItem1.Text = "Red";
            this.redToolStripMenuItem1.Click += new System.EventHandler(this.redToolStripMenuItem1_Click);
            // 
            // greenToolStripMenuItem1
            // 
            this.greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
            this.greenToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem1.Text = "Green";
            this.greenToolStripMenuItem1.Click += new System.EventHandler(this.greenToolStripMenuItem1_Click);
            // 
            // blueToolStripMenuItem1
            // 
            this.blueToolStripMenuItem1.Name = "blueToolStripMenuItem1";
            this.blueToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem1.Text = "Blue";
            this.blueToolStripMenuItem1.Click += new System.EventHandler(this.blueToolStripMenuItem1_Click);
            // 
            // styleToolStripMenuItem1
            // 
            this.styleToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rightToolStripMenuItem,
            this.leftToolStripMenuItem,
            this.crossToolStripMenuItem});
            this.styleToolStripMenuItem1.Name = "styleToolStripMenuItem1";
            this.styleToolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.styleToolStripMenuItem1.Text = "Style";
            // 
            // rightToolStripMenuItem
            // 
            this.rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            this.rightToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.rightToolStripMenuItem.Text = "Right";
            this.rightToolStripMenuItem.Click += new System.EventHandler(this.rightToolStripMenuItem_Click);
            // 
            // leftToolStripMenuItem
            // 
            this.leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            this.leftToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.leftToolStripMenuItem.Text = "Left";
            this.leftToolStripMenuItem.Click += new System.EventHandler(this.leftToolStripMenuItem_Click);
            // 
            // crossToolStripMenuItem
            // 
            this.crossToolStripMenuItem.Name = "crossToolStripMenuItem";
            this.crossToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.crossToolStripMenuItem.Text = "Cross";
            this.crossToolStripMenuItem.Click += new System.EventHandler(this.crossToolStripMenuItem_Click);
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolBarStripDropDownButton1});
            this.ToolBar.Location = new System.Drawing.Point(0, 24);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(800, 25);
            this.ToolBar.TabIndex = 2;
            this.ToolBar.Text = "toolStrip1";
            // 
            // ToolBarStripDropDownButton1
            // 
            this.ToolBarStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolBarStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineColorToolStripMenuItem,
            this.rectangleColorToolStripMenuItem});
            this.ToolBarStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("ToolBarStripDropDownButton1.Image")));
            this.ToolBarStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolBarStripDropDownButton1.Name = "ToolBarStripDropDownButton1";
            this.ToolBarStripDropDownButton1.Size = new System.Drawing.Size(91, 22);
            this.ToolBarStripDropDownButton1.Text = "Chart ToolBar";
            // 
            // lineColorToolStripMenuItem
            // 
            this.lineColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem2,
            this.greenToolStripMenuItem2,
            this.blueToolStripMenuItem2});
            this.lineColorToolStripMenuItem.Name = "lineColorToolStripMenuItem";
            this.lineColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lineColorToolStripMenuItem.Text = "LineColor";
            // 
            // redToolStripMenuItem2
            // 
            this.redToolStripMenuItem2.Checked = true;
            this.redToolStripMenuItem2.CheckOnClick = true;
            this.redToolStripMenuItem2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.redToolStripMenuItem2.Name = "redToolStripMenuItem2";
            this.redToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem2.Text = "Red";
            this.redToolStripMenuItem2.Click += new System.EventHandler(this.redToolStripMenuItem2_Click);
            // 
            // greenToolStripMenuItem2
            // 
            this.greenToolStripMenuItem2.CheckOnClick = true;
            this.greenToolStripMenuItem2.Name = "greenToolStripMenuItem2";
            this.greenToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem2.Text = "Green";
            this.greenToolStripMenuItem2.Click += new System.EventHandler(this.greenToolStripMenuItem2_Click);
            // 
            // blueToolStripMenuItem2
            // 
            this.blueToolStripMenuItem2.CheckOnClick = true;
            this.blueToolStripMenuItem2.Name = "blueToolStripMenuItem2";
            this.blueToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem2.Text = "Blue";
            this.blueToolStripMenuItem2.Click += new System.EventHandler(this.blueToolStripMenuItem2_Click);
            // 
            // rectangleColorToolStripMenuItem
            // 
            this.rectangleColorToolStripMenuItem.CheckOnClick = true;
            this.rectangleColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem3,
            this.greenToolStripMenuItem3,
            this.blueToolStripMenuItem3});
            this.rectangleColorToolStripMenuItem.Name = "rectangleColorToolStripMenuItem";
            this.rectangleColorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rectangleColorToolStripMenuItem.Text = "RectangleColor";
            // 
            // redToolStripMenuItem3
            // 
            this.redToolStripMenuItem3.Checked = true;
            this.redToolStripMenuItem3.CheckOnClick = true;
            this.redToolStripMenuItem3.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.redToolStripMenuItem3.Name = "redToolStripMenuItem3";
            this.redToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem3.Text = "Red";
            this.redToolStripMenuItem3.Click += new System.EventHandler(this.redToolStripMenuItem3_Click);
            // 
            // greenToolStripMenuItem3
            // 
            this.greenToolStripMenuItem3.CheckOnClick = true;
            this.greenToolStripMenuItem3.Name = "greenToolStripMenuItem3";
            this.greenToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem3.Text = "Green";
            this.greenToolStripMenuItem3.Click += new System.EventHandler(this.greenToolStripMenuItem3_Click);
            // 
            // blueToolStripMenuItem3
            // 
            this.blueToolStripMenuItem3.CheckOnClick = true;
            this.blueToolStripMenuItem3.Name = "blueToolStripMenuItem3";
            this.blueToolStripMenuItem3.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem3.Text = "Blue";
            this.blueToolStripMenuItem3.Click += new System.EventHandler(this.blueToolStripMenuItem3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyNameToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Format";
            // 
            // companyNameToolStripMenuItem
            // 
            this.companyNameToolStripMenuItem.Name = "companyNameToolStripMenuItem";
            this.companyNameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.companyNameToolStripMenuItem.Text = "Company Name";
            this.companyNameToolStripMenuItem.Click += new System.EventHandler(this.companyNameToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Line.ResumeLayout(false);
            this.Rectangle.ResumeLayout(false);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip Line;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solidToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dottedToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip Rectangle;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem styleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crossToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolBar;
        private System.Windows.Forms.ToolStripDropDownButton ToolBarStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem lineColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem rectangleColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyNameToolStripMenuItem;
    }
}

