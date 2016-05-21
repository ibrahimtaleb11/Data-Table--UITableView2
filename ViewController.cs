using System;

using UIKit;

namespace TableViewApp
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void UIButton14_TouchUpInside (UIButton sender)
		{
			conversationsview controller=this.Storyboard.InstantiateViewController("conversationsview")as conversationsview;
			this.NavigationController.PushViewController(controller,true);
		}

		partial void UIButton153_TouchUpInside (UIButton sender)
		{
			seconedview controller=this.Storyboard.InstantiateViewController("seconedview")as seconedview;
			this.NavigationController.PushViewController(controller,true);
		}
	}
}

