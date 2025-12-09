using System.Windows;

namespace TestWindow
{
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Simulate heavy startup
            Thread.Sleep(TimeSpan.FromSeconds(6));

            // Create and show the main window after the delay
            var mainWindow = new MainWindow();
            mainWindow.Show();
        }
    }
}
