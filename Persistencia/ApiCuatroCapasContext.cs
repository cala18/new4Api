using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class ApiCuatroCapasContext : DbContext
    {
        public ApiCuatroCapasContext(DbContextOptions options) : base(options)
        {
        }
    }
}