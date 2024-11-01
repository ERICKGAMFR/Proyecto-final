using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocios
{
    public class CN_CLIENTE
    {
        private CD_CLIENTE objCD_CLIENTE = new CD_CLIENTE();
        public List<CLIENTE> Listar()
        {
            return objCD_CLIENTE.Listar();
        }

        public void ingresarcln(string nombre, int edad, string telefono, string telefono911, string correo, string domicilio, string colonia, int estadoId)
        {
            objCD_CLIENTE.ingresar_cliente(nombre, edad, telefono, telefono911, correo, domicilio, colonia, estadoId);
        }
    }
}
