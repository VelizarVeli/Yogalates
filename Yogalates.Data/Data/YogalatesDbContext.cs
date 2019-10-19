﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yogalates.Models;

namespace Yogalates.Data.Data
{
    public class YogalatesDbContext : IdentityDbContext<YogalatesUser>
    {
        public YogalatesDbContext(DbContextOptions<YogalatesDbContext> options)
            : base(options)
        {
        }
    }
}
