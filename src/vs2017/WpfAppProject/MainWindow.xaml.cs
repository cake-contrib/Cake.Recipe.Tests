using System.Windows;

namespace WpfAppProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NoNameLabel.Content = $"2 + 2 = {MathClass.Add(2, 2)}";
        }
    }
}