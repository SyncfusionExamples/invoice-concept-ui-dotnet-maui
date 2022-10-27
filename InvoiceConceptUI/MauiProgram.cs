using Microsoft.Extensions.Logging;
using Syncfusion.Maui.ListView.Hosting;
using Syncfusion.Maui.SignaturePad.Hosting;

namespace InvoiceConceptUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .ConfigureSyncfusionSignaturePad()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif
        builder.ConfigureSyncfusionListView();
        return builder.Build();
	}
}

