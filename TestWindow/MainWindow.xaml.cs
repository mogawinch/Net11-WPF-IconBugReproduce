using System.Windows.Media.Imaging;

namespace TestWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

            Loaded += (sender, e) =>
            {
                Icon = new BitmapImage(new Uri("pack://application:,,,/TestWindow;component/VideoGeneric.ico"));
            };
        }
    }
}