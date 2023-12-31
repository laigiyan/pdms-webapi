﻿using PDMS.Core.DBManager;
using PDMS.Core.Extensions.AutofacManager;
using PDMS.Entity.SystemModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace PDMS.Core.EFDbContext
{
    public class ServiceDbContext : BaseDbContext, IDependency
    {
        protected override string ConnectionString
        {
            get
            {
                return DBServerProvider.ServiceConnectingString;
            }
        }
        public ServiceDbContext() : base() { }

        public ServiceDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.UseDbType(optionsBuilder, ConnectionString);
            //默认禁用实体跟踪
            optionsBuilder = optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder, typeof(ServiceEntity));
        }
    }
}
