# XamarinForms-PixateFreestyle
Example using Pixate Freestyle with Xamarin Forms

This example included compiled PixateFreestyle iOS version for iOS Unified in folder libs/Xamarin-PixateFreestyle/iOS, you can manually add to your iOS project.

Other important is Renderers/StyleRenderer.cs in iOS and Android project allow you can use StyleId and ClassId property on Xamarin Forms control.

Demo code in C# PCL

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

Demo code in css
```css
#buttondemo{
	color            : #446620;
	background-color : linear-gradient(#87c44a, #b4da77);
	border-width     : 1px;
	border-color     : #84a254;
	border-style     : solid;
	border-radius    : 10px;
	font-size        : 13px;
}

.normalButton{
	background-color : linear-gradient(#CEDCE7, #596a72);
	border-width     : 2px;
	border-color     : black;
	border-radius    : 8px;
	border-style     : solid;
	font-weight: bold;
}
```
![Demo Image](https://raw.githubusercontent.com/flashvnn/XamarinForms-PixateFreestyle/master/demo-image.png)
