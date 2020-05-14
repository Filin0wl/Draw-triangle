using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Drawing_IOS
{
    public class TriangleView : UIView
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);

            using (CGContext g = UIGraphics.GetCurrentContext())
            {

                //set up drawing attributes
                g.SetLineWidth(10);
                UIColor.Blue.SetFill();
                UIColor.Red.SetStroke();

                //create geometry
                var path = new CGPath();

                path.AddLines(
                    new CGPoint[]{
                    new CGPoint (100, 200),
                    new CGPoint (160, 100),
                    new CGPoint (220, 200)});

                path.CloseSubpath();

                //add geometry to graphics context and draw it
                g.AddPath(path);
                g.DrawPath(CGPathDrawingMode.FillStroke);
            }
        }
    }
}