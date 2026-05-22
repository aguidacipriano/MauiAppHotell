using Microsoft.Extensions.Logging;

namespace MauiAppHotell
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
                    fonts.AddFont("Exo2-BoldItalic.ttf", "Exo2BoldItalic");
                    fonts.AddFont("Exo2-ExtraLight.ttf", "Exo2ExtraLight");
                    fonts.AddFont("Exo2-Regular.ttf", "Exo2Regular");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
