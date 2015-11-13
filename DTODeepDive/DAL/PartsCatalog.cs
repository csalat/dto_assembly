﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
// 
// Do not make changes directly to this file - edit the template instead.
// 
// The following connection settings were used to generate this file:
//     Configuration file:     "DTODeepDive\App.config"
//     Connection String Name: "PartsCatalog"
//     Connection String:      "Data Source=BSBZGV1\MSSQLSERVER2012;Initial Catalog=PartsCatalog;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise

// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace DtoDeepDive.Data.DAL
{
    // ************************************************************************
    // Unit of work
    public interface IPartsCatalogDbContext : IDisposable
    {
        DbSet<Component> Components { get; set; } // Component
        DbSet<LaborSequence> LaborSequences { get; set; } // LaborSequences
        DbSet<Part> Parts { get; set; } // Parts

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        
        // Stored Procedures
    }

    // ************************************************************************
    // Database context
    public class PartsCatalogDbContext : DbContext, IPartsCatalogDbContext
    {
        public DbSet<Component> Components { get; set; } // Component
        public DbSet<LaborSequence> LaborSequences { get; set; } // LaborSequences
        public DbSet<Part> Parts { get; set; } // Parts
        
        static PartsCatalogDbContext()
        {
            System.Data.Entity.Database.SetInitializer<PartsCatalogDbContext>(null);
        }

        public PartsCatalogDbContext()
            : base("Name=PartsCatalog")
        {
        }

        public PartsCatalogDbContext(string connectionString) : base(connectionString)
        {
        }

        public PartsCatalogDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ComponentConfiguration());
            modelBuilder.Configurations.Add(new LaborSequenceConfiguration());
            modelBuilder.Configurations.Add(new PartConfiguration());
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new ComponentConfiguration(schema));
            modelBuilder.Configurations.Add(new LaborSequenceConfiguration(schema));
            modelBuilder.Configurations.Add(new PartConfiguration(schema));
            return modelBuilder;
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake Database context
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.16.0.0")]
    public class FakePartsCatalogDbContext : IPartsCatalogDbContext
    {
        public DbSet<Component> Components { get; set; }
        public DbSet<LaborSequence> LaborSequences { get; set; }
        public DbSet<Part> Parts { get; set; }

        public FakePartsCatalogDbContext()
        {
            Components = new FakeDbSet<Component>();
            LaborSequences = new FakeDbSet<LaborSequence>();
            Parts = new FakeDbSet<Part>();
        }
        
        public int SaveChangesCount { get; private set; } 
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        protected virtual void Dispose(bool disposing)
        {
        }
        
        public void Dispose()
        {
            Dispose(true);
        }
        
        // Stored Procedures
    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.16.0.0")]
    public class FakeDbSet<TEntity> : DbSet<TEntity>, IQueryable, IEnumerable<TEntity>, IDbAsyncEnumerable<TEntity> 
        where TEntity : class 
    { 
        private readonly ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;
 
        public FakeDbSet() 
        { 
            _data = new ObservableCollection<TEntity>(); 
            _query = _data.AsQueryable(); 
        }

        public override IEnumerable<TEntity> AddRange(IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }
        
        public override TEntity Add(TEntity item) 
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Add(item); 
            return item; 
        } 
 
        public override TEntity Remove(TEntity item) 
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Remove(item); 
            return item; 
        } 
 
        public override TEntity Attach(TEntity item) 
        {
            if (item == null) throw new ArgumentNullException("item");
            _data.Add(item); 
            return item; 
        } 
 
        public override TEntity Create() 
        { 
            return Activator.CreateInstance<TEntity>(); 
        } 
 
        public override TDerivedEntity Create<TDerivedEntity>() 
        { 
            return Activator.CreateInstance<TDerivedEntity>(); 
        } 
 
        public override ObservableCollection<TEntity> Local 
        { 
            get { return _data; } 
        } 
 
        Type IQueryable.ElementType 
        { 
            get { return _query.ElementType; } 
        } 
 
        Expression IQueryable.Expression 
        { 
            get { return _query.Expression; } 
        } 
 
        IQueryProvider IQueryable.Provider 
        { 
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); } 
        } 
 
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() 
        { 
            return _data.GetEnumerator(); 
        } 
 
        IEnumerator<TEntity> IEnumerable<TEntity>.GetEnumerator() 
        { 
            return _data.GetEnumerator(); 
        } 
 
        IDbAsyncEnumerator<TEntity> IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator() 
        { 
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator()); 
        }
    } 
 
    public class FakeDbAsyncQueryProvider<TEntity> : IDbAsyncQueryProvider 
    { 
        private readonly IQueryProvider _inner; 
 
        public FakeDbAsyncQueryProvider(IQueryProvider inner) 
        { 
            _inner = inner; 
        } 
 
        public IQueryable CreateQuery(Expression expression) 
        { 
            return new FakeDbAsyncEnumerable<TEntity>(expression); 
        } 
 
        public IQueryable<TElement> CreateQuery<TElement>(Expression expression) 
        { 
            return new FakeDbAsyncEnumerable<TElement>(expression); 
        } 
 
        public object Execute(Expression expression) 
        { 
            return _inner.Execute(expression); 
        } 
 
        public TResult Execute<TResult>(Expression expression) 
        { 
            return _inner.Execute<TResult>(expression); 
        } 
 
        public System.Threading.Tasks.Task<object> ExecuteAsync(Expression expression, CancellationToken cancellationToken) 
        { 
            return System.Threading.Tasks.Task.FromResult(Execute(expression)); 
        } 
 
        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(Expression expression, CancellationToken cancellationToken) 
        { 
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression)); 
        } 
    } 
 
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, IDbAsyncEnumerable<T>, IQueryable<T> 
    { 
        public FakeDbAsyncEnumerable(IEnumerable<T> enumerable) 
            : base(enumerable) 
        { } 
 
        public FakeDbAsyncEnumerable(Expression expression) 
            : base(expression) 
        { } 
 
        public IDbAsyncEnumerator<T> GetAsyncEnumerator() 
        { 
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator()); 
        } 
 
        IDbAsyncEnumerator IDbAsyncEnumerable.GetAsyncEnumerator() 
        { 
            return GetAsyncEnumerator(); 
        } 
 
        IQueryProvider IQueryable.Provider 
        { 
            get { return new FakeDbAsyncQueryProvider<T>(this); } 
        } 
    } 
 
    public class FakeDbAsyncEnumerator<T> : IDbAsyncEnumerator<T> 
    { 
        private readonly IEnumerator<T> _inner; 
 
        public FakeDbAsyncEnumerator(IEnumerator<T> inner) 
        { 
            _inner = inner; 
        } 
 
        public void Dispose() 
        { 
            _inner.Dispose(); 
        } 
 
        public System.Threading.Tasks.Task<bool> MoveNextAsync(CancellationToken cancellationToken) 
        { 
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext()); 
        } 
 
        public T Current 
        { 
            get { return _inner.Current; } 
        } 
 
        object IDbAsyncEnumerator.Current 
        { 
            get { return Current; } 
        } 
    }

    // ************************************************************************
    // POCO classes

    // Component
    public class Component
    {
        public int Id { get; set; } // Id (Primary key)
        public string ComponentNumber { get; set; } // ComponentNumber
        public string ComponentDescription { get; set; } // ComponentDescription
        public string Material { get; set; } // Material
        public string UnitOfMeasure { get; set; } // UnitOfMeasure
        public int Type { get; set; } // Type
        public int ParentPartId { get; set; } // ParentPartId

        // Foreign keys
        public virtual Part Part { get; set; } // FK_dbo.Component_dbo.Parts_ParentPartId
    }

    // LaborSequences
    public class LaborSequence
    {
        public int Id { get; set; } // Id (Primary key)
        public string LaborSequenceNumber { get; set; } // LaborSequenceNumber
        public string LaborSequenceDesc { get; set; } // LaborSequenceDesc
        public decimal? RunTime { get; set; } // RunTime
        public decimal? Burden { get; set; } // Burden
        public decimal? LaborRate { get; set; } // LaborRate
        public string Facility { get; set; } // Facility
        public string Machine { get; set; } // Machine
        public int ParentPartId { get; set; } // ParentPartId

        // Foreign keys
        public virtual Part Part { get; set; } // FK_LaborSequences_ParentPartId
    }

    // Parts
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.16.0.0")]
    public class Part
    {
        public int Id { get; set; } // Id (Primary key)
        public string PartNumber { get; set; } // PartNumber
        public string Message { get; set; } // Message
        public string User { get; set; } // User
        public string SalesCode { get; set; } // SalesCode
        public string ExtendedDescription { get; set; } // ExtendedDescription
        public string Facility { get; set; } // Facility
        public string InventType { get; set; } // InventType
        public string ItemClass { get; set; } // ItemClass
        public string LeadTimeCode { get; set; } // LeadTimeCode
        public string MfgLeadTime { get; set; } // MfgLeadTime
        public string PartDescription { get; set; } // PartDescription
        public string PartNumberNoFacility { get; set; } // PartNumberNoFacility
        public string ProductType { get; set; } // ProductType
        public string UnitOfMeasure { get; set; } // UnitOfMeasure
        public string HiddenSpec { get; set; } // HiddenSpec
        public bool PriceIsRfq { get; set; } // PriceIsRfq
        public string DrawingNumber { get; set; } // DrawingNumber
        public string RevisionComments { get; set; } // RevisionComments
        public string CreatedBy { get; set; } // CreatedBy
        public DateTime? CreatedOn { get; set; } // CreatedOn
        public string EngineeringStatus { get; set; } // EngineeringStatus
        public string InventoryStatus { get; set; } // InventoryStatus
        public double TotalQuantityRequired { get; set; } // TotalQuantityRequired
        public double TotalSquareFootage { get; set; } // TotalSquareFootage
        public int BomLevel { get; set; } // BomLevel
        public double Cost { get; set; } // Cost
        public double BaseCost { get; set; } // BaseCost
        public double Qpa { get; set; } // Qpa
        public double BaseQpa { get; set; } // BaseQpa
        public double MarketCost { get; set; } // MarketCost
        public double BaseMarketCost { get; set; } // BaseMarketCost
        public double BatchSize { get; set; } // BatchSize
        public double TotalWeight { get; set; } // TotalWeight
        public bool CostError { get; set; } // CostError
        public string ParentNum { get; set; } // ParentNum
        public string ShopFloorNotes { get; set; } // ShopFloorNotes

        // Reverse navigation
        public virtual ICollection<Component> Components { get; set; } // Component.FK_dbo.Component_dbo.Parts_ParentPartId
        public virtual ICollection<LaborSequence> LaborSequences { get; set; } // LaborSequences.FK_LaborSequences_ParentPartId
        
        public Part()
        {
            Components = new List<Component>();
            LaborSequences = new List<LaborSequence>();
        }
    }


    // ************************************************************************
    // POCO Configuration

    // Component
    public class ComponentConfiguration : EntityTypeConfiguration<Component>
    {
        public ComponentConfiguration()
            : this("dbo")
        {
        }
 
        public ComponentConfiguration(string schema)
        {
            ToTable(schema + ".Component");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.ComponentNumber).HasColumnName("ComponentNumber").IsOptional().HasColumnType("nvarchar");
            Property(x => x.ComponentDescription).HasColumnName("ComponentDescription").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Material).HasColumnName("Material").IsOptional().HasColumnType("nvarchar");
            Property(x => x.UnitOfMeasure).HasColumnName("UnitOfMeasure").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Type).HasColumnName("Type").IsRequired().HasColumnType("int");
            Property(x => x.ParentPartId).HasColumnName("ParentPartId").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Part).WithMany(b => b.Components).HasForeignKey(c => c.ParentPartId); // FK_dbo.Component_dbo.Parts_ParentPartId
        }
    }

    // LaborSequences
    public class LaborSequenceConfiguration : EntityTypeConfiguration<LaborSequence>
    {
        public LaborSequenceConfiguration()
            : this("dbo")
        {
        }
 
        public LaborSequenceConfiguration(string schema)
        {
            ToTable(schema + ".LaborSequences");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(x => x.LaborSequenceNumber).HasColumnName("LaborSequenceNumber").IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.LaborSequenceDesc).HasColumnName("LaborSequenceDesc").IsOptional().HasColumnType("nvarchar");
            Property(x => x.RunTime).HasColumnName("RunTime").IsOptional().HasColumnType("decimal");
            Property(x => x.Burden).HasColumnName("Burden").IsOptional().HasColumnType("decimal");
            Property(x => x.LaborRate).HasColumnName("LaborRate").IsOptional().HasColumnType("decimal");
            Property(x => x.Facility).HasColumnName("Facility").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.Machine).HasColumnName("Machine").IsOptional().IsUnicode(false).HasColumnType("varchar").HasMaxLength(50);
            Property(x => x.ParentPartId).HasColumnName("ParentPartId").IsRequired().HasColumnType("int");

            // Foreign keys
            HasRequired(a => a.Part).WithMany(b => b.LaborSequences).HasForeignKey(c => c.ParentPartId); // FK_LaborSequences_ParentPartId
        }
    }

    // Parts
    public class PartConfiguration : EntityTypeConfiguration<Part>
    {
        public PartConfiguration()
            : this("dbo")
        {
        }
 
        public PartConfiguration(string schema)
        {
            ToTable(schema + ".Parts");
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName("Id").IsRequired().HasColumnType("int").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(x => x.PartNumber).HasColumnName("PartNumber").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Message).HasColumnName("Message").IsOptional().HasColumnType("nvarchar");
            Property(x => x.User).HasColumnName("User").IsOptional().HasColumnType("nvarchar");
            Property(x => x.SalesCode).HasColumnName("SalesCode").IsOptional().HasColumnType("nvarchar");
            Property(x => x.ExtendedDescription).HasColumnName("ExtendedDescription").IsOptional().HasColumnType("nvarchar");
            Property(x => x.Facility).HasColumnName("Facility").IsOptional().HasColumnType("nvarchar");
            Property(x => x.InventType).HasColumnName("InventType").IsOptional().HasColumnType("nvarchar");
            Property(x => x.ItemClass).HasColumnName("ItemClass").IsOptional().HasColumnType("nvarchar");
            Property(x => x.LeadTimeCode).HasColumnName("LeadTimeCode").IsOptional().HasColumnType("nvarchar");
            Property(x => x.MfgLeadTime).HasColumnName("MfgLeadTime").IsOptional().HasColumnType("nvarchar");
            Property(x => x.PartDescription).HasColumnName("PartDescription").IsOptional().HasColumnType("nvarchar");
            Property(x => x.PartNumberNoFacility).HasColumnName("PartNumberNoFacility").IsOptional().HasColumnType("nvarchar");
            Property(x => x.ProductType).HasColumnName("ProductType").IsOptional().HasColumnType("nvarchar");
            Property(x => x.UnitOfMeasure).HasColumnName("UnitOfMeasure").IsOptional().HasColumnType("nvarchar");
            Property(x => x.HiddenSpec).HasColumnName("HiddenSpec").IsOptional().HasColumnType("nvarchar");
            Property(x => x.PriceIsRfq).HasColumnName("PriceIsRfq").IsRequired().HasColumnType("bit");
            Property(x => x.DrawingNumber).HasColumnName("DrawingNumber").IsOptional().HasColumnType("nvarchar");
            Property(x => x.RevisionComments).HasColumnName("RevisionComments").IsOptional().HasColumnType("nvarchar");
            Property(x => x.CreatedBy).HasColumnName("CreatedBy").IsOptional().HasColumnType("nvarchar");
            Property(x => x.CreatedOn).HasColumnName("CreatedOn").IsOptional().HasColumnType("datetime");
            Property(x => x.EngineeringStatus).HasColumnName("EngineeringStatus").IsOptional().HasColumnType("nvarchar");
            Property(x => x.InventoryStatus).HasColumnName("InventoryStatus").IsOptional().HasColumnType("nvarchar");
            Property(x => x.TotalQuantityRequired).HasColumnName("TotalQuantityRequired").IsRequired().HasColumnType("float");
            Property(x => x.TotalSquareFootage).HasColumnName("TotalSquareFootage").IsRequired().HasColumnType("float");
            Property(x => x.BomLevel).HasColumnName("BomLevel").IsRequired().HasColumnType("int");
            Property(x => x.Cost).HasColumnName("Cost").IsRequired().HasColumnType("float");
            Property(x => x.BaseCost).HasColumnName("BaseCost").IsRequired().HasColumnType("float");
            Property(x => x.Qpa).HasColumnName("Qpa").IsRequired().HasColumnType("float");
            Property(x => x.BaseQpa).HasColumnName("BaseQpa").IsRequired().HasColumnType("float");
            Property(x => x.MarketCost).HasColumnName("MarketCost").IsRequired().HasColumnType("float");
            Property(x => x.BaseMarketCost).HasColumnName("BaseMarketCost").IsRequired().HasColumnType("float");
            Property(x => x.BatchSize).HasColumnName("BatchSize").IsRequired().HasColumnType("float");
            Property(x => x.TotalWeight).HasColumnName("TotalWeight").IsRequired().HasColumnType("float");
            Property(x => x.CostError).HasColumnName("CostError").IsRequired().HasColumnType("bit");
            Property(x => x.ParentNum).HasColumnName("ParentNum").IsOptional().HasColumnType("nvarchar");
            Property(x => x.ShopFloorNotes).HasColumnName("ShopFloorNotes").IsOptional().HasColumnType("nvarchar");
        }
    }


    // ************************************************************************
    // Stored procedure return models

}
// </auto-generated>
