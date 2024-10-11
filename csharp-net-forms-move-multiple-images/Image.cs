using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_net_forms_move_multiple_images
{
    public class Image
    {
        public System.Drawing.Image imagePic;
        public int width;
        public int height;
        public Point position = new Point();
        public bool active = false;
        public Rectangle rect;

        public Image(string imageLocation)
        {
            imagePic = System.Drawing.Image.FromFile(imageLocation);
            width = 100;
            height = 100;
            rect = new Rectangle(position.X, position.Y, width, height);
        }
    }
}
