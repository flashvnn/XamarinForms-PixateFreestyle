using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using XFormPixateFreestyle.iOS;


[assembly: ExportRenderer (typeof(Entry), typeof(StyledEntryRenderer))]
[assembly: ExportRenderer (typeof(Button), typeof(StyleButtonRenderer))]
[assembly: ExportRenderer (typeof(Image), typeof(StyledImageRenderer))]
[assembly: ExportRenderer (typeof(Label), typeof(StyledLabelRenderer))]
[assembly: ExportRenderer (typeof(ListView), typeof(StyledListViewRenderer))]
//[assembly: ExportRenderer (typeof(ViewCell), typeof(StyledViewCellRenderer))]
//[assembly: ExportRenderer (typeof(TextCell), typeof(StyledTextCellRenderer))]
//[assembly: ExportRenderer (typeof(ImageCell), typeof(StyledImageCellRenderer))]

namespace XFormPixateFreestyle.iOS
{
	public static class StyledRenderer
	{
		public static void UpdateStyle (UIView view, VisualElement model = null)
		{
			var styleId = model.StyleId;
			var classId = model.ClassId;
			UpdateStyle (view, styleId, classId);
		}

		public static void UpdateStyle (UIView view, string styleId, string classId)
		{
			//Log.Trace ("Update style " + styleId + " " + classId + " for " + view);
			if (!string.IsNullOrWhiteSpace (styleId)) {
				PixateFreestyleLib.PixateFreestyle.SetStyleId (view, styleId);
			}
			if (!string.IsNullOrWhiteSpace (classId)) {
				PixateFreestyleLib.PixateFreestyle.SetStyleClass (view, classId);
			}
		}

		public static void StyleOnElementPropertyChanged (UIView control, VisualElement element, object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (e.PropertyName == "ClassId" || e.PropertyName == "StyleId") {
				StyledRenderer.UpdateStyle (control, element);
			}
		}

		public static void StyleOnElementChanged (UIView control, VisualElement element)
		{
			StyledRenderer.UpdateStyle (control, element);
		}
	}

	public class StyledEntryRenderer: EntryRenderer
	{
		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);
			StyledRenderer.StyleOnElementPropertyChanged (Control, Element, sender, e);
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Entry> e)
		{
			base.OnElementChanged (e);
			StyledRenderer.StyleOnElementChanged (Control, e.NewElement);
		}
	}

	public class StyleButtonRenderer: ButtonRenderer
	{
		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);
			StyledRenderer.StyleOnElementPropertyChanged (Control, Element, sender, e);
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged (e);
			StyledRenderer.StyleOnElementChanged (Control, e.NewElement);
		}
	}

	public class StyledImageRenderer:ImageRenderer
	{
		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);
			StyledRenderer.StyleOnElementPropertyChanged (Control, Element, sender, e);
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Image> e)
		{
			base.OnElementChanged (e);
			StyledRenderer.StyleOnElementChanged (Control, e.NewElement);
		}
	}

	public class StyledLabelRenderer: LabelRenderer
	{
		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);
			StyledRenderer.StyleOnElementPropertyChanged (Control, Element, sender, e);
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.Label> e)
		{
			base.OnElementChanged (e);
			StyledRenderer.StyleOnElementChanged (Control, e.NewElement);
		}
	}

	public class StyledListViewRenderer: ListViewRenderer
	{
		protected override void OnElementPropertyChanged (object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged (sender, e);
			StyledRenderer.StyleOnElementPropertyChanged (Control, Element, sender, e);
		}

		protected override void OnElementChanged (ElementChangedEventArgs<Xamarin.Forms.ListView> e)
		{
			base.OnElementChanged (e);
			StyledRenderer.StyleOnElementChanged (Control, e.NewElement);
		}
	}
}