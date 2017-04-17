using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using XFShapeView.iOS;

namespace TestIconizeAndShape.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{

			global::Xamarin.Forms.Forms.Init();

			Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.IoniconsModule());

			LoadApplication(new App());

			ShapeRenderer.Init();
			FormsPlugin.Iconize.iOS.IconControls.Init();
			return base.FinishedLaunching(app, options);
		}
	}
}
