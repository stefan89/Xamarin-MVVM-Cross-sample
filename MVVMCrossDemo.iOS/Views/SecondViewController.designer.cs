// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MVVMCrossDemo.iOS
{
	[Register ("SecondViewController")]
	partial class SecondViewController
	{
		[Outlet]
		UIKit.UIButton buttonNavigateToThirdPage { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonNavigateToThirdPage != null) {
				buttonNavigateToThirdPage.Dispose ();
				buttonNavigateToThirdPage = null;
			}
		}
	}
}
