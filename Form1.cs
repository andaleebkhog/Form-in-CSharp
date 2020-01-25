using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace Form1
{
    

    public partial class Form1 : Form
    {
        //CompanyName Data
        string s_CompanyName;
        Font f_CompanyName;
        Brush b_CompanyName;
        Color c_CompanyName;
        PointF p_CompanyName;
        
        //Revenue Data
        string s_Revenue;
        Font f_Revenue;
        Brush b_Revenue;
        Color c_Revenue;
        PointF p_Revenue;
        
        // -------------------------TABLE--------------------------
        //Table Rectangle
        Color c_TableFrame;
        Pen p_TableFrame;
        Rectangle r_TableFrame;
        
        //Table Row Lines
        Point tl_LineStart;
        Point tl_LineEnd;
        Color tl_LineColor;
        Pen tl_LinePen;

        //Table Vertical Line
        Point tlv_LineStart;
        Point tlv_LineEnd;
        Color tlv_LineColor;
        Pen tlv_LinePen;

        //Table data Year
        string s_dataY;
        Font f_dataY;
        Brush b_dataY;
        Color c_dataY;
        PointF p_dataY;

        //Table data Revenue
        string s_dataR;
        Font f_dataR;
        Brush b_dataR;
        Color c_dataR;
        PointF p_dataR;

        //Actual data Years
        string[] s_year = new string[] {"1988","1989","1990","1991","1992","1993","1994","1995","1996","1997","1998"};
        Font f_year;
        Brush b_year;
        Color c_year;
        PointF p_year;

        //Actual data Revnues
        string[] s_rev = new string[] { "150", "170", "180", "175", "200", "250", "210", "240", "280", "140", "180" };
        Font f_rev;
        Brush b_rev;
        Color c_rev;
        PointF p_rev;

        //---------------------------CHART-------------------------
        //X-Axis Chart Line
        Point xcl_LineStart;
        Point xcl_LineEnd;
        Color xcl_LineColor;
        Pen xcl_LinePen;

        //X-Axis CharLine Indicators
        Point xclInd_LineStart;
        Point xclInd_LineEnd;
        Color xclInd_LineColor;
        Pen xclInd_LinePen;

        //Y-Axis Chart Line
        Point ycl_LineStart;
        Point ycl_LineEnd;
        Color ycl_LineColor;
        Pen ycl_LinePen;

        //Y-Axis CharLine Indicators
        Point yclInd_LineStart;
        Point yclInd_LineEnd;
        Color yclInd_LineColor;
        Pen yclInd_LinePen;

        //Chart Mini Data revenues
        string[] s_crev = new string[] { "100","110","120","130","140","150","160","170","180","190","200","210","220","230","240","250","260","270","280" };
        Font f_crev;
        Brush b_crev;
        Color c_crev;
        PointF p_crev;

        //Chart Mini Data Years
        string[] s_cyear = new string[] { "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998" };
        Font f_cyear;
        Brush b_cyear;
        Color c_cyear;
        PointF p_cyear;

        //Chart PointLines
        
        Color pt1_LineColor;
        Pen pt1_LinePen;
        

        //Years word in Chart
        string s_YearWord;
        Font f_YearWord;
        Brush b_YearWord;
        Color c_YearWord;
        PointF p_YearWord;

        //Revenue word in Chart
        string s_RevWord;
        Font f_RevWord;
        Brush b_RevWord;
        Color c_RevWord;
        PointF p_RevWord;

        //Filled Rectangle of BarChart
        Color c_GraphBar;
        Brush b_GraphBar;


        
        
        



        public void DisplayRevenueWord()
        {
            Graphics g = this.CreateGraphics();
            var x = (this.Width - g.MeasureString(s_RevWord, f_RevWord).Width) - 1180;
            p_RevWord = new PointF(x, 45);
            g.DrawString(s_RevWord, f_RevWord, b_RevWord, p_RevWord);
        }

        public void DisplayYearWord()
        {
            Graphics g = this.CreateGraphics();
            var x = (this.Width - g.MeasureString(s_YearWord, f_YearWord).Width) - 800 ;
            p_YearWord = new PointF(x, 570);
            g.DrawString(s_YearWord, f_YearWord, b_YearWord, p_YearWord);
        }
        public void DisplayPt1()
        {
            Graphics g = CreateGraphics();
            g.DrawLine(pt1_LinePen,113,485,150,426);
            Graphics h = CreateGraphics();
            h.DrawLine(pt1_LinePen, 150, 426,190, 396);
            Graphics i = CreateGraphics();
            i.DrawLine(pt1_LinePen, 190, 396,230,411);
            Graphics j = CreateGraphics();
            j.DrawLine(pt1_LinePen, 230, 411,270,336);
            Graphics k = CreateGraphics();
            k.DrawLine(pt1_LinePen, 270, 336,310,186);
            Graphics l = CreateGraphics();
            l.DrawLine(pt1_LinePen, 310, 186,350,306);
            Graphics m = CreateGraphics();
            m.DrawLine(pt1_LinePen, 350, 306,390,216);
            Graphics n = CreateGraphics();
            n.DrawLine(pt1_LinePen, 390, 216, 430, 96);
            Graphics p = CreateGraphics();
            p.DrawLine(pt1_LinePen, 430, 96, 470, 516);

        }

        public void DisplayBarCharts()
        {
            var x = 103;
            var barwidth = 18;

            Graphics g = this.CreateGraphics();
            g.FillRectangle(b_GraphBar, x, 485,barwidth, 135);
            Graphics h = this.CreateGraphics();
            h.FillRectangle(b_GraphBar, x+40, 423, barwidth, 195);
            Graphics i = this.CreateGraphics();
            i.FillRectangle(b_GraphBar, x + 40 * 2,395, barwidth,225);
            Graphics j = this.CreateGraphics();
            j.FillRectangle(b_GraphBar, x + 40 * 3,410, barwidth,210);
            Graphics k = this.CreateGraphics();
            k.FillRectangle(b_GraphBar, x + 40 * 4,335, barwidth,285);
            Graphics l = this.CreateGraphics();
            l.FillRectangle(b_GraphBar, x + 40 * 5,185, barwidth,435);
            Graphics m = this.CreateGraphics();
            m.FillRectangle(b_GraphBar, x + 40 * 6, 300, barwidth, 320);
            Graphics n = this.CreateGraphics();
            n.FillRectangle(b_GraphBar, x + 40 * 7, 215, barwidth, 405);
            Graphics p = this.CreateGraphics();
            p.FillRectangle(b_GraphBar, x + 40 * 8, 95, barwidth, 525);
            Graphics q = this.CreateGraphics();
            q.FillRectangle(b_GraphBar, x + 40 * 9, 515, barwidth, 105);



        }

        public void DisplayChartYears()
        {
            Graphics g = this.CreateGraphics();
            var y = 640;
            var x = 60;
            for (int i = 0; i < 11; i++)

            {
                x += 40;
               // var x = ((this.Width - g.MeasureString(s_cyear[i], f_cyear).Width) -1270);
                p_cyear = new PointF(x, y);
                g.DrawString(s_cyear[i], f_cyear, b_year, p_cyear);
                 
            }
        }

        public void DisplayChartRev()
        {
            Graphics g = this.CreateGraphics();
            var y = 118;
            for (int i = 17; i > 0; i--)
            {
                var x = (this.Width - g.MeasureString(s_crev[i], f_crev).Width) - 1325;
                p_crev = new PointF(x, y);
                g.DrawString(s_crev[i], f_crev, b_crev, p_crev);
                y += 30;
            }

            
        }

        public void DisplayYCIndLines()
        {
            Graphics g = this.CreateGraphics();
            var lineStart = this.Width - 1300;
            var lineEnd = this.Width - 1316;
            var lineHeight = 45;
            for(int i = 0; i < 18; i++)
            {
                yclInd_LineStart = new Point(lineStart, lineHeight+50);
                yclInd_LineEnd = new Point(lineEnd, lineHeight+50);
                g.DrawLine(yclInd_LinePen, yclInd_LineStart, yclInd_LineEnd);
                lineHeight += 30;
            }
            
        }

        public void DisplayXCIndLines()
        {
            Graphics g = this.CreateGraphics();
            var lineStart = this.Width - 1270;
            var lineEnd = this.Width - 1270;
            var lineHeight = 615;
            for(int i=0; i < 11; i++)
            {
                xclInd_LineStart = new Point(lineStart, lineHeight);
                xclInd_LineEnd = new Point(lineEnd, lineHeight+16);
                g.DrawLine(xclInd_LinePen, xclInd_LineStart, xclInd_LineEnd);
                lineStart += 40;
                lineEnd += 40;
            }
            
        }

        public void DisplayYCLine()
        {
            Graphics g = this.CreateGraphics();
            var lineStart = this.Width - 1300;
            var lineEnd = this.Width - 1300;
            var lineHeight = 620;
            ycl_LineStart = new Point(lineStart, lineHeight);
            ycl_LineEnd = new Point(lineEnd, 40);
            g.DrawLine(ycl_LinePen, ycl_LineStart, ycl_LineEnd);
        }

        public void DisplayXCLine()
        {
            Graphics g = this.CreateGraphics();
            var lineStart = this.Width - 1300;
            var lineEnd = this.Width - 800;
            var lineHeight = 620;
            xcl_LineStart = new Point(lineStart, lineHeight);
            xcl_LineEnd = new Point(lineEnd, lineHeight);
            g.DrawLine(xcl_LinePen, xcl_LineStart, xcl_LineEnd);
            
            
        }

        public void DisplayRevenueValues()
        {
            Graphics g = this.CreateGraphics();
            var y = 208;
            for (int i = 0; i < 11; i++)
            {
                var x = (this.Width - g.MeasureString(s_rev[i], f_rev).Width) - 180;
                p_rev = new PointF(x, y);
                g.DrawString(s_rev[i], f_rev, b_rev, p_rev);
                y += 40;
            }
        }

        public void DisplayYears()
        {
            Graphics g = this.CreateGraphics();
            var y = 208;
            for (int i=0; i < 11; i++)
            {
                var x = (this.Width - g.MeasureString(s_year[i], f_year).Width) - 375;
                p_year = new PointF(x, y);
                g.DrawString(s_year[i], f_year, b_year, p_year);
                y += 40;
            }
        }

        public void DisplayDataRevenue()
        {
            Graphics g = this.CreateGraphics();
            var x = (this.Width - g.MeasureString(s_dataR, f_dataR).Width) - 160;
            p_dataR = new PointF(x, 163);
            g.DrawString(s_dataR, f_dataR, b_dataR, p_dataR);
        }
        public void DisplayDataYear()
        {
            Graphics g = this.CreateGraphics();
            var x = (this.Width - g.MeasureString(s_dataY, f_dataY).Width)-375;
            p_dataY = new PointF(x, 163);
            g.DrawString(s_dataY, f_dataY, b_dataY, p_dataY);
        }
        public void DisplayTableVLine()
        {
            Graphics g = this.CreateGraphics();
            var lineStart = this.Width - 295;
            var lineEnd = this.Width-295;
            tlv_LineStart = new Point(lineStart,152);
            tlv_LineEnd = new Point(lineEnd, 652);
            g.DrawLine(tlv_LinePen, tlv_LineStart, tlv_LineEnd);
        }

        public void DisplayTableLine()
        {
            Graphics g = this.CreateGraphics();
            var lineStart = this.Width - 500;
            var lineEnd = this.Width - 100;
            var lineHeight = 200;
            
            for(int i=0; i<11; i++)
            {
                tl_LineStart = new Point(lineStart, lineHeight);
                tl_LineEnd = new Point(lineEnd, lineHeight);
                g.DrawLine(tl_LinePen, tl_LineStart, tl_LineEnd);
                lineHeight += 40;
            }
            
        }
        public void DisplayTable()
        {
            Graphics g = this.CreateGraphics();
            var x1 = (this.Width - 500);
            g.DrawRectangle(p_TableFrame, r_TableFrame);
            r_TableFrame = new Rectangle(x1, 150, 400, 500);

        }

        public void DisplayRevenue()
        {
            Graphics g = this.CreateGraphics();
            var x = (this.Width - g.MeasureString(s_Revenue, f_Revenue).Width) / 2;
            p_Revenue = new PointF(x, 80);
            g.DrawString(s_Revenue, f_Revenue, b_Revenue, p_Revenue);
        }

        public void DisplayCompanyName()
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            var x = (this.Width - g.MeasureString(s_CompanyName,f_CompanyName).Width)/2;
            p_CompanyName = new PointF(x, 45);
            g.DrawString(s_CompanyName, f_CompanyName, b_CompanyName, p_CompanyName);
            
            
        }

        //Keys Function



        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            DisplayPt1();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            DisplayCompanyName();
            DisplayRevenue();
            DisplayTable();
            DisplayTableLine();
            DisplayTableVLine();
            DisplayDataYear();
            DisplayDataRevenue();
            DisplayYears();
            DisplayRevenueValues();
            DisplayXCLine();
            DisplayYCLine();
            DisplayXCIndLines();
            DisplayYCIndLines();
            DisplayChartRev();
            DisplayChartYears();
            DisplayBarCharts();
            DisplayPt1();
            DisplayYearWord();
            DisplayRevenueWord();
            
        }


        public Form1()
        {
            InitializeComponent();
            //CompanyName
            s_CompanyName = "ABC Company";
            f_CompanyName = new Font("Arial", 20 ,FontStyle.Underline);
            c_CompanyName = Color.Black;
            b_CompanyName = new SolidBrush(c_CompanyName);
           
            //RevenueStringData
            s_Revenue = "Anuual Revenue";
            f_Revenue = new Font("Arial", 15,FontStyle.Underline);
            c_Revenue = Color.Black;
            b_Revenue = new SolidBrush(c_Revenue);

            //Table Drawing
            c_TableFrame = Color.Black;
            p_TableFrame = new Pen(c_TableFrame, 3);

            //Table Lines Drawing
            tl_LineColor = Color.Black;
            tl_LinePen = new Pen(tl_LineColor , 3);

            //Table Line Drawing -- Vertical Line
            tlv_LineColor = Color.Black;
            tlv_LinePen = new Pen(tlv_LineColor, 3);

            //Table data Drawing year Heading
            s_dataY = "Year";
            f_dataY = new Font("Arial", 15,FontStyle.Bold);
            c_dataY = Color.Black;
            b_dataY = new SolidBrush(c_dataY);

            //Table data Drawing Revenue Heading
            s_dataR = "Revenue";
            f_dataR = new Font("Arial", 15, FontStyle.Bold);
            c_dataR = Color.Black;
            b_dataR = new SolidBrush(c_dataR);

            //Table data Drawing years Itself
            f_year = new Font("Arial", 15);
            c_year = Color.Black;
            b_year = new SolidBrush(c_dataR);

            //Table data Drawing revenue Itself
            f_rev = new Font("Arial", 15);
            c_rev = Color.Black;
            b_rev = new SolidBrush(c_dataR);
            
            //--------------------------------CHART----------------------------------

            //x-Axis Chart line Drawing
            xcl_LineColor = Color.Black;
            xcl_LinePen = new Pen(xcl_LineColor, 7);
            xcl_LinePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            //x-Axis Indicators lines
            xclInd_LineColor = Color.Black;
            xclInd_LinePen = new Pen(xclInd_LineColor, 3);

            //y-Axis Chart line Drawing
            ycl_LineColor = Color.Black;
            ycl_LinePen = new Pen(ycl_LineColor, 7);
            ycl_LinePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            //y-Axis Indicators lines
            yclInd_LineColor = Color.Black;
            yclInd_LinePen = new Pen(yclInd_LineColor, 3);

            //DataChart mini Revenues
            f_crev = new Font("Arial", 8);
            c_crev = Color.Black;
            b_crev = new SolidBrush(c_crev);

            //DataChart mini years
            f_cyear = new Font("Arial", 8);
            c_cyear = Color.Black;
            b_cyear = new SolidBrush(c_cyear);

            //Chart LINES
            pt1_LineColor = Color.Blue;
            pt1_LinePen = new Pen(pt1_LineColor, 3);

            //Year Word in Chart
            s_YearWord = "Years";
            f_YearWord = new Font("Arial", 14);
            c_YearWord = Color.Red;
            b_YearWord = new SolidBrush(c_YearWord);

            //Revenue Word in Chart
            s_RevWord = "Revenues";
            f_RevWord = new Font("Arial", 14);
            c_RevWord = Color.Green;
            b_RevWord = new SolidBrush(c_YearWord);

            //Rectangles of BarCharts
            c_GraphBar = Color.Red;
            b_GraphBar = new HatchBrush(HatchStyle.BackwardDiagonal,c_GraphBar);

            //Context Menu
            //this.ContextMenuStrip = this.Line;

            //Context Menu 
            //this.ContextMenuStrip = this.Rectangle;
            
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
                

            if ((int)e.KeyChar == 18)
            {
                pt1_LineColor = Color.Red;
            }
            else if ((int)e.KeyChar == 2)
            {
                pt1_LineColor = Color.Blue;
            }
            else if ((int)e.KeyChar == 7)
            {
                pt1_LineColor = Color.Green;
            }
            pt1_LinePen.Color = pt1_LineColor;

            Invalidate();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

 // ----------------------------------------------

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            c_GraphBar = Color.Red;
            b_GraphBar = new HatchBrush(HatchStyle.BackwardDiagonal, c_GraphBar);
            Invalidate();
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            c_GraphBar = Color.Green;
            b_GraphBar = new HatchBrush(HatchStyle.BackwardDiagonal, c_GraphBar);
            Invalidate();
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            c_GraphBar = Color.Blue;
            b_GraphBar = new HatchBrush(HatchStyle.BackwardDiagonal, c_GraphBar);
            Invalidate();
        }

        private void rightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_GraphBar = new HatchBrush(HatchStyle.BackwardDiagonal, c_GraphBar);
            Invalidate();
        }

        private void leftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_GraphBar = new HatchBrush(HatchStyle.ForwardDiagonal, c_GraphBar);
            Invalidate();
        }

        private void crossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            b_GraphBar = new HatchBrush(HatchStyle.Cross, c_GraphBar);
            Invalidate();
        }
        //-----------------------------------------------------
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt1_LineColor = Color.Red;
            pt1_LinePen.Color = pt1_LineColor;
            Invalidate();

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt1_LineColor = Color.Green;
            pt1_LinePen.Color = pt1_LineColor;
            Invalidate();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt1_LineColor = Color.Blue;
            pt1_LinePen.Color = pt1_LineColor;
            Invalidate();
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt1_LinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            Invalidate();
        }

        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt1_LinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Invalidate();
        }

        private void dottedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pt1_LinePen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.X > 50 && e.X < 550)
                {
                    if (e.Y > 40 && e.Y < 620)
                    {
                        ContextMenuStrip = Rectangle;
                    }
                }
                else
                {
                    ContextMenuStrip = Line;
                }

            };

            if(e.Button == MouseButtons.Left)
            {
                if(e.X >50 && e.X < 550)
                {
                    if(e.Y >600 && e.Y < 620)
                    {
                        MessageBox.Show("Revenue is 100", "Rev Value");
                    }
                    else if (e.Y > 570 && e.Y < 600)
                    {
                        MessageBox.Show("Revenue is 110", "Rev Value");
                    }
                    else if (e.Y > 540 && e.Y < 570)
                    {
                        MessageBox.Show("Revenue is 120", "Rev Value");
                    }
                    else if (e.Y > 510 && e.Y < 540)
                    {
                        MessageBox.Show("Revenue is 130", "Rev Value");
                    }
                    else if (e.Y > 480 && e.Y < 510)
                    {
                        MessageBox.Show("Revenue is 140", "Rev Value");
                    }
                    else if (e.Y > 450 && e.Y < 480)
                    {
                        MessageBox.Show("Revenue is 150", "Rev Value");
                    }
                    else if (e.Y > 420 && e.Y < 450)
                    {
                        MessageBox.Show("Revenue is 160", "Rev Value");
                    }
                    else if (e.Y > 390 && e.Y < 420)
                    {
                        MessageBox.Show("Revenue is 170", "Rev Value");
                    }
                    else if (e.Y > 360 && e.Y <390)
                    {
                        MessageBox.Show("Revenue is 180", "Rev Value");
                    }
                    else if (e.Y > 330 && e.Y < 360)
                    {
                        MessageBox.Show("Revenue is 190", "Rev Value");
                    }
                    else if (e.Y > 300 && e.Y < 330)
                    {
                        MessageBox.Show("Revenue is 200", "Rev Value");
                    }
                    else if (e.Y > 270 && e.Y < 300)
                    {
                        MessageBox.Show("Revenue is 210", "Rev Value");
                    }
                    else if (e.Y > 240 && e.Y < 270)
                    {
                        MessageBox.Show("Revenue is 220", "Rev Value");
                    }
                    else if (e.Y > 210 && e.Y < 240)
                    {
                        MessageBox.Show("Revenue is 230", "Rev Value");
                    }
                    else if (e.Y > 180 && e.Y < 210)
                    {
                        MessageBox.Show("Revenue is 240", "Rev Value");
                    }
                    else if (e.Y > 150 && e.Y < 180)
                    {
                        MessageBox.Show("Revenue is 250", "Rev Value");
                    }
                    else if (e.Y > 120 && e.Y < 150)
                    {
                        MessageBox.Show("Revenue is 260", "Rev Value");
                    }
                    else if (e.Y > 90 && e.Y < 120)
                    {
                        MessageBox.Show("Revenue is 270", "Rev Value");
                    }
                    else if (e.Y > 60 && e.Y < 90)
                    {
                        MessageBox.Show("Revenue is 280", "Rev Value");
                    }

                }
            }

        }

        //private void toolStripLabel1_Click(object sender, EventArgs e)
        //{

        //}

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pt1_LineColor = Color.Red;
            pt1_LinePen.Color = pt1_LineColor;
            Invalidate();
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pt1_LineColor = Color.Green;
            pt1_LinePen.Color = pt1_LineColor;
            Invalidate();
        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pt1_LineColor = Color.Blue;
            pt1_LinePen.Color = pt1_LineColor;
            Invalidate();
        }

        private void redToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            c_GraphBar = Color.Red;
            b_GraphBar = new HatchBrush(HatchStyle.BackwardDiagonal, c_GraphBar);
            Invalidate();
        }

        private void greenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            c_GraphBar = Color.Green;
            b_GraphBar = new HatchBrush(HatchStyle.BackwardDiagonal, c_GraphBar);
            Invalidate();
        }

        private void blueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            c_GraphBar = Color.Blue;
            b_GraphBar = new HatchBrush(HatchStyle.BackwardDiagonal, c_GraphBar);
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void companyNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyName dialogBox = new CompanyName();
            DialogResult dResult;
           
            
            dialogBox.DlgTxtOld = s_CompanyName;
            dialogBox.DlgTxt = s_CompanyName;
            dialogBox.ColorDlg = c_CompanyName;
            //dialogBox.FontDialog = f_CompanyName;
            

            dResult = dialogBox.ShowDialog();
            

            if(dResult == DialogResult.OK)
            {
                //1
                s_CompanyName = dialogBox.DlgTxtOld;
                s_CompanyName = dialogBox.DlgTxt;
                //2
                c_CompanyName = dialogBox.ColorDlg;
                Brush myColor = new SolidBrush(c_CompanyName);
                b_CompanyName = myColor;
                //3
                f_CompanyName = new Font(dialogBox.FontDialog,20,FontStyle.Underline);

                //4
                f_CompanyName = new Font(dialogBox.FontDialog, dialogBox.SizeDialog);
                
                // bn7tag forsha gdeda 3shan neghyar l color bta3na
                Invalidate();
            }

            //--------------------- PROJECT ENDED YAAYYYYYYY
            
        }
    }
}
