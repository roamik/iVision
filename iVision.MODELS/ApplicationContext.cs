using iVision.MODELS.Entities;
using iVision.MODELS.Entities.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace iVision.MODELS
{
    public class ApplicationContext : IdentityDbContext<User, Role, Guid>
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<MedicalCard> MedicalCards { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options){}
    }
}
