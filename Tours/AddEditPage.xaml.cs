using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace Tours
{
    /// <summary>
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {
        private Hotel _currenthotel = new Hotel();

        public AddEditPage()
        {
            InitializeComponent();
            DataContext = _currenthotel;
            ComboCountries.ItemsSource = TourBase319Entities.GetContext().Country.ToList();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currenthotel.Name))
                errors.AppendLine("Укажите название отеля");
            if (_currenthotel.CountryOfStars < 1 || _currenthotel.CountryOfStars > 5)
                errors.AppendLine("Количество звезд - число от 1 до 5");
        }
    }
}
