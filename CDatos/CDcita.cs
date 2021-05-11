using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CEntidad;
using System.Data;
using System.Data.SqlClient;

namespace CDatos
{
    public class CDcita
    {
        Cconexion oconexion = new Cconexion();
        SqlCommand ocmd = new SqlCommand();

        public bool Guardar_cita(CEcita ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDTURISMO");
                ocmd.CommandText = "guardar1_cita";
                ocmd.Parameters.Add("@id_guia", ocitas.Id_guia);
                ocmd.Parameters.Add("@id_cliente", ocitas.Id_cliente);
                ocmd.Parameters.Add("@num_acompanantes", ocitas.Num_acompanantes);
                ocmd.Parameters.Add("@nom_cliente", ocitas.Nom_cliente);
                ocmd.Parameters.Add("@nom_guia", ocitas.Nom_guia);
                ocmd.Parameters.Add("@destino", ocitas.Destino);
                ocmd.Parameters.Add("@cel_guia", ocitas.Cel_guia);
                ocmd.Parameters.Add("@cel_cliente", ocitas.Cel_cliente);
                ocmd.Parameters.Add("@dr_cliente", ocitas.Dr_cliente);
                ocmd.Parameters.Add("@tip_seguro", ocitas.Tip_seguro);
                ocmd.Parameters.Add("@hora", ocitas.Hora);
                ocmd.Parameters.Add("@fecha", ocitas.Fecha);
                ocmd.Parameters.Add("@valor_persona", ocitas.Valor_persona);
                ocmd.Parameters.Add("@valor_total", ocitas.Valor_total);
                ocmd.Parameters.Add("@activo", ocitas.Activo);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool eliminar_cita(CEcita ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDTURISMO");
                ocmd.CommandText = "eliminar";
                ocmd.Parameters.Add("@id_guia", ocitas.Id_guia);
                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        public DataSet consultar_cita(CEcita ocitas)
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDTURISMO");
                ocmd.CommandText = "consultar_cita";
                ocmd.Parameters.Add("@id_guia", ocitas.Id_guia);
                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

    }
    
}
