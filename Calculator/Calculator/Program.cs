using Avalonia;
using Avalonia.ReactiveUI;
using Calculator.Abstractions;
using Calculator.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Инжектор зависимостей
        /// </summary>
        public static ServiceProvider Di { get; set; }

        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args)
        {
            Di = ConfigureServices()
                .BuildServiceProvider();

            BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);
        }

        /// <summary>
        /// Настройка инжектора зависимостей
        /// </summary>
        /// <returns></returns>
        public static IServiceCollection ConfigureServices()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<IInputService, InputService>();

            services.AddSingleton<ICalculationService, CalculationService>();

            return services;
        }

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .UseReactiveUI();
    }
}
