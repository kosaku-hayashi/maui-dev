using MauiIcons.Core;
using MauiIcons.Material;
using MauiIcons.FontAwesome;

namespace MauiDev;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        _ = new MauiIcon();

        var test = new Slider().ThumbImageSource;
        var test3 = new Page().IconImageSource;
        var test2 = new Page().BackgroundImageSource;
        var test4 = new Shell().IconImageSource;
        var tesr55 = new Shell().BackgroundImageSource;
        var test5 = new Shell().FlyoutIcon;
        var test6 = new BaseShellItem().Icon;
        var test7 = new BaseShellItem().FlyoutIcon;
        var test8 = new SearchHandler().ClearIcon;
        var test9 = new SearchHandler().QueryIcon;
        var test10 = new SearchHandler().ClearPlaceholderIcon;
        var test11 = new MenuItem().IconImageSource;
        var test12 = new ImageCell().ImageSource;

        //layout.Add(new ImageButton().Icon(MaterialIcons.VerifiedUser));
        //layout.Add(new Image().Icon(MaterialIcons.Delete));
        //layout.Add(new Label().Icon(MaterialIcons.Home).IconSize(40.0).IconColor(Colors.Red));
        //layout.Add(new Entry().Icon(MaterialIcons.Wallet).IconSize(20.0).IconColor(Colors.Aqua));
        //layout.Add(new SearchBar().Icon(MaterialIcons.OfflineShare));
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if(count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

