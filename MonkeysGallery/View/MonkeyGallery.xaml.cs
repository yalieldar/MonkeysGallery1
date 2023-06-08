using MonkeysGallery.ViewModel;

namespace MonkeysGallery.View;

public partial class MonkeyGallery : ContentPage
{
	public MonkeyGallery(MonkeyViewModel vm)
	{
		InitializeComponent();
		this.BindingContext= vm;
	}
}