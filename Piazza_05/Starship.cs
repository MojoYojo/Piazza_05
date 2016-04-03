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
    public partial class Starship : Form
    {
        public Starship()
        {
            InitializeComponent();
        }

        private void Starship_Paint(object sender, PaintEventArgs e)
        {
            int pw = panel1.Width, ph = panel1.Height, indent = 20;
            Graphics g = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 20);
            SolidBrush brush = new SolidBrush(Color.RoyalBlue);
            Rectangle rect = new Rectangle(0, 0, Width - 15, Height - 40);
            g.DrawRectangle(pen, rect);
            g.FillRectangle(brush, rect.X + pen.Width-10, rect.Y + pen.Width-10, rect.Width - pen.Width, rect.Height - pen.Width);

            pen = new Pen(Color.Yellow, 3);
            brush = new SolidBrush(Color.White);
            rect = new Rectangle(pw / 2 + 110, 20, 160, 30);
            g.DrawRectangle(pen, rect);
            g.FillRectangle(brush, rect);

            string drawString = "Level: 1 Score: 200 Live: ***";
            Font drawFont = new Font("Arial", 8);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();
            g.DrawString(drawString, drawFont, drawBrush, rect.X + 10, rect.Y + 10, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();

            pen.Dispose();
            brush.Dispose();

            Point[] starshipPoints = new Point[] {
                new Point(pw / 2 + indent, ph / 2 - ph / 13),
                new Point(pw / 2 + indent + pw / 20, ph / 2 - ph / 24),
                new Point(pw / 2 + indent + pw / 20, ph / 2 + ph / 24),
                new Point(pw / 2 + indent, ph / 2 + ph / 13),
                new Point(pw / 2 + indent - pw / 20, ph / 2 + ph / 24),
                new Point(pw / 2 + indent - pw / 20, ph / 2 - ph / 24)
            };
            SolidBrush starshipBrush = new SolidBrush(Color.Yellow);
            g.FillPolygon(starshipBrush, starshipPoints);

            createStarshipArray(g, new Rectangle(pw/2 + indent, ph/2 + indent/2, 50, 50));

            createBullet(g, new Rectangle(pw / 2 + indent + indent/2, ph / 2 - indent*2 - indent/2, 25, 25));

            createAsteroid(g, new Rectangle(150,140, 40, 40));
            createAsteroid(g, new Rectangle(panel1.Width - 110, 130, 40, 40));
            createAsteroid(g, new Rectangle(200, panel1.Height/2 + 40, 40, 50));
            createAsteroid(g, new Rectangle(panel1.Width/2 + 150, panel1.Height / 2 + 100, 50, 45));
            createStar(g, new Rectangle(40, 70, 25, 25));
            createStar(g, new Rectangle(panel1.Width / 2 - 100, 50, 25, 25));
            createStar(g, new Rectangle(panel1.Width / 2 + 80, 90, 25, 25));
            createStar(g, new Rectangle(panel1.Width - 70, panel1.Height/2 - 40, 25, 25));
            createStar(g, new Rectangle(panel1.Width - 150, panel1.Height / 2 + 20, 25, 25));
            createStar(g, new Rectangle(50, panel1.Height - 100, 25, 25));
            createStar(g, new Rectangle(panel1.Width / 2 - 100, panel1.Height - 120, 25, 25));
            createStar(g, new Rectangle(panel1.Width - 75, panel1.Height - 70, 25, 25));
            g.Dispose();
        }

        private void createBullet(Graphics g, Rectangle rect)
        {
            int X = rect.X, Y = rect.Y, W = rect.Width, H = rect.Height;

            Point[] starshipArrayPoints = new Point[] {
                new Point(X, Y - H/2),
                new Point(X + W/7, Y - H/7),
                new Point(X + W/2, Y),
                new Point(X + W/7, Y + H/7),
                new Point(X, Y + H/2),
                new Point(X - W/7, Y + H/7),
                new Point(X - W/2, Y),
                new Point(X - W/7, Y - H/7)
            };
            SolidBrush starshipArrayBrush = new SolidBrush(Color.Green);
            g.FillPolygon(starshipArrayBrush, starshipArrayPoints);
        }

        private void createStarshipArray(Graphics g, Rectangle rect)
        {
            int X = rect.X, Y = rect.Y, W = rect.Width, H = rect.Height;

            Point[] starshipArrayPoints = new Point[] {
                new Point(X, Y - H/2),
                new Point(X + W/4, Y - H/6),
                new Point(X + W/8, Y - H/6),
                new Point(X + W/8, Y + H/8),
                new Point(X - W/8, Y + H/8),
                new Point(X - W/8, Y - H/6),
                new Point(X - W/4, Y - H/6),
            };
            SolidBrush starshipArrayBrush = new SolidBrush(Color.Green);
            g.FillPolygon(starshipArrayBrush, starshipArrayPoints);
        }

        private void createStar(Graphics g, Rectangle rect)
        {
            SolidBrush starBrush = new SolidBrush(Color.White);
            g.FillEllipse(starBrush, rect);
        }

        private void createAsteroid(Graphics g, Rectangle rect)
        {
            int X = rect.X, Y = rect.Y, W = rect.Width, H = rect.Height;

            Point[] asteroidPoints = new Point[] {
                new Point(X - W/2, Y - H/4),
                new Point(X - W/6 - 2, Y - H/4),
                new Point(X, Y - H/2),
                new Point(X + W/6 + 2, Y - H/4),
                new Point(X + W/2, Y - H/4),
                new Point(X + W/4 + 5, Y),
                new Point(X + W/2, Y + H/4),
                new Point(X + W/6 + 2, Y + H/4),
                new Point(X, Y + H/2),
                new Point(X - W/6 - 2, Y + H/4),
                new Point(X - W/2, Y + H/4),
                new Point(X - W/4 - 5, Y)
            };
            SolidBrush asteroidBrush = new SolidBrush(Color.Red);
            g.FillPolygon(asteroidBrush, asteroidPoints);
        }

        private void Starship_Load(object sender, EventArgs e)
        {
        }

        private void animate(object sender, EventArgs e)
        {

        }

    }
}
