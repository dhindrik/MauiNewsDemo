using MauiNews.Views;

namespace MauiNews;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NewsView();
	}
}
