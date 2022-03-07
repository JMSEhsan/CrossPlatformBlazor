using CrossPlatformBlazor.Data;
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using RazorClassLibrary;
using RazorClassLibrary.Data;

namespace WinFormsBlazor
{
    public partial class FormBlazorWeb : Form
    {
        public static AppState AppState = new AppState();
        public FormBlazorWeb()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            serviceCollection.AddSingleton<WeatherForecastService>();
            serviceCollection.AddSingleton<AppState>();

            InitializeComponent();

            blazorWebView1.HostPage = @"wwwroot\index.html";
            blazorWebView1.Services = serviceCollection.BuildServiceProvider();
            blazorWebView1.RootComponents.Add<App>("#app");
        }

        private void FormBlazorCountBTM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Counter Value: " + AppState.Counter);
        }
    }
}