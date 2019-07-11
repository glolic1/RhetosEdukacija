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
// Reference: C:\Projects\Demo\dist\DemoRhetosServer\bin\Generated\ServerDom.Orm.dll
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

    public class DomRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public DomRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Bookstore._Helper._ModuleRepository _Bookstore;
        public Bookstore._Helper._ModuleRepository Bookstore { get { return _Bookstore ?? (_Bookstore = new Bookstore._Helper._ModuleRepository(_repositories)); } }

        private Rezervacije._Helper._ModuleRepository _Rezervacije;
        public Rezervacije._Helper._ModuleRepository Rezervacije { get { return _Rezervacije ?? (_Rezervacije = new Rezervacije._Helper._ModuleRepository(_repositories)); } }

        private Common._Helper._ModuleRepository _Common;
        public Common._Helper._ModuleRepository Common { get { return _Common ?? (_Common = new Common._Helper._ModuleRepository(_repositories)); } }

        /*CommonDomRepositoryMembers*/
    }

    public static class Infrastructure
    {
        public static readonly RegisteredInterfaceImplementations RegisteredInterfaceImplementationName = new RegisteredInterfaceImplementations
        {
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonFilterId), @"Common.FilterId" },
            { typeof(Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata), @"Common.KeepSynchronizedMetadata" },
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonClaim), @"Common.Claim" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipal), @"Common.Principal" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalHasRole), @"Common.PrincipalHasRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRole), @"Common.Role" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRoleInheritsRole), @"Common.RoleInheritsRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalPermission), @"Common.PrincipalPermission" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRolePermission), @"Common.RolePermission" },
            /*RegisteredInterfaceImplementationName*/
        };

        public static readonly ApplyFiltersOnClientRead ApplyFiltersOnClientRead = new ApplyFiltersOnClientRead
        {
            /*ApplyFiltersOnClientRead*/
        };

        public static readonly CurrentKeepSynchronizedMetadata CurrentKeepSynchronizedMetadata = new CurrentKeepSynchronizedMetadata
        {
            /*AddKeepSynchronizedMetadata*/
        };

        /*CommonInfrastructureMembers*/
    }

    public class ExecutionContext
    {
        protected Lazy<Rhetos.Persistence.IPersistenceTransaction> _persistenceTransaction;
        public Rhetos.Persistence.IPersistenceTransaction PersistenceTransaction { get { return _persistenceTransaction.Value; } }

        protected Lazy<Rhetos.Utilities.IUserInfo> _userInfo;
        public Rhetos.Utilities.IUserInfo UserInfo { get { return _userInfo.Value; } }

        protected Lazy<Rhetos.Utilities.ISqlExecuter> _sqlExecuter;
        public Rhetos.Utilities.ISqlExecuter SqlExecuter { get { return _sqlExecuter.Value; } }

        protected Lazy<Rhetos.Security.IAuthorizationManager> _authorizationManager;
        public Rhetos.Security.IAuthorizationManager AuthorizationManager { get { return _authorizationManager.Value; } }

        protected Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> _genericRepositories;
        public Rhetos.Dom.DefaultConcepts.GenericRepositories GenericRepositories { get { return _genericRepositories.Value; } }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>() where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>();
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>(string entityName) where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>(entityName);
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<IEntity> GenericRepository(string entityName)
        {
            return GenericRepositories.GetGenericRepository(entityName);
        }

        protected Lazy<Common.DomRepository> _repository;
        public Common.DomRepository Repository { get { return _repository.Value; } }

        public Rhetos.Logging.ILogProvider LogProvider { get; private set; }

        protected Lazy<Rhetos.Security.IWindowsSecurity> _windowsSecurity;
        public Rhetos.Security.IWindowsSecurity WindowsSecurity { get { return _windowsSecurity.Value; } }

        public EntityFrameworkContext EntityFrameworkContext { get; private set; }

        /*ExecutionContextMember*/

        // This constructor is used for automatic parameter injection with autofac.
        public ExecutionContext(
            Lazy<Rhetos.Persistence.IPersistenceTransaction> persistenceTransaction,
            Lazy<Rhetos.Utilities.IUserInfo> userInfo,
            Lazy<Rhetos.Utilities.ISqlExecuter> sqlExecuter,
            Lazy<Rhetos.Security.IAuthorizationManager> authorizationManager,
            Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> genericRepositories,
            Lazy<Common.DomRepository> repository,
            Rhetos.Logging.ILogProvider logProvider,
            Lazy<Rhetos.Security.IWindowsSecurity> windowsSecurity/*ExecutionContextConstructorArgument*/,
            EntityFrameworkContext entityFrameworkContext)
        {
            _persistenceTransaction = persistenceTransaction;
            _userInfo = userInfo;
            _sqlExecuter = sqlExecuter;
            _authorizationManager = authorizationManager;
            _genericRepositories = genericRepositories;
            _repository = repository;
            LogProvider = logProvider;
            _windowsSecurity = windowsSecurity;
            EntityFrameworkContext = entityFrameworkContext;
            /*ExecutionContextConstructorAssignment*/
        }

        // This constructor is used for manual context creation (unit testing)
        public ExecutionContext()
        {
        }
    }

    [System.ComponentModel.Composition.Export(typeof(Autofac.Module))]
    public class AutofacModuleConfiguration : Autofac.Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            builder.RegisterType<DomRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EntityFrameworkConfiguration>().SingleInstance();
            builder.RegisterType<EntityFrameworkContext>()
                .As<EntityFrameworkContext>()
                .As<System.Data.Entity.DbContext>()
                .As<Rhetos.Persistence.IPersistenceCache>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ExecutionContext>().InstancePerLifetimeScope();
            builder.RegisterInstance(Infrastructure.RegisteredInterfaceImplementationName).ExternallyOwned();
            builder.RegisterInstance(Infrastructure.ApplyFiltersOnClientRead).ExternallyOwned();
            builder.RegisterInstance(Infrastructure.CurrentKeepSynchronizedMetadata).ExternallyOwned();
            builder.RegisterType<Bookstore._Helper.Book_Repository>().Keyed<IRepository>("Bookstore.Book").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore._Helper.BookBrowse_Repository>().Keyed<IRepository>("Bookstore.BookBrowse").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore._Helper.BooksThemes_Repository>().Keyed<IRepository>("Bookstore.BooksThemes").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore._Helper.Person_Repository>().Keyed<IRepository>("Bookstore.Person").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore._Helper.ChildBook_Repository>().Keyed<IRepository>("Bookstore.ChildBook").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore._Helper.ForeignBook_Repository>().Keyed<IRepository>("Bookstore.ForeignBook").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore._Helper.Theme_Repository>().Keyed<IRepository>("Bookstore.Theme").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore._Helper.BookTheme_Repository>().Keyed<IRepository>("Bookstore.BookTheme").InstancePerLifetimeScope();
            builder.RegisterType<Rezervacije._Helper.Soba_Repository>().Keyed<IRepository>("Rezervacije.Soba").InstancePerLifetimeScope();
            builder.RegisterType<Rezervacije._Helper.TipSobe_Repository>().Keyed<IRepository>("Rezervacije.TipSobe").InstancePerLifetimeScope();
            builder.RegisterType<Rezervacije._Helper.Rezervacija_Repository>().Keyed<IRepository>("Rezervacije.Rezervacija").InstancePerLifetimeScope();
            builder.RegisterType<Rezervacije._Helper.BrojRezervacijaPoSobi_Repository>().Keyed<IRepository>("Rezervacije.BrojRezervacijaPoSobi").InstancePerLifetimeScope();
            builder.RegisterType<Rezervacije._Helper.BrowseSoba_Repository>().Keyed<IRepository>("Rezervacije.BrowseSoba").InstancePerLifetimeScope();
            builder.RegisterType<Rezervacije._Helper.Hotel_Repository>().Keyed<IRepository>("Rezervacije.Hotel").InstancePerLifetimeScope();
            builder.RegisterType<Rezervacije._Helper.Gost_Repository>().Keyed<IRepository>("Rezervacije.Gost").InstancePerLifetimeScope();
            builder.RegisterType<Rezervacije._Helper.StraniGost_Repository>().Keyed<IRepository>("Rezervacije.StraniGost").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AutoCodeCache_Repository>().Keyed<IRepository>("Common.AutoCodeCache").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.FilterId_Repository>().Keyed<IRepository>("Common.FilterId").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.KeepSynchronizedMetadata_Repository>().Keyed<IRepository>("Common.KeepSynchronizedMetadata").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ExclusiveLock_Repository>().Keyed<IRepository>("Common.ExclusiveLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.SetLock_Repository>().Keyed<IRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.SetLock_Repository>().Keyed<IActionRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ReleaseLock_Repository>().Keyed<IRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ReleaseLock_Repository>().Keyed<IActionRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogReader_Repository>().Keyed<IRepository>("Common.LogReader").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogRelatedItemReader_Repository>().Keyed<IRepository>("Common.LogRelatedItemReader").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Log_Repository>().Keyed<IRepository>("Common.Log").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AddToLog_Repository>().Keyed<IRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AddToLog_Repository>().Keyed<IActionRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogRelatedItem_Repository>().Keyed<IRepository>("Common.LogRelatedItem").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RelatedEventsSource_Repository>().Keyed<IRepository>("Common.RelatedEventsSource").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Claim_Repository>().Keyed<IRepository>("Common.Claim").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.MyClaim_Repository>().Keyed<IRepository>("Common.MyClaim").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Principal_Repository>().Keyed<IRepository>("Common.Principal").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalHasRole_Repository>().Keyed<IRepository>("Common.PrincipalHasRole").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Role_Repository>().Keyed<IRepository>("Common.Role").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RoleInheritsRole_Repository>().Keyed<IRepository>("Common.RoleInheritsRole").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalPermission_Repository>().Keyed<IRepository>("Common.PrincipalPermission").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RolePermission_Repository>().Keyed<IRepository>("Common.RolePermission").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.FilterId_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonFilterId>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.KeepSynchronizedMetadata_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Claim_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonClaim>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Principal_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipal>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalHasRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalHasRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Role_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RoleInheritsRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRoleInheritsRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalPermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalPermission>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RolePermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRolePermission>>().InstancePerLifetimeScope();
            /*CommonAutofacConfigurationMembers*/

            base.Load(builder);
        }
    }

    public abstract class RepositoryBase : IRepository
    {
        protected Common.DomRepository _domRepository;
        protected Common.ExecutionContext _executionContext;
    }

    public abstract class ReadableRepositoryBase<TEntity> : RepositoryBase, IReadableRepository<TEntity>
        where TEntity : class, IEntity
    {
        public IEnumerable<TEntity> Load(object parameter, Type parameterType)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Load(parameter, parameterType);
            return (IEnumerable<TEntity>)items;
        }

        public IEnumerable<TEntity> Read(object parameter, Type parameterType, bool preferQuery)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Read(parameter, parameterType, preferQuery);
            return (IEnumerable<TEntity>)items;
        }

        [Obsolete("Use Load() or Query() method.")]
        public abstract TEntity[] All();

        [Obsolete("Use Load() or Query() method.")]
        public TEntity[] Filter(FilterAll filterAll)
        {
            return All();
        }
    }

    public abstract class QueryableRepositoryBase<TQueryableEntity, TEntity> : ReadableRepositoryBase<TEntity>, IQueryableRepository<TQueryableEntity, TEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        [Obsolete("Use Load(identifiers) or Query(identifiers) method.")]
        public TEntity[] Filter(IEnumerable<Guid> identifiers)
        {
            const int BufferSize = 500; // EF 6.1.3 LINQ query has O(n^2) time complexity. Batch size of 500 results with optimal total time on the test system.
            int n = identifiers.Count();
            var result = new List<TEntity>(n);
            for (int i = 0; i < (n + BufferSize - 1) / BufferSize; i++)
            {
                Guid[] idBuffer = identifiers.Skip(i * BufferSize).Take(BufferSize).ToArray();
                List<TEntity> itemBuffer;
                if (idBuffer.Count() == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
                {
                    Guid id = idBuffer.Single();
                    itemBuffer = Query().Where(item => item.ID == id).GenericToSimple<TEntity>().ToList();
                }
                else
                    itemBuffer = Query().Where(item => idBuffer.Contains(item.ID)).GenericToSimple<TEntity>().ToList();
                result.AddRange(itemBuffer);
            }
            return result.ToArray();
        }

        public abstract IQueryable<TQueryableEntity> Query();

        // LINQ to Entity does not support Query() method in subqueries.
        public IQueryable<TQueryableEntity> Subquery { get { return Query(); } }

        public IQueryable<TQueryableEntity> Query(object parameter, Type parameterType)
        {
            var query = _executionContext.GenericRepository(typeof(TEntity).FullName).Query(parameter, parameterType);
            return (IQueryable<TQueryableEntity>)query;
        }
    }

    public abstract class OrmRepositoryBase<TQueryableEntity, TEntity> : QueryableRepositoryBase<TQueryableEntity, TEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        public IQueryable<TQueryableEntity> Filter(IQueryable<TQueryableEntity> items, IEnumerable<Guid> ids)
        {
            if (!(ids is System.Collections.IList))
                ids = ids.ToList();

            if (ids.Count() == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
            {
                Guid id = ids.Single();
                return items.Where(item => item.ID == id);
            }
            else
            {
                // Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
                var idsQuery = _domRepository.Common.FilterId.CreateQueryableFilterIds(ids);
                return items.Where(item => idsQuery.Contains(item.ID));
            }
        }
    }

    internal class DontTrackHistory<T> : List<T>
    {
    }
    /*CommonNamespaceMembers*/
}

