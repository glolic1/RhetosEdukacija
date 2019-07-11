// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Autofac.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Rhetos.Extensibility.Interfaces.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Rhetos.Utilities.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Rhetos.Security.Interfaces.dll
// Reference: C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.Composition\v4.0_4.0.0.0__b77a5c561934e089\System.ComponentModel.Composition.dll
// Reference: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Rhetos.Logging.Interfaces.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\EntityFramework.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\EntityFramework.SqlServer.dll
// Reference: C:\WINDOWS\Microsoft.Net\assembly\GAC_64\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll
// Reference: C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Rhetos.Persistence.Interfaces.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Plugins\Rhetos.Processing.DefaultCommands.Interfaces.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Rhetos.Processing.Interfaces.dll
// Reference: C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll
// Reference: C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\Microsoft.CSharp\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.CSharp.dll
// Reference: C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Data.DataSetExtensions\v4.0_4.0.0.0__b77a5c561934e089\System.Data.DataSetExtensions.dll
// Reference: C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll
// Reference: C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Xml.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.Linq.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Plugins\Rhetos.Dom.DefaultConcepts.Interfaces.dll
// Reference: C:\WINDOWS\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Generated\ServerDom.Model.dll
// CompilerOptions: "/optimize"

namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;
    using Autofac;
    /*CommonUsing*/

    public class EntityFrameworkContext : System.Data.Entity.DbContext, Rhetos.Persistence.IPersistenceCache
    {
        private readonly Rhetos.Utilities.IConfiguration _configuration;

        public EntityFrameworkContext(
            Rhetos.Persistence.IPersistenceTransaction persistenceTransaction,
            Rhetos.Dom.DefaultConcepts.Persistence.EntityFrameworkMetadata metadata,
            EntityFrameworkConfiguration entityFrameworkConfiguration, // EntityFrameworkConfiguration is provided as an IoC dependency for EntityFrameworkContext in order to initialize the global DbConfiguration before using DbContext.
            Rhetos.Utilities.IConfiguration configuration)
            : base(new System.Data.Entity.Core.EntityClient.EntityConnection(metadata.MetadataWorkspace, persistenceTransaction.Connection), false)
        {
            _configuration = configuration;
            Initialize();
            Database.UseTransaction(persistenceTransaction.Transaction);
        }

        /// <summary>
        /// This constructor is used at deployment-time to create slow EntityFrameworkContext instance before the metadata files are generated.
        /// The instance is used by EntityFrameworkGenerateMetadataFiles to generate the metadata files.
        /// </summary>
        protected EntityFrameworkContext(
            System.Data.Common.DbConnection connection,
            EntityFrameworkConfiguration entityFrameworkConfiguration, // EntityFrameworkConfiguration is provided as an IoC dependency for EntityFrameworkContext in order to initialize the global DbConfiguration before using DbContext.
            Rhetos.Utilities.IConfiguration configuration)
            : base(connection, true)
        {
            _configuration = configuration;
            Initialize();
        }

        private void Initialize()
        {
            System.Data.Entity.Database.SetInitializer<EntityFrameworkContext>(null); // Prevent EF from creating database objects.

            this.Configuration.UseDatabaseNullSemantics = _configuration.GetBool("EntityFramework.UseDatabaseNullSemantics", false).Value;
            /*EntityFrameworkContextInitialize*/

            this.Database.CommandTimeout = Rhetos.Utilities.SqlUtility.SqlCommandTimeout;
        }

        public void ClearCache()
        {
            SetDetaching(true);
            try
            {
                Configuration.AutoDetectChangesEnabled = false;
                var trackedItems = ChangeTracker.Entries().ToList();
                foreach (var item in trackedItems)
                    Entry(item.Entity).State = System.Data.Entity.EntityState.Detached;
                Configuration.AutoDetectChangesEnabled = true;
            }
            finally
            {
                SetDetaching(false);
            }
        }

        private void SetDetaching(bool detaching)
        {
            foreach (var item in ChangeTracker.Entries().Select(entry => entry.Entity).OfType<IDetachOverride>())
                item.Detaching = detaching;
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<global::Common.AutoCodeCache>();
            modelBuilder.Entity<Common.Queryable.Common_AutoCodeCache>().Map(m => { m.MapInheritedProperties(); m.ToTable("AutoCodeCache", "Common"); });
            modelBuilder.Ignore<global::Common.FilterId>();
            modelBuilder.Entity<Common.Queryable.Common_FilterId>().Map(m => { m.MapInheritedProperties(); m.ToTable("FilterId", "Common"); });
            modelBuilder.Ignore<global::Common.KeepSynchronizedMetadata>();
            modelBuilder.Entity<Common.Queryable.Common_KeepSynchronizedMetadata>().Map(m => { m.MapInheritedProperties(); m.ToTable("KeepSynchronizedMetadata", "Common"); });
            modelBuilder.Ignore<global::Common.ExclusiveLock>();
            modelBuilder.Entity<Common.Queryable.Common_ExclusiveLock>().Map(m => { m.MapInheritedProperties(); m.ToTable("ExclusiveLock", "Common"); });
            modelBuilder.Ignore<global::Common.LogReader>();
            modelBuilder.Entity<Common.Queryable.Common_LogReader>().Map(m => { m.MapInheritedProperties(); m.ToTable("LogReader", "Common"); });
            modelBuilder.Ignore<global::Common.LogRelatedItemReader>();
            modelBuilder.Entity<Common.Queryable.Common_LogRelatedItemReader>().Map(m => { m.MapInheritedProperties(); m.ToTable("LogRelatedItemReader", "Common"); });
            modelBuilder.Ignore<global::Common.Log>();
            modelBuilder.Entity<Common.Queryable.Common_Log>().Map(m => { m.MapInheritedProperties(); m.ToTable("Log", "Common"); });
            modelBuilder.Ignore<global::Common.LogRelatedItem>();
            modelBuilder.Entity<Common.Queryable.Common_LogRelatedItem>().Map(m => { m.MapInheritedProperties(); m.ToTable("LogRelatedItem", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_LogRelatedItem>()
                .HasOptional(t => t.Log).WithMany()
                .HasForeignKey(t => t.LogID);
            modelBuilder.Ignore<global::Common.RelatedEventsSource>();
            modelBuilder.Entity<Common.Queryable.Common_RelatedEventsSource>().Map(m => { m.MapInheritedProperties(); m.ToTable("RelatedEventsSource", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_RelatedEventsSource>()
                .HasOptional(t => t.Log).WithMany()
                .HasForeignKey(t => t.LogID);
            modelBuilder.Ignore<global::Common.Claim>();
            modelBuilder.Entity<Common.Queryable.Common_Claim>().Map(m => { m.MapInheritedProperties(); m.ToTable("Claim", "Common"); });
            modelBuilder.Ignore<global::Common.Principal>();
            modelBuilder.Entity<Common.Queryable.Common_Principal>().Map(m => { m.MapInheritedProperties(); m.ToTable("Principal", "Common"); });
            modelBuilder.Ignore<global::Common.PrincipalHasRole>();
            modelBuilder.Entity<Common.Queryable.Common_PrincipalHasRole>().Map(m => { m.MapInheritedProperties(); m.ToTable("PrincipalHasRole", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_PrincipalHasRole>()
                .HasOptional(t => t.Principal).WithMany()
                .HasForeignKey(t => t.PrincipalID);
            modelBuilder.Ignore<global::Common.Role>();
            modelBuilder.Entity<Common.Queryable.Common_Role>().Map(m => { m.MapInheritedProperties(); m.ToTable("Role", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_PrincipalHasRole>()
                .HasOptional(t => t.Role).WithMany()
                .HasForeignKey(t => t.RoleID);
            modelBuilder.Ignore<global::Common.RoleInheritsRole>();
            modelBuilder.Entity<Common.Queryable.Common_RoleInheritsRole>().Map(m => { m.MapInheritedProperties(); m.ToTable("RoleInheritsRole", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_RoleInheritsRole>()
                .HasOptional(t => t.UsersFrom).WithMany()
                .HasForeignKey(t => t.UsersFromID);
            modelBuilder.Entity<Common.Queryable.Common_RoleInheritsRole>()
                .HasOptional(t => t.PermissionsFrom).WithMany()
                .HasForeignKey(t => t.PermissionsFromID);
            modelBuilder.Ignore<global::Common.PrincipalPermission>();
            modelBuilder.Entity<Common.Queryable.Common_PrincipalPermission>().Map(m => { m.MapInheritedProperties(); m.ToTable("PrincipalPermission", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_PrincipalPermission>()
                .HasOptional(t => t.Principal).WithMany()
                .HasForeignKey(t => t.PrincipalID);
            modelBuilder.Entity<Common.Queryable.Common_PrincipalPermission>()
                .HasOptional(t => t.Claim).WithMany()
                .HasForeignKey(t => t.ClaimID);
            modelBuilder.Ignore<global::Common.RolePermission>();
            modelBuilder.Entity<Common.Queryable.Common_RolePermission>().Map(m => { m.MapInheritedProperties(); m.ToTable("RolePermission", "Common"); });
            modelBuilder.Entity<Common.Queryable.Common_RolePermission>()
                .HasOptional(t => t.Role).WithMany()
                .HasForeignKey(t => t.RoleID);
            modelBuilder.Entity<Common.Queryable.Common_RolePermission>()
                .HasOptional(t => t.Claim).WithMany()
                .HasForeignKey(t => t.ClaimID);
            modelBuilder.Ignore<global::Bookstore.Book>();
            modelBuilder.Entity<Common.Queryable.Bookstore_Book>().Map(m => { m.MapInheritedProperties(); m.ToTable("Book", "Bookstore"); });
            modelBuilder.Ignore<global::Bookstore.BooksThemes>();
            modelBuilder.Entity<Common.Queryable.Bookstore_BooksThemes>().Map(m => { m.MapInheritedProperties(); m.ToTable("BooksThemes", "Bookstore"); });
            modelBuilder.Entity<Common.Queryable.Bookstore_BooksThemes>().HasRequired(t => t.Base).WithOptional(t => t.Extension_BooksThemes);
            modelBuilder.Ignore<global::Bookstore.Person>();
            modelBuilder.Entity<Common.Queryable.Bookstore_Person>().Map(m => { m.MapInheritedProperties(); m.ToTable("Person", "Bookstore"); });
            modelBuilder.Entity<Common.Queryable.Bookstore_Book>()
                .HasOptional(t => t.Author).WithMany()
                .HasForeignKey(t => t.AuthorID);
            modelBuilder.Ignore<global::Bookstore.ChildBook>();
            modelBuilder.Entity<Common.Queryable.Bookstore_ChildBook>().Map(m => { m.MapInheritedProperties(); m.ToTable("ChildBook", "Bookstore"); });
            modelBuilder.Entity<Common.Queryable.Bookstore_ChildBook>().HasRequired(t => t.Base).WithOptional(t => t.Extension_ChildBook);
            modelBuilder.Ignore<global::Bookstore.ForeignBook>();
            modelBuilder.Entity<Common.Queryable.Bookstore_ForeignBook>().Map(m => { m.MapInheritedProperties(); m.ToTable("ForeignBook", "Bookstore"); });
            modelBuilder.Entity<Common.Queryable.Bookstore_ForeignBook>().HasRequired(t => t.Base).WithOptional(t => t.Extension_ForeignBook);
            modelBuilder.Entity<Common.Queryable.Bookstore_ForeignBook>()
                .HasOptional(t => t.Translator).WithMany()
                .HasForeignKey(t => t.TranslatorID);
            modelBuilder.Ignore<global::Bookstore.Theme>();
            modelBuilder.Entity<Common.Queryable.Bookstore_Theme>().Map(m => { m.MapInheritedProperties(); m.ToTable("Theme", "Bookstore"); });
            modelBuilder.Ignore<global::Bookstore.BookTheme>();
            modelBuilder.Entity<Common.Queryable.Bookstore_BookTheme>().Map(m => { m.MapInheritedProperties(); m.ToTable("BookTheme", "Bookstore"); });
            modelBuilder.Entity<Common.Queryable.Bookstore_BookTheme>()
                .HasOptional(t => t.Book).WithMany()
                .HasForeignKey(t => t.BookID);
            modelBuilder.Entity<Common.Queryable.Bookstore_BookTheme>()
                .HasOptional(t => t.Theme).WithMany()
                .HasForeignKey(t => t.ThemeID);
            modelBuilder.Ignore<global::Rezervacije.Soba>();
            modelBuilder.Entity<Common.Queryable.Rezervacije_Soba>().Map(m => { m.MapInheritedProperties(); m.ToTable("Soba", "Rezervacije"); });
            modelBuilder.Ignore<global::Rezervacije.TipSobe>();
            modelBuilder.Entity<Common.Queryable.Rezervacije_TipSobe>().Map(m => { m.MapInheritedProperties(); m.ToTable("TipSobe", "Rezervacije"); });
            modelBuilder.Entity<Common.Queryable.Rezervacije_Soba>()
                .HasOptional(t => t.TipSobeID).WithMany()
                .HasForeignKey(t => t.TipSobeIDID);
            modelBuilder.Entity<Common.Queryable.Rezervacije_TipSobe>().Property(t => t.Cijena).HasPrecision(28, 10);
            modelBuilder.Ignore<global::Rezervacije.Rezervacija>();
            modelBuilder.Entity<Common.Queryable.Rezervacije_Rezervacija>().Map(m => { m.MapInheritedProperties(); m.ToTable("Rezervacija", "Rezervacije"); });
            modelBuilder.Entity<Common.Queryable.Rezervacije_Rezervacija>()
                .HasOptional(t => t.SobaID).WithMany()
                .HasForeignKey(t => t.SobaIDID);
            modelBuilder.Ignore<global::Rezervacije.BrojRezervacijaPoSobi>();
            modelBuilder.Entity<Common.Queryable.Rezervacije_BrojRezervacijaPoSobi>().Map(m => { m.MapInheritedProperties(); m.ToTable("BrojRezervacijaPoSobi", "Rezervacije"); });
            modelBuilder.Entity<Common.Queryable.Rezervacije_BrojRezervacijaPoSobi>().HasRequired(t => t.Base).WithOptional(t => t.Extension_BrojRezervacijaPoSobi);
            modelBuilder.Ignore<global::Rezervacije.Hotel>();
            modelBuilder.Entity<Common.Queryable.Rezervacije_Hotel>().Map(m => { m.MapInheritedProperties(); m.ToTable("Hotel", "Rezervacije"); });
            modelBuilder.Entity<Common.Queryable.Rezervacije_Soba>()
                .HasOptional(t => t.Hotel).WithMany()
                .HasForeignKey(t => t.HotelID);
            modelBuilder.Ignore<global::Rezervacije.Gost>();
            modelBuilder.Entity<Common.Queryable.Rezervacije_Gost>().Map(m => { m.MapInheritedProperties(); m.ToTable("Gost", "Rezervacije"); });
            modelBuilder.Entity<Common.Queryable.Rezervacije_Rezervacija>()
                .HasOptional(t => t.GostID).WithMany()
                .HasForeignKey(t => t.GostIDID);
            modelBuilder.Ignore<global::Rezervacije.StraniGost>();
            modelBuilder.Entity<Common.Queryable.Rezervacije_StraniGost>().Map(m => { m.MapInheritedProperties(); m.ToTable("StraniGost", "Rezervacije"); });
            modelBuilder.Entity<Common.Queryable.Rezervacije_StraniGost>().HasRequired(t => t.Base).WithOptional(t => t.Extension_StraniGost);
            modelBuilder.Entity<Common.Queryable.Common_LogRelatedItemReader>()
                .HasOptional(t => t.Log).WithMany()
                .HasForeignKey(t => t.LogID);
            modelBuilder.Entity<Common.Queryable.Common_Claim>().Ignore(t => t.Extension_MyClaim);
            modelBuilder.Entity<Common.Queryable.Bookstore_Book>().Ignore(t => t.Extension_BookBrowse);
            modelBuilder.Entity<Common.Queryable.Rezervacije_Soba>().Ignore(t => t.Extension_BrowseSoba);
            /*EntityFrameworkOnModelCreating*/
        }

        public System.Data.Entity.DbSet<Common.Queryable.Common_AutoCodeCache> Common_AutoCodeCache { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_FilterId> Common_FilterId { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_KeepSynchronizedMetadata> Common_KeepSynchronizedMetadata { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_ExclusiveLock> Common_ExclusiveLock { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_LogReader> Common_LogReader { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_LogRelatedItemReader> Common_LogRelatedItemReader { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Log> Common_Log { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_LogRelatedItem> Common_LogRelatedItem { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_RelatedEventsSource> Common_RelatedEventsSource { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Claim> Common_Claim { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Principal> Common_Principal { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_PrincipalHasRole> Common_PrincipalHasRole { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_Role> Common_Role { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_RoleInheritsRole> Common_RoleInheritsRole { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_PrincipalPermission> Common_PrincipalPermission { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Common_RolePermission> Common_RolePermission { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Book> Bookstore_Book { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_BooksThemes> Bookstore_BooksThemes { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Person> Bookstore_Person { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_ChildBook> Bookstore_ChildBook { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_ForeignBook> Bookstore_ForeignBook { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_Theme> Bookstore_Theme { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Bookstore_BookTheme> Bookstore_BookTheme { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Rezervacije_Soba> Rezervacije_Soba { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Rezervacije_TipSobe> Rezervacije_TipSobe { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Rezervacije_Rezervacija> Rezervacije_Rezervacija { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Rezervacije_BrojRezervacijaPoSobi> Rezervacije_BrojRezervacijaPoSobi { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Rezervacije_Hotel> Rezervacije_Hotel { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Rezervacije_Gost> Rezervacije_Gost { get; set; }
        public System.Data.Entity.DbSet<Common.Queryable.Rezervacije_StraniGost> Rezervacije_StraniGost { get; set; }
        /*EntityFrameworkContextMembers*/
    }

    public class EntityFrameworkConfiguration : System.Data.Entity.DbConfiguration
    {
        public EntityFrameworkConfiguration()
        {
            SetProviderServices("System.Data.SqlClient", System.Data.Entity.SqlServer.SqlProviderServices.Instance);

            AddInterceptor(new Rhetos.Dom.DefaultConcepts.Persistence.FullTextSearchInterceptor());
            /*EntityFrameworkConfiguration*/

            System.Data.Entity.DbConfiguration.SetConfiguration(this);
        }
    }
}