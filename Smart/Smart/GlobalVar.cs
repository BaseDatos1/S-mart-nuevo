using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart
{
    public static class GlobalVar
    {
        static string cedulaUsuarioActual = "";
        static int idSucursalActual = 0;
        static string tipoUsuarioSistema= "";

        public static string CedulaUsuarioActual
        {
            get
            {
                return cedulaUsuarioActual;
            }
            set
            {
                cedulaUsuarioActual = value;
            }
        }

        public static int IdSucursalActual
        {
            get
            {
                return idSucursalActual;
            }
            set
            {
                idSucursalActual = value;
            }
        }

        public static string TipoUsuarioSistema
        {
            get
            {
                return tipoUsuarioSistema;
            }
            set
            {
                tipoUsuarioSistema = value;
            }
        }
    }
}
