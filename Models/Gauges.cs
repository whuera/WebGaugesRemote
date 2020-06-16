using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Gauges
    {

        public int id_proyectos { set; get; }
        public string nombre_proyecto { set; get; }
        public string codigo_proyecto { set; get; }
        public int id_indicadores { set; get; }
        public string nombre_indicador { set; get; }
        public int valor_indicador { set; get; }
        public string especificacion_indicador { set; get; }
        public string observacion_indicador { set; get; }


    }
}
