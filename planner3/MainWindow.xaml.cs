using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace planner3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            date_text.Text = DateTime.Today.ToLongDateString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calendar_planner.Visibility = Visibility;
            date_text.Visibility = Visibility.Hidden;
        }

        private void calendar_planner_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime data = (DateTime)calendar_planner.SelectedDate;
            date_text.Text = data.ToLongDateString();
            calendar_planner.Visibility = Visibility.Hidden;
            date_text.Visibility = Visibility;
        }
    }
}
