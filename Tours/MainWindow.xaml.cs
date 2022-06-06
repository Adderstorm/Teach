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
        public MainWindow()
        {
            InitializeComponent();
            Manager.MainFrame = MainFrame;
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

        }

        private void groups_Click(object sender, RoutedEventArgs e)
        {

        }

        private void faculty_Click(object sender, RoutedEventArgs e)
        {

        }

        private void course_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RUP_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExpelledStud_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AVGStudGrade_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AcademicLoad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AcademicLoadSortByTerm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FStudents_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AVGGroupGrade_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListStudentsGrade_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StudRating_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Other_Click(object sender, RoutedEventArgs e)
        {
            int k = 1;
            if(k % 2 == 0)
            {
                SecondaryTables.Visibility = Visibility.Hidden;
                Other.Margin = new Thickness(5, 180, 5, 0);
                k++;
            }
            else
            {
                SecondaryTables.Visibility = Visibility.Visible;
                Other.Margin = new Thickness(5, 495, 5, 0);
                k++;
            }
        }
    }
}
