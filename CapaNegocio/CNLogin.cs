using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetFramework.Layers.ADO.Net;

namespace NetFramework.Layers.CapaDatos
{
    public class CNLogin
    {
        CDLogin objLogin = new CDLogin();
        public DataTable Verificar(String usuario, String password)
        {
            return objLogin.VerificarLogin(usuario, password); 
        }
    }
}
