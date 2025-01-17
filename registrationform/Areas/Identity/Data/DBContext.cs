﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using registrationform.Models;

namespace registrationform.Data;

public class DBContext : IdentityDbContext<IdentityUser>
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Service> service { get; set; }

    public DbSet<ApplicationUser> ApplicationUser { get; set; }

    public DbSet<Booking> Booking { get; set; }

    public DbSet<AuditModel> AuditModel { get; set; }

}
