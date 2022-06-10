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
        int choosenTable = 0;
        public TableView(int choose)
        {
            InitializeComponent();
            choosenTable = choose;

            switch (choose)
            {
                case 1:
                    GStudent.Visibility = Visibility.Visible;
                    DGStudent.ItemsSource = CollegeNLEntities.GetContext().Student.ToList();
                    break;
                case 2:
                    GGroup.Visibility= Visibility.Visible;
                    DGGroup.ItemsSource = CollegeNLEntities.GetContext().Group.ToList();
                    break;
                case 3:
                    GFaculty.Visibility = Visibility.Visible;
                    DGFaculty.ItemsSource = CollegeNLEntities.GetContext().Faculty.ToList();
                    break;
                case 4:
                    GCourse.Visibility = Visibility.Visible;
                    DGCourse.ItemsSource = CollegeNLEntities.GetContext().Course.ToList();
                    break;
                case 5:
                    GRup.Visibility = Visibility.Visible;
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
            Manager.MainFrame.Navigate(new AddEditPage(null, null, null, null, null, choosenTable));
        }

        private void BtnDel_Click(object sender, RoutedEventArgs e)
        {
            var StudentForRemoving = DGStudent.SelectedItems.Cast<Student>().ToList();
            var GroupForRemoving = DGGroup.SelectedItems.Cast<Group>().ToList();
            var FacultyForRemoving = DGFaculty.SelectedItems.Cast<Faculty>().ToList();
            var RUPStudentForRemoving = DGRup.SelectedItems.Cast<RUP>().ToList();
            var CourseForRemoving = DGCourse.SelectedItems.Cast<Course>().ToList();
            if(MessageBox.Show($"Вы точно хотите удалить эти элементы?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    CollegeNLEntities.GetContext().Student.RemoveRange(StudentForRemoving);
                    CollegeNLEntities.GetContext().Group.RemoveRange(GroupForRemoving);
                    CollegeNLEntities.GetContext().Faculty.RemoveRange(FacultyForRemoving);
                    CollegeNLEntities.GetContext().RUP.RemoveRange(RUPStudentForRemoving);
                    CollegeNLEntities.GetContext().Course.RemoveRange(CourseForRemoving);
                    CollegeNLEntities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");

                    DGStudent.ItemsSource = CollegeNLEntities.GetContext().Student.ToList();
                    DGGroup.ItemsSource = CollegeNLEntities.GetContext().Group.ToList();
                    DGRup.ItemsSource = CollegeNLEntities.GetContext().RUP.ToList();
                    DGFaculty.ItemsSource = CollegeNLEntities.GetContext().Faculty.ToList();
                    DGCourse.ItemsSource = CollegeNLEntities.GetContext().Course.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnEditGroup_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null, (sender as Button).DataContext as Group, null, null, null, choosenTable));
        }

        private void BtnEditStudent_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Student, null, null, null, null, choosenTable));
        }

        private void BtnEditRup_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null, null, null, null,(sender as Button).DataContext as RUP, choosenTable));
        }

        private void BtnEditCourse_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null,null,null,(sender as Button).DataContext as Course,null, choosenTable));
        }

        private void BtnEditFaculty_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null,null,(sender as Button).DataContext as Faculty,null,null, choosenTable));
        }
    }
}
