using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestWindow
{

    public class MainViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<string> Items { get; } = new();

        private bool _isLoading;
        public bool IsLoading
        {
            get => _isLoading;
            set { _isLoading = value; OnPropertyChanged(); }
        }

        public MainViewModel()
        {
            _ = LoadAsync();
        }

        private async Task LoadAsync()
        {
            IsLoading = true;
            await Task.Delay(10000); // Simulate long load
            for (int i = 1; i <= 100; i++)
                Items.Add($"Item {i}");
            IsLoading = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string name = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}
