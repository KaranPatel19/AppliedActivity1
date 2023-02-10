using AppliedActivity1.Services;
namespace AppliedActivity1;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		DependencyService.Register<WebClientService>();


		MainPage = new AppShell();
	}
}

