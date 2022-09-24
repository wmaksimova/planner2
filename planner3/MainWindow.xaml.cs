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
            List<string> dates = new List<string>();
            DateTime[] datesTime = new DateTime[10];
            datesTime[0] = DateTime.Today;
            dates.Add(datesTime[0].ToLongDateString());
            for (int i = 1; i < 10; i++)
            {
                datesTime[i] = datesTime[i - 1].AddDays(1);
                dates.Add(datesTime[i].ToLongDateString());
            }
            dateList.ItemsSource = dates;
        }
    }
}
