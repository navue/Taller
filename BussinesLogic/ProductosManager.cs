using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BussinesLogic
{
    public class ProductoManager
    {
        public static int Guardar(Producto pProducto)
        {
            if (pProducto.Nombre != "")
            {
                return ProductosDAL.Guardar(pProducto);
            }
            else
            {
                return 0;
            }
        }
    }
}
