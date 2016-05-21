using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.IO;
using System.Collections.Generic;


namespace TableViewApp
{
	partial class conversationsview : UITableViewController
	{
		public conversationsview (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.
		
			//string[] names = new string[]{"ibrahim","Taleb","Dahan","MOhammed"};

			List<string> list = new List<string> ();
			List<TableItem> table = new List<TableItem> ();

			table.Add (new TableItem (){Heading="Ibrahim ",SubHeading="ibrahim Taleb Mohammed Dahan",ImageName="image2.png"});
			table.Add (new TableItem (){Heading="Amera ",SubHeading="Amera Mohammed Moftah",ImageName="image3.png"});
			table.Add (new TableItem (){Heading="Taha ",SubHeading="Taha MOhammed Moftah",ImageName="image4.png"});
			table.Add (new TableItem (){Heading="Ameer Aldden",SubHeading="Ameer Aldden Mohammed Moftah",ImageName="image2.png"});



			TableItemGroup tp = new TableItemGroup ();
			tp.Items = table;

			List<TableItemGroup> tableItems0g = new List<TableItemGroup> ();

			tableItems0g.Add(new TableItemGroup(){Name="Gropup1Dahan",Footer="thisfoter",Items=table});




			TableView.Source = new TableSource (tableItems0g);

		
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			try
			{

				TableView.ReloadData();
			}
			catch(Exception exc) 

			{

				new UIAlertView ("OOps!", "Error", null, "OK").Show ();
			}
		}
	}
}
