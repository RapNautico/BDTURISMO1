using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidad
{
   public class CEdestino
    {
        private int cod_destino;
        private string nom_destino;
        private DateTime hora;
        private DateTime fecha;
        private Byte activo;

        public int Cod_destino { get => cod_destino; set => cod_destino = value; }
        public string Nom_destino { get => nom_destino; set => nom_destino = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