namespace Bookstore._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Bookstore*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Book_Repository _Book_Repository;
        public Book_Repository Book { get { return _Book_Repository ?? (_Book_Repository = (Book_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Book")); } }

        private BookBrowse_Repository _BookBrowse_Repository;
        public BookBrowse_Repository BookBrowse { get { return _BookBrowse_Repository ?? (_BookBrowse_Repository = (BookBrowse_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.BookBrowse")); } }

        private BooksThemes_Repository _BooksThemes_Repository;
        public BooksThemes_Repository BooksThemes { get { return _BooksThemes_Repository ?? (_BooksThemes_Repository = (BooksThemes_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.BooksThemes")); } }

        private Person_Repository _Person_Repository;
        public Person_Repository Person { get { return _Person_Repository ?? (_Person_Repository = (Person_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Person")); } }

        private ChildBook_Repository _ChildBook_Repository;
        public ChildBook_Repository ChildBook { get { return _ChildBook_Repository ?? (_ChildBook_Repository = (ChildBook_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.ChildBook")); } }

        private ForeignBook_Repository _ForeignBook_Repository;
        public ForeignBook_Repository ForeignBook { get { return _ForeignBook_Repository ?? (_ForeignBook_Repository = (ForeignBook_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.ForeignBook")); } }

        private Theme_Repository _Theme_Repository;
        public Theme_Repository Theme { get { return _Theme_Repository ?? (_Theme_Repository = (Theme_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.Theme")); } }

        private BookTheme_Repository _BookTheme_Repository;
        public BookTheme_Repository BookTheme { get { return _BookTheme_Repository ?? (_BookTheme_Repository = (BookTheme_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Bookstore.BookTheme")); } }

        /*ModuleInfo RepositoryMembers Bookstore*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Book*/
    public class Book_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Book*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_Book, Bookstore.Book> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_Book, Bookstore.Book> // Common.ReadableRepositoryBase<Bookstore.Book> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.Book>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.Book*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Book*/

        public Book_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.Book*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Book*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Bookstore.Book[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Bookstore_Book> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Bookstore.Book*/
            return _executionContext.EntityFrameworkContext.Bookstore_Book.AsNoTracking();
        }

        public void Save(IEnumerable<Bookstore.Book> insertedNew, IEnumerable<Bookstore.Book> updatedNew, IEnumerable<Bookstore.Book> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.Book*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Code != null && newItem.Code.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Book.Code", "256" },
                        "DataStructure:Bookstore.Book,ID:" + invalidItem.ID.ToString() + ",Property:Code",
                        null);
            }
            if (checkUserPermissions)
            {
                var invalidItem = insertedNew.Where(newItem => newItem.Code != null).FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "Code", "Bookstore.Book" },
                        "DataStructure:Bookstore.Book,ID:" + invalidItem.ID + ",Property:Code",
                        null);
            
            }

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Title != null && newItem.Title.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Book.Title", "256" },
                        "DataStructure:Bookstore.Book,ID:" + invalidItem.ID.ToString() + ",Property:Title",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.Book*/

            
            {
                var defaultValueFunc_Code = Function<Bookstore.Book>.Create(item => "K+++");

                foreach (var _item in insertedNew)
                {
                    bool setDefaultValue_Code = _item.Code == null;
                    /*DataStructureInfo Item DefaultValuetValidation Bookstore.Book*/
                    if (setDefaultValue_Code)
                        _item.Code = defaultValueFunc_Code(_item);
                }
            }
            { 
                var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

                foreach (var newItem in insertedNew)
                    if(newItem.Created == null)
                        newItem.Created = now;
            }
            { // UkloniRazmakePriSpremanju
                foreach (var room in insertedNew.Concat(updatedNew))
                    room.Title = room.Title.Replace(" ", string.Empty);
            }

            /*DataStructureInfo WritableOrm Initialization Bookstore.Book*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Bookstore_Book> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_Book>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Bookstore_Book> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_Book>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            AutoCodeHelper.UpdateCodesWithoutCache(
                _executionContext.SqlExecuter, "Bookstore.Book", "Code",
                insertedNew.Select(item => AutoCodeItem.Create(item, item.Code/*AutoCodePropertyInfo Grouping Bookstore.Book.Code*/)).ToList(),
                (item, newCode) => item.Code = newCode/*AutoCodePropertyInfo GroupColumnMetadata Bookstore.Book.Code*/);

            if (checkUserPermissions)
            {
                var changes = updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem });
                foreach (var change in changes)
                    if (change.newItem.Code == null && change.oldItem.Code != null)
                        change.newItem.Code = change.oldItem.Code;
                var invalidItem = changes
                    .Where(change => change.newItem.Code != null && !change.newItem.Code.Equals(change.oldItem.Code) || change.newItem.Code == null && change.oldItem.Code != null)
                    .Select(change => change.newItem)
                    .FirstOrDefault();

                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "It is not allowed to directly enter {0} property of {1}.",
                        new[] { "Code", "Bookstore.Book" },
                        "DataStructure:Bookstore.Book,ID:" + invalidItem.ID + ",Property:Code",
                        null);
            
            }

            if (deletedIds.Count() > 0)
            {
                List<Bookstore.BookTheme> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Bookstore.BookTheme.Query()
                        .Where(child => child.BookID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Bookstore.BookTheme { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Bookstore.BookTheme.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Bookstore.ChildBook> childItems = _executionContext.Repository.Bookstore.ChildBook
                    .Query(deletedIds.Select(parent => parent.ID))
                    .Select(child => child.ID).ToList()
                    .Select(childId => new Bookstore.ChildBook { ID = childId }).ToList();

                if (childItems.Count() > 0)
                    _domRepository.Bookstore.ChildBook.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Bookstore.ForeignBook> childItems = _executionContext.Repository.Bookstore.ForeignBook
                    .Query(deletedIds.Select(parent => parent.ID))
                    .Select(child => child.ID).ToList()
                    .Select(childId => new Bookstore.ForeignBook { ID = childId }).ToList();

                if (childItems.Count() > 0)
                    _domRepository.Bookstore.ForeignBook.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.Book*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.Book*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Bookstore_Book.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Bookstore.Person", @"ID", @"FK_Book_Person_AuthorID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Book,Property:AuthorID,Referenced:Bookstore.Person";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.ChildBook", @"ID", @"FK_ChildBook_Book_ID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.ChildBook,Property:ID,Referenced:Bookstore.Book";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.ForeignBook", @"ID", @"FK_ForeignBook_Book_ID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.ForeignBook,Property:ID,Referenced:Bookstore.Book";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.BookTheme", @"BookID", @"FK_BookTheme_Book_BookID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTheme,Property:BookID,Referenced:Bookstore.Book";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Bookstore.Book", @"IX_Book_Code"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Book,Property:Code";
                /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.Book*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Bookstore.Book");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_Book> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.Book*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.Book*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.Book");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.Book*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new CommonMisspelling()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_CommonMisspelling(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new Bookstore.NumberOfPages_MinValueFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_NumberOfPages_MinValueFilter(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredCode()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredCode(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.Book*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_CommonMisspelling(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"It is not allowed to enter misspelled word ""curiousity"".";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"CommonMisspelling";
            /*InvalidDataInfo ErrorMetadata Bookstore.Book.CommonMisspelling*/
            /*InvalidDataInfo OverrideUserMessages Bookstore.Book.CommonMisspelling*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> localSource, Pretrazivanje localParameter)
        {
            Func<IQueryable<Common.Queryable.Bookstore_Book>, Common.DomRepository, Pretrazivanje/*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.Pretrazivanje*/, IQueryable<Common.Queryable.Bookstore_Book>> filterFunction =
            (query, repository, parameter) => 
        {
            if(parameter.MinBrojStranica != null)
                return query.Where(knjiga => knjiga.NumberOfPages >= parameter.MinBrojStranica);
            return query;
        };

            /*ComposableFilterByInfo BeforeFilter Bookstore.Book.Pretrazivanje*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.Pretrazivanje*/);
        }

        public global::Bookstore.Book[] Filter(Pretrazivanje2 filter_Parameter)
        {
            Func<Common.DomRepository, Pretrazivanje2/*FilterByInfo AdditionalParametersType Bookstore.Book.Pretrazivanje2*/, Bookstore.Book[]> filter_Function =
                (repository, parameter) =>
        {
            return repository.Bookstore.Book.Query().Where(k=>k.Title.Contains("test")).ToSimple().ToArray();
        };

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Bookstore.Book.Pretrazivanje2*/);
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> localSource, Bookstore.NumberOfPages_MinValueFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.Bookstore_Book>, Common.DomRepository, Bookstore.NumberOfPages_MinValueFilter/*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.NumberOfPages_MinValueFilter'*/, IQueryable<Common.Queryable.Bookstore_Book>> filterFunction =
            (items, repository, parameter) => { int limit = 5; return items.Where(item => item.NumberOfPages != null && item.NumberOfPages < limit); };

            /*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.NumberOfPages_MinValueFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.NumberOfPages_MinValueFilter'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_NumberOfPages_MinValueFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Minimum value of {0} is {1}.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"Bookstore.NumberOfPages_MinValueFilter";
            metadata[@"Property"] = @"NumberOfPages";
            /*InvalidDataInfo ErrorMetadata Bookstore.Book.'Bookstore.NumberOfPages_MinValueFilter'*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"NumberOfPages", @"5" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Bookstore.Book.'Bookstore.NumberOfPages_MinValueFilter'*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredCode(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredCode";
            metadata[@"Property"] = @"Code";
            /*InvalidDataInfo ErrorMetadata Bookstore.Book.SystemRequiredCode*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"ShortString Bookstore.Book.Code" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Bookstore.Book.SystemRequiredCode*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> localSource, Bookstore.ForeignBookAuthorNameStartsWithX localParameter)
        {
            Func<IQueryable<Common.Queryable.Bookstore_Book>, Common.DomRepository, Bookstore.ForeignBookAuthorNameStartsWithX/*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.ForeignBookAuthorNameStartsWithX'*/, IQueryable<Common.Queryable.Bookstore_Book>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Author.Name.StartsWith("X") && item.Extension_ForeignBook!= null);

            /*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.ForeignBookAuthorNameStartsWithX'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.ForeignBookAuthorNameStartsWithX'*/);
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> localSource, Bookstore.CommonMisspelling localParameter)
        {
            Func<IQueryable<Common.Queryable.Bookstore_Book>, Common.DomRepository, Bookstore.CommonMisspelling/*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.CommonMisspelling'*/, IQueryable<Common.Queryable.Bookstore_Book>> filterFunction =
            (source, repository, parameter) => source.Where(book => book.Title.Contains("curiousity"));

            /*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.CommonMisspelling'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.CommonMisspelling'*/);
        }

        public IQueryable<Common.Queryable.Bookstore_Book> Filter(IQueryable<Common.Queryable.Bookstore_Book> localSource, Bookstore.SystemRequiredCode localParameter)
        {
            Func<IQueryable<Common.Queryable.Bookstore_Book>, Common.DomRepository, Bookstore.SystemRequiredCode/*ComposableFilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.SystemRequiredCode'*/, IQueryable<Common.Queryable.Bookstore_Book>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Code == null);

            /*ComposableFilterByInfo BeforeFilter Bookstore.Book.'Bookstore.SystemRequiredCode'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.SystemRequiredCode'*/);
        }

        public global::Bookstore.Book[] Filter(Pretrazivanje filter_Parameter)
        {
            Func<Common.DomRepository, Pretrazivanje/*FilterByInfo AdditionalParametersType Bookstore.Book.Pretrazivanje*/, Bookstore.Book[]> filter_Function =
                (repository, parameter) => repository.Bookstore.Book.Filter(repository.Bookstore.Book.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Bookstore.Book.Pretrazivanje*/);
        }

        public global::Bookstore.Book[] Filter(Bookstore.NumberOfPages_MinValueFilter filter_Parameter)
        {
            Func<Common.DomRepository, Bookstore.NumberOfPages_MinValueFilter/*FilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.NumberOfPages_MinValueFilter'*/, Bookstore.Book[]> filter_Function =
                (repository, parameter) => repository.Bookstore.Book.Filter(repository.Bookstore.Book.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.NumberOfPages_MinValueFilter'*/);
        }

        public global::Bookstore.Book[] Filter(Bookstore.ForeignBookAuthorNameStartsWithX filter_Parameter)
        {
            Func<Common.DomRepository, Bookstore.ForeignBookAuthorNameStartsWithX/*FilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.ForeignBookAuthorNameStartsWithX'*/, Bookstore.Book[]> filter_Function =
                (repository, parameter) => repository.Bookstore.Book.Filter(repository.Bookstore.Book.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.ForeignBookAuthorNameStartsWithX'*/);
        }

        public global::Bookstore.Book[] Filter(Bookstore.CommonMisspelling filter_Parameter)
        {
            Func<Common.DomRepository, Bookstore.CommonMisspelling/*FilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.CommonMisspelling'*/, Bookstore.Book[]> filter_Function =
                (repository, parameter) => repository.Bookstore.Book.Filter(repository.Bookstore.Book.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.CommonMisspelling'*/);
        }

        public global::Bookstore.Book[] Filter(Bookstore.SystemRequiredCode filter_Parameter)
        {
            Func<Common.DomRepository, Bookstore.SystemRequiredCode/*FilterByInfo AdditionalParametersType Bookstore.Book.'Bookstore.SystemRequiredCode'*/, Bookstore.Book[]> filter_Function =
                (repository, parameter) => repository.Bookstore.Book.Filter(repository.Bookstore.Book.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Bookstore.Book.'Bookstore.SystemRequiredCode'*/);
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Book*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.BookBrowse*/
    public class BookBrowse_Repository : /*DataStructureInfo OverrideBaseType Bookstore.BookBrowse*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_BookBrowse, Bookstore.BookBrowse> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_BookBrowse, Bookstore.BookBrowse> // Common.ReadableRepositoryBase<Bookstore.BookBrowse> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Bookstore.BookBrowse*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.BookBrowse*/

        public BookBrowse_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Bookstore.BookBrowse*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.BookBrowse*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Bookstore.BookBrowse[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Bookstore_BookBrowse> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Bookstore.BookBrowse*/
            return Query(_domRepository.Bookstore.Book.Query());
        }

        public IQueryable<Common.Queryable.Bookstore_BookBrowse> Query(IQueryable<Common.Queryable.Bookstore_Book> source)
        {
            return source.Select(item => new Common.Queryable.Bookstore_BookBrowse
                {
                    ID = item.ID,
                    Base = item,
                    Title = item.Title,
                    AuthorName = item.Author.Name,
                    Extension_ChildBookAgeFrom = item.Extension_ChildBook.AgeFrom,
                    /*BrowseDataStructureInfo BrowseProperties Bookstore.BookBrowse*/
                });
        }

        /*DataStructureInfo RepositoryMembers Bookstore.BookBrowse*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.BooksThemes*/
    public class BooksThemes_Repository : /*DataStructureInfo OverrideBaseType Bookstore.BooksThemes*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_BooksThemes, Bookstore.BooksThemes> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_BooksThemes, Bookstore.BooksThemes> // Common.ReadableRepositoryBase<Bookstore.BooksThemes> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Bookstore.BooksThemes*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.BooksThemes*/

        public BooksThemes_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Bookstore.BooksThemes*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.BooksThemes*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Bookstore.BooksThemes[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Bookstore_BooksThemes> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Bookstore.BooksThemes*/
            return _executionContext.EntityFrameworkContext.Bookstore_BooksThemes.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Bookstore.BooksThemes*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Person*/
    public class Person_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Person*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_Person, Bookstore.Person> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_Person, Bookstore.Person> // Common.ReadableRepositoryBase<Bookstore.Person> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.Person>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.Person*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Person*/

        public Person_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.Person*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Person*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Bookstore.Person[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Bookstore_Person> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Bookstore.Person*/
            return _executionContext.EntityFrameworkContext.Bookstore_Person.AsNoTracking();
        }

        public void Save(IEnumerable<Bookstore.Person> insertedNew, IEnumerable<Bookstore.Person> updatedNew, IEnumerable<Bookstore.Person> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.Person*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Person.Name", "256" },
                        "DataStructure:Bookstore.Person,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.Person*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.Person*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Bookstore_Person> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_Person>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Bookstore_Person> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_Person>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.Person*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.Person*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Bookstore_Person.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.Book", @"AuthorID", @"FK_Book_Person_AuthorID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Book,Property:AuthorID,Referenced:Bookstore.Person";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.ForeignBook", @"TranslatorID", @"FK_ForeignBook_Person_TranslatorID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.ForeignBook,Property:TranslatorID,Referenced:Bookstore.Person";
                /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.Person*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Bookstore.Person");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_Person> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.Person*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.Person*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.Person");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.Person*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.Person*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Person*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.ChildBook*/
    public class ChildBook_Repository : /*DataStructureInfo OverrideBaseType Bookstore.ChildBook*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_ChildBook, Bookstore.ChildBook> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_ChildBook, Bookstore.ChildBook> // Common.ReadableRepositoryBase<Bookstore.ChildBook> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.ChildBook>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.ChildBook*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.ChildBook*/

        public ChildBook_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.ChildBook*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.ChildBook*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Bookstore.ChildBook[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Bookstore_ChildBook> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Bookstore.ChildBook*/
            return _executionContext.EntityFrameworkContext.Bookstore_ChildBook.AsNoTracking();
        }

        public void Save(IEnumerable<Bookstore.ChildBook> insertedNew, IEnumerable<Bookstore.ChildBook> updatedNew, IEnumerable<Bookstore.ChildBook> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.ChildBook*/

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.ChildBook*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.ChildBook*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Bookstore_ChildBook> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_ChildBook>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Bookstore_ChildBook> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_ChildBook>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.ChildBook*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.ChildBook*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Bookstore_ChildBook.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Bookstore.ChildBook*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Bookstore.ChildBook");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_ChildBook> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.ChildBook*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.ChildBook*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.ChildBook");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.ChildBook*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.ChildBook*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.ChildBook*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.ForeignBook*/
    public class ForeignBook_Repository : /*DataStructureInfo OverrideBaseType Bookstore.ForeignBook*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_ForeignBook, Bookstore.ForeignBook> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_ForeignBook, Bookstore.ForeignBook> // Common.ReadableRepositoryBase<Bookstore.ForeignBook> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.ForeignBook>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.ForeignBook*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.ForeignBook*/

        public ForeignBook_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.ForeignBook*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.ForeignBook*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Bookstore.ForeignBook[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Bookstore_ForeignBook> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Bookstore.ForeignBook*/
            return _executionContext.EntityFrameworkContext.Bookstore_ForeignBook.AsNoTracking();
        }

        public void Save(IEnumerable<Bookstore.ForeignBook> insertedNew, IEnumerable<Bookstore.ForeignBook> updatedNew, IEnumerable<Bookstore.ForeignBook> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.ForeignBook*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.OriginalLanguage != null && newItem.OriginalLanguage.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ForeignBook.OriginalLanguage", "256" },
                        "DataStructure:Bookstore.ForeignBook,ID:" + invalidItem.ID.ToString() + ",Property:OriginalLanguage",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.ForeignBook*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.ForeignBook*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Bookstore_ForeignBook> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_ForeignBook>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Bookstore_ForeignBook> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_ForeignBook>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.ForeignBook*/

            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.ForeignBook*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Bookstore_ForeignBook.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Bookstore.Person", @"ID", @"FK_ForeignBook_Person_TranslatorID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.ForeignBook,Property:TranslatorID,Referenced:Bookstore.Person";
                /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.ForeignBook*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Bookstore.ForeignBook");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_ForeignBook> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.ForeignBook*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.ForeignBook*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.ForeignBook");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.ForeignBook*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.ForeignBook*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.ForeignBook*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.Theme*/
    public class Theme_Repository : /*DataStructureInfo OverrideBaseType Bookstore.Theme*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_Theme, Bookstore.Theme> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_Theme, Bookstore.Theme> // Common.ReadableRepositoryBase<Bookstore.Theme> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.Theme>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.Theme*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.Theme*/

        public Theme_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.Theme*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.Theme*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Bookstore.Theme[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Bookstore_Theme> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Bookstore.Theme*/
            return _executionContext.EntityFrameworkContext.Bookstore_Theme.AsNoTracking();
        }

        public void Save(IEnumerable<Bookstore.Theme> insertedNew, IEnumerable<Bookstore.Theme> updatedNew, IEnumerable<Bookstore.Theme> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.Theme*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Theme.Name", "256" },
                        "DataStructure:Bookstore.Theme,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.Theme*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.Theme*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Bookstore_Theme> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_Theme>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Bookstore_Theme> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_Theme>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.Theme*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Bookstore.Theme.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Bookstore.Theme", "Name" },
                        "DataStructure:Bookstore.Theme,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.Theme*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Bookstore_Theme.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Bookstore.BookTheme", @"ThemeID", @"FK_BookTheme_Theme_ThemeID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTheme,Property:ThemeID,Referenced:Bookstore.Theme";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Bookstore.Theme", @"IX_Theme_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.Theme,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.Theme*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Bookstore.Theme");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_Theme> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.Theme*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.Theme*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.Theme");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.Theme*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.Theme*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Bookstore.Theme*/
    }

    /*DataStructureInfo RepositoryAttributes Bookstore.BookTheme*/
    public class BookTheme_Repository : /*DataStructureInfo OverrideBaseType Bookstore.BookTheme*/ Common.OrmRepositoryBase<Common.Queryable.Bookstore_BookTheme, Bookstore.BookTheme> // Common.QueryableRepositoryBase<Common.Queryable.Bookstore_BookTheme, Bookstore.BookTheme> // Common.ReadableRepositoryBase<Bookstore.BookTheme> // global::Common.RepositoryBase
        , IWritableRepository<Bookstore.BookTheme>, IValidateRepository/*DataStructureInfo RepositoryInterface Bookstore.BookTheme*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Bookstore.BookTheme*/

        public BookTheme_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Bookstore.BookTheme*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Bookstore.BookTheme*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Bookstore.BookTheme[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Bookstore_BookTheme> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Bookstore.BookTheme*/
            return _executionContext.EntityFrameworkContext.Bookstore_BookTheme.AsNoTracking();
        }

        public void Save(IEnumerable<Bookstore.BookTheme> insertedNew, IEnumerable<Bookstore.BookTheme> updatedNew, IEnumerable<Bookstore.BookTheme> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Bookstore.BookTheme*/

            /*DataStructureInfo WritableOrm ArgumentValidation Bookstore.BookTheme*/

            /*DataStructureInfo WritableOrm Initialization Bookstore.BookTheme*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Bookstore_BookTheme> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_BookTheme>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Bookstore_BookTheme> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Bookstore_BookTheme>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Bookstore.BookTheme*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ThemeID == null /*RequiredPropertyInfo OrCondition Bookstore.BookTheme.Theme*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Bookstore.BookTheme", "Theme" },
                        "DataStructure:Bookstore.BookTheme,ID:" + invalid.ID.ToString() + ",Property:ThemeID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Bookstore.BookTheme*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Bookstore_BookTheme.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Bookstore.Book", @"ID", @"FK_BookTheme_Book_BookID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTheme,Property:BookID,Referenced:Bookstore.Book";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Bookstore.Theme", @"ID", @"FK_BookTheme_Theme_ThemeID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTheme,Property:ThemeID,Referenced:Bookstore.Theme";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Bookstore.BookTheme", @"IX_BookTheme_Book_Theme"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Bookstore.BookTheme,Property:Book Theme";
                /*DataStructureInfo WritableOrm OnDatabaseError Bookstore.BookTheme*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Bookstore.BookTheme");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Bookstore_BookTheme> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Bookstore.BookTheme*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Bookstore.BookTheme*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Bookstore.BookTheme");

                /*DataStructureInfo WritableOrm AfterSave Bookstore.BookTheme*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredBook()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredBook(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Bookstore.BookTheme*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredBook(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredBook";
            metadata[@"Property"] = @"Book";
            /*InvalidDataInfo ErrorMetadata Bookstore.BookTheme.SystemRequiredBook*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Bookstore.BookTheme.Book" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Bookstore.BookTheme.SystemRequiredBook*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Bookstore_BookTheme> Filter(IQueryable<Common.Queryable.Bookstore_BookTheme> localSource, Bookstore.SystemRequiredBook localParameter)
        {
            Func<IQueryable<Common.Queryable.Bookstore_BookTheme>, Common.DomRepository, Bookstore.SystemRequiredBook/*ComposableFilterByInfo AdditionalParametersType Bookstore.BookTheme.'Bookstore.SystemRequiredBook'*/, IQueryable<Common.Queryable.Bookstore_BookTheme>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Book == null);

            /*ComposableFilterByInfo BeforeFilter Bookstore.BookTheme.'Bookstore.SystemRequiredBook'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Bookstore.BookTheme.'Bookstore.SystemRequiredBook'*/);
        }

        public global::Bookstore.BookTheme[] Filter(Bookstore.SystemRequiredBook filter_Parameter)
        {
            Func<Common.DomRepository, Bookstore.SystemRequiredBook/*FilterByInfo AdditionalParametersType Bookstore.BookTheme.'Bookstore.SystemRequiredBook'*/, Bookstore.BookTheme[]> filter_Function =
                (repository, parameter) => repository.Bookstore.BookTheme.Filter(repository.Bookstore.BookTheme.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Bookstore.BookTheme.'Bookstore.SystemRequiredBook'*/);
        }

        /*DataStructureInfo RepositoryMembers Bookstore.BookTheme*/
    }

    /*ModuleInfo HelperNamespaceMembers Bookstore*/
}

namespace Rezervacije._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Rezervacije*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Soba_Repository _Soba_Repository;
        public Soba_Repository Soba { get { return _Soba_Repository ?? (_Soba_Repository = (Soba_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Rezervacije.Soba")); } }

        private TipSobe_Repository _TipSobe_Repository;
        public TipSobe_Repository TipSobe { get { return _TipSobe_Repository ?? (_TipSobe_Repository = (TipSobe_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Rezervacije.TipSobe")); } }

        private Rezervacija_Repository _Rezervacija_Repository;
        public Rezervacija_Repository Rezervacija { get { return _Rezervacija_Repository ?? (_Rezervacija_Repository = (Rezervacija_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Rezervacije.Rezervacija")); } }

        private BrojRezervacijaPoSobi_Repository _BrojRezervacijaPoSobi_Repository;
        public BrojRezervacijaPoSobi_Repository BrojRezervacijaPoSobi { get { return _BrojRezervacijaPoSobi_Repository ?? (_BrojRezervacijaPoSobi_Repository = (BrojRezervacijaPoSobi_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Rezervacije.BrojRezervacijaPoSobi")); } }

        private BrowseSoba_Repository _BrowseSoba_Repository;
        public BrowseSoba_Repository BrowseSoba { get { return _BrowseSoba_Repository ?? (_BrowseSoba_Repository = (BrowseSoba_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Rezervacije.BrowseSoba")); } }

        private Hotel_Repository _Hotel_Repository;
        public Hotel_Repository Hotel { get { return _Hotel_Repository ?? (_Hotel_Repository = (Hotel_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Rezervacije.Hotel")); } }

        private Gost_Repository _Gost_Repository;
        public Gost_Repository Gost { get { return _Gost_Repository ?? (_Gost_Repository = (Gost_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Rezervacije.Gost")); } }

        private StraniGost_Repository _StraniGost_Repository;
        public StraniGost_Repository StraniGost { get { return _StraniGost_Repository ?? (_StraniGost_Repository = (StraniGost_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Rezervacije.StraniGost")); } }

        /*ModuleInfo RepositoryMembers Rezervacije*/
    }

    /*DataStructureInfo RepositoryAttributes Rezervacije.Soba*/
    public class Soba_Repository : /*DataStructureInfo OverrideBaseType Rezervacije.Soba*/ Common.OrmRepositoryBase<Common.Queryable.Rezervacije_Soba, Rezervacije.Soba> // Common.QueryableRepositoryBase<Common.Queryable.Rezervacije_Soba, Rezervacije.Soba> // Common.ReadableRepositoryBase<Rezervacije.Soba> // global::Common.RepositoryBase
        , IWritableRepository<Rezervacije.Soba>, IValidateRepository/*DataStructureInfo RepositoryInterface Rezervacije.Soba*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Rezervacije.Soba*/

        public Soba_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Rezervacije.Soba*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Rezervacije.Soba*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Rezervacije.Soba[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Rezervacije_Soba> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Rezervacije.Soba*/
            return _executionContext.EntityFrameworkContext.Rezervacije_Soba.AsNoTracking();
        }

        public void Save(IEnumerable<Rezervacije.Soba> insertedNew, IEnumerable<Rezervacije.Soba> updatedNew, IEnumerable<Rezervacije.Soba> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Rezervacije.Soba*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Ime != null && newItem.Ime.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Soba.Ime", "256" },
                        "DataStructure:Rezervacije.Soba,ID:" + invalidItem.ID.ToString() + ",Property:Ime",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Rezervacije.Soba*/

            { // UkloniRazmakePriSpremanju
                foreach (var room in insertedNew.Concat(updatedNew))
                    room.Ime = room.Ime.Replace(" ", string.Empty);
            }

            /*DataStructureInfo WritableOrm Initialization Rezervacije.Soba*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Rezervacije_Soba> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_Soba>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Rezervacije_Soba> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_Soba>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Rezervacije.Soba*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Ime == null || string.IsNullOrWhiteSpace(item.Ime) /*RequiredPropertyInfo OrCondition Rezervacije.Soba.Ime*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Rezervacije.Soba", "Ime" },
                        "DataStructure:Rezervacije.Soba,ID:" + invalid.ID.ToString() + ",Property:Ime", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Rezervacije.Soba*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Rezervacije_Soba.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Rezervacije.TipSobe", @"ID", @"FK_Soba_TipSobe_TipSobeIDID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.Soba,Property:TipSobeIDID,Referenced:Rezervacije.TipSobe";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Rezervacije.Rezervacija", @"SobaIDID", @"FK_Rezervacija_Soba_SobaIDID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.Rezervacija,Property:SobaIDID,Referenced:Rezervacije.Soba";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Rezervacije.Hotel", @"ID", @"FK_Soba_Hotel_HotelID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.Soba,Property:HotelID,Referenced:Rezervacije.Hotel";
                /*DataStructureInfo WritableOrm OnDatabaseError Rezervacije.Soba*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Rezervacije.Soba");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Rezervacije_Soba> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Rezervacije.Soba*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Rezervacije.Soba*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Rezervacije.Soba");

                /*DataStructureInfo WritableOrm AfterSave Rezervacije.Soba*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new CommonMisspelling()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_CommonMisspelling(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Rezervacije.Soba*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_CommonMisspelling(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Ne moĹľete unijeti krivo napisano ime sobe ""dvosbna"".";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"CommonMisspelling";
            /*InvalidDataInfo ErrorMetadata Rezervacije.Soba.CommonMisspelling*/
            /*InvalidDataInfo OverrideUserMessages Rezervacije.Soba.CommonMisspelling*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public global::Rezervacije.Soba[] Filter(PretrazivanjeSobe filter_Parameter)
        {
            Func<Common.DomRepository, PretrazivanjeSobe/*FilterByInfo AdditionalParametersType Rezervacije.Soba.PretrazivanjeSobe*/, Rezervacije.Soba[]> filter_Function =
                (repository, parameter) =>
        {
            return repository.Rezervacije.Soba.Query().Where(s=>s.Ime.Contains("Pet")).ToSimple().ToArray();
        };

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Rezervacije.Soba.PretrazivanjeSobe*/);
        }

        public IQueryable<Common.Queryable.Rezervacije_Soba> Filter(IQueryable<Common.Queryable.Rezervacije_Soba> localSource, Rezervacije.CommonMisspelling localParameter)
        {
            Func<IQueryable<Common.Queryable.Rezervacije_Soba>, Common.DomRepository, Rezervacije.CommonMisspelling/*ComposableFilterByInfo AdditionalParametersType Rezervacije.Soba.'Rezervacije.CommonMisspelling'*/, IQueryable<Common.Queryable.Rezervacije_Soba>> filterFunction =
            (source, repository, parameter) => source.Where(soba => soba.Ime.Contains("dvosbna"));

            /*ComposableFilterByInfo BeforeFilter Rezervacije.Soba.'Rezervacije.CommonMisspelling'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Rezervacije.Soba.'Rezervacije.CommonMisspelling'*/);
        }

        public global::Rezervacije.Soba[] Filter(Rezervacije.CommonMisspelling filter_Parameter)
        {
            Func<Common.DomRepository, Rezervacije.CommonMisspelling/*FilterByInfo AdditionalParametersType Rezervacije.Soba.'Rezervacije.CommonMisspelling'*/, Rezervacije.Soba[]> filter_Function =
                (repository, parameter) => repository.Rezervacije.Soba.Filter(repository.Rezervacije.Soba.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Rezervacije.Soba.'Rezervacije.CommonMisspelling'*/);
        }

        /*DataStructureInfo RepositoryMembers Rezervacije.Soba*/
    }

    /*DataStructureInfo RepositoryAttributes Rezervacije.TipSobe*/
    public class TipSobe_Repository : /*DataStructureInfo OverrideBaseType Rezervacije.TipSobe*/ Common.OrmRepositoryBase<Common.Queryable.Rezervacije_TipSobe, Rezervacije.TipSobe> // Common.QueryableRepositoryBase<Common.Queryable.Rezervacije_TipSobe, Rezervacije.TipSobe> // Common.ReadableRepositoryBase<Rezervacije.TipSobe> // global::Common.RepositoryBase
        , IWritableRepository<Rezervacije.TipSobe>, IValidateRepository/*DataStructureInfo RepositoryInterface Rezervacije.TipSobe*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Rezervacije.TipSobe*/

        public TipSobe_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Rezervacije.TipSobe*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Rezervacije.TipSobe*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Rezervacije.TipSobe[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Rezervacije_TipSobe> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Rezervacije.TipSobe*/
            return _executionContext.EntityFrameworkContext.Rezervacije_TipSobe.AsNoTracking();
        }

        public void Save(IEnumerable<Rezervacije.TipSobe> insertedNew, IEnumerable<Rezervacije.TipSobe> updatedNew, IEnumerable<Rezervacije.TipSobe> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Rezervacije.TipSobe*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Ime != null && newItem.Ime.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "TipSobe.Ime", "256" },
                        "DataStructure:Rezervacije.TipSobe,ID:" + invalidItem.ID.ToString() + ",Property:Ime",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Rezervacije.TipSobe*/

            /*DataStructureInfo WritableOrm Initialization Rezervacije.TipSobe*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Rezervacije_TipSobe> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_TipSobe>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Rezervacije_TipSobe> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_TipSobe>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Rezervacije.TipSobe*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Ime == null || string.IsNullOrWhiteSpace(item.Ime) /*RequiredPropertyInfo OrCondition Rezervacije.TipSobe.Ime*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Rezervacije.TipSobe", "Ime" },
                        "DataStructure:Rezervacije.TipSobe,ID:" + invalid.ID.ToString() + ",Property:Ime", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Cijena == null /*RequiredPropertyInfo OrCondition Rezervacije.TipSobe.Cijena*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Rezervacije.TipSobe", "Cijena" },
                        "DataStructure:Rezervacije.TipSobe,ID:" + invalid.ID.ToString() + ",Property:Cijena", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Rezervacije.TipSobe*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Rezervacije_TipSobe.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Rezervacije.Soba", @"TipSobeIDID", @"FK_Soba_TipSobe_TipSobeIDID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.Soba,Property:TipSobeIDID,Referenced:Rezervacije.TipSobe";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Rezervacije.TipSobe", @"IX_TipSobe_Ime"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.TipSobe,Property:Ime";
                /*DataStructureInfo WritableOrm OnDatabaseError Rezervacije.TipSobe*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Rezervacije.TipSobe");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Rezervacije_TipSobe> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Rezervacije.TipSobe*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Rezervacije.TipSobe*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Rezervacije.TipSobe");

                /*DataStructureInfo WritableOrm AfterSave Rezervacije.TipSobe*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new Rezervacije.Cijena_MaxValueFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_Cijena_MaxValueFilter(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Rezervacije.TipSobe*/
            yield break;
        }

        public IQueryable<Common.Queryable.Rezervacije_TipSobe> Filter(IQueryable<Common.Queryable.Rezervacije_TipSobe> localSource, PretrazivanjeTipSobe localParameter)
        {
            Func<IQueryable<Common.Queryable.Rezervacije_TipSobe>, Common.DomRepository, PretrazivanjeTipSobe/*ComposableFilterByInfo AdditionalParametersType Rezervacije.TipSobe.PretrazivanjeTipSobe*/, IQueryable<Common.Queryable.Rezervacije_TipSobe>> filterFunction =
            (query, repository, parameter) => 
        {
            if(parameter.MinimalnaCijena != null)
                return query.Where(tipSobe => tipSobe.Cijena >= parameter.MinimalnaCijena);
            return query;
        };

            /*ComposableFilterByInfo BeforeFilter Rezervacije.TipSobe.PretrazivanjeTipSobe*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Rezervacije.TipSobe.PretrazivanjeTipSobe*/);
        }

        public IQueryable<Common.Queryable.Rezervacije_TipSobe> Filter(IQueryable<Common.Queryable.Rezervacije_TipSobe> localSource, Rezervacije.Cijena_MaxValueFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.Rezervacije_TipSobe>, Common.DomRepository, Rezervacije.Cijena_MaxValueFilter/*ComposableFilterByInfo AdditionalParametersType Rezervacije.TipSobe.'Rezervacije.Cijena_MaxValueFilter'*/, IQueryable<Common.Queryable.Rezervacije_TipSobe>> filterFunction =
            (items, repository, parameter) => { decimal limit = 9999M; return items.Where(item => item.Cijena != null && item.Cijena > limit); };

            /*ComposableFilterByInfo BeforeFilter Rezervacije.TipSobe.'Rezervacije.Cijena_MaxValueFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Rezervacije.TipSobe.'Rezervacije.Cijena_MaxValueFilter'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_Cijena_MaxValueFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Maximum value of {0} is {1}.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"Rezervacije.Cijena_MaxValueFilter";
            metadata[@"Property"] = @"Cijena";
            /*InvalidDataInfo ErrorMetadata Rezervacije.TipSobe.'Rezervacije.Cijena_MaxValueFilter'*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Cijena", @"9999" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Rezervacije.TipSobe.'Rezervacije.Cijena_MaxValueFilter'*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public global::Rezervacije.TipSobe[] Filter(PretrazivanjeTipSobe filter_Parameter)
        {
            Func<Common.DomRepository, PretrazivanjeTipSobe/*FilterByInfo AdditionalParametersType Rezervacije.TipSobe.PretrazivanjeTipSobe*/, Rezervacije.TipSobe[]> filter_Function =
                (repository, parameter) => repository.Rezervacije.TipSobe.Filter(repository.Rezervacije.TipSobe.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Rezervacije.TipSobe.PretrazivanjeTipSobe*/);
        }

        public global::Rezervacije.TipSobe[] Filter(Rezervacije.Cijena_MaxValueFilter filter_Parameter)
        {
            Func<Common.DomRepository, Rezervacije.Cijena_MaxValueFilter/*FilterByInfo AdditionalParametersType Rezervacije.TipSobe.'Rezervacije.Cijena_MaxValueFilter'*/, Rezervacije.TipSobe[]> filter_Function =
                (repository, parameter) => repository.Rezervacije.TipSobe.Filter(repository.Rezervacije.TipSobe.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Rezervacije.TipSobe.'Rezervacije.Cijena_MaxValueFilter'*/);
        }

        /*DataStructureInfo RepositoryMembers Rezervacije.TipSobe*/
    }

    /*DataStructureInfo RepositoryAttributes Rezervacije.Rezervacija*/
    public class Rezervacija_Repository : /*DataStructureInfo OverrideBaseType Rezervacije.Rezervacija*/ Common.OrmRepositoryBase<Common.Queryable.Rezervacije_Rezervacija, Rezervacije.Rezervacija> // Common.QueryableRepositoryBase<Common.Queryable.Rezervacije_Rezervacija, Rezervacije.Rezervacija> // Common.ReadableRepositoryBase<Rezervacije.Rezervacija> // global::Common.RepositoryBase
        , IWritableRepository<Rezervacije.Rezervacija>, IValidateRepository/*DataStructureInfo RepositoryInterface Rezervacije.Rezervacija*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Rezervacije.Rezervacija*/

        public Rezervacija_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Rezervacije.Rezervacija*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Rezervacije.Rezervacija*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Rezervacije.Rezervacija[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Rezervacije_Rezervacija> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Rezervacije.Rezervacija*/
            return _executionContext.EntityFrameworkContext.Rezervacije_Rezervacija.AsNoTracking();
        }

        public void Save(IEnumerable<Rezervacije.Rezervacija> insertedNew, IEnumerable<Rezervacije.Rezervacija> updatedNew, IEnumerable<Rezervacije.Rezervacija> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Rezervacije.Rezervacija*/

            /*DataStructureInfo WritableOrm ArgumentValidation Rezervacije.Rezervacija*/

            { 
                var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

                foreach (var newItem in insertedNew)
                    if(newItem.Created == null)
                        newItem.Created = now;
            }
            /*DataStructureInfo WritableOrm Initialization Rezervacije.Rezervacija*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Rezervacije_Rezervacija> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_Rezervacija>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Rezervacije_Rezervacija> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_Rezervacija>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Rezervacije.Rezervacija*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.CheckIn == null /*RequiredPropertyInfo OrCondition Rezervacije.Rezervacija.CheckIn*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Rezervacije.Rezervacija", "CheckIn" },
                        "DataStructure:Rezervacije.Rezervacija,ID:" + invalid.ID.ToString() + ",Property:CheckIn", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.CheckOut == null /*RequiredPropertyInfo OrCondition Rezervacije.Rezervacija.CheckOut*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Rezervacije.Rezervacija", "CheckOut" },
                        "DataStructure:Rezervacije.Rezervacija,ID:" + invalid.ID.ToString() + ",Property:CheckOut", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Rezervacije.Rezervacija*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Rezervacije_Rezervacija.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Rezervacije.Soba", @"ID", @"FK_Rezervacija_Soba_SobaIDID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.Rezervacija,Property:SobaIDID,Referenced:Rezervacije.Soba";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Rezervacije.Rezervacija", @"IX_Rezervacija_CheckIn_CheckOut_SobaID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.Rezervacija,Property:CheckIn CheckOut SobaID";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Rezervacije.Gost", @"ID", @"FK_Rezervacija_Gost_GostIDID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.Rezervacija,Property:GostIDID,Referenced:Rezervacije.Gost";
                /*DataStructureInfo WritableOrm OnDatabaseError Rezervacije.Rezervacija*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Rezervacije.Rezervacija");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Rezervacije_Rezervacija> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Rezervacije.Rezervacija*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Rezervacije.Rezervacija*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Rezervacije.Rezervacija");

                /*DataStructureInfo WritableOrm AfterSave Rezervacije.Rezervacija*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Rezervacije.Rezervacija*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Rezervacije.Rezervacija*/
    }

    /*DataStructureInfo RepositoryAttributes Rezervacije.BrojRezervacijaPoSobi*/
    public class BrojRezervacijaPoSobi_Repository : /*DataStructureInfo OverrideBaseType Rezervacije.BrojRezervacijaPoSobi*/ Common.OrmRepositoryBase<Common.Queryable.Rezervacije_BrojRezervacijaPoSobi, Rezervacije.BrojRezervacijaPoSobi> // Common.QueryableRepositoryBase<Common.Queryable.Rezervacije_BrojRezervacijaPoSobi, Rezervacije.BrojRezervacijaPoSobi> // Common.ReadableRepositoryBase<Rezervacije.BrojRezervacijaPoSobi> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Rezervacije.BrojRezervacijaPoSobi*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Rezervacije.BrojRezervacijaPoSobi*/

        public BrojRezervacijaPoSobi_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Rezervacije.BrojRezervacijaPoSobi*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Rezervacije.BrojRezervacijaPoSobi*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Rezervacije.BrojRezervacijaPoSobi[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Rezervacije_BrojRezervacijaPoSobi> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Rezervacije.BrojRezervacijaPoSobi*/
            return _executionContext.EntityFrameworkContext.Rezervacije_BrojRezervacijaPoSobi.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Rezervacije.BrojRezervacijaPoSobi*/
    }

    /*DataStructureInfo RepositoryAttributes Rezervacije.BrowseSoba*/
    public class BrowseSoba_Repository : /*DataStructureInfo OverrideBaseType Rezervacije.BrowseSoba*/ Common.OrmRepositoryBase<Common.Queryable.Rezervacije_BrowseSoba, Rezervacije.BrowseSoba> // Common.QueryableRepositoryBase<Common.Queryable.Rezervacije_BrowseSoba, Rezervacije.BrowseSoba> // Common.ReadableRepositoryBase<Rezervacije.BrowseSoba> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Rezervacije.BrowseSoba*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Rezervacije.BrowseSoba*/

        public BrowseSoba_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Rezervacije.BrowseSoba*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Rezervacije.BrowseSoba*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Rezervacije.BrowseSoba[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Rezervacije_BrowseSoba> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Rezervacije.BrowseSoba*/
            return Query(_domRepository.Rezervacije.Soba.Query());
        }

        public IQueryable<Common.Queryable.Rezervacije_BrowseSoba> Query(IQueryable<Common.Queryable.Rezervacije_Soba> source)
        {
            return source.Select(item => new Common.Queryable.Rezervacije_BrowseSoba
                {
                    ID = item.ID,
                    Base = item,
                    BrojSobe = item.Broj,
                    HotelName = item.Hotel.Ime,
                    BrojRezervacija = item.Extension_BrojRezervacijaPoSobi.BrojRezervacija,
                    /*BrowseDataStructureInfo BrowseProperties Rezervacije.BrowseSoba*/
                });
        }

        /*DataStructureInfo RepositoryMembers Rezervacije.BrowseSoba*/
    }

    /*DataStructureInfo RepositoryAttributes Rezervacije.Hotel*/
    public class Hotel_Repository : /*DataStructureInfo OverrideBaseType Rezervacije.Hotel*/ Common.OrmRepositoryBase<Common.Queryable.Rezervacije_Hotel, Rezervacije.Hotel> // Common.QueryableRepositoryBase<Common.Queryable.Rezervacije_Hotel, Rezervacije.Hotel> // Common.ReadableRepositoryBase<Rezervacije.Hotel> // global::Common.RepositoryBase
        , IWritableRepository<Rezervacije.Hotel>, IValidateRepository/*DataStructureInfo RepositoryInterface Rezervacije.Hotel*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Rezervacije.Hotel*/

        public Hotel_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Rezervacije.Hotel*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Rezervacije.Hotel*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Rezervacije.Hotel[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Rezervacije_Hotel> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Rezervacije.Hotel*/
            return _executionContext.EntityFrameworkContext.Rezervacije_Hotel.AsNoTracking();
        }

        public void Save(IEnumerable<Rezervacije.Hotel> insertedNew, IEnumerable<Rezervacije.Hotel> updatedNew, IEnumerable<Rezervacije.Hotel> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Rezervacije.Hotel*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Ime != null && newItem.Ime.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Hotel.Ime", "256" },
                        "DataStructure:Rezervacije.Hotel,ID:" + invalidItem.ID.ToString() + ",Property:Ime",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Adresa != null && newItem.Adresa.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Hotel.Adresa", "256" },
                        "DataStructure:Rezervacije.Hotel,ID:" + invalidItem.ID.ToString() + ",Property:Adresa",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Rezervacije.Hotel*/

            /*DataStructureInfo WritableOrm Initialization Rezervacije.Hotel*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Rezervacije_Hotel> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_Hotel>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Rezervacije_Hotel> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_Hotel>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Rezervacije.Hotel*/

            /*DataStructureInfo WritableOrm ProcessedOldData Rezervacije.Hotel*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Rezervacije_Hotel.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Rezervacije.Soba", @"HotelID", @"FK_Soba_Hotel_HotelID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.Soba,Property:HotelID,Referenced:Rezervacije.Hotel";
                /*DataStructureInfo WritableOrm OnDatabaseError Rezervacije.Hotel*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Rezervacije.Hotel");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Rezervacije_Hotel> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Rezervacije.Hotel*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Rezervacije.Hotel*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Rezervacije.Hotel");

                /*DataStructureInfo WritableOrm AfterSave Rezervacije.Hotel*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Rezervacije.Hotel*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Rezervacije.Hotel*/
    }

    /*DataStructureInfo RepositoryAttributes Rezervacije.Gost*/
    public class Gost_Repository : /*DataStructureInfo OverrideBaseType Rezervacije.Gost*/ Common.OrmRepositoryBase<Common.Queryable.Rezervacije_Gost, Rezervacije.Gost> // Common.QueryableRepositoryBase<Common.Queryable.Rezervacije_Gost, Rezervacije.Gost> // Common.ReadableRepositoryBase<Rezervacije.Gost> // global::Common.RepositoryBase
        , IWritableRepository<Rezervacije.Gost>, IValidateRepository/*DataStructureInfo RepositoryInterface Rezervacije.Gost*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Rezervacije.Gost*/

        public Gost_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Rezervacije.Gost*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Rezervacije.Gost*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Rezervacije.Gost[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Rezervacije_Gost> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Rezervacije.Gost*/
            return _executionContext.EntityFrameworkContext.Rezervacije_Gost.AsNoTracking();
        }

        public void Save(IEnumerable<Rezervacije.Gost> insertedNew, IEnumerable<Rezervacije.Gost> updatedNew, IEnumerable<Rezervacije.Gost> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Rezervacije.Gost*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Ime != null && newItem.Ime.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Gost.Ime", "256" },
                        "DataStructure:Rezervacije.Gost,ID:" + invalidItem.ID.ToString() + ",Property:Ime",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Prezime != null && newItem.Prezime.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Gost.Prezime", "256" },
                        "DataStructure:Rezervacije.Gost,ID:" + invalidItem.ID.ToString() + ",Property:Prezime",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Email != null && newItem.Email.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Gost.Email", "256" },
                        "DataStructure:Rezervacije.Gost,ID:" + invalidItem.ID.ToString() + ",Property:Email",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Rezervacije.Gost*/

            /*DataStructureInfo WritableOrm Initialization Rezervacije.Gost*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Rezervacije_Gost> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_Gost>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Rezervacije_Gost> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_Gost>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Rezervacije.StraniGost> childItems = _executionContext.Repository.Rezervacije.StraniGost
                    .Query(deletedIds.Select(parent => parent.ID))
                    .Select(child => child.ID).ToList()
                    .Select(childId => new Rezervacije.StraniGost { ID = childId }).ToList();

                if (childItems.Count() > 0)
                    _domRepository.Rezervacije.StraniGost.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Rezervacije.Gost*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Ime == null || string.IsNullOrWhiteSpace(item.Ime) /*RequiredPropertyInfo OrCondition Rezervacije.Gost.Ime*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Rezervacije.Gost", "Ime" },
                        "DataStructure:Rezervacije.Gost,ID:" + invalid.ID.ToString() + ",Property:Ime", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Rezervacije.Gost*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Rezervacije_Gost.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Rezervacije.Rezervacija", @"GostIDID", @"FK_Rezervacija_Gost_GostIDID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.Rezervacija,Property:GostIDID,Referenced:Rezervacije.Gost";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Rezervacije.StraniGost", @"ID", @"FK_StraniGost_Gost_ID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Rezervacije.StraniGost,Property:ID,Referenced:Rezervacije.Gost";
                /*DataStructureInfo WritableOrm OnDatabaseError Rezervacije.Gost*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Rezervacije.Gost");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Rezervacije_Gost> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Rezervacije.Gost*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Rezervacije.Gost*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Rezervacije.Gost");

                /*DataStructureInfo WritableOrm AfterSave Rezervacije.Gost*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Rezervacije.Gost*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Rezervacije.Gost*/
    }

    /*DataStructureInfo RepositoryAttributes Rezervacije.StraniGost*/
    public class StraniGost_Repository : /*DataStructureInfo OverrideBaseType Rezervacije.StraniGost*/ Common.OrmRepositoryBase<Common.Queryable.Rezervacije_StraniGost, Rezervacije.StraniGost> // Common.QueryableRepositoryBase<Common.Queryable.Rezervacije_StraniGost, Rezervacije.StraniGost> // Common.ReadableRepositoryBase<Rezervacije.StraniGost> // global::Common.RepositoryBase
        , IWritableRepository<Rezervacije.StraniGost>, IValidateRepository/*DataStructureInfo RepositoryInterface Rezervacije.StraniGost*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Rezervacije.StraniGost*/

        public StraniGost_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Rezervacije.StraniGost*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Rezervacije.StraniGost*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Rezervacije.StraniGost[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Rezervacije_StraniGost> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Rezervacije.StraniGost*/
            return _executionContext.EntityFrameworkContext.Rezervacije_StraniGost.AsNoTracking();
        }

        public void Save(IEnumerable<Rezervacije.StraniGost> insertedNew, IEnumerable<Rezervacije.StraniGost> updatedNew, IEnumerable<Rezervacije.StraniGost> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Rezervacije.StraniGost*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ImePrevoditelja != null && newItem.ImePrevoditelja.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "StraniGost.ImePrevoditelja", "256" },
                        "DataStructure:Rezervacije.StraniGost,ID:" + invalidItem.ID.ToString() + ",Property:ImePrevoditelja",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.PrezimePrevoditelja != null && newItem.PrezimePrevoditelja.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "StraniGost.PrezimePrevoditelja", "256" },
                        "DataStructure:Rezervacije.StraniGost,ID:" + invalidItem.ID.ToString() + ",Property:PrezimePrevoditelja",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Rezervacije.StraniGost*/

            /*DataStructureInfo WritableOrm Initialization Rezervacije.StraniGost*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Rezervacije_StraniGost> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_StraniGost>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Rezervacije_StraniGost> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Rezervacije_StraniGost>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Rezervacije.StraniGost*/

            /*DataStructureInfo WritableOrm ProcessedOldData Rezervacije.StraniGost*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Rezervacije_StraniGost.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Rezervacije.StraniGost*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Rezervacije.StraniGost");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Rezervacije_StraniGost> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Rezervacije.StraniGost*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Rezervacije.StraniGost*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Rezervacije.StraniGost");

                /*DataStructureInfo WritableOrm AfterSave Rezervacije.StraniGost*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Rezervacije.StraniGost*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Rezervacije.StraniGost*/
    }

    /*ModuleInfo HelperNamespaceMembers Rezervacije*/
}

namespace Common._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Common*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private AutoCodeCache_Repository _AutoCodeCache_Repository;
        public AutoCodeCache_Repository AutoCodeCache { get { return _AutoCodeCache_Repository ?? (_AutoCodeCache_Repository = (AutoCodeCache_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AutoCodeCache")); } }

        private FilterId_Repository _FilterId_Repository;
        public FilterId_Repository FilterId { get { return _FilterId_Repository ?? (_FilterId_Repository = (FilterId_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.FilterId")); } }

        private KeepSynchronizedMetadata_Repository _KeepSynchronizedMetadata_Repository;
        public KeepSynchronizedMetadata_Repository KeepSynchronizedMetadata { get { return _KeepSynchronizedMetadata_Repository ?? (_KeepSynchronizedMetadata_Repository = (KeepSynchronizedMetadata_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.KeepSynchronizedMetadata")); } }

        private ExclusiveLock_Repository _ExclusiveLock_Repository;
        public ExclusiveLock_Repository ExclusiveLock { get { return _ExclusiveLock_Repository ?? (_ExclusiveLock_Repository = (ExclusiveLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ExclusiveLock")); } }

        private SetLock_Repository _SetLock_Repository;
        public SetLock_Repository SetLock { get { return _SetLock_Repository ?? (_SetLock_Repository = (SetLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.SetLock")); } }

        private ReleaseLock_Repository _ReleaseLock_Repository;
        public ReleaseLock_Repository ReleaseLock { get { return _ReleaseLock_Repository ?? (_ReleaseLock_Repository = (ReleaseLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ReleaseLock")); } }

        private LogReader_Repository _LogReader_Repository;
        public LogReader_Repository LogReader { get { return _LogReader_Repository ?? (_LogReader_Repository = (LogReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogReader")); } }

        private LogRelatedItemReader_Repository _LogRelatedItemReader_Repository;
        public LogRelatedItemReader_Repository LogRelatedItemReader { get { return _LogRelatedItemReader_Repository ?? (_LogRelatedItemReader_Repository = (LogRelatedItemReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItemReader")); } }

        private Log_Repository _Log_Repository;
        public Log_Repository Log { get { return _Log_Repository ?? (_Log_Repository = (Log_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Log")); } }

        private AddToLog_Repository _AddToLog_Repository;
        public AddToLog_Repository AddToLog { get { return _AddToLog_Repository ?? (_AddToLog_Repository = (AddToLog_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AddToLog")); } }

        private LogRelatedItem_Repository _LogRelatedItem_Repository;
        public LogRelatedItem_Repository LogRelatedItem { get { return _LogRelatedItem_Repository ?? (_LogRelatedItem_Repository = (LogRelatedItem_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItem")); } }

        private RelatedEventsSource_Repository _RelatedEventsSource_Repository;
        public RelatedEventsSource_Repository RelatedEventsSource { get { return _RelatedEventsSource_Repository ?? (_RelatedEventsSource_Repository = (RelatedEventsSource_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RelatedEventsSource")); } }

        private Claim_Repository _Claim_Repository;
        public Claim_Repository Claim { get { return _Claim_Repository ?? (_Claim_Repository = (Claim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Claim")); } }

        private MyClaim_Repository _MyClaim_Repository;
        public MyClaim_Repository MyClaim { get { return _MyClaim_Repository ?? (_MyClaim_Repository = (MyClaim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.MyClaim")); } }

        private Principal_Repository _Principal_Repository;
        public Principal_Repository Principal { get { return _Principal_Repository ?? (_Principal_Repository = (Principal_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Principal")); } }

        private PrincipalHasRole_Repository _PrincipalHasRole_Repository;
        public PrincipalHasRole_Repository PrincipalHasRole { get { return _PrincipalHasRole_Repository ?? (_PrincipalHasRole_Repository = (PrincipalHasRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalHasRole")); } }

        private Role_Repository _Role_Repository;
        public Role_Repository Role { get { return _Role_Repository ?? (_Role_Repository = (Role_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Role")); } }

        private RoleInheritsRole_Repository _RoleInheritsRole_Repository;
        public RoleInheritsRole_Repository RoleInheritsRole { get { return _RoleInheritsRole_Repository ?? (_RoleInheritsRole_Repository = (RoleInheritsRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RoleInheritsRole")); } }

        private PrincipalPermission_Repository _PrincipalPermission_Repository;
        public PrincipalPermission_Repository PrincipalPermission { get { return _PrincipalPermission_Repository ?? (_PrincipalPermission_Repository = (PrincipalPermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalPermission")); } }

        private RolePermission_Repository _RolePermission_Repository;
        public RolePermission_Repository RolePermission { get { return _RolePermission_Repository ?? (_RolePermission_Repository = (RolePermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RolePermission")); } }

        /*ModuleInfo RepositoryMembers Common*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AutoCodeCache*/
    public class AutoCodeCache_Repository : /*DataStructureInfo OverrideBaseType Common.AutoCodeCache*/ Common.OrmRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.QueryableRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.ReadableRepositoryBase<Common.AutoCodeCache> // global::Common.RepositoryBase
        , IWritableRepository<Common.AutoCodeCache>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.AutoCodeCache*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.AutoCodeCache*/

        public AutoCodeCache_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.AutoCodeCache*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.AutoCodeCache*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.AutoCodeCache[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_AutoCodeCache> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.AutoCodeCache*/
            return _executionContext.EntityFrameworkContext.Common_AutoCodeCache.AsNoTracking();
        }

        public void Save(IEnumerable<Common.AutoCodeCache> insertedNew, IEnumerable<Common.AutoCodeCache> updatedNew, IEnumerable<Common.AutoCodeCache> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.AutoCodeCache*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Entity != null && newItem.Entity.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Entity", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Entity",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Property != null && newItem.Property.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Property", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Property",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Grouping != null && newItem.Grouping.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Grouping", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Grouping",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Prefix != null && newItem.Prefix.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Prefix", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Prefix",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm Initialization Common.AutoCodeCache*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_AutoCodeCache> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_AutoCodeCache>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_AutoCodeCache> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_AutoCodeCache>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.AutoCodeCache*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_AutoCodeCache.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.AutoCodeCache", @"IX_AutoCodeCache_Entity_Property_Grouping_Prefix"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.AutoCodeCache,Property:Entity Property Grouping Prefix";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.AutoCodeCache*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.AutoCodeCache");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_AutoCodeCache> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.AutoCodeCache*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.AutoCodeCache*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.AutoCodeCache");

                /*DataStructureInfo WritableOrm AfterSave Common.AutoCodeCache*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.AutoCodeCache*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.AutoCodeCache*/
    }

    /*DataStructureInfo RepositoryAttributes Common.FilterId*/
    public class FilterId_Repository : /*DataStructureInfo OverrideBaseType Common.FilterId*/ Common.OrmRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.QueryableRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.ReadableRepositoryBase<Common.FilterId> // global::Common.RepositoryBase
        , IWritableRepository<Common.FilterId>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.FilterId*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.FilterId*/

        public FilterId_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.FilterId*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.FilterId*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.FilterId[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_FilterId> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.FilterId*/
            return _executionContext.EntityFrameworkContext.Common_FilterId.AsNoTracking();
        }

        public void Save(IEnumerable<Common.FilterId> insertedNew, IEnumerable<Common.FilterId> updatedNew, IEnumerable<Common.FilterId> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.FilterId*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.FilterId*/

            /*DataStructureInfo WritableOrm Initialization Common.FilterId*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_FilterId> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_FilterId>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_FilterId> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_FilterId>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.FilterId*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.FilterId*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_FilterId.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Common.FilterId*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.FilterId");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_FilterId> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.FilterId*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.FilterId*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.FilterId");

                /*DataStructureInfo WritableOrm AfterSave Common.FilterId*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.FilterId*/
            yield break;
        }

        /// <summary>
        /// Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
        /// EF 6.1.3 has performance issues on Contains function with large lists. It seems to have O(n^2) time complexity.
        /// </summary>
        public IEnumerable<Guid> CreateQueryableFilterIds(IEnumerable<Guid> ids)
        {
            Rhetos.Utilities.CsUtility.Materialize(ref ids);

            if (ids.Count() < 200)
                return ids;

            var handle = Guid.NewGuid();
            string sqlInsertIdFormat = "INSERT INTO Common.FilterId (Handle, Value) VALUES ('" + SqlUtility.GuidToString(handle) + "', '{0}');";

            const int chunkSize = 1000; // Keeping a moderate SQL script size.
            for (int start = 0; start < ids.Count(); start += chunkSize)
            {
                string sqlInsertIds = string.Join("\r\n", ids.Skip(start).Take(chunkSize)
                        .Select(id => string.Format(sqlInsertIdFormat, SqlUtility.GuidToString(id))));
                _executionContext.SqlExecuter.ExecuteSql(sqlInsertIds);
            }

            // Delete temporary data when closing the connection. The data must remain in the database until the returned query is used.
            string deleteFilterIds = "DELETE FROM Common.FilterId WHERE Handle = " + SqlUtility.QuoteGuid(handle);
            _executionContext.PersistenceTransaction.BeforeClose += () =>
                {
                    try
                    {
                        _executionContext.SqlExecuter.ExecuteSql(deleteFilterIds);
                    }
                    catch
                    {
                        // Cleanup error may be ignored. The temporary data may be deleted on regular maintenance.
                    }
                };

            return Query().Where(filterId => filterId.Handle == handle).Select(filterId => filterId.Value.Value);
        }

        /*DataStructureInfo RepositoryMembers Common.FilterId*/
    }

    /*DataStructureInfo RepositoryAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata_Repository : /*DataStructureInfo OverrideBaseType Common.KeepSynchronizedMetadata*/ Common.OrmRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.QueryableRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.ReadableRepositoryBase<Common.KeepSynchronizedMetadata> // global::Common.RepositoryBase
        , IWritableRepository<Common.KeepSynchronizedMetadata>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.KeepSynchronizedMetadata*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.KeepSynchronizedMetadata*/

        public KeepSynchronizedMetadata_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.KeepSynchronizedMetadata*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.KeepSynchronizedMetadata*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.KeepSynchronizedMetadata[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.KeepSynchronizedMetadata*/
            return _executionContext.EntityFrameworkContext.Common_KeepSynchronizedMetadata.AsNoTracking();
        }

        public void Save(IEnumerable<Common.KeepSynchronizedMetadata> insertedNew, IEnumerable<Common.KeepSynchronizedMetadata> updatedNew, IEnumerable<Common.KeepSynchronizedMetadata> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.KeepSynchronizedMetadata*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Target != null && newItem.Target.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "KeepSynchronizedMetadata.Target", "256" },
                        "DataStructure:Common.KeepSynchronizedMetadata,ID:" + invalidItem.ID.ToString() + ",Property:Target",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Source != null && newItem.Source.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "KeepSynchronizedMetadata.Source", "256" },
                        "DataStructure:Common.KeepSynchronizedMetadata,ID:" + invalidItem.ID.ToString() + ",Property:Source",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm Initialization Common.KeepSynchronizedMetadata*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_KeepSynchronizedMetadata>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_KeepSynchronizedMetadata>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.KeepSynchronizedMetadata*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_KeepSynchronizedMetadata.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Common.KeepSynchronizedMetadata*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.KeepSynchronizedMetadata");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.KeepSynchronizedMetadata*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.KeepSynchronizedMetadata*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.KeepSynchronizedMetadata");

                /*DataStructureInfo WritableOrm AfterSave Common.KeepSynchronizedMetadata*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.KeepSynchronizedMetadata*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.KeepSynchronizedMetadata*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ExclusiveLock*/
    public class ExclusiveLock_Repository : /*DataStructureInfo OverrideBaseType Common.ExclusiveLock*/ Common.OrmRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.QueryableRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.ReadableRepositoryBase<Common.ExclusiveLock> // global::Common.RepositoryBase
        , IWritableRepository<Common.ExclusiveLock>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.ExclusiveLock*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.ExclusiveLock*/

        public ExclusiveLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.ExclusiveLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.ExclusiveLock*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.ExclusiveLock[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_ExclusiveLock> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.ExclusiveLock*/
            return _executionContext.EntityFrameworkContext.Common_ExclusiveLock.AsNoTracking();
        }

        public void Save(IEnumerable<Common.ExclusiveLock> insertedNew, IEnumerable<Common.ExclusiveLock> updatedNew, IEnumerable<Common.ExclusiveLock> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.ExclusiveLock*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ResourceType != null && newItem.ResourceType.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.ResourceType", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:ResourceType",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.UserName != null && newItem.UserName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.UserName", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:UserName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Workstation != null && newItem.Workstation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.Workstation", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:Workstation",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.ExclusiveLock*/

            /*DataStructureInfo WritableOrm Initialization Common.ExclusiveLock*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_ExclusiveLock> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ExclusiveLock>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_ExclusiveLock> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ExclusiveLock>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.ExclusiveLock*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceType == null || string.IsNullOrWhiteSpace(item.ResourceType) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceType*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceType" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceType", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceID == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceID*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceID" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "UserName" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "Workstation" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockStart == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockStart*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockStart" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockStart", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockFinish == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockFinish*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockFinish" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockFinish", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.ExclusiveLock*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_ExclusiveLock.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.ExclusiveLock", @"IX_ExclusiveLock_ResourceID_ResourceType"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.ExclusiveLock,Property:ResourceID ResourceType";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.ExclusiveLock*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.ExclusiveLock");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_ExclusiveLock> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.ExclusiveLock*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.ExclusiveLock*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.ExclusiveLock");

                /*DataStructureInfo WritableOrm AfterSave Common.ExclusiveLock*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.ExclusiveLock*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.ExclusiveLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.SetLock*/
    public class SetLock_Repository : /*DataStructureInfo OverrideBaseType Common.SetLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.SetLock*/
    {
        private readonly Rhetos.Utilities.ILocalizer _localizer;
        /*DataStructureInfo RepositoryPrivateMembers Common.SetLock*/

        public SetLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ILocalizer _localizer/*DataStructureInfo RepositoryConstructorArguments Common.SetLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._localizer = _localizer;
            /*DataStructureInfo RepositoryConstructorCode Common.SetLock*/
        }

        public void Execute(Common.SetLock actionParameter)
        {
            Action<Common.SetLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.SetLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var now = SqlUtility.GetDatabaseTime(_executionContext.SqlExecuter);

            var oldLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID)
                .FirstOrDefault();
            
            if (oldLock == null)
                repository.Common.ExclusiveLock.Insert(new[] { new Common.ExclusiveLock
                    {
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = now,
                        LockFinish = now.AddMinutes(15)
                    }});
            else if (oldLock.UserName == userInfo.UserName
                && oldLock.Workstation == userInfo.Workstation
                || oldLock.LockFinish < now)
                repository.Common.ExclusiveLock.Update(new[] { new Common.ExclusiveLock
                    {
                        ID = oldLock.ID,
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = now,
                        LockFinish = now.AddMinutes(15)
                    }});
             else
             {
                string lockInfo = _localizer["Locked record {0}, ID {1}.", oldLock.ResourceType, oldLock.ResourceID];

                string errorInfo;
                if (oldLock.UserName.Equals(userInfo.UserName, StringComparison.InvariantCultureIgnoreCase))
                    errorInfo = _localizer["It is not allowed to enter the record at client workstation '{0}' because the data entry is in progress at workstation '{1}'.",
                        userInfo.Workstation, oldLock.Workstation];
                else
                    errorInfo = _localizer["It is not allowed to enter the record because the data entry is in progress by user '{0}'.",
                        oldLock.UserName];
                
                string localizedMessage = errorInfo + "\r\n" + lockInfo;
                throw new Rhetos.UserException(localizedMessage);
             }
        };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.SetLock*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.SetLock*/);
                /*ActionInfo AfterAction Common.SetLock*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.SetLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.SetLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ReleaseLock*/
    public class ReleaseLock_Repository : /*DataStructureInfo OverrideBaseType Common.ReleaseLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.ReleaseLock*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.ReleaseLock*/

        public ReleaseLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.ReleaseLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.ReleaseLock*/
        }

        public void Execute(Common.ReleaseLock actionParameter)
        {
            Action<Common.ReleaseLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.ReleaseLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var myLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID
                    && itemLock.UserName == userInfo.UserName
                    && itemLock.Workstation == userInfo.Workstation)
                .FirstOrDefault();

            if (myLock != null)
                repository.Common.ExclusiveLock.Delete(new[] { myLock });
        };

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.ReleaseLock*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.ReleaseLock*/);
                /*ActionInfo AfterAction Common.ReleaseLock*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.ReleaseLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.ReleaseLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogReader*/
    public class LogReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.ReadableRepositoryBase<Common.LogReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogReader*/

        public LogReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogReader*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogReader[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogReader> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogReader*/
            return _executionContext.EntityFrameworkContext.Common_LogReader.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.LogReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItemReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.ReadableRepositoryBase<Common.LogRelatedItemReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogRelatedItemReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItemReader*/

        public LogRelatedItemReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItemReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItemReader*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogRelatedItemReader[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogRelatedItemReader> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogRelatedItemReader*/
            return _executionContext.EntityFrameworkContext.Common_LogRelatedItemReader.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItemReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Log*/
    public class Log_Repository : /*DataStructureInfo OverrideBaseType Common.Log*/ Common.OrmRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.QueryableRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.ReadableRepositoryBase<Common.Log> // global::Common.RepositoryBase
        , IWritableRepository<Common.Log>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Log*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Log*/

        public Log_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Log*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Log*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Log[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Log> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Log*/
            return _executionContext.EntityFrameworkContext.Common_Log.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Log> insertedNew, IEnumerable<Common.Log> updatedNew, IEnumerable<Common.Log> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Log*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.UserName != null && newItem.UserName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.UserName", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:UserName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Workstation != null && newItem.Workstation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.Workstation", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:Workstation",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ContextInfo != null && newItem.ContextInfo.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.ContextInfo", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:ContextInfo",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Action != null && newItem.Action.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.Action", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:Action",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.TableName != null && newItem.TableName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.TableName", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:TableName",
                        null);
            }
            if (checkUserPermissions)
                throw new Rhetos.UserException(
                    "It is not allowed to directly modify {0}.", new[] { "Common.Log" }, null, null);
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Log*/

            /*DataStructureInfo WritableOrm Initialization Common.Log*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Log> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Log>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Log> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Log>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.LogRelatedItem> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.LogRelatedItem.Query()
                        .Where(child => child.LogID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.LogRelatedItem { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.LogRelatedItem.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Log*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Created == null /*RequiredPropertyInfo OrCondition Common.Log.Created*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Created" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Created", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.Log.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "UserName" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.Log.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Workstation" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Action == null || string.IsNullOrWhiteSpace(item.Action) /*RequiredPropertyInfo OrCondition Common.Log.Action*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Action" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Action", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Log*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Log.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.LogRelatedItem", @"LogID", @"FK_LogRelatedItem_Log_LogID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Log*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Log");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Log> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Log*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Log*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Log");

                /*DataStructureInfo WritableOrm AfterSave Common.Log*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Log*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Log*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AddToLog*/
    public class AddToLog_Repository : /*DataStructureInfo OverrideBaseType Common.AddToLog*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.AddToLog*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.AddToLog*/

        public AddToLog_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.AddToLog*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.AddToLog*/
        }

        public void Execute(Common.AddToLog actionParameter)
        {
            Action<Common.AddToLog, Common.DomRepository, IUserInfo, Common.ExecutionContext/*DataStructureInfo AdditionalParametersType Common.AddToLog*/> action_Object = (parameter, repository, userInfo, context) =>
		{
			if (parameter.Action == null)
				throw new Rhetos.UserException("Parameter Action is required.");
			string sql = @"INSERT INTO Common.Log (Action, TableName, ItemId, Description)
                SELECT @p0, @p1, @p2, @p3";
			context.EntityFrameworkContext.Database.ExecuteSqlCommand(sql,
				parameter.Action,
				parameter.TableName,
				parameter.ItemId,
				parameter.Description);
		};

            bool allEffectsCompleted = false;
            try
            {
                /*ActionInfo BeforeAction Common.AddToLog*/
                action_Object(actionParameter, _domRepository, _executionContext.UserInfo, _executionContext/*DataStructureInfo AdditionalParametersArgument Common.AddToLog*/);
                /*ActionInfo AfterAction Common.AddToLog*/
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.AddToLog) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.AddToLog*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItem*/
    public class LogRelatedItem_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItem*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.ReadableRepositoryBase<Common.LogRelatedItem> // global::Common.RepositoryBase
        , IWritableRepository<Common.LogRelatedItem>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.LogRelatedItem*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItem*/

        public LogRelatedItem_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItem*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItem*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogRelatedItem[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogRelatedItem> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogRelatedItem*/
            return _executionContext.EntityFrameworkContext.Common_LogRelatedItem.AsNoTracking();
        }

        public void Save(IEnumerable<Common.LogRelatedItem> insertedNew, IEnumerable<Common.LogRelatedItem> updatedNew, IEnumerable<Common.LogRelatedItem> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.LogRelatedItem*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.TableName != null && newItem.TableName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "LogRelatedItem.TableName", "256" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalidItem.ID.ToString() + ",Property:TableName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Relation != null && newItem.Relation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "LogRelatedItem.Relation", "256" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalidItem.ID.ToString() + ",Property:Relation",
                        null);
            }
            if (checkUserPermissions)
                throw new Rhetos.UserException(
                    "It is not allowed to directly modify {0}.", new[] { "Common.LogRelatedItem" }, null, null);
            /*DataStructureInfo WritableOrm ArgumentValidation Common.LogRelatedItem*/

            /*DataStructureInfo WritableOrm Initialization Common.LogRelatedItem*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_LogRelatedItem> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_LogRelatedItem>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_LogRelatedItem> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_LogRelatedItem>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.LogRelatedItem*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LogID == null /*RequiredPropertyInfo OrCondition Common.LogRelatedItem.Log*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.LogRelatedItem", "Log" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalid.ID.ToString() + ",Property:LogID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.LogRelatedItem*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_LogRelatedItem.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Log", @"ID", @"FK_LogRelatedItem_Log_LogID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.LogRelatedItem*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.LogRelatedItem");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_LogRelatedItem> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.LogRelatedItem*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.LogRelatedItem*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.LogRelatedItem");

                /*DataStructureInfo WritableOrm AfterSave Common.LogRelatedItem*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredLog()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredLog(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.LogRelatedItem*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredLog(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredLog";
            metadata[@"Property"] = @"Log";
            /*InvalidDataInfo ErrorMetadata Common.LogRelatedItem.SystemRequiredLog*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.LogRelatedItem.Log" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.LogRelatedItem.SystemRequiredLog*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_LogRelatedItem> Filter(IQueryable<Common.Queryable.Common_LogRelatedItem> localSource, Common.SystemRequiredLog localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_LogRelatedItem>, Common.DomRepository, Common.SystemRequiredLog/*ComposableFilterByInfo AdditionalParametersType Common.LogRelatedItem.'Common.SystemRequiredLog'*/, IQueryable<Common.Queryable.Common_LogRelatedItem>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Log == null);

            /*ComposableFilterByInfo BeforeFilter Common.LogRelatedItem.'Common.SystemRequiredLog'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.LogRelatedItem.'Common.SystemRequiredLog'*/);
        }

        public global::Common.LogRelatedItem[] Filter(Common.SystemRequiredLog filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredLog/*FilterByInfo AdditionalParametersType Common.LogRelatedItem.'Common.SystemRequiredLog'*/, Common.LogRelatedItem[]> filter_Function =
                (repository, parameter) => repository.Common.LogRelatedItem.Filter(repository.Common.LogRelatedItem.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.LogRelatedItem.'Common.SystemRequiredLog'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItem*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource_Repository : /*DataStructureInfo OverrideBaseType Common.RelatedEventsSource*/ Common.OrmRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.QueryableRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.ReadableRepositoryBase<Common.RelatedEventsSource> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.RelatedEventsSource*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.RelatedEventsSource*/

        public RelatedEventsSource_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.RelatedEventsSource*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.RelatedEventsSource*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RelatedEventsSource[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RelatedEventsSource> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RelatedEventsSource*/
            return _executionContext.EntityFrameworkContext.Common_RelatedEventsSource.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.RelatedEventsSource*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Claim*/
    public class Claim_Repository : /*DataStructureInfo OverrideBaseType Common.Claim*/ Common.OrmRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.QueryableRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.ReadableRepositoryBase<Common.Claim> // global::Common.RepositoryBase
        , IWritableRepository<Common.Claim>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Claim*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Claim*/

        public Claim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Claim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Claim*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Claim[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Claim> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Claim*/
            return _executionContext.EntityFrameworkContext.Common_Claim.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Claim> insertedNew, IEnumerable<Common.Claim> updatedNew, IEnumerable<Common.Claim> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Claim*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ClaimResource != null && newItem.ClaimResource.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Claim.ClaimResource", "256" },
                        "DataStructure:Common.Claim,ID:" + invalidItem.ID.ToString() + ",Property:ClaimResource",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ClaimRight != null && newItem.ClaimRight.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Claim.ClaimRight", "256" },
                        "DataStructure:Common.Claim,ID:" + invalidItem.ID.ToString() + ",Property:ClaimRight",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Claim*/

            /*DataStructureInfo WritableOrm Initialization Common.Claim*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Claim> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Claim>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Claim> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Claim>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            foreach (var newItem in insertedNew)
                if (newItem.Active == null)
                    newItem.Active = true;

            foreach (var change in updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem }))
                if (change.newItem.Active == null)
                    change.newItem.Active = change.oldItem.Active ?? true;

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Claim*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimResource == null || string.IsNullOrWhiteSpace(item.ClaimResource) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimResource*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimResource" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimResource", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimRight == null || string.IsNullOrWhiteSpace(item.ClaimRight) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimRight*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimRight" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimRight", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Claim*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Claim.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"ClaimID", @"FK_PrincipalPermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"ClaimID", @"FK_RolePermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Claim", @"IX_Claim_ClaimResource_ClaimRight"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Claim,Property:ClaimResource ClaimRight";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Claim*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Claim");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Claim> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Claim*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Claim*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Claim");

                /*DataStructureInfo WritableOrm AfterSave Common.Claim*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredActive()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredActive(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Claim*/
            yield break;
        }

        // Claims in use should be deactivated instead of deleted.
        public IEnumerable<Claim> Filter(IEnumerable<Claim> deleted, Rhetos.Dom.DefaultConcepts.DeactivateInsteadOfDelete parameter)
        {
            var deactivateClaimsId = new List<Guid>();
            var deletedClaimsId = new Lazy<List<Guid>>(() => deleted.Select(c => c.ID).ToList());

            {
                // Don't delete claims that are referenced from RolePermission:

                var permissionsQuery = _domRepository.Common.RolePermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            
            {
                // Don't delete claims that are referenced from PrincipalPermission:

                var permissionsQuery = _domRepository.Common.PrincipalPermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            /*DataStructureInfo DeactivateInsteadOfDelete Common.Claim*/

            var deactivateClaimsIdIndex = new HashSet<Guid>(deactivateClaimsId);
            return deleted.Where(item => deactivateClaimsIdIndex.Contains(item.ID)).ToList();
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> localSource, Rhetos.Dom.DefaultConcepts.ActiveItems localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository, Rhetos.Dom.DefaultConcepts.ActiveItems/*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/, IQueryable<Common.Queryable.Common_Claim>> filterFunction =
            (items, repository, parameter) =>
                    {
                        if (parameter != null && parameter.ItemID.HasValue)
                            return items.Where(item => item.Active == null || item.Active.Value || item.ID == parameter.ItemID.Value);
                        else
                            return items.Where(item => item.Active == null || item.Active.Value);
                    };

            /*ComposableFilterByInfo BeforeFilter Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredActive(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredActive";
            metadata[@"Property"] = @"Active";
            /*InvalidDataInfo ErrorMetadata Common.Claim.SystemRequiredActive*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Bool Common.Claim.Active" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.Claim.SystemRequiredActive*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> localSource, Common.SystemRequiredActive localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository, Common.SystemRequiredActive/*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Common.SystemRequiredActive'*/, IQueryable<Common.Queryable.Common_Claim>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Active == null);

            /*ComposableFilterByInfo BeforeFilter Common.Claim.'Common.SystemRequiredActive'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Common.SystemRequiredActive'*/);
        }

        public global::Common.Claim[] Filter(Rhetos.Dom.DefaultConcepts.ActiveItems filter_Parameter)
        {
            Func<Common.DomRepository, Rhetos.Dom.DefaultConcepts.ActiveItems/*FilterByInfo AdditionalParametersType Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/, Common.Claim[]> filter_Function =
                (repository, parameter) => repository.Common.Claim.Filter(repository.Common.Claim.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/);
        }

        public global::Common.Claim[] Filter(Common.SystemRequiredActive filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredActive/*FilterByInfo AdditionalParametersType Common.Claim.'Common.SystemRequiredActive'*/, Common.Claim[]> filter_Function =
                (repository, parameter) => repository.Common.Claim.Filter(repository.Common.Claim.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.Claim.'Common.SystemRequiredActive'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.Claim*/
    }

    /*DataStructureInfo RepositoryAttributes Common.MyClaim*/
    public class MyClaim_Repository : /*DataStructureInfo OverrideBaseType Common.MyClaim*/ Common.QueryableRepositoryBase<Common.Queryable.Common_MyClaim, Common.MyClaim> // Common.ReadableRepositoryBase<Common.MyClaim> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.MyClaim*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.MyClaim*/

        public MyClaim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.MyClaim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.MyClaim*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.MyClaim[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_MyClaim> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.MyClaim*/
            return Compute(_domRepository.Common.Claim.Query(), _domRepository/*DataStructureInfo AdditionalParametersArgument Common.MyClaim*/);
        }

        public readonly Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository/*DataStructureInfo AdditionalParametersType Common.MyClaim*/, IQueryable<Common.Queryable.Common_MyClaim>> Compute =
            (query, repository) =>
		{ throw new Rhetos.UserException("Reading Common.MyClaim without filter is not permitted. Use filter by Common.Claim or Common.Claim[]."); };

        public global::Common.MyClaim[] Filter(Common.Claim filter_Parameter)
        {
            Func<Common.DomRepository, Common.Claim, Common.ExecutionContext/*FilterByInfo AdditionalParametersType Common.MyClaim.'Common.Claim'*/, Common.MyClaim[]> filter_Function =
                (repository, parameter, executionContext) =>
			{
				var claim = repository.Common.Claim.Query().Where(item => item.ClaimResource == parameter.ClaimResource && item.ClaimRight == parameter.ClaimRight).SingleOrDefault();
				if (claim == null)
					throw new Rhetos.UserException("Claim {0}-{1} does not exist.",
						new[] { parameter.ClaimResource, parameter.ClaimRight }, null, null);
				
				return repository.Common.MyClaim.Filter(new[] { claim });
			};

            return filter_Function(_domRepository, filter_Parameter, _executionContext/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'Common.Claim'*/);
        }

        public global::Common.MyClaim[] Filter(IEnumerable<Common.Claim> filter_Parameter)
        {
            Func<Common.DomRepository, IEnumerable<Common.Claim>, Common.ExecutionContext/*FilterByInfo AdditionalParametersType Common.MyClaim.'IEnumerable<Common.Claim>'*/, Common.MyClaim[]> filter_Function =
                (repository, claims, executionContext) =>
			{
                var securityClaims = claims.Select(c => new Rhetos.Security.Claim(c.ClaimResource, c.ClaimRight)).ToList();
                var authorizations = executionContext.AuthorizationManager.GetAuthorizations(securityClaims);
			
                return claims.Zip(authorizations, (claim, authorized) => new Common.MyClaim {
                        ID = claim.ID,
                        Applies = authorized
                    }).ToArray();
             };

            return filter_Function(_domRepository, filter_Parameter, _executionContext/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'IEnumerable<Common.Claim>'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.MyClaim*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Principal*/
    public class Principal_Repository : /*DataStructureInfo OverrideBaseType Common.Principal*/ Common.OrmRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.QueryableRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.ReadableRepositoryBase<Common.Principal> // global::Common.RepositoryBase
        , IWritableRepository<Common.Principal>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Principal*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Principal*/

        public Principal_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Principal*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Principal*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Principal[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Principal> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Principal*/
            return _executionContext.EntityFrameworkContext.Common_Principal.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Principal> insertedNew, IEnumerable<Common.Principal> updatedNew, IEnumerable<Common.Principal> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Principal*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Principal.Name", "256" },
                        "DataStructure:Common.Principal,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Principal*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.Principal*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Principal> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Principal>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Principal> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Principal>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalHasRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalHasRole.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalHasRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalHasRole.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Principal*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Principal.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Principal", "Name" },
                        "DataStructure:Common.Principal,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Principal*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Principal.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"PrincipalID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"PrincipalID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Principal", @"IX_Principal_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Principal,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Principal*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Principal");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Principal> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalInfos = ((IEnumerable<Rhetos.Dom.DefaultConcepts.IPrincipal>)insertedNew).Concat(updatedNew)
                    .Concat(updatedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }))
                    .Concat(deletedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }));
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Principal*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Principal*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Principal");

                /*DataStructureInfo WritableOrm AfterSave Common.Principal*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Principal*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Principal*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalHasRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.ReadableRepositoryBase<Common.PrincipalHasRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalHasRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalHasRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalHasRole*/

        public PrincipalHasRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalHasRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalHasRole*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.PrincipalHasRole[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_PrincipalHasRole> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.PrincipalHasRole*/
            return _executionContext.EntityFrameworkContext.Common_PrincipalHasRole.AsNoTracking();
        }

        public void Save(IEnumerable<Common.PrincipalHasRole> insertedNew, IEnumerable<Common.PrincipalHasRole> updatedNew, IEnumerable<Common.PrincipalHasRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalHasRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalHasRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalHasRole*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalHasRole>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalHasRole>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalHasRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Principal" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Role" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalHasRole*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_PrincipalHasRole.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalHasRole", @"IX_PrincipalHasRole_Principal_Role"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:Principal Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_PrincipalHasRole_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalHasRole*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.PrincipalHasRole");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalHasRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalHasRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalHasRole");

                /*DataStructureInfo WritableOrm AfterSave Common.PrincipalHasRole*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalHasRole*/
            yield break;
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Query(Rhetos.Dom.DefaultConcepts.IPrincipal queryParameter)
        {
            /*QueryWithParameterInfo BeforeQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            Func<Rhetos.Dom.DefaultConcepts.IPrincipal, IQueryable<Common.Queryable.Common_PrincipalHasRole>> queryFunction = parameter => Query().Where(item => item.Principal.ID == parameter.ID);
            var queryResult = queryFunction(queryParameter);
            /*QueryWithParameterInfo AfterQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            return queryResult;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalHasRole.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalHasRole.Principal" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalHasRole.SystemRequiredPrincipal*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Filter(IQueryable<Common.Queryable.Common_PrincipalHasRole> localSource, Common.SystemRequiredPrincipal localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalHasRole>, Common.DomRepository, Common.SystemRequiredPrincipal/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/, IQueryable<Common.Queryable.Common_PrincipalHasRole>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Principal == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/);
        }

        public global::Common.PrincipalHasRole[] Filter(Common.SystemRequiredPrincipal filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredPrincipal/*FilterByInfo AdditionalParametersType Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/, Common.PrincipalHasRole[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalHasRole.Filter(repository.Common.PrincipalHasRole.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalHasRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Role*/
    public class Role_Repository : /*DataStructureInfo OverrideBaseType Common.Role*/ Common.OrmRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.QueryableRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.ReadableRepositoryBase<Common.Role> // global::Common.RepositoryBase
        , IWritableRepository<Common.Role>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Role*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Role*/

        public Role_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Role*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Role*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Role[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Role> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Role*/
            return _executionContext.EntityFrameworkContext.Common_Role.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Role> insertedNew, IEnumerable<Common.Role> updatedNew, IEnumerable<Common.Role> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Role*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Role.Name", "256" },
                        "DataStructure:Common.Role,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Role*/

            /*DataStructureInfo WritableOrm Initialization Common.Role*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Role> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Role>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Role> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Role>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.RoleInheritsRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RoleInheritsRole.Query()
                        .Where(child => child.UsersFromID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RoleInheritsRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RoleInheritsRole.Delete(childItems);
            }

            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.RoleID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }

            /*DataStructureInfo WritableOrm OldDataLoaded Common.Role*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Role.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Role", "Name" },
                        "DataStructure:Common.Role,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Role*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Role.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"RoleID", @"FK_PrincipalHasRole_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"UsersFromID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"PermissionsFromID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"RoleID", @"FK_RolePermission_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Role", @"IX_Role_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Role,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Role*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Role");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Role> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Concat(deletedIds).Select(r => r.ID);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Role*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Role*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Role");

                /*DataStructureInfo WritableOrm AfterSave Common.Role*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Role*/
            yield break;
        }

        /*DataStructureInfo RepositoryMembers Common.Role*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole_Repository : /*DataStructureInfo OverrideBaseType Common.RoleInheritsRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.ReadableRepositoryBase<Common.RoleInheritsRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.RoleInheritsRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RoleInheritsRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RoleInheritsRole*/

        public RoleInheritsRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RoleInheritsRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RoleInheritsRole*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RoleInheritsRole[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RoleInheritsRole> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RoleInheritsRole*/
            return _executionContext.EntityFrameworkContext.Common_RoleInheritsRole.AsNoTracking();
        }

        public void Save(IEnumerable<Common.RoleInheritsRole> insertedNew, IEnumerable<Common.RoleInheritsRole> updatedNew, IEnumerable<Common.RoleInheritsRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RoleInheritsRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RoleInheritsRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RoleInheritsRole*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RoleInheritsRole>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RoleInheritsRole>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RoleInheritsRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UsersFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.UsersFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "UsersFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:UsersFromID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PermissionsFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.PermissionsFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "PermissionsFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:PermissionsFromID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RoleInheritsRole*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_RoleInheritsRole.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RoleInheritsRole", @"IX_RoleInheritsRole_UsersFrom_PermissionsFrom"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFrom PermissionsFrom";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.RoleInheritsRole*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.RoleInheritsRole");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.UsersFromID)
                        .Concat(updatedOld.Select(item => item.UsersFromID))
                        .Concat(deletedOld.Select(item => item.UsersFromID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RoleInheritsRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RoleInheritsRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RoleInheritsRole");

                /*DataStructureInfo WritableOrm AfterSave Common.RoleInheritsRole*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredUsersFrom()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredUsersFrom(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RoleInheritsRole*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredUsersFrom(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredUsersFrom";
            metadata[@"Property"] = @"UsersFrom";
            /*InvalidDataInfo ErrorMetadata Common.RoleInheritsRole.SystemRequiredUsersFrom*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RoleInheritsRole.UsersFrom" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RoleInheritsRole.SystemRequiredUsersFrom*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_RoleInheritsRole> Filter(IQueryable<Common.Queryable.Common_RoleInheritsRole> localSource, Common.SystemRequiredUsersFrom localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RoleInheritsRole>, Common.DomRepository, Common.SystemRequiredUsersFrom/*ComposableFilterByInfo AdditionalParametersType Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/, IQueryable<Common.Queryable.Common_RoleInheritsRole>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.UsersFrom == null);

            /*ComposableFilterByInfo BeforeFilter Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/);
        }

        public global::Common.RoleInheritsRole[] Filter(Common.SystemRequiredUsersFrom filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredUsersFrom/*FilterByInfo AdditionalParametersType Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/, Common.RoleInheritsRole[]> filter_Function =
                (repository, parameter) => repository.Common.RoleInheritsRole.Filter(repository.Common.RoleInheritsRole.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.RoleInheritsRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalPermission*/
    public class PrincipalPermission_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalPermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.ReadableRepositoryBase<Common.PrincipalPermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalPermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalPermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalPermission*/

        public PrincipalPermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalPermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalPermission*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.PrincipalPermission[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_PrincipalPermission> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.PrincipalPermission*/
            return _executionContext.EntityFrameworkContext.Common_PrincipalPermission.AsNoTracking();
        }

        public void Save(IEnumerable<Common.PrincipalPermission> insertedNew, IEnumerable<Common.PrincipalPermission> updatedNew, IEnumerable<Common.PrincipalPermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalPermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalPermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalPermission*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_PrincipalPermission> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalPermission>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_PrincipalPermission> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalPermission>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalPermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Principal" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Claim" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "IsAuthorized" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalPermission*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_PrincipalPermission.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_PrincipalPermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalPermission", @"IX_PrincipalPermission_Principal_Claim"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:Principal Claim";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalPermission*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.PrincipalPermission");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalPermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalPermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalPermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalPermission");

                /*DataStructureInfo WritableOrm AfterSave Common.PrincipalPermission*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalPermission*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Principal" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalPermission.SystemRequiredPrincipal*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Claim" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalPermission.SystemRequiredClaim*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> localSource, Common.SystemRequiredPrincipal localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalPermission>, Common.DomRepository, Common.SystemRequiredPrincipal/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/, IQueryable<Common.Queryable.Common_PrincipalPermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Principal == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/);
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> localSource, Common.SystemRequiredClaim localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalPermission>, Common.DomRepository, Common.SystemRequiredClaim/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredClaim'*/, IQueryable<Common.Queryable.Common_PrincipalPermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Claim == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredClaim'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredClaim'*/);
        }

        public global::Common.PrincipalPermission[] Filter(Common.SystemRequiredPrincipal filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredPrincipal/*FilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/, Common.PrincipalPermission[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalPermission.Filter(repository.Common.PrincipalPermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/);
        }

        public global::Common.PrincipalPermission[] Filter(Common.SystemRequiredClaim filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredClaim/*FilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredClaim'*/, Common.PrincipalPermission[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalPermission.Filter(repository.Common.PrincipalPermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredClaim'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalPermission*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RolePermission*/
    public class RolePermission_Repository : /*DataStructureInfo OverrideBaseType Common.RolePermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.ReadableRepositoryBase<Common.RolePermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.RolePermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RolePermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RolePermission*/

        public RolePermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RolePermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RolePermission*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RolePermission[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RolePermission> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RolePermission*/
            return _executionContext.EntityFrameworkContext.Common_RolePermission.AsNoTracking();
        }

        public void Save(IEnumerable<Common.RolePermission> insertedNew, IEnumerable<Common.RolePermission> updatedNew, IEnumerable<Common.RolePermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RolePermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RolePermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RolePermission*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_RolePermission> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RolePermission>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_RolePermission> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RolePermission>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RolePermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Role" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Claim" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.RolePermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "IsAuthorized" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RolePermission*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_RolePermission.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RolePermission_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_RolePermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RolePermission", @"IX_RolePermission_Role_Claim"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:Role Claim";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.RolePermission*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.RolePermission");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RolePermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.RoleID)
                        .Concat(updatedOld.Select(item => item.RoleID))
                        .Concat(deletedOld.Select(item => item.RoleID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RolePermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RolePermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RolePermission");

                /*DataStructureInfo WritableOrm AfterSave Common.RolePermission*/

                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredRole()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredRole(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RolePermission*/
            yield break;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredRole(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredRole";
            metadata[@"Property"] = @"Role";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredRole*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RolePermission.Role" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RolePermission.SystemRequiredRole*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RolePermission.Claim" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RolePermission.SystemRequiredClaim*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> localSource, Common.SystemRequiredRole localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RolePermission>, Common.DomRepository, Common.SystemRequiredRole/*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredRole'*/, IQueryable<Common.Queryable.Common_RolePermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Role == null);

            /*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredRole'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredRole'*/);
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> localSource, Common.SystemRequiredClaim localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RolePermission>, Common.DomRepository, Common.SystemRequiredClaim/*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredClaim'*/, IQueryable<Common.Queryable.Common_RolePermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Claim == null);

            /*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredClaim'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredClaim'*/);
        }

        public global::Common.RolePermission[] Filter(Common.SystemRequiredRole filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredRole/*FilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredRole'*/, Common.RolePermission[]> filter_Function =
                (repository, parameter) => repository.Common.RolePermission.Filter(repository.Common.RolePermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredRole'*/);
        }

        public global::Common.RolePermission[] Filter(Common.SystemRequiredClaim filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredClaim/*FilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredClaim'*/, Common.RolePermission[]> filter_Function =
                (repository, parameter) => repository.Common.RolePermission.Filter(repository.Common.RolePermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredClaim'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.RolePermission*/
    }

    /*ModuleInfo HelperNamespaceMembers Common*/
}

/*RepositoryClasses*/