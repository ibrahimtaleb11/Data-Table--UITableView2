using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TableViewApp
{
	partial class seconedview : UIViewController
	{
		public seconedview (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
			string[] names = new string[]{"ibrahim","Taleb","Dahan","MOhammed"};
			tabelview1.Source = new TableSource001 (names);

		
		
		}
	}
}
