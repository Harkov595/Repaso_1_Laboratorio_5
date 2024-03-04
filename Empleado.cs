using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_1_Laboratorio_5
{
    class Empleado
    {
        int noEmpleado;
        string nombres;
        Decimal sueldoHora;
        public int NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public decimal SueldoHora { get => sueldoHora; set => sueldoHora = value; }
    }
}
