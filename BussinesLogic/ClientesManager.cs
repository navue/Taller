using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Domain;

namespace BussinesLogic
{
    public static class ClientesManager
    {
        public static int Guardar(Cliente pCliente)
        {
            DateTime fecha_nac = DateTime.Parse(pCliente.Fecha_Nac);
            if (fecha_nac <= DateTime.Now.Date)
            {
                return ClientesDAL.Guardar(pCliente);
            }
            else return 0;
        }
    }
}
