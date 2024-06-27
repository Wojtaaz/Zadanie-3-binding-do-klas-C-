using System.Windows;
using WpfApp.Model;

namespace WpfApp.Views
{
    public partial class EditWindow : Window
    {
        public Film Film { get; set; }

        public EditWindow()
        {
            InitializeComponent();
            Film = new Film();
            DataContext = Film;
        }

        public EditWindow(Film film) : this()
        {
            Film = film;
            DataContext = Film;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
