using System;
using System.Collections.ObjectModel;
using WpfApp.Model;

namespace WpfApp.ViewModel
{
    public class FilmViewModel
    {
        public ObservableCollection<Film> Filmy { get; set; }

        public FilmViewModel()
        {
            Filmy = new ObservableCollection<Film>();
            // Dodaj przykładowe dane
            Filmy.Add(new Film
            {
                Tytul = "Film 1",
                Rezyser = "Rezyser 1",
                Studio = "Studio 1",
                Nosnik = "DVD",
                Dlugosc = new TimeSpan(1, 30, 0),
                DataWydania = DateTime.Now
            });
        }

        // Metody Dodaj, Edytuj, Usun
    }
}
