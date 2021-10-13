using System.Security.Principal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class BaseEntity : EntidadID
    {
        public int Id { get; set; }

        public BaseEntity()
        {
        }

        public BaseEntity(int id)
        {
            Id = id;
        }
    }
}