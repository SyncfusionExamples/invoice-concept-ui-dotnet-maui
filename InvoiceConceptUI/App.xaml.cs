namespace InvoiceConceptUI;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		var navigationPage = new NavigationPage(new MainPage());
		navigationPage.BackgroundColor = Color.FromArgb("#fafafa");
	}
}

