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
    /// Логика взаимодействия для TableView.xaml
    /// </summary>
    public partial class TableView : Page
    {
        public TableView(int choose)
        {
            InitializeComponent();

            switch (choose)
            {
                case 1:
                    DGStudent1.Visibility = Visibility.Visible;
                    DGStudent.ItemsSource = CollegeNLEntities.GetContext().Student.ToList();
                    break;
                case 2:
                    DGGroup1.Visibility= Visibility.Visible;
                    DGGroup.ItemsSource = CollegeNLEntities.GetContext().Group.ToList();
                    break;
                case 3:
                    DGFaculty1.Visibility = Visibility.Visible;
                    DGFaculty.ItemsSource = CollegeNLEntities.GetContext().Faculty.ToList();
                    break;
                case 4:
                    DGCourse1.Visibility = Visibility.Visible;
                    DGCourse.ItemsSource = CollegeNLEntities.GetContext().Course.ToList();
                    break;
                case 5:
                    DGRup1.Visibility = Visibility.Visible;
                    DGRup.ItemsSource = CollegeNLEntities.GetContext().RUP.ToList();
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    break;
                case 14:
                    break;
                default:
                    MessageBox.Show("Кажется произошла непредвиденная ошибка!");
                    break;
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditGroup_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditStudent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditRup_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditCourse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEditFaculty_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
