using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad.BL
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string password)
        {
            if (usuario == "admin" && password == "admin")
            {
                return true;
            }
            else
            {
                if (usuario == "user" && password == "user")
                {
                    return true;
                }
            }

            return false;

        }
    }
}
