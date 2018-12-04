using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmediaProject
{
    class JpgDecoderClass
    {
        public int lenght { get; set; }
        public int dataPrecision { get; set; }
        public int imageHeight { get; set; }
        public int imageWidth { get; set; }

        public void imageProperies(string imageName)
        {

            //const string Path = @"..\..\Images\image1.jpg"; // mozna uzyc: image1/2/3/4/5
            string Path = @"..\..\Images\" + imageName + ".jpg";

            byte[] byteArray = File.ReadAllBytes(Path);
            //  foreach (var byt in byteArray)
            //   {
            //       Console.Write(byt.ToString());
            //  }
            for (int i = 0; i < (byteArray.Length); i++) //  byteArray iteration
            {

                if (byteArray[i] == 0xff && byteArray[i + 1] == 0xd8) // looking for start of image (SOI)
                {
                    // Console.WriteLine("Start of Image was detected... ");
                    string message = "Start of Image was detected...";
                    string caption = "Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(message, caption, buttons);

                }
                else if (byteArray[i] == 0xff && byteArray[i + 1] == 0xc0) // SOF0 marker indefier
                {
                    // SOF0 : Marker indefier (2 bajty) -> Lenght (2 bajty) -> Data precision (1 bajt) ->
                    // -> Image Height (2 bajty) -> Image Width (2 bajty) -> NumberOfComponents (1 bajt) -> Each component

                    lenght = (byteArray[i + 2]) * 256 + (byteArray[i + 3]);
                    dataPrecision = byteArray[i + 4];
                    imageHeight = (byteArray[i + 5]) * 256 + (byteArray[i + 6]);
                    imageWidth = (byteArray[i + 7]) * 256 + (byteArray[i + 8]);
                    int numberOfComponents = byteArray[i + 9];
                    int eachComponent_componentID = byteArray[i + 10];
                    int eachComponent_samplingFactors = byteArray[i + 11];
                    int eachComponent_quantizationTableNumber = byteArray[i + 12];
                    /*                           EACH COMPONENT
                                                 Read each component data of 3 bytes. It contains,
                                                (component Id(1byte)(1 = Y, 2 = Cb, 3 = Cr, 4 = I, 5 = Q),   
                                                 sampling factors (1byte) (bit 0-3 vertical., 4-7 horizontal.)
                                                 quantization table number (1 byte)
                     */
                    string message = "Image properties";
                    string caption = "Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(message, caption, buttons);
                    /* Console.WriteLine("JPG info: ");
                     Console.WriteLine("Lenght: " + lenght);
                     Console.WriteLine("Data precision: " + dataPrecision);
                     Console.WriteLine("Height: " + imageHeight);
                     Console.WriteLine("Width: " + imageWidth);*/
                }
                else if (byteArray[i] == 0xff && byteArray[i + 1] == 0xd9) // looking for end of image (EOI)
                {
                    // Console.WriteLine("Start of Image was detected... ");
                    string message = "End of Image was detected...";
                    string caption = "Message";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result;

                    // Displays the MessageBox.

                    result = MessageBox.Show(message, caption, buttons);
                    // Console.WriteLine("End of Image was detected... ");
                }
            }







        }

    }





}

