using System;

namespace libreria_RERS.Data.Models
{
    public class Books
    {
        public string Titulo { get; internal set; }
        public string Descripcion { get; internal set; }
        public bool IsRead { get; internal set; }
        public DateTime DateRead { get; internal set; }
        public int Rate { get; internal set; }
        public string Genero { get; internal set; }
        public string Autor { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public string CoverUrl { get; internal set; }
    }
}