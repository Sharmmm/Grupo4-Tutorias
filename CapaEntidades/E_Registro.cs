using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_Registro
    {
        private int _IdTutoria;
        private int _IdEstudiante;

        private string search;

        public int IdTutoria { get => _IdTutoria; set => _IdTutoria = value; }
        public int IdEstudiante { get => _IdEstudiante; set => _IdEstudiante = value; }
        public string Search { get => search; set => search = value; }
    }
}
