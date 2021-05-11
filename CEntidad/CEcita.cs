using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEntidad
{
    public class CEcita
    {
        private string id_guia;
        private string id_cliente;
        private string num_acompanantes;
        private string nom_cliente;
        private string nom_guia;
        private string destino;
        private string cel_guia;
        private string cel_cliente;
        private string dr_cliente;
        private string tip_seguro;
        private DateTime hora;
        private DateTime fecha;
        private int valor_persona;
        private int valor_total;
        private Byte activo;

        public string Id_guia { get => id_guia; set => id_guia = value; }
        public string Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Num_acompanantes { get => num_acompanantes; set => num_acompanantes = value; }
        public string Nom_cliente { get => nom_cliente; set => nom_cliente = value; }
        public string Nom_guia { get => nom_guia; set => nom_guia = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Cel_guia { get => cel_guia; set => cel_guia = value; }
        public string Cel_cliente { get => cel_cliente; set => cel_cliente = value; }
        public string Dr_cliente { get => dr_cliente; set => dr_cliente = value; }
        public string Tip_seguro { get => tip_seguro; set => tip_seguro = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Valor_persona { get => valor_persona; set => valor_persona = value; }
        public int Valor_total { get => valor_total; set => valor_total = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
