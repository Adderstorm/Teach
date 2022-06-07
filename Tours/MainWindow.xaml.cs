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

namespace Tours
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int k = 1;
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
            Manager.MainFrame.Navigate(Manager.tableView);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.GoBack();
        }

        private void MainFrame_ContentRendered(object sender, EventArgs e)
        {
            if(MainFrame.CanGoBack)
            {
                BtnBack.Visibility = Visibility.Visible;
            }
            else
            {
                BtnBack.Visibility = Visibility.Hidden;
            }
        }

        private void students_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(1));
        }

        private void groups_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(2));
        }

        private void faculty_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(3));
        }

        private void course_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(4));
        }

        private void RUP_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(5));
        }

        private void ExpelledStud_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(6));
        }

        private void AVGStudGrade_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(7));
        }

        private void AcademicLoad_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(8));
        }

        private void AcademicLoadSortByTerm_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(9));
        }

        private void FStudents_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(10));
        }

        private void AVGGroupGrade_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(11));
        }

        private void ListStudent_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(12));
        }

        private void ListStudentsGrade_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(13));
        }

        private void StudRating_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TableView(14));
        }

        private void Other_Click(object sender, RoutedEventArgs e)
        {
            if(k % 2 == 0)
            {
                SecondaryTables.Visibility = Visibility.Hidden;
                Other.Margin = new Thickness(5, 180, 5, 0);
                k+= 1;
            }
            else
            {
                SecondaryTables.Visibility = Visibility.Visible;
                Other.Margin = new Thickness(5, 495, 5, 0);
                k+= 1;
            }
        }
    }
}
