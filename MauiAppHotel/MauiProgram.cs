using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Inter_18pt-Light.ttf", "Inter_18ptLight.ttf");
                    fonts.AddFont("Inter_24pt-Thin.ttf", "Inter_24ptThin.ttf");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
