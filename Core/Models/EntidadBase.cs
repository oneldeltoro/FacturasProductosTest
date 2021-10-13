using System.Security.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Core.Models
{
    public abstract class EntidadBase
    {
        public int Id { get; private set; }

        public EntidadBase()
        {
        }

        public EntidadBase(int id)
        {
            Id = id;
        }
    }
}