using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RudnevDrag
{
    public partial class Form1 : Form
    {
        int rectX, rectY, circX, circY, sqX, sqY;
        Image a1, a2, a3, a4, a5, a6, b1, b2, b3, b4, b5, b6, c1, c2, c3, c4, c5, c6, d1, d2, d3, 
        d4, d5, d6, e1, e2, e3, e4, e5, e6, f1, f2, f3, f4, f5, f6;
        int lx = 0, ly = 0;
        int cx = 0, cy = 0;
        int LastClicked = 0;
        int X, Y, dX, dY;
        int a1X, a1Y, a2X, a2Y, a3X, a3Y, a4X, a4Y, a5X, a5Y, a6X, a6Y, b1X, b1Y, b2X, b2Y, b3X, b3Y, b4X, b4Y, b5X, b5Y, b6X, b6Y,
        c1X, c1Y, c2X, c2Y, c3X, c3Y, c4X, c4Y, c5X, c5Y, c6X, c6Y, d1X, d1Y, d2X, d2Y, d3X, d3Y, d4X, d4Y, d5X, d5Y, d6X, d6Y,
        e1X, e1Y, e2X, e2Y, e3X, e3Y, e4X, e4Y, e5X, e5Y, e6X, e6Y, f1X, f1Y, f2X, f2Y, f3X, f3Y, f4X, f4Y, f5X, f5Y, f6X, f6Y;
        bool boola1, boola2, boola3 = false;
        
        public Form1()
        {
            InitializeComponent();
            a1 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_001.jpg");
            pictureBox1.Image = a1;
            a2 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_002.jpg");
            pictureBox2.Image = a2;
            a3 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_003.jpg");
            pictureBox3.Image = a3;
            a4 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_004.jpg");
            pictureBox4.Image = a4;
            a5 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_005.jpg");
            pictureBox5.Image = a5;
            a6 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_006.jpg");
            pictureBox6.Image = a6;
            b1 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_007.jpg");
            pictureBox7.Image = b1;
            b2 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_008.jpg");
            pictureBox8.Image = b2;
            b3 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_009.jpg");
            pictureBox9.Image = b3;
            b4 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_010.jpg");
            pictureBox10.Image = b4;
            b5 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_011.jpg");
            pictureBox11.Image = b5;
            b6 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_012.jpg");
            pictureBox12.Image = b6;
            c1 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_013.jpg");
            pictureBox13.Image = c1;
            c2 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_014.jpg");
            pictureBox14.Image = c2;
            c3 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_015.jpg");
            pictureBox15.Image = c3;
            c4 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_016.jpg");
            pictureBox16.Image = c4;
            c5 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_017.jpg");
            pictureBox17.Image = c5;
            c6 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_018.jpg");
            pictureBox18.Image = c6;
            d1 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_019.jpg");
            pictureBox19.Image = d1;
            d2 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_020.jpg");
            pictureBox20.Image = d2;
            d3 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_021.jpg");
            pictureBox21.Image = d3;
            d4 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_022.jpg");
            pictureBox22.Image = d4;
            d5 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_023.jpg");
            pictureBox23.Image = d5;
            d6 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_024.jpg");
            pictureBox24.Image = d6;
            e1 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_025.jpg");
            pictureBox25.Image = e1;
            e2 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_026.jpg");
            pictureBox26.Image = e2;
            e3 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_027.jpg");
            pictureBox27.Image = e3;
            e4 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_028.jpg");
            pictureBox28.Image = e4;
            e5 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_029.jpg");
            pictureBox29.Image = e5;
            e6 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_030.jpg");
            pictureBox30.Image = e6;
            f1 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_031.jpg");
            pictureBox31.Image = f1;
            f2 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_032.jpg");
            pictureBox32.Image = f2;
            f3 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_033.jpg");
            pictureBox33.Image = f3;
            f4 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_034.jpg");
            pictureBox34.Image = f4;
            f5 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_035.jpg");
            pictureBox35.Image = f5;
            f6 = Image.FromFile("C:/Users/opilane/source/repos/RudnevDrag/Resources/image_part_036.jpg");
            pictureBox36.Image = f6;
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            boola1 = true;
            boola2 = false;
            boola3 = false;
            lx = e.X;
            ly = e.Y;
           // LastClicked = 0;
        }
        private void PictureBox13_Click(object sender, EventArgs e)
        {
        }
        private void Panel1_Click(object sender, EventArgs e)
        {

        }
        private void Form1_LocationChanged(object sender, EventArgs e)
        {

        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb1 mdwn";
            LastClicked = 1;
            lx = e.X;
            ly = e.Y;
            a1X = e.X - pictureBox1.Location.X;
            a1Y = e.Y - pictureBox1.Location.Y;
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb2 mdwn";
            LastClicked = 2;
            lx = e.X;
            ly = e.Y;
            a2X = e.X - pictureBox2.Location.X;
            a2Y = e.Y - pictureBox2.Location.Y;
        }
        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb3 mdwn";
            LastClicked = 3;
            lx = e.X;
            ly = e.Y;
            a3X = e.X - pictureBox3.Location.X;
            a3Y = e.Y - pictureBox3.Location.Y;
        }
        private void PictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb4 mdwn";
            LastClicked = 4;
            lx = e.X;
            ly = e.Y;
            a4X = e.X - pictureBox4.Location.X;
            a4Y = e.Y - pictureBox4.Location.Y;
        }
        private void PictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb5 mdwn";
            LastClicked = 5;
            lx = e.X;
            ly = e.Y;
            a5X = e.X - pictureBox5.Location.X;
            a5Y = e.Y - pictureBox5.Location.Y;
        }
        private void PictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb6 mdwn";
            LastClicked = 6;
            lx = e.X;
            ly = e.Y;
            a6X = e.X - pictureBox6.Location.X;
            a6Y = e.Y - pictureBox6.Location.Y;

        }

        private void PictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb78 mdwn";
            LastClicked = 7;
            lx = e.X;
            ly = e.Y;
            b1X = e.X - pictureBox7.Location.X;
            b1Y = e.Y - pictureBox7.Location.Y;
        }
        private void PictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb8 mdwn";
            LastClicked = 8;
            lx = e.X;
            ly = e.Y;
            b2X = e.X - pictureBox8.Location.X;
            b2Y = e.Y - pictureBox8.Location.Y;
        }
        private void PictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb9 mdwn";
            LastClicked = 9;
            lx = e.X;
            ly = e.Y;
            b3X = e.X - pictureBox9.Location.X;
            b3Y = e.Y - pictureBox9.Location.Y;
        }
        private void PictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb10 mdwn";
            LastClicked = 10;
            lx = e.X;
            ly = e.Y;
            b4X = e.X - pictureBox10.Location.X;
            b4Y = e.Y - pictureBox10.Location.Y;
        }
        private void PictureBox11_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb11 mdwn";
            LastClicked = 11;
            lx = e.X;
            ly = e.Y;
            b5X = e.X - pictureBox11.Location.X;
            b5Y = e.Y - pictureBox11.Location.Y;

        }
        private void PictureBox12_MouseDown(object sender, MouseEventArgs e)
        {
            test.Text = "pb12 mdwn";
            LastClicked = 12;
            lx = e.X;
            ly = e.Y;
            b6X = e.X - pictureBox12.Location.X;
            b6Y = e.Y - pictureBox12.Location.Y;
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
           if (LastClicked==1)
            {
                e.Graphics.DrawImage(pictureBox1.Image, cx, cy);
            }
           if(LastClicked==2)
            {
                e.Graphics.DrawImage(pictureBox2.Image, cx, cy);
            }
            if (LastClicked == 3)
            {
                e.Graphics.DrawImage(pictureBox3.Image, cx, cy);
            }
            if (LastClicked == 4)
            {
                e.Graphics.DrawImage(pictureBox4.Image, cx, cy);
            }
            if (LastClicked == 5)
            {
                e.Graphics.DrawImage(pictureBox5.Image, cx, cy);
            }
            if (LastClicked == 6)
            {
                e.Graphics.DrawImage(pictureBox6.Image, cx, cy);
            }
            if (LastClicked == 7)
            {
                e.Graphics.DrawImage(pictureBox7.Image, cx, cy);
            }
            if (LastClicked == 8)
            {
                e.Graphics.DrawImage(pictureBox8.Image, cx, cy);
            }
            if (LastClicked == 9)
            {
                e.Graphics.DrawImage(pictureBox9.Image, cx, cy);
            }
            if (LastClicked == 10)
            {
                e.Graphics.DrawImage(pictureBox10.Image, cx, cy);
            }
            if (LastClicked == 11)
            {
                e.Graphics.DrawImage(pictureBox11.Image, cx, cy);
            }
            if (LastClicked == 12)
            {
                e.Graphics.DrawImage(pictureBox12.Image, cx, cy);
            }
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            test.Text = "mousemove";

            if (LastClicked==1)
            {
                pictureBox1.Invalidate();
                test.Text = "mousemove1";

            }
            if (LastClicked == 2)
            {
                pictureBox2.Invalidate();
                test.Text = "mousemove2";

            }
            if (LastClicked == 3)
            {
                pictureBox3.Invalidate();
                test.Text = "mousemove3";

            }
            if (LastClicked == 4)
            {
                pictureBox4.Invalidate();
                test.Text = "mousemove4";

            }
            if (LastClicked == 5)
            {
                pictureBox5.Invalidate();
                test.Text = "mousemove5";

            }
            if (LastClicked == 6)
            {
                pictureBox6.Invalidate();
                test.Text = "mousemove6";
            }
            if (LastClicked == 7)
            {
                pictureBox7.Invalidate();
                test.Text = "mousemove7";

            }
            if (LastClicked == 8)
            {
                pictureBox8.Invalidate();
                test.Text = "mousemove8";

            }
            if (LastClicked == 9)
            {
                pictureBox9.Invalidate();
                test.Text = "mousemove9";

            }
            if (LastClicked == 10)
            {
                pictureBox10.Invalidate();
                test.Text = "mousemove10";

            }
            if (LastClicked == 11)
            {
                pictureBox11.Invalidate();
                test.Text = "mousemove11";

            }
            if (LastClicked == 12)
            {
                pictureBox12.Invalidate();
                test.Text = "mousemove12";
            }


            /* if(pictureBox1.Capture ||
                pictureBox2.Capture ||
                pictureBox3.Capture)
            {
                int dx = e.X - lx;
                int dy = e.Y - ly;
                cx += dx;
                cy += dy;
                lx = e.X;
                ly = e.Y;
                pictureBox1.Invalidate();
                pictureBox2.Invalidate();
                pictureBox3.Invalidate();
            }*/
        }

        private void Panel1_MouseHover(object sender, EventArgs e)
        {
          if(this.Location== pictureBox5.Location)
            {
                test.Text = "loc";
            }
        }
        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            test.Text = "czxczcx";
            boola1 = false;
            boola2 = false;
            boola3 = false;
            if (LastClicked == 1)
            {
                test.Text = "mv1";
                if (pictureBox1.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv11";
                    pictureBox1.Invalidate();
                }
            }
            if (LastClicked == 2)
            {
                test.Text = "mv2";
                if (pictureBox2.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv22";
                    pictureBox2.Invalidate();
                }
            }
            if (LastClicked == 3)
            {
                test.Text = "mv3";
                if (pictureBox3.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv33";
                    pictureBox3.Invalidate();
                }
            }
            if (LastClicked == 4)
            {
                test.Text = "mv4";
                if (pictureBox4.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv44";
                    pictureBox4.Invalidate();
                }
            }
            if (LastClicked == 5)
            {
                test.Text = "mv5";
                if (pictureBox5.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv55";
                    pictureBox5.Invalidate();
                }
            }
            if (LastClicked == 6)
            {
                test.Text = "mv6";
                if (pictureBox6.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv66";
                    pictureBox6.Invalidate();
                }
            }
            if (LastClicked == 7)
            {
                test.Text = "mv7";
                if (pictureBox7.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv77";
                    if(e.Location.X==125 && e.Location.Y==125)
                    {
                        var p7x = pictureBox7.Location.X;
                        var p7y = pictureBox7.Location.Y;
                        X = p7x;
                        Y = p7y;
                        dx = e.X;
                        dy = e.Y;
                        p7x = pictureBox8.Location.X;
                        p7y = pictureBox8.Location.Y;

                    }
                    pictureBox7.Invalidate();
                }
            }
            if (LastClicked == 8)
            {
                test.Text = "mv8";
                if (pictureBox8.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv88";
                    pictureBox8.Invalidate();
                }
            }
            if (LastClicked == 9)
            {
                test.Text = "mv9";
                if (pictureBox9.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv99";
                    pictureBox9.Invalidate();
                }
            }
            if (LastClicked == 10)
            {
                test.Text = "mv10";
                if (pictureBox10.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv101";
                    pictureBox10.Invalidate();
                }
            }
            if (LastClicked == 11)
            {
                test.Text = "mv11";
                if (pictureBox12.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv111";
                    pictureBox11.Invalidate();
                }
            }
            if (LastClicked == 12)
            {
                test.Text = "mv12";
                if (pictureBox12.Capture)
                {
                    int dx = e.X - lx;
                    int dy = e.Y - ly;
                    cx += dx;
                    cy += dy;
                    lx = e.X;
                    ly = e.Y;
                    test.Text = "mv121";
                    pictureBox12.Invalidate();
                }
            }
        }
        private void PictureBox25_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox32_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox31_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox26_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox27_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox28_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox29_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox30_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
