using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica
{
    public class Logica
    {
        public string vcpCodigoProducto = "", vcpTipoDePago;
        public double vcpCantidadProducto;
        public string mtdNombre()
        {
            string vNombreProducto = "";

            if (vcpCodigoProducto == "1") vNombreProducto = "Computadora";
            if (vcpCodigoProducto == "2") vNombreProducto = "Telefono";
            if (vcpCodigoProducto == "3") vNombreProducto = "Router";
            if (vcpCodigoProducto == "4") vNombreProducto = "Mouse";
            if (vcpCodigoProducto == "5") vNombreProducto = "Bocina";

            return vNombreProducto;
        }

        public double mtdRetornaPrecio()
        {
            double vPrecioProducto = 0; //declaracion de variable.

            if (vcpCodigoProducto == "1") vPrecioProducto = 10000;
            if (vcpCodigoProducto == "2") vPrecioProducto = 1500;
            if (vcpCodigoProducto == "3") vPrecioProducto = 500;
            if (vcpCodigoProducto == "4") vPrecioProducto = 50;
            if (vcpCodigoProducto == "5") vPrecioProducto = 100;

            return vPrecioProducto;
        }

        public DateTime mtdRecuperaFechaHoy()
        {
            DateTime vfechaHoy = DateTime.Today;
            return vfechaHoy;
        }
    }
}
