# XamarinForms-PixateFreestyle
Example using Pixate Freestyle with Xamarin Forms

This example included compiled PixateFreestyle iOS version for iOS Unified in folder libs/Xamarin-PixateFreestyle/iOS, you can manually add to your iOS project.

Other important is Renderers/StyleRenderer.cs in iOS and Android project allow you can use StyleId and ClassId property on Xamarin Forms control.

Demo code:

```C#
  var button = new Button {
		Text = "Button 1"
	};
	button.StyleId = "buttondemo";

	var button2 = new Button {
		Text = "Button 2"
	};
	button2.ClassId = "normalButton";
```
![Demo Image](https://raw.githubusercontent.com/flashvnn/XamarinForms-PixateFreestyle/master/demo-image.png)
