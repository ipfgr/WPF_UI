using System.Windows;

namespace ClientApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }



      

        private void CloseWindow(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            this.Close();
        }
        public void goSetting(object sender , System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }
    }
}
