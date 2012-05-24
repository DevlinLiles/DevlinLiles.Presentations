using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using FrameworkExtension.Core;
using FrameworkExtension.Core.Contexts;
using FrameworkExtension.Core.Interfaces;
using Infrastructure.Mappings;
using Infrastructure.Properties;

namespace Infrastructure
{
    public class ShopContext : EFContext
    {
        public ShopContext() : base(Settings.Default.ShopConnection)
        {
            
        }

        public ShopContext(string connectionString)
            : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new WBSItemMap());
            modelBuilder.Configurations.Add(new ProjectMap());
            modelBuilder.Configurations.Add(new BuildingMap());
            modelBuilder.Configurations.Add(new FloorMap());
            modelBuilder.Configurations.Add(new ActivityMap());
        }

    }
}