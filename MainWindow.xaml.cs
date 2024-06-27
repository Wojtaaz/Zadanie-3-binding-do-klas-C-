using System.Windows;
using WpfApp.ViewModel;
using WpfApp.Model;

namespace WpfApp.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as FilmViewModel;
            var editWindow = new EditWindow();
            if (editWindow.ShowDialog() == true)
            {
                vm.Filmy.Add(editWindow.Film);
            }
        }

        private void Edytuj_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as FilmViewModel;
            if (FilmListBox.SelectedItem is Film selectedFilm)
            {
                var editWindow = new EditWindow(selectedFilm);
                if (editWindow.ShowDialog() == true)
                {
                    int index = vm.Filmy.IndexOf(selectedFilm);
                    vm.Filmy[index] = editWindow.Film;
                }
            }
        }

        private void Usun_Click(object sender, RoutedEventArgs e)
        {
            var vm = DataContext as FilmViewModel;
            if (FilmListBox.SelectedItem is Film selectedFilm)
            {
                vm.Filmy.Remove(selectedFilm);
            }
        }
    }
}
