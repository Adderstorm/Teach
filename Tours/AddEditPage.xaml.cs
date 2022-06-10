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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        Student _currentStud = new Student();
        Group _currentgroup = new Group();
        Faculty _currentfaculty = new Faculty();
        Course _currentcourse = new Course();
        RUP _currentRUP = new RUP();
        int choosentable = 0;
        bool IsThisAdd = false;
        public AddEditPage(Student _choosenstud, Group _choosengroup, Faculty _choosenfaculty, Course _choosencourse, RUP _choosenrup, int choose)
        {
            InitializeComponent();
            choosentable = choose;
            if (_choosenstud != null)
            {
                Student1.Visibility = Visibility.Visible;
                _currentStud = _choosenstud;
            }
            else if (_choosenrup != null)
            {
                Rup1.Visibility = Visibility.Visible;
                _currentRUP = _choosenrup;
            }
            else if (_choosengroup != null)
            {
                Group1.Visibility = Visibility.Visible;
                _currentgroup = _choosengroup;
            }
            else if (_choosenfaculty != null)
            {
                Faculty1.Visibility = Visibility.Visible;
                _currentfaculty = _choosenfaculty;
            }
            else if (_choosencourse != null)
            {
                Course1.Visibility = Visibility.Visible;
                _currentcourse = _choosencourse;
            }
            else
            {
                switch (choose)
                {
                    case 1:
                        Student1.Visibility = Visibility.Visible;
                        break;
                    case 2:
                        Group1.Visibility = Visibility.Visible;
                        break;
                    case 3:
                        Faculty1.Visibility = Visibility.Visible;
                        break;
                    case 4:
                        Course1.Visibility = Visibility.Visible;
                        break;
                    case 5:
                        Rup1.Visibility = Visibility.Visible;
                        break;
                    default:
                        MessageBox.Show("Кажется произошла непредвиденная ошибка!");
                        break;
                }
                IsThisAdd = true;
            }
            switch(choosentable)
            {
                case 1:
                    DataContext = _currentStud;
                    break;
                case 2:
                    DataContext = _currentgroup;
                    break;
                case 3:
                    DataContext = _currentfaculty;
                    break;
                case 4:
                    DataContext = _currentcourse;
                    break;
                case 5:
                    DataContext = _currentRUP;
                    break;
            }
            if (IsThisAdd == false)
            {
                BtnSave.Visibility = Visibility.Visible;
                BtnAdd.Visibility = Visibility.Hidden;
            }
            else
            {
                BtnAdd.Visibility = Visibility.Visible;
                BtnSave.Visibility = Visibility.Hidden;
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            switch (choosentable)
            {
                case 1:
                    CollegeNLEntities.GetContext().UpdRup(tbRupName.Text, Convert.ToInt32(tbFacultyHour.Text), tbAttestationView.Text, Convert.ToInt32(tbRupTrainerID.Text), Convert.ToInt32(tbTerm), Convert.ToInt32(tbRupCourseID), Convert.ToInt32(tbRupFacultyID));
                    break;
                case 2:
                    CollegeNLEntities.GetContext().Group.Add(_currentgroup);
                    break;
                case 3:
                    CollegeNLEntities.GetContext().Faculty.Add(_currentfaculty);
                    break;
                case 4:
                    CollegeNLEntities.GetContext().Course.Add(_currentcourse);
                    break;
                case 5:
                    CollegeNLEntities.GetContext().RUP.Add(_currentRUP);
                    break;
            }
            try
            {
                CollegeNLEntities.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            switch (choosentable)
            {
                case 1:
                    CollegeNLEntities.GetContext().Student.Add(_currentStud);
                    break;
                case 2:
                    CollegeNLEntities.GetContext().Group.Add(_currentgroup);
                    break;
                case 3:
                    CollegeNLEntities.GetContext().Faculty.Add(_currentfaculty);
                    break;
                case 4:
                    CollegeNLEntities.GetContext().Course.Add(_currentcourse);
                    break;
                case 5:
                    CollegeNLEntities.GetContext().RUP.Add(_currentRUP);
                    break;
            }
            try
            {
                CollegeNLEntities.GetContext().SaveChanges();
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
