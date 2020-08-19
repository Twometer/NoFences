using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoFences.Util
{
    public static class Extensions
    {

        public static PointF Move(this PointF point, float offsetX, float offsetY)
        {
            return new PointF(point.X + offsetX, point.Y + offsetY);
        }


        public static Rectangle Shrink(this Rectangle rect, int offset)
        {
            return new Rectangle(rect.X + offset, rect.Y + offset, rect.Width - offset * 2, rect.Height - offset * 2);
        }

    }
}
