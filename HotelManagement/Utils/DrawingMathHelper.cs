using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Utils
{
    internal class DrawingMathHelper
    {
        public static Point FindSmallPointCenter(Point pBig, Size sBig, Size sSmall)
        {
            int centerHeight = sBig.Height / 2;
            int centerWidth = sBig.Width / 2;

            int dialogCenterHeight = sSmall.Height / 2;
            int dialogCenterWidth = sSmall.Width / 2;

            int StartX = pBig.X + (centerWidth - dialogCenterWidth);
            int StartY = pBig.Y + (centerHeight - dialogCenterHeight);

            return new Point(StartX, StartY);
        }
    }
}
