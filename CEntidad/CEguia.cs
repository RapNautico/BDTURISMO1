using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidad
{
   public class CEguia
    {
        private string id_guia;
        private string cel_guia;
        private string nom_guia;
        private Byte activo;

        public string Id_guia { get => id_guia; set => id_guia = value; }
        public string Cel_guia { get => cel_guia; set => cel_guia = value; }
        public string Nom_guia { get => nom_guia; set => nom_guia = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
