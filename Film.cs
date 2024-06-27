using System;

namespace WpfApp.Model
{
    public class Film
    {
        public string Tytul { get; set; }
        public string Rezyser { get; set; }
        public string Studio { get; set; }
        public string Nosnik { get; set; }
        public TimeSpan Dlugosc { get; set; }
        public DateTime DataWydania { get; set; }
    }
}
