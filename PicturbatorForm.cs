using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picturbator
{

    public partial class Form : System.Windows.Forms.Form
    {

        Image SourceImage;
        static Image Picture;
        int PicWidth = 640;
        int PicHeight = 480;
        int Amount = 10;
        static bool isRotated = false;


        public Form()
        {
            InitializeComponent();
            Logo_PictureBox.Image = Properties.Resources.logo;
        }

        private void AddImage_Btn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Title = "Open Image";
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SourceImage = Image.FromFile(dialog.FileName);
            }
            dialog.Dispose();
            Width_Txt.Enabled   = Height_Txt.Enabled 
                                = UnitScale_Trb.Enabled = UnitMaxSize_Trb.Enabled 
                                = Amount_Trb.Enabled 
                                = Reroll_Btn.Enabled = Export_Btn.Enabled 
                                = true;
            Reroll();
        }
        private void UnitMinSize_Trb_Scroll(object sender, EventArgs e)
        {
        }
        private void UnitMaxSize_Trb_Scroll(object sender, EventArgs e)
        {
        }

        public void Reroll()
        {
            PictureBox.Image = null;
            PictureBox.Invalidate();
            Picture = DrawPicture(SourceImage, UnitScale_Trb.Value, UnitMaxSize_Trb.Value, PicWidth, PicHeight, Amount);
            PictureBox.Image = Picture;
        }
        public static Image DrawPicture(Image SourceImage, int MinScale, int MaxScale, int PicWidth, int PicHeight, int Amount)
        {
            Random _random = new Random();
            int UnitPosX, UnitPosY;
            float UnitImageScale;
            Bitmap Picture = new Bitmap(PicWidth, PicHeight);
                using (Graphics g = Graphics.FromImage((Image)Picture))
                {

                    for (int i = Amount; i > 0; --i)
                    {
                        UnitImageScale = _random.Next(MinScale, MaxScale);
                        UnitPosX = _random.Next(0, PicWidth);
                        UnitPosY = _random.Next(0, PicHeight);


                        if (!isRotated)
                        {
                            g.DrawImage(SourceImage, UnitPosX - 200, UnitPosY - 200
                       , ((float)SourceImage.Width * UnitImageScale / 100), ((float)SourceImage.Height * UnitImageScale / 100));
                        }
                        else
                        {
                            using (Bitmap rotatedImage = new Bitmap(SourceImage.Width, SourceImage.Height))
                            {
                                using (Graphics rg = Graphics.FromImage(rotatedImage))
                                {
                                    rg.TranslateTransform((float)SourceImage.Width / 2, (float)SourceImage.Height / 2);
                                    rg.RotateTransform(_random.Next(0, 359));
                                    rg.TranslateTransform(-(float)SourceImage.Width / 2, -(float)SourceImage.Height / 2);
                                    rg.DrawImage(SourceImage, new Point(0, 0));
                                }
                                g.DrawImage(rotatedImage, UnitPosX - SourceImage.Width/2, UnitPosY - SourceImage.Height / 2
                           , ((float)SourceImage.Width * UnitImageScale / 100), ((float)SourceImage.Height * UnitImageScale / 100));

                            }
                        }
                    }
            return Picture;
            }
        }

        private void Export_Btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Jpeg Image|*.jpg|Png Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        Picture.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        Picture.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }

        private void Amount_Trb_Scroll(object sender, EventArgs e)
        {
            Amount = Amount_Trb.Value;
        }

        private void Reroll_Btn_Click(object sender, EventArgs e)
        {
            Reroll();
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Width_Txt_ValueChanged(object sender, EventArgs e)
        {

            PicWidth = Int16.Parse(Width_Txt.Text);
        }

        private void Height_Txt_ValueChanged(object sender, EventArgs e)
        {
            PicHeight = Int16.Parse(Height_Txt.Text);
        }

        private void Rotation_Chk_CheckedChanged(object sender, EventArgs e)
        {
            isRotated = !isRotated;
        }


    }
}
