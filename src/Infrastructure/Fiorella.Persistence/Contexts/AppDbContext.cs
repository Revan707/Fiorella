﻿using Microsoft.EntityFrameworkCore;

namespace Fiorella.Persistence.Contexts;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }
}
