using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Fonty.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			LoadApplication(new App());

			foreach (var family in UIFont.FamilyNames)
			{
				System.Diagnostics.Debug.WriteLine($"{family}");

				foreach (var name in UIFont.FontNamesForFamilyName(family))
				{
					System.Diagnostics.Debug.WriteLine($"{name}");
				}
			}

			return base.FinishedLaunching(app, options);
		}
    }
}
