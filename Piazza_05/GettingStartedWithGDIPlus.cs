using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piazza_05
{
    public partial class GettingStartedWithGDIPlus : Form
    {
        Rectangle rect;
        Color color = Color.Red;
        bool filled = false;
        public GettingStartedWithGDIPlus()
        {
            InitializeComponent();
            timer1.Start();
            rect = new Rectangle(xCoordTB.Value, yCoordTB.Value, widthTB.Value, heightTB.Value);
        }

        private void DrawRectangle()
        {
            System.Drawing.Graphics formGraphics;
            formGraphics = panel1.CreateGraphics();
            if (!filled)
            {
                System.Drawing.Pen myPen = new System.Drawing.Pen(color);
                formGraphics.DrawRectangle(myPen, rect);
                myPen.Dispose();
            }
            else
            {
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(color);
                formGraphics.FillRectangle(myBrush, rect);
                myBrush.Dispose();
            }
            formGraphics.Dispose();
        }

        private void DrawEllipse()
        {
            System.Drawing.Graphics formGraphics;
            formGraphics = panel1.CreateGraphics();
            if (!filled)
            {
                System.Drawing.Pen myPen = new System.Drawing.Pen(color);
                formGraphics.DrawEllipse(myPen, rect);
                myPen.Dispose();
            }
            else
            {
                System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(color);
                formGraphics.FillEllipse(myBrush, rect);
                myBrush.Dispose();
            }
            formGraphics.Dispose();
        }

        private void chooseColorForFigure(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
            panel1.Invalidate();
        }

        private void displace(object sender, EventArgs e)
        {
            TrackBar tb = sender as TrackBar;
            if (rect.X + rect.Width > 501)
                tb.Value = tb.Maximum - rect.Width;
            else if (rect.Y + rect.Height > 501)
                tb.Value = tb.Maximum - rect.Height;

            if (tb == widthTB)
                rect.Width = tb.Value;
            if (tb == heightTB)
                rect.Height = tb.Value;
            if (tb == xCoordTB)
                rect.X = tb.Value;
            if (tb == yCoordTB)
                rect.Y = tb.Value;
            panel1.Invalidate();
        }

        private void checkChanged(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void Fill_Figure(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                filled = true;
            else
                filled = false;
            panel1.Invalidate();
        }

        TextBox animationTxtBox = new TextBox();
        Button animationBtn = new Button();

        private void createAnimationTxtBox()
        {
            int locationY = panel1.Height / 2;
            animationTxtBox.Location = new Point(panel1.Width / 16, locationY - locationY / 4);
            animationTxtBox.Size = new Size(panel1.Width - panel1.Width / (4 * 2), 40);
            animationTxtBox.Font = new Font(animationTxtBox.Font.FontFamily, 24);
        }

        private void startTextAnimation(object sender, EventArgs e)
        {
            if (rRB.Checked)
                rRB.Checked = false;
            else if (eRB.Checked)
                eRB.Checked = false;
            panel1.Invalidate();
            createAnimationTxtBox();
            panel1.Controls.Add(animationTxtBox);

            if (!animationTxtBox.Controls.Contains(animationBtn))
            {
                animationBtn.Size = new Size(60, animationTxtBox.ClientSize.Height + 2);
                animationBtn.Location = new Point(animationTxtBox.ClientSize.Width - animationBtn.Width, -1);
                animationBtn.Cursor = Cursors.Default;
                animationBtn.Font = new Font(animationBtn.Font.FontFamily, 12);
                animationBtn.Text = "GO";

                animationBtn.Click += new EventHandler(startAnimation);
                animationBtn.ForeColor = Color.CornflowerBlue;
                animationTxtBox.Controls.Add(animationBtn);
                // Send EM_SETMARGINS to prevent text from disappearing underneath the button
                SendMessage(animationTxtBox.Handle, 0xd3, (IntPtr)2, (IntPtr)(animationBtn.Width << 16));
                base.OnLoad(e);
            }
        }

        private void startAnimation(object sender, EventArgs e) {
            System.Drawing.Graphics formGraphics = panel1.CreateGraphics();
            string drawString = animationTxtBox.Text;
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 24);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();
            int locationY = panel1.Height / 2;
            formGraphics.DrawString(drawString, drawFont, drawBrush, panel1.Width / 16, locationY + locationY / 4, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
            panel1.Controls.Remove(animationTxtBox);
        }

        //ANIMATION PROVIDER
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void startToCreateTheMasterpiece(object sender, EventArgs e)
        {
            if ((rRB.Checked || eRB.Checked) && panel1.Controls.Contains(animationTxtBox))
                panel1.Controls.Remove(animationTxtBox);
            if (rRB.Checked)
                DrawRectangle();
            else if (eRB.Checked)
                DrawEllipse();
        }
    }
}
