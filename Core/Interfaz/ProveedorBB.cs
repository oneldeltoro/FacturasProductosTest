using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Core.Interfaz
{
    public interface ProveedorBB
    {
        public string GetDatabaseProvider();

        public string GetConnectionString();
    }
}