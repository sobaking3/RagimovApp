﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RagimovApp.DataFolder
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBEntities : DbContext
    {
        public DBEntities()
            : base("name=DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cinema> Cinema { get; set; }
        public virtual DbSet<CinemaAdress> CinemaAdress { get; set; }
        public virtual DbSet<Films> Films { get; set; }
        public virtual DbSet<Halls> Halls { get; set; }
        public virtual DbSet<PlaceStatus> PlaceStatus { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<ScheduleOfFilms> ScheduleOfFilms { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tickets> Tickets { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<WorkerAdress> WorkerAdress { get; set; }
        public virtual DbSet<WorkerInfo> WorkerInfo { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CityWorker> CityWorker { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<RegionWorker> RegionWorker { get; set; }
        public virtual DbSet<Street> Street { get; set; }
        public virtual DbSet<StreetWorker> StreetWorker { get; set; }
    }
}
