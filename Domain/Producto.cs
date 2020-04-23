﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Precio { get; set; }
        public string Stock { get; set; }

        public Producto() { }

        public Producto(int pId, string pNombre, string pDescripcion, string pPrecio, string pStock)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.Precio = pPrecio;
            this.Stock = pStock;
        }

    }
}
