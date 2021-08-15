using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Tutoria
    {
        private int _IdTutoria;
        private int _IdDocente;
        private string _Horario;

        private string search;

        public int IdTutoria { get => _IdTutoria; set => _IdTutoria = value; }
        public int IdDocente { get => _IdDocente; set => _IdDocente = value; }
        public string Horario { get => _Horario; set => _Horario = value; }
        public string Search { get => search; set => search = value; }
    }
}
