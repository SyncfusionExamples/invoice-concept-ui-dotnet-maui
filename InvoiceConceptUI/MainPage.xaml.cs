namespace InvoiceConceptUI;

public partial class MainPage : ContentPage
{ 
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.ItemsViewModel();
    } 
}


