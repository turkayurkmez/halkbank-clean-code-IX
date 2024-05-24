using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstution
{
    public class Geometry
    {
        public static IGeometry GetRectangle(int unit1, int? unit2=null)
        {
            //varsayınki burada birkaç satır kritik kod var:
            if (unit2.HasValue)
            {
                return new Rectangle { Width = unit1, Height = unit2.Value };
            }
            return new Square { EdgeLength = unit1 };
        }
    }

    public interface IGeometry {

        int GetArea();
    
    }
    public class Rectangle : IGeometry 
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int GetArea() => Width * Height;
    }

    public class Square : IGeometry//: Rectangle
    {
        //public int Width { get => base.Width; set { base.Width = value; base.Height = value; } }
        //public override int Height { get => base.Width; set { base.Width = value; base.Height = value; } }
        public int EdgeLength { get; set; }
        public int GetArea() => EdgeLength * EdgeLength;
            
    }
}
