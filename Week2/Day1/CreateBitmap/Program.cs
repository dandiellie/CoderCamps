// The following code was given in the Coder Camps online textbook.
// The assignment was to fix and improve it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CreateBitmap
{
    class Program
    {
        static void Main(string[] args)
        {
            // create bitmap
            var bitmap = new Bitmap(500, 500);

            // randomly set 1000 pixels
            var rnd = new Random();
            for (var i = 0; i < 1000; i++)
            {
                bitmap.SetPixel(rnd.Next(500), rnd.Next(500), Color.Red);
            }

            // save bitmap to current directory (debug directory)
            var currentDirectory = Environment.CurrentDirectory;
            var path = Path.Combine(currentDirectory, "MyImage.png");
            bitmap.Save(path, ImageFormat.Png);
        }
    }
}
