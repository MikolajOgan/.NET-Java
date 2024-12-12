namespace lab33
{


    public class zad2
    {
        public Bitmap? img;
        public Bitmap? img1;
        public Bitmap? img2;
        public Bitmap? img3;
        public Bitmap? img4;

        public void copy()
        {
            img1 = img;
            img2 = img;
            img3 = img;
            img4 = img;
        }

        public void black(Bitmap ig, PictureBox p1) {
            for (int x = 0; x < ig.Width; x++)
            {
                for(int y = 0; y < ig.Height; y++)
                {
                    ig.SetPixel(x, y, Color.Black);
                }
            }

            p1.Image = ig;
        }

        public void SetPixelColor(Bitmap image, int x, int y, int red, int green, int blue)
        {
            if (x >= 0 && x < image.Width && y >= 0 && y < image.Height)
            {
                image.SetPixel(x, y, Color.FromArgb(red, green, blue));
            }
        }

        public void rev(Bitmap ig, PictureBox p1)
        {
            for (int x = 0; x < ig.Width; x++)
            {
                for (int y = 0; y < ig.Height; y++)
                {
                    Color c = ig.GetPixel(x, y);
                    int R = 255 - c.R;
                    int G = 255 - c.G;
                    int B = 255 - c.B;
                    SetPixelColor(ig, x, y, R, G, B);
                }
            }

            p1.Image = ig;
        }

        public void remR(Bitmap ig, PictureBox p1)
        {
            for (int x = 0; x < ig.Width; x++)
            {
                for (int y = 0; y < ig.Height; y++)
                {
                    Color c = ig.GetPixel(x, y);
                    int R = 0;
                    int G = 255 - c.G;
                    int B = 255 - c.B;
                    SetPixelColor(ig, x, y, R, G, B);
                }
            }

            p1.Image = ig;
        }

        public void avg(Bitmap ig, PictureBox p1)
        {
            for (int x = 0; x < ig.Width; x++)
            {
                for (int y = 0; y < ig.Height; y++)
                {
                    Color c = ig.GetPixel(x, y);
                    int sum = c.R + c.G + c.B;
                    sum /= 3;
                    SetPixelColor(ig, x, y, sum, sum, sum);
                }
            }

            p1.Image = ig;
        }

        public void onlB(Bitmap ig, PictureBox p1)
        {
            for (int x = 0; x < ig.Width; x++)
            {
                for (int y = 0; y < ig.Height; y++)
                {
                    Color c = ig.GetPixel(x, y);
                    int R = 0;
                    int G = 0;
                    int B = 255 - c.B;
                    SetPixelColor(ig, x, y, R, G, B);
                }
            }

            p1.Image = ig;
        }


    }


}
