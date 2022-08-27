using AForge.Imaging.Filters;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using Tesseract;

namespace AirtimeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //ImageToText();
        }

        private void imageToTextBtn_Click(object sender, EventArgs e)
        {
            textBox.Text = DeCaptcha(pictureBox1.Image);
        }

        private string OCR(Bitmap bmp)
        {
            using (TesseractEngine engine = new TesseractEngine(@"C:\Users\damilola.adamson\source\repos\AirtimeManagement\AirtimeManagement\tessdata\", "eng", EngineMode.Default))
            {
                engine.SetVariable("tessedit_char_whitelist", "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ");
                engine.SetVariable("tessedit_unrej_any_wd", true);

                    using (var page = engine.Process(bmp, PageSegMode.SingleLine))
                    {
                        return page.GetText();
                    }
                
            }
        }

        private string DeCaptcha(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            bmp = bmp.Clone(new Rectangle(0, 0, img.Width, img.Height), System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Erosion erosion = new Erosion();
            Dilatation dilatation = new Dilatation();
            Invert inverter = new Invert();
            ColorFiltering cor = new ColorFiltering();
            cor.Blue = new AForge.IntRange(200, 255);
            cor.Red = new AForge.IntRange(200, 255);
            cor.Green = new AForge.IntRange(200, 255);
            Opening open = new Opening();
            BlobsFiltering bc = new BlobsFiltering() { MinHeight = 10 };
            Closing close = new Closing();
            GaussianSharpen gs = new GaussianSharpen();
            ContrastCorrection cc = new ContrastCorrection();
            FiltersSequence seq = new FiltersSequence(gs, inverter, open, inverter, bc, inverter, open, cc, cor, bc, inverter);
            pictureBox1.Image = seq.Apply(bmp);
            return OCR((Bitmap)pictureBox1.Image);
        }

        private void ImageToText()
        {
            var path = @"C:\Users\damilola.adamson\Pictures\SavedPictures\tessdata";
            var sourceFilePath = @"C:\Users\damilola.adamson\Pictures\Title details.JPG";
            //            var image = new Bitmap(@"C:\Users\damilola.adamson\Pictures\Title details.JPG");
            using (var engine = new TesseractEngine(path, "eng"))
            {
                engine.SetVariable("user_defined_dpi", "70"); //set dpi for supressing warning
                using (var img = Pix.LoadFromFile(sourceFilePath))
                {
                    using (var page = engine.Process(img))
                    {
                        var text = page.GetText();
                        Console.WriteLine();
                        Console.WriteLine("---Image Text---");
                        Console.WriteLine();
                        Console.WriteLine(text);
                    }
                }
            }
        }

        private void uploadImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg|PNG|*.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
    }
}