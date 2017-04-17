using System;
using FormsPlugin.Iconize;
using Plugin.Iconize;
using Xamarin.Forms;
using XFShapeView;

namespace TestIconizeAndShape
{
	public class MyPage : ContentPage
	{
		public MyPage()
		{

			Label l = new Label() {Text  = "Press the icon", VerticalOptions = LayoutOptions.Center, FontSize = 40 };

			IconImage iconImage = new IconImage() { IconColor = Color.White, IconSize = 40, VerticalOptions = LayoutOptions.Center};
			iconImage.Icon = Iconize.FindIconForKey("ion-information").Key;


			var circle = new ShapeView
			{
				ShapeType = ShapeType.Circle,
				HeightRequest = 50,
				WidthRequest = 50,
				Color = Color.Green,
				VerticalOptions = LayoutOptions.Center,
				CornerRadius = 5,
				BorderColor = Color.Red,
				BorderWidth = 1f,
				Content = iconImage
			};

			StackLayout sl = new StackLayout() { VerticalOptions = LayoutOptions.Center, Orientation = StackOrientation.Horizontal, Children =  { l, circle }, Margin = new Thickness(0,20,0,0) };

			Content = sl;

		}
	}
}

