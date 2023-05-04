using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.EntcolumnaUnoades.Models
{
    public class Tabla
    {
        private object _columnaUno;
        private object _columnaDos;

        public object ColumnaUno
        {
            get => _columnaUno;
            set => _columnaUno = value;
        }

        public object ColumnaDos
        {
            get => _columnaDos;
            set => _columnaDos = value;
        }

        public Tabla(object columnaUno, object columnaDos)
        {
            _columnaUno = columnaUno;
            _columnaDos = columnaDos;
        }

    }
}
