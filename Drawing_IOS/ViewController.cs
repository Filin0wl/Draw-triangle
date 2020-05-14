using Foundation;
using System;
using UIKit;

namespace Drawing_IOS
{
    public partial class ViewController : UIViewController
    {
        TriangleView drawTriangle;
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.
            drawTriangle = new TriangleView() { Frame = UIScreen.MainScreen.Bounds };
            View.AddSubview(drawTriangle);
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}