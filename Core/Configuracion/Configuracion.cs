using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Core.Configuracion
{
    public class Configuracion
    {
        public BDConexcion Defaults { get; set; }
    
    }

    public class BDConexcion
    {
        public string DBProvider { get; set; }
        public string ConexcionString { get; set; }
    }
}