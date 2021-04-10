using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend_TDP.Models
{
    public class Solicitud
    {
        public int idDespacho { get; set; }
        public DateTime fechaCreacion { get; set; }
        public DateTime fechaDespacho { get; set; }
        public string direccionEntrega { get; set; }
        public string observacion { get; set; }
        public int idSolicitante { get; set; }
        public int idRecepcionista { get; set; }
    }
}
