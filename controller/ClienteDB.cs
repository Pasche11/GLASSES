using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using domain;

namespace controller
{
    public class ClienteDB
    {
        public List<Cliente> listar()
        {
            //DECLARACIONES OBJ:
            List<Cliente> lista = new List<Cliente>();

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            try
            {
                //ESTABLECER CONEXION Y COMANDO:
                conn.ConnectionString = "server=.; database= CATALOGO_DB; integrated security= true;";
                cmd.CommandType= System.Data.CommandType.Text;
                cmd.CommandText = "SELECT Id, Descripcion from MARCAS";
                cmd.Connection = conn;

                //EJECUTAR CONEXION Y COMANDO:
                conn.Open();
                reader= cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente aux = new Cliente();
                    aux.Cuit = reader.GetString(0);
                    aux.RazonSocial = reader.GetString(1);
                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
