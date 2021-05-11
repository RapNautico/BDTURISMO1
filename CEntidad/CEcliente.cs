using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidad
{
   public class CEcliente
    {
        private string id_cliente;
        private string cel_cliente;
        private string tip_seguro;
        private string nom_cliente;
        private string dr_cliente;
        private Byte activo;

        public string Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Cel_cliente { get => cel_cliente; set => cel_cliente = value; }
        public string Tip_seguro { get => tip_seguro; set => tip_seguro = value; }
        public string Nom_cliente { get => nom_cliente; set => nom_cliente = value; }
        public string Dr_cliente { get => dr_cliente; set => dr_cliente = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
