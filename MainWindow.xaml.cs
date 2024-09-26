using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1
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

        private void Change_Color_Click(object sender, RoutedEventArgs e)
        {
            switch (((FrameworkElement)sender).Tag.ToString())
            {
                case "red":
                    main.Background = Brushes.Red;
                    break;
                case "yellow":
                    main.Background = Brushes.Yellow;
                    break;
                case "white":
                    main.Background = Brushes.White;
                    break;
            }
        }
        private void Author(object sender, RoutedEventArgs e)
        {
            if (info_author.Visibility == Visibility.Hidden)
                info_author.Visibility = Visibility.Visible;
            else
                info_author.Visibility = Visibility.Hidden;
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void status_change_to_red(object sender, RoutedEventArgs e)
        {
            status.Text = "Изменение цвета фона на красный";
        }
        private void status_change_to_yellow(object sender, RoutedEventArgs e)
        {
            status.Text = "Изменение цвета фона на жёлтый";
        }
        private void status_change_to_white(object sender, RoutedEventArgs e)
        {
            status.Text = "Изменение цвета фона на белый";
        }
        private void status_author(object sender, RoutedEventArgs e)
        {
            status.Text = "Информация про автора";
        }
        private void status_exit(object sender, RoutedEventArgs e)
        {
            status.Text = "Выход из приложения";
        }

    }
}