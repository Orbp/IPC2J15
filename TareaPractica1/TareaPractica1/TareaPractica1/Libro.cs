using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaPractica1
{
    class Libro
    {
        public int Id_Libro { get; set; }
        public string Nombre_libro { get; set; }
        public int Num_Existencias { get; set; }
        public int Num_Paginas { get; set; }
        public string Autor_libro { get; set; }
        public string Tema_libro { get; set; }
        public int Existencia_en_libreria { get; set; }
        public int Prestamos { get; set; }
        public int Reserva { get; set; }
    }
}
