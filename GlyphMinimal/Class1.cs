using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace GlyphMinimal
{
    public class Class1 : FrameworkElement
    {
        GlyphTypeface _typeFace;
        Pen widepen;
        Pen pen;
        public Class1()
        {
            new Typeface("Arial").TryGetGlyphTypeface(out _typeFace);
            widepen = new Pen(Brushes.Black, 3.0);
            pen = new Pen(Brushes.Black, 1.0);
        }
        protected override void OnRender(DrawingContext drawingContext)
        {
            //var r = Helper.Run("hello", _typeFace, 40, new Point(100,100));
            //var g = r.BuildGeometry();
            //var t = g.Bounds;
            //Pen widepen = new Pen(Brushes.Black, 3.0);
            //Pen pen = new Pen(Brushes.Black, 1.0);
            //var v = g.GetRenderBounds(widepen);
            //drawingContext.DrawRectangle(null,pen, t);
            //drawingContext.DrawGeometry(Brushes.LightBlue, new Pen(Brushes.Blue, 1), g);
            int x = 0;
            int y = 20;
            for (int i = 0; i < 3200; i++)
            {
                var r = Helper.Run("hello", _typeFace, 10, new Point(x,y));
                //var g = r.BuildGeometry();
                //var t = g.Bounds;

                //var v = g.GetRenderBounds(widepen);
                //drawingContext.DrawRectangle(null, pen, t);
                //drawingContext.DrawGeometry(Brushes.LightBlue, new Pen(Brushes.Blue, 1), g);

                drawingContext.DrawGlyphRun(Brushes.BlueViolet, r);
                x += 35;
                if (x > 2020)
                {
                    x = 0;
                    y += 20;
                }
            }

            //drawingContext.DrawGlyphRun(Brushes.BlueViolet,r);
            base.OnRender(drawingContext);
        }
    }
}
