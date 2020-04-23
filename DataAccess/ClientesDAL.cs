using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccess
{
    public class ClientesDAL
    {
        public static int Guardar(Cliente pCliente)
        {
            if (pCliente.Id == 0) return Agregar(pCliente);
            else return Actualizar(pCliente);
        }

        public static List<Cliente> Buscar()
        {
            List<Cliente> lista = new List<Cliente>();

            SqlCommand comando = new SqlCommand("GetClientes", BDComun.ObtenerConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = reader.GetInt32(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Apellido = reader.GetString(2);
                pCliente.Fecha_Nac = reader.GetString(3);
                pCliente.Direccion = reader.GetString(4);


                lista.Add(pCliente);
            }

            return lista;
        }

        public static List<Cliente> Buscar(string pNombre, string pApellido)
        {
            List<Cliente> lista = new List<Cliente>();

            SqlCommand comando = new SqlCommand("GetClientesNyA", BDComun.ObtenerConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", pNombre);
            comando.Parameters.AddWithValue("@Apellido", pApellido);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.Id = reader.GetInt32(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Apellido = reader.GetString(2);
                pCliente.Fecha_Nac = reader.GetString(3);
                pCliente.Direccion = reader.GetString(4);


                lista.Add(pCliente);
            }

            return lista;
        }

        public static int Actualizar(Cliente pCliente)
        {
            int retorno = 0;
            SqlConnection conexion = BDComun.ObtenerConexion();

            SqlCommand comando = new SqlCommand("UpdateCli", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", pCliente.Apellido);
            comando.Parameters.AddWithValue("@Fecha_Nacimiento", pCliente.Fecha_Nac);
            comando.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
            comando.Parameters.AddWithValue("@IdCliente", pCliente.Id);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int Agregar(Cliente pCliente)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand("AgregarCli", BDComun.ObtenerConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", pCliente.Nombre);
            comando.Parameters.AddWithValue("@Apellido", pCliente.Apellido);
            comando.Parameters.AddWithValue("@Fecha_Nacimiento", pCliente.Fecha_Nac);
            comando.Parameters.AddWithValue("@Direccion", pCliente.Direccion);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static Cliente ObtenerCliente(int pId)
        {
            Cliente pCliente = new Cliente();

            SqlConnection conexion = BDComun.ObtenerConexion();
            SqlCommand comando = new SqlCommand("ObtenerCliente", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdCliente", pId);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                pCliente.Id = reader.GetInt32(0);
                pCliente.Nombre = reader.GetString(1);
                pCliente.Apellido = reader.GetString(2);
                pCliente.Fecha_Nac = reader.GetString(3);
                pCliente.Direccion = reader.GetString(4);

            }

            conexion.Close();
            return pCliente;

        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            SqlConnection conexion = BDComun.ObtenerConexion();

            SqlCommand comando = new SqlCommand("DeleteCli", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdCliente", pId);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
