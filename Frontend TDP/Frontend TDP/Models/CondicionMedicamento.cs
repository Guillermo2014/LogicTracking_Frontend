using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_TDP.Models
{
    public class CondicionMedicamento
    {

        public int idCondicionMedicamento { get; set; }
        public DateTime fechaCreacion { get; set; }
        public String variableMedicion { get; set; }
        public String unidadMedida { get; set; }
        public Double valorMedida { get; set; }
        //public Medicamento medicamento { get; set; }

    }
}
