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
            switch(choose)
            {
                case 1:
                    DGStudent.Visibility = Visibility.Visible;
                    break;
                case 2:
                    DGGroup.Visibility= Visibility.Visible;
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    DGRup.Visibility = Visibility.Visible;
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
    }
}
