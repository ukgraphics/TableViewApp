// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace TableViewApp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTableColumn TableColumn1 { get; set; }

		[Outlet]
		AppKit.NSTableColumn TableColumn2 { get; set; }

		[Outlet]
		AppKit.NSTableView TableView1 { get; set; }

		[Action ("ClickedButton:")]
		partial void ClickedButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (TableView1 != null) {
				TableView1.Dispose ();
				TableView1 = null;
			}

			if (TableColumn1 != null) {
				TableColumn1.Dispose ();
				TableColumn1 = null;
			}

			if (TableColumn2 != null) {
				TableColumn2.Dispose ();
				TableColumn2 = null;
			}
		}
	}
}
