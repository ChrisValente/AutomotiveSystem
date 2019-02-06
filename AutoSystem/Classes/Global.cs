using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSystem.Classes
{
    //Classe global para transferir informações de um Form para o outro
    class Global
    {
        public static class GlobalUserStatus
        {
            private static string m_status = "";
            public static string Status
            {
                get { return m_status; }
                set { m_status = value; }
            }
        }
    }
}
