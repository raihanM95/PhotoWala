using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhotoWala.DatabaseContext.DatabaseContext
{
    public class PhotoWalaDbContext : DbContext
    {
        public PhotoWalaDbContext(DbContextOptions<PhotoWalaDbContext> options)
            : base(options)
        {
        }
    }
}
