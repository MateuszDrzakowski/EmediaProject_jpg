using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EmediaProject
{

    public partial class Form1 : Form
    {

        JpgDecoderClass jpg = new JpgDecoderClass();

        public Form1()
        {
            InitializeComponent();
        }


        private void FFTbutton_Click(object sender, EventArgs e)
        {   try
            {
                string imageName = imageNameBox.Text;
                jpg.imageProperies(imageName);
                richTextBox1.Text = ("Lenght: " + jpg.lenght.ToString() + "\n" + "Data precision: " +
                                     jpg.dataPrecision.ToString() + "\n" + "Height: " + jpg.imageHeight.ToString() + "\n" + "Width: " +
                                     jpg.imageWidth.ToString());

                //OriginalImage.Image = Image.FromFile(@"..\..\Images\image3.jpg");
                originalImage.Image = Image.FromFile(@"..\..\Images\" + imageName + ".jpg");

                FastFourierClass fft = new FastFourierClass((Bitmap)originalImage.Image);
                fft.ForwardFFT();
                fft.FFTShift();
                fft.FFTPlot(fft.FFTShifted);

                magnitudeImage.Image = (Image)fft.FourierPlot;
                phaseImage.Image = (Image)fft.PhasePlot;
                fft.InverseFFT();
                inverseImage.Image = fft.Obj;
            }
            catch
            {
                MessageBox.Show("Podano nieprawidłową nazwę pliku!");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
