using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasarim_Bolumu.Areas.Admin.Identity
{
    public class SqlIdentityContext:IdentityDbContext<CustomUser>
    {
        public SqlIdentityContext(DbContextOptions<SqlIdentityContext> options) : base(options)
        {

        }
    }

}