using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_net_forms_move_multiple_images
{
    public class Card
    {
        public Image cardPic;
        public int width;
        public int height;
        public Point position = new Point();
        public bool active = false;
        public Rectangle rect;

        public Card(string imageLocation)
        {
            cardPic = Image.FromFile(imageLocation);
            width = cardPic.Width;
            height = cardPic.Height;
            rect = new Rectangle(position.X, position.Y, width, height);
        }
    }
}
