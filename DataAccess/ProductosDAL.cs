using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DataAccess
{
    public class ProductosDAL
    {
        public static int Guardar(Producto pProducto)
        {
            if (pProducto.Id == 0) return Agregar(pProducto);
            else return Modificar(pProducto);
        }

        public static List<Producto> Buscar()
        {
            List<Producto> lista = new List<Producto>();

            SqlCommand comando = new SqlCommand("GetProductos", BDComun.ObtenerConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Producto pProducto = new Producto();
                pProducto.Id = reader.GetInt32(0);
                pProducto.Nombre = reader.GetString(1);
                pProducto.Descripcion = reader.GetString(2);
                pProducto.Precio = reader.GetString(3);
                pProducto.Stock = reader.GetString(4);


                lista.Add(pProducto);
            }

            return lista;
        }

        public static List<Producto> Buscar(string pNombre)
        {
            List<Producto> lista = new List<Producto>();

            SqlCommand comando = new SqlCommand("GetProductosNom", BDComun.ObtenerConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", pNombre);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Producto pProducto = new Producto();
                pProducto.Id = reader.GetInt32(0);
                pProducto.Nombre = reader.GetString(1);
                pProducto.Descripcion = reader.GetString(2);
                pProducto.Precio = reader.GetString(3);
                pProducto.Stock = reader.GetString(4);


                lista.Add(pProducto);
            }

            return lista;
        }
        public static int Agregar(Producto pProducto)
        {

            int retorno = 0;

            SqlCommand comando = new SqlCommand("AgregarProd", BDComun.ObtenerConexion());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pProducto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", pProducto.Precio);
            comando.Parameters.AddWithValue("@Stock", pProducto.Stock);
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static int Modificar(Producto pProducto)
        {
            int retorno = 0;
            SqlConnection conexion = BDComun.ObtenerConexion();

            SqlCommand comando = new SqlCommand("UpdateProd", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", pProducto.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", pProducto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", pProducto.Precio);
            comando.Parameters.AddWithValue("@Stock", pProducto.Stock);
            comando.Parameters.AddWithValue("@IdProducto", pProducto.Id);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int Eliminar(int pId)
        {
            int retorno = 0;
            SqlConnection conexion = BDComun.ObtenerConexion();

            SqlCommand comando = new SqlCommand("DeleteProd", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProducto", pId);
            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static Producto ObtenerProducto(int pId)
        {
            Producto pProducto = new Producto();
            SqlConnection conexion = BDComun.ObtenerConexion();

            SqlCommand comando = new SqlCommand("ObtenerProductos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@IdProducto", pId);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
              
                pProducto.Id = reader.GetInt32(0);
                pProducto.Nombre = reader.GetString(1);
                pProducto.Descripcion = reader.GetString(2);
                pProducto.Precio = reader.GetString(3);
                pProducto.Stock = reader.GetString(4);

            }

            conexion.Close();
            return pProducto;

        }
    }
}
