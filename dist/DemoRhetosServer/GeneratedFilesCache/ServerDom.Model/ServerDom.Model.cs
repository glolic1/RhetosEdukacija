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
// CompilerOptions: "/optimize"

namespace Bookstore
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

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Book*/
    public class Book : EntityBase<Bookstore.Book>/*Next DataStructureInfo ClassInterace Bookstore.Book*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_Book ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_Book
            {
                ID = item.ID,
                Code = item.Code,
                Title = item.Title,
                NumberOfPages = item.NumberOfPages,
                Created = item.Created,
                AuthorID = item.AuthorID/*DataStructureInfo AssignSimpleProperty Bookstore.Book*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.Book.Code*/
        public string Code { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.Title*/
        public string Title { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.NumberOfPages*/
        public int? NumberOfPages { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.Book.AuthorID*/
        public Guid? AuthorID { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Book*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Pretrazivanje*/
    public class Pretrazivanje/*DataStructureInfo ClassInterace Bookstore.Pretrazivanje*/
    {
        [DataMember]/*PropertyInfo Attribute Bookstore.Pretrazivanje.MinBrojStranica*/
        public int? MinBrojStranica { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Pretrazivanje*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Pretrazivanje2*/
    public class Pretrazivanje2/*DataStructureInfo ClassInterace Bookstore.Pretrazivanje2*/
    {
        /*DataStructureInfo ClassBody Bookstore.Pretrazivanje2*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.BookBrowse*/
    public class BookBrowse : EntityBase<Bookstore.BookBrowse>/*Next DataStructureInfo ClassInterace Bookstore.BookBrowse*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_BookBrowse ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_BookBrowse
            {
                ID = item.ID,
                Title = item.Title,
                AuthorName = item.AuthorName,
                Extension_ChildBookAgeFrom = item.Extension_ChildBookAgeFrom/*DataStructureInfo AssignSimpleProperty Bookstore.BookBrowse*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.BookBrowse.Title*/
        public string Title { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.BookBrowse.AuthorName*/
        public string AuthorName { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.BookBrowse.Extension_ChildBookAgeFrom*/
        public int? Extension_ChildBookAgeFrom { get; set; }
        /*DataStructureInfo ClassBody Bookstore.BookBrowse*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.BooksThemes*/
    public class BooksThemes : EntityBase<Bookstore.BooksThemes>/*Next DataStructureInfo ClassInterace Bookstore.BooksThemes*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_BooksThemes ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_BooksThemes
            {
                ID = item.ID,
                Title = item.Title,
                NumberOfThemes = item.NumberOfThemes/*DataStructureInfo AssignSimpleProperty Bookstore.BooksThemes*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.BooksThemes.Title*/
        public string Title { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.BooksThemes.NumberOfThemes*/
        public int? NumberOfThemes { get; set; }
        /*DataStructureInfo ClassBody Bookstore.BooksThemes*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Person*/
    public class Person : EntityBase<Bookstore.Person>/*Next DataStructureInfo ClassInterace Bookstore.Person*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_Person ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_Person
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Person*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.Person.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Person*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.ChildBook*/
    public class ChildBook : EntityBase<Bookstore.ChildBook>/*Next DataStructureInfo ClassInterace Bookstore.ChildBook*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_ChildBook ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_ChildBook
            {
                ID = item.ID,
                AgeFrom = item.AgeFrom,
                AgeTo = item.AgeTo/*DataStructureInfo AssignSimpleProperty Bookstore.ChildBook*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.ChildBook.AgeFrom*/
        public int? AgeFrom { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.ChildBook.AgeTo*/
        public int? AgeTo { get; set; }
        /*DataStructureInfo ClassBody Bookstore.ChildBook*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.ForeignBook*/
    public class ForeignBook : EntityBase<Bookstore.ForeignBook>/*Next DataStructureInfo ClassInterace Bookstore.ForeignBook*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_ForeignBook ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_ForeignBook
            {
                ID = item.ID,
                OriginalLanguage = item.OriginalLanguage,
                TranslatorID = item.TranslatorID/*DataStructureInfo AssignSimpleProperty Bookstore.ForeignBook*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.ForeignBook.OriginalLanguage*/
        public string OriginalLanguage { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.ForeignBook.TranslatorID*/
        public Guid? TranslatorID { get; set; }
        /*DataStructureInfo ClassBody Bookstore.ForeignBook*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.Theme*/
    public class Theme : EntityBase<Bookstore.Theme>/*Next DataStructureInfo ClassInterace Bookstore.Theme*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_Theme ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_Theme
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Theme*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.Theme.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Bookstore.Theme*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.BookTheme*/
    public class BookTheme : EntityBase<Bookstore.BookTheme>/*Next DataStructureInfo ClassInterace Bookstore.BookTheme*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Bookstore_BookTheme ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Bookstore_BookTheme
            {
                ID = item.ID,
                BookID = item.BookID,
                ThemeID = item.ThemeID/*DataStructureInfo AssignSimpleProperty Bookstore.BookTheme*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Bookstore.BookTheme.BookID*/
        public Guid? BookID { get; set; }
        [DataMember]/*PropertyInfo Attribute Bookstore.BookTheme.ThemeID*/
        public Guid? ThemeID { get; set; }
        /*DataStructureInfo ClassBody Bookstore.BookTheme*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.NumberOfPages_MinValueFilter*/
    public class NumberOfPages_MinValueFilter/*DataStructureInfo ClassInterace Bookstore.NumberOfPages_MinValueFilter*/
    {
        /*DataStructureInfo ClassBody Bookstore.NumberOfPages_MinValueFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.ForeignBookAuthorNameStartsWithX*/
    public class ForeignBookAuthorNameStartsWithX/*DataStructureInfo ClassInterace Bookstore.ForeignBookAuthorNameStartsWithX*/
    {
        /*DataStructureInfo ClassBody Bookstore.ForeignBookAuthorNameStartsWithX*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.CommonMisspelling*/
    public class CommonMisspelling/*DataStructureInfo ClassInterace Bookstore.CommonMisspelling*/
    {
        /*DataStructureInfo ClassBody Bookstore.CommonMisspelling*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.SystemRequiredCode*/
    public class SystemRequiredCode/*DataStructureInfo ClassInterace Bookstore.SystemRequiredCode*/
    {
        /*DataStructureInfo ClassBody Bookstore.SystemRequiredCode*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Bookstore.SystemRequiredBook*/
    public class SystemRequiredBook/*DataStructureInfo ClassInterace Bookstore.SystemRequiredBook*/
    {
        /*DataStructureInfo ClassBody Bookstore.SystemRequiredBook*/
    }

    /*ModuleInfo Body Bookstore*/
}

namespace Rezervacije
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

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.Soba*/
    public class Soba : EntityBase<Rezervacije.Soba>/*Next DataStructureInfo ClassInterace Rezervacije.Soba*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Rezervacije_Soba ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Rezervacije_Soba
            {
                ID = item.ID,
                Ime = item.Ime,
                Broj = item.Broj,
                TipSobeIDID = item.TipSobeIDID,
                HotelID = item.HotelID/*DataStructureInfo AssignSimpleProperty Rezervacije.Soba*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Rezervacije.Soba.Ime*/
        public string Ime { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Soba.Broj*/
        public int? Broj { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Soba.TipSobeIDID*/
        public Guid? TipSobeIDID { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Soba.HotelID*/
        public Guid? HotelID { get; set; }
        /*DataStructureInfo ClassBody Rezervacije.Soba*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.TipSobe*/
    public class TipSobe : EntityBase<Rezervacije.TipSobe>/*Next DataStructureInfo ClassInterace Rezervacije.TipSobe*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Rezervacije_TipSobe ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Rezervacije_TipSobe
            {
                ID = item.ID,
                Ime = item.Ime,
                Cijena = item.Cijena/*DataStructureInfo AssignSimpleProperty Rezervacije.TipSobe*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Rezervacije.TipSobe.Ime*/
        public string Ime { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.TipSobe.Cijena*/
        public decimal? Cijena { get; set; }
        /*DataStructureInfo ClassBody Rezervacije.TipSobe*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.PretrazivanjeTipSobe*/
    public class PretrazivanjeTipSobe/*DataStructureInfo ClassInterace Rezervacije.PretrazivanjeTipSobe*/
    {
        [DataMember]/*PropertyInfo Attribute Rezervacije.PretrazivanjeTipSobe.MinimalnaCijena*/
        public int? MinimalnaCijena { get; set; }
        /*DataStructureInfo ClassBody Rezervacije.PretrazivanjeTipSobe*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.PretrazivanjeSobe*/
    public class PretrazivanjeSobe/*DataStructureInfo ClassInterace Rezervacije.PretrazivanjeSobe*/
    {
        /*DataStructureInfo ClassBody Rezervacije.PretrazivanjeSobe*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.Rezervacija*/
    public class Rezervacija : EntityBase<Rezervacije.Rezervacija>/*Next DataStructureInfo ClassInterace Rezervacije.Rezervacija*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Rezervacije_Rezervacija ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Rezervacije_Rezervacija
            {
                ID = item.ID,
                CheckIn = item.CheckIn,
                CheckOut = item.CheckOut,
                SobaIDID = item.SobaIDID,
                Created = item.Created,
                GostIDID = item.GostIDID/*DataStructureInfo AssignSimpleProperty Rezervacije.Rezervacija*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Rezervacije.Rezervacija.CheckIn*/
        public DateTime? CheckIn { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Rezervacija.CheckOut*/
        public DateTime? CheckOut { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Rezervacija.SobaIDID*/
        public Guid? SobaIDID { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Rezervacija.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Rezervacija.GostIDID*/
        public Guid? GostIDID { get; set; }
        /*DataStructureInfo ClassBody Rezervacije.Rezervacija*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.BrojRezervacijaPoSobi*/
    public class BrojRezervacijaPoSobi : EntityBase<Rezervacije.BrojRezervacijaPoSobi>/*Next DataStructureInfo ClassInterace Rezervacije.BrojRezervacijaPoSobi*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Rezervacije_BrojRezervacijaPoSobi ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Rezervacije_BrojRezervacijaPoSobi
            {
                ID = item.ID,
                BrojRezervacija = item.BrojRezervacija,
                Ime = item.Ime/*DataStructureInfo AssignSimpleProperty Rezervacije.BrojRezervacijaPoSobi*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Rezervacije.BrojRezervacijaPoSobi.BrojRezervacija*/
        public int? BrojRezervacija { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.BrojRezervacijaPoSobi.Ime*/
        public string Ime { get; set; }
        /*DataStructureInfo ClassBody Rezervacije.BrojRezervacijaPoSobi*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.BrowseSoba*/
    public class BrowseSoba : EntityBase<Rezervacije.BrowseSoba>/*Next DataStructureInfo ClassInterace Rezervacije.BrowseSoba*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Rezervacije_BrowseSoba ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Rezervacije_BrowseSoba
            {
                ID = item.ID,
                BrojSobe = item.BrojSobe,
                HotelName = item.HotelName,
                BrojRezervacija = item.BrojRezervacija/*DataStructureInfo AssignSimpleProperty Rezervacije.BrowseSoba*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Rezervacije.BrowseSoba.BrojSobe*/
        public int? BrojSobe { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.BrowseSoba.HotelName*/
        public string HotelName { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.BrowseSoba.BrojRezervacija*/
        public int? BrojRezervacija { get; set; }
        /*DataStructureInfo ClassBody Rezervacije.BrowseSoba*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.Hotel*/
    public class Hotel : EntityBase<Rezervacije.Hotel>/*Next DataStructureInfo ClassInterace Rezervacije.Hotel*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Rezervacije_Hotel ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Rezervacije_Hotel
            {
                ID = item.ID,
                Ime = item.Ime,
                Adresa = item.Adresa,
                BrojZvjezdica = item.BrojZvjezdica/*DataStructureInfo AssignSimpleProperty Rezervacije.Hotel*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Rezervacije.Hotel.Ime*/
        public string Ime { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Hotel.Adresa*/
        public string Adresa { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Hotel.BrojZvjezdica*/
        public int? BrojZvjezdica { get; set; }
        /*DataStructureInfo ClassBody Rezervacije.Hotel*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.Gost*/
    public class Gost : EntityBase<Rezervacije.Gost>/*Next DataStructureInfo ClassInterace Rezervacije.Gost*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Rezervacije_Gost ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Rezervacije_Gost
            {
                ID = item.ID,
                Ime = item.Ime,
                Prezime = item.Prezime,
                BrojTelefona = item.BrojTelefona,
                Email = item.Email/*DataStructureInfo AssignSimpleProperty Rezervacije.Gost*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Rezervacije.Gost.Ime*/
        public string Ime { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Gost.Prezime*/
        public string Prezime { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Gost.BrojTelefona*/
        public string BrojTelefona { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.Gost.Email*/
        public string Email { get; set; }
        /*DataStructureInfo ClassBody Rezervacije.Gost*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.StraniGost*/
    public class StraniGost : EntityBase<Rezervacije.StraniGost>/*Next DataStructureInfo ClassInterace Rezervacije.StraniGost*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Rezervacije_StraniGost ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Rezervacije_StraniGost
            {
                ID = item.ID,
                ImePrevoditelja = item.ImePrevoditelja,
                PrezimePrevoditelja = item.PrezimePrevoditelja/*DataStructureInfo AssignSimpleProperty Rezervacije.StraniGost*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Rezervacije.StraniGost.ImePrevoditelja*/
        public string ImePrevoditelja { get; set; }
        [DataMember]/*PropertyInfo Attribute Rezervacije.StraniGost.PrezimePrevoditelja*/
        public string PrezimePrevoditelja { get; set; }
        /*DataStructureInfo ClassBody Rezervacije.StraniGost*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.Cijena_MaxValueFilter*/
    public class Cijena_MaxValueFilter/*DataStructureInfo ClassInterace Rezervacije.Cijena_MaxValueFilter*/
    {
        /*DataStructureInfo ClassBody Rezervacije.Cijena_MaxValueFilter*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Rezervacije.CommonMisspelling*/
    public class CommonMisspelling/*DataStructureInfo ClassInterace Rezervacije.CommonMisspelling*/
    {
        /*DataStructureInfo ClassBody Rezervacije.CommonMisspelling*/
    }

    /*ModuleInfo Body Rezervacije*/
}

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

    /*ModuleInfo Using Common*/

    [DataContract]/*DataStructureInfo ClassAttributes Common.AutoCodeCache*/
    public class AutoCodeCache : EntityBase<Common.AutoCodeCache>/*Next DataStructureInfo ClassInterace Common.AutoCodeCache*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_AutoCodeCache ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Entity*/
        public string Entity { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Property*/
        public string Property { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Grouping*/
        public string Grouping { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.Prefix*/
        public string Prefix { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.MinDigits*/
        public int? MinDigits { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AutoCodeCache.LastCode*/
        public int? LastCode { get; set; }
        /*DataStructureInfo ClassBody Common.AutoCodeCache*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.FilterId*/
    public class FilterId : EntityBase<Common.FilterId>, Rhetos.Dom.DefaultConcepts.ICommonFilterId/*Next DataStructureInfo ClassInterace Common.FilterId*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_FilterId ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.FilterId.Handle*/
        public Guid? Handle { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.FilterId.Value*/
        public Guid? Value { get; set; }
        /*DataStructureInfo ClassBody Common.FilterId*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata : EntityBase<Common.KeepSynchronizedMetadata>, Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata/*Next DataStructureInfo ClassInterace Common.KeepSynchronizedMetadata*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_KeepSynchronizedMetadata ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Target*/
        public string Target { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Source*/
        public string Source { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.KeepSynchronizedMetadata.Context*/
        public string Context { get; set; }
        /*DataStructureInfo ClassBody Common.KeepSynchronizedMetadata*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ExclusiveLock*/
    public class ExclusiveLock : EntityBase<Common.ExclusiveLock>/*Next DataStructureInfo ClassInterace Common.ExclusiveLock*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_ExclusiveLock ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockStart*/
        public DateTime? LockStart { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ExclusiveLock.LockFinish*/
        public DateTime? LockFinish { get; set; }
        /*DataStructureInfo ClassBody Common.ExclusiveLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SetLock*/
    public class SetLock/*DataStructureInfo ClassInterace Common.SetLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.SetLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.SetLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.ReleaseLock*/
    public class ReleaseLock/*DataStructureInfo ClassInterace Common.ReleaseLock*/
    {
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceType*/
        public string ResourceType { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.ReleaseLock.ResourceID*/
        public Guid? ResourceID { get; set; }
        /*DataStructureInfo ClassBody Common.ReleaseLock*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogReader*/
    public class LogReader : EntityBase<Common.LogReader>/*Next DataStructureInfo ClassInterace Common.LogReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                Created = item.Created,
                Description = item.Description,
                ItemId = item.ItemId/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogReader.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogReader.ItemId*/
        public Guid? ItemId { get; set; }
        /*DataStructureInfo ClassBody Common.LogReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader : EntityBase<Common.LogRelatedItemReader>/*Next DataStructureInfo ClassInterace Common.LogRelatedItemReader*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItemReader ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                LogID = item.LogID,
                ItemId = item.ItemId/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItemReader.ItemId*/
        public Guid? ItemId { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItemReader*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Log*/
    public class Log : EntityBase<Common.Log>/*Next DataStructureInfo ClassInterace Common.Log*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Log ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Log.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Log.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.Log*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.AddToLog*/
    public class AddToLog/*DataStructureInfo ClassInterace Common.AddToLog*/
    {
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.AddToLog.Description*/
        public string Description { get; set; }
        /*DataStructureInfo ClassBody Common.AddToLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.LogRelatedItem*/
    public class LogRelatedItem : EntityBase<Common.LogRelatedItem>/*Next DataStructureInfo ClassInterace Common.LogRelatedItem*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_LogRelatedItem ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.ItemId*/
        public Guid? ItemId { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.LogRelatedItem.Relation*/
        public string Relation { get; set; }
        /*DataStructureInfo ClassBody Common.LogRelatedItem*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource : EntityBase<Common.RelatedEventsSource>/*Next DataStructureInfo ClassInterace Common.RelatedEventsSource*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RelatedEventsSource ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                Created = item.Created,
                Description = item.Description,
                ItemId = item.ItemId/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.LogID*/
        public Guid? LogID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Relation*/
        public string Relation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToTable*/
        public string RelatedToTable { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.RelatedToItem*/
        public Guid? RelatedToItem { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.UserName*/
        public string UserName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Workstation*/
        public string Workstation { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ContextInfo*/
        public string ContextInfo { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Action*/
        public string Action { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.TableName*/
        public string TableName { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Created*/
        public DateTime? Created { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.Description*/
        public string Description { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RelatedEventsSource.ItemId*/
        public Guid? ItemId { get; set; }
        /*DataStructureInfo ClassBody Common.RelatedEventsSource*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Claim*/
    public class Claim : EntityBase<Common.Claim>, Rhetos.Dom.DefaultConcepts.IDeactivatable, Rhetos.Dom.DefaultConcepts.ICommonClaim/*Next DataStructureInfo ClassInterace Common.Claim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Claim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimResource*/
        public string ClaimResource { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.ClaimRight*/
        public string ClaimRight { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.Claim.Active*/
        public bool? Active { get; set; }
        /*DataStructureInfo ClassBody Common.Claim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.MyClaim*/
    public class MyClaim : EntityBase<Common.MyClaim>/*Next DataStructureInfo ClassInterace Common.MyClaim*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_MyClaim ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.MyClaim.Applies*/
        public bool? Applies { get; set; }
        /*DataStructureInfo ClassBody Common.MyClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Principal*/
    public class Principal : EntityBase<Common.Principal>, Rhetos.Dom.DefaultConcepts.IPrincipal/*Next DataStructureInfo ClassInterace Common.Principal*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Principal ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Principal.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Principal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole : EntityBase<Common.PrincipalHasRole>, Rhetos.Dom.DefaultConcepts.IPrincipalHasRole/*Next DataStructureInfo ClassInterace Common.PrincipalHasRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalHasRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalHasRole.RoleID*/
        public Guid? RoleID { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalHasRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.Role*/
    public class Role : EntityBase<Common.Role>, Rhetos.Dom.DefaultConcepts.IRole/*Next DataStructureInfo ClassInterace Common.Role*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_Role ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.Role.Name*/
        public string Name { get; set; }
        /*DataStructureInfo ClassBody Common.Role*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole : EntityBase<Common.RoleInheritsRole>, Rhetos.Dom.DefaultConcepts.IRoleInheritsRole/*Next DataStructureInfo ClassInterace Common.RoleInheritsRole*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RoleInheritsRole ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.UsersFromID*/
        public Guid? UsersFromID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RoleInheritsRole.PermissionsFromID*/
        public Guid? PermissionsFromID { get; set; }
        /*DataStructureInfo ClassBody Common.RoleInheritsRole*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.PrincipalPermission*/
    public class PrincipalPermission : EntityBase<Common.PrincipalPermission>, Rhetos.Dom.DefaultConcepts.IPrincipalPermission/*Next DataStructureInfo ClassInterace Common.PrincipalPermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_PrincipalPermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.PrincipalID*/
        public Guid? PrincipalID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.PrincipalPermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.PrincipalPermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RolePermission*/
    public class RolePermission : EntityBase<Common.RolePermission>, Rhetos.Dom.DefaultConcepts.IRolePermission/*Next DataStructureInfo ClassInterace Common.RolePermission*/
    {
        /// <summary>Converts the simple object to a navigation object, and copies its simple properties. Navigation properties are set to null.</summary>
        public Common.Queryable.Common_RolePermission ToNavigation()
        {
            var item = this;
            return new Common.Queryable.Common_RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        [DataMember]/*PropertyInfo Attribute Common.RolePermission.RoleID*/
        public Guid? RoleID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.ClaimID*/
        public Guid? ClaimID { get; set; }
        [DataMember]/*PropertyInfo Attribute Common.RolePermission.IsAuthorized*/
        public bool? IsAuthorized { get; set; }
        /*DataStructureInfo ClassBody Common.RolePermission*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsReadItems*/
    public class RowPermissionsReadItems/*DataStructureInfo ClassInterace Common.RowPermissionsReadItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsReadItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.RowPermissionsWriteItems*/
    public class RowPermissionsWriteItems/*DataStructureInfo ClassInterace Common.RowPermissionsWriteItems*/
    {
        /*DataStructureInfo ClassBody Common.RowPermissionsWriteItems*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredActive*/
    public class SystemRequiredActive/*DataStructureInfo ClassInterace Common.SystemRequiredActive*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredActive*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredLog*/
    public class SystemRequiredLog/*DataStructureInfo ClassInterace Common.SystemRequiredLog*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredLog*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredPrincipal*/
    public class SystemRequiredPrincipal/*DataStructureInfo ClassInterace Common.SystemRequiredPrincipal*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredPrincipal*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredUsersFrom*/
    public class SystemRequiredUsersFrom/*DataStructureInfo ClassInterace Common.SystemRequiredUsersFrom*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredUsersFrom*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredClaim*/
    public class SystemRequiredClaim/*DataStructureInfo ClassInterace Common.SystemRequiredClaim*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredClaim*/
    }

    [DataContract]/*DataStructureInfo ClassAttributes Common.SystemRequiredRole*/
    public class SystemRequiredRole/*DataStructureInfo ClassInterace Common.SystemRequiredRole*/
    {
        /*DataStructureInfo ClassBody Common.SystemRequiredRole*/
    }

    /*ModuleInfo Body Common*/
}

/*SimpleClasses*/

namespace Common.Queryable
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*DataStructureInfo QueryableClassAttributes Bookstore.Book*/
    public class Bookstore_Book : global::Bookstore.Book, IQueryableEntity<Bookstore.Book>, System.IEquatable<Bookstore_Book>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.Book*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.Book ToSimple()
        {
            var item = this;
            return new Bookstore.Book
            {
                ID = item.ID,
                Code = item.Code,
                Title = item.Title,
                NumberOfPages = item.NumberOfPages,
                Created = item.Created,
                AuthorID = item.AuthorID/*DataStructureInfo AssignSimpleProperty Bookstore.Book*/
            };
        }

        private Common.Queryable.Bookstore_BooksThemes _extension_BooksThemes;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Extension_BooksThemes*/
        public virtual Common.Queryable.Bookstore_BooksThemes Extension_BooksThemes
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Extension_BooksThemes*/
                return _extension_BooksThemes;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Extension_BooksThemes*/
                _extension_BooksThemes = value;
            }
        }

        private Common.Queryable.Bookstore_Person _author;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Author*/
        public virtual Common.Queryable.Bookstore_Person Author
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Author*/
                return _author;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Author*/
                _author = value;
                AuthorID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Bookstore_ChildBook _extension_ChildBook;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Extension_ChildBook*/
        public virtual Common.Queryable.Bookstore_ChildBook Extension_ChildBook
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Extension_ChildBook*/
                return _extension_ChildBook;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Extension_ChildBook*/
                _extension_ChildBook = value;
            }
        }

        private Common.Queryable.Bookstore_ForeignBook _extension_ForeignBook;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Extension_ForeignBook*/
        public virtual Common.Queryable.Bookstore_ForeignBook Extension_ForeignBook
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Extension_ForeignBook*/
                return _extension_ForeignBook;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Extension_ForeignBook*/
                _extension_ForeignBook = value;
            }
        }

        private Common.Queryable.Bookstore_BookBrowse _extension_BookBrowse;

        /*DataStructureQueryable PropertyAttribute Bookstore.Book.Extension_BookBrowse*/
        public virtual Common.Queryable.Bookstore_BookBrowse Extension_BookBrowse
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.Book.Extension_BookBrowse*/
                return _extension_BookBrowse;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.Book.Extension_BookBrowse*/
                _extension_BookBrowse = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.Book*/

        public bool Equals(Bookstore_Book other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.BookBrowse*/
    public class Bookstore_BookBrowse : global::Bookstore.BookBrowse, IQueryableEntity<Bookstore.BookBrowse>, System.IEquatable<Bookstore_BookBrowse>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.BookBrowse*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.BookBrowse ToSimple()
        {
            var item = this;
            return new Bookstore.BookBrowse
            {
                ID = item.ID,
                Title = item.Title,
                AuthorName = item.AuthorName,
                Extension_ChildBookAgeFrom = item.Extension_ChildBookAgeFrom/*DataStructureInfo AssignSimpleProperty Bookstore.BookBrowse*/
            };
        }

        private Common.Queryable.Bookstore_Book _base;

        /*DataStructureQueryable PropertyAttribute Bookstore.BookBrowse.Base*/
        public virtual Common.Queryable.Bookstore_Book Base
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.BookBrowse.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.BookBrowse.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.BookBrowse*/

        public bool Equals(Bookstore_BookBrowse other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.BooksThemes*/
    public class Bookstore_BooksThemes : global::Bookstore.BooksThemes, IQueryableEntity<Bookstore.BooksThemes>, System.IEquatable<Bookstore_BooksThemes>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.BooksThemes*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.BooksThemes ToSimple()
        {
            var item = this;
            return new Bookstore.BooksThemes
            {
                ID = item.ID,
                Title = item.Title,
                NumberOfThemes = item.NumberOfThemes/*DataStructureInfo AssignSimpleProperty Bookstore.BooksThemes*/
            };
        }

        private Common.Queryable.Bookstore_Book _base;

        /*DataStructureQueryable PropertyAttribute Bookstore.BooksThemes.Base*/
        public virtual Common.Queryable.Bookstore_Book Base
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.BooksThemes.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.BooksThemes.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.BooksThemes*/

        public bool Equals(Bookstore_BooksThemes other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.Person*/
    public class Bookstore_Person : global::Bookstore.Person, IQueryableEntity<Bookstore.Person>, System.IEquatable<Bookstore_Person>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.Person*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.Person ToSimple()
        {
            var item = this;
            return new Bookstore.Person
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Person*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.Person*/

        public bool Equals(Bookstore_Person other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.ChildBook*/
    public class Bookstore_ChildBook : global::Bookstore.ChildBook, IQueryableEntity<Bookstore.ChildBook>, System.IEquatable<Bookstore_ChildBook>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.ChildBook*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.ChildBook ToSimple()
        {
            var item = this;
            return new Bookstore.ChildBook
            {
                ID = item.ID,
                AgeFrom = item.AgeFrom,
                AgeTo = item.AgeTo/*DataStructureInfo AssignSimpleProperty Bookstore.ChildBook*/
            };
        }

        private Common.Queryable.Bookstore_Book _base;

        /*DataStructureQueryable PropertyAttribute Bookstore.ChildBook.Base*/
        public virtual Common.Queryable.Bookstore_Book Base
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.ChildBook.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.ChildBook.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.ChildBook*/

        public bool Equals(Bookstore_ChildBook other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.ForeignBook*/
    public class Bookstore_ForeignBook : global::Bookstore.ForeignBook, IQueryableEntity<Bookstore.ForeignBook>, System.IEquatable<Bookstore_ForeignBook>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.ForeignBook*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.ForeignBook ToSimple()
        {
            var item = this;
            return new Bookstore.ForeignBook
            {
                ID = item.ID,
                OriginalLanguage = item.OriginalLanguage,
                TranslatorID = item.TranslatorID/*DataStructureInfo AssignSimpleProperty Bookstore.ForeignBook*/
            };
        }

        private Common.Queryable.Bookstore_Book _base;

        /*DataStructureQueryable PropertyAttribute Bookstore.ForeignBook.Base*/
        public virtual Common.Queryable.Bookstore_Book Base
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.ForeignBook.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.ForeignBook.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        private Common.Queryable.Bookstore_Person _translator;

        /*DataStructureQueryable PropertyAttribute Bookstore.ForeignBook.Translator*/
        public virtual Common.Queryable.Bookstore_Person Translator
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.ForeignBook.Translator*/
                return _translator;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.ForeignBook.Translator*/
                _translator = value;
                TranslatorID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.ForeignBook*/

        public bool Equals(Bookstore_ForeignBook other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.Theme*/
    public class Bookstore_Theme : global::Bookstore.Theme, IQueryableEntity<Bookstore.Theme>, System.IEquatable<Bookstore_Theme>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.Theme*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.Theme ToSimple()
        {
            var item = this;
            return new Bookstore.Theme
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Theme*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.Theme*/

        public bool Equals(Bookstore_Theme other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Bookstore.BookTheme*/
    public class Bookstore_BookTheme : global::Bookstore.BookTheme, IQueryableEntity<Bookstore.BookTheme>, System.IEquatable<Bookstore_BookTheme>, IDetachOverride/*DataStructureInfo QueryableClassInterace Bookstore.BookTheme*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Bookstore.BookTheme ToSimple()
        {
            var item = this;
            return new Bookstore.BookTheme
            {
                ID = item.ID,
                BookID = item.BookID,
                ThemeID = item.ThemeID/*DataStructureInfo AssignSimpleProperty Bookstore.BookTheme*/
            };
        }

        private Common.Queryable.Bookstore_Book _book;

        /*DataStructureQueryable PropertyAttribute Bookstore.BookTheme.Book*/
        public virtual Common.Queryable.Bookstore_Book Book
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.BookTheme.Book*/
                return _book;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.BookTheme.Book*/
                _book = value;
                BookID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Bookstore_Theme _theme;

        /*DataStructureQueryable PropertyAttribute Bookstore.BookTheme.Theme*/
        public virtual Common.Queryable.Bookstore_Theme Theme
        {
            get
            {
                /*DataStructureQueryable Getter Bookstore.BookTheme.Theme*/
                return _theme;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Bookstore.BookTheme.Theme*/
                _theme = value;
                ThemeID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Bookstore.BookTheme*/

        public bool Equals(Bookstore_BookTheme other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Rezervacije.Soba*/
    public class Rezervacije_Soba : global::Rezervacije.Soba, IQueryableEntity<Rezervacije.Soba>, System.IEquatable<Rezervacije_Soba>, IDetachOverride/*DataStructureInfo QueryableClassInterace Rezervacije.Soba*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Rezervacije.Soba ToSimple()
        {
            var item = this;
            return new Rezervacije.Soba
            {
                ID = item.ID,
                Ime = item.Ime,
                Broj = item.Broj,
                TipSobeIDID = item.TipSobeIDID,
                HotelID = item.HotelID/*DataStructureInfo AssignSimpleProperty Rezervacije.Soba*/
            };
        }

        private Common.Queryable.Rezervacije_TipSobe _tipSobeID;

        /*DataStructureQueryable PropertyAttribute Rezervacije.Soba.TipSobeID*/
        public virtual Common.Queryable.Rezervacije_TipSobe TipSobeID
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.Soba.TipSobeID*/
                return _tipSobeID;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.Soba.TipSobeID*/
                _tipSobeID = value;
                TipSobeIDID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Rezervacije_BrojRezervacijaPoSobi _extension_BrojRezervacijaPoSobi;

        /*DataStructureQueryable PropertyAttribute Rezervacije.Soba.Extension_BrojRezervacijaPoSobi*/
        public virtual Common.Queryable.Rezervacije_BrojRezervacijaPoSobi Extension_BrojRezervacijaPoSobi
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.Soba.Extension_BrojRezervacijaPoSobi*/
                return _extension_BrojRezervacijaPoSobi;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.Soba.Extension_BrojRezervacijaPoSobi*/
                _extension_BrojRezervacijaPoSobi = value;
            }
        }

        private Common.Queryable.Rezervacije_Hotel _hotel;

        /*DataStructureQueryable PropertyAttribute Rezervacije.Soba.Hotel*/
        public virtual Common.Queryable.Rezervacije_Hotel Hotel
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.Soba.Hotel*/
                return _hotel;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.Soba.Hotel*/
                _hotel = value;
                HotelID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Rezervacije_BrowseSoba _extension_BrowseSoba;

        /*DataStructureQueryable PropertyAttribute Rezervacije.Soba.Extension_BrowseSoba*/
        public virtual Common.Queryable.Rezervacije_BrowseSoba Extension_BrowseSoba
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.Soba.Extension_BrowseSoba*/
                return _extension_BrowseSoba;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.Soba.Extension_BrowseSoba*/
                _extension_BrowseSoba = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Rezervacije.Soba*/

        public bool Equals(Rezervacije_Soba other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Rezervacije.TipSobe*/
    public class Rezervacije_TipSobe : global::Rezervacije.TipSobe, IQueryableEntity<Rezervacije.TipSobe>, System.IEquatable<Rezervacije_TipSobe>, IDetachOverride/*DataStructureInfo QueryableClassInterace Rezervacije.TipSobe*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Rezervacije.TipSobe ToSimple()
        {
            var item = this;
            return new Rezervacije.TipSobe
            {
                ID = item.ID,
                Ime = item.Ime,
                Cijena = item.Cijena/*DataStructureInfo AssignSimpleProperty Rezervacije.TipSobe*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Rezervacije.TipSobe*/

        public bool Equals(Rezervacije_TipSobe other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Rezervacije.Rezervacija*/
    public class Rezervacije_Rezervacija : global::Rezervacije.Rezervacija, IQueryableEntity<Rezervacije.Rezervacija>, System.IEquatable<Rezervacije_Rezervacija>, IDetachOverride/*DataStructureInfo QueryableClassInterace Rezervacije.Rezervacija*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Rezervacije.Rezervacija ToSimple()
        {
            var item = this;
            return new Rezervacije.Rezervacija
            {
                ID = item.ID,
                CheckIn = item.CheckIn,
                CheckOut = item.CheckOut,
                SobaIDID = item.SobaIDID,
                Created = item.Created,
                GostIDID = item.GostIDID/*DataStructureInfo AssignSimpleProperty Rezervacije.Rezervacija*/
            };
        }

        private Common.Queryable.Rezervacije_Soba _sobaID;

        /*DataStructureQueryable PropertyAttribute Rezervacije.Rezervacija.SobaID*/
        public virtual Common.Queryable.Rezervacije_Soba SobaID
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.Rezervacija.SobaID*/
                return _sobaID;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.Rezervacija.SobaID*/
                _sobaID = value;
                SobaIDID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Rezervacije_Gost _gostID;

        /*DataStructureQueryable PropertyAttribute Rezervacije.Rezervacija.GostID*/
        public virtual Common.Queryable.Rezervacije_Gost GostID
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.Rezervacija.GostID*/
                return _gostID;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.Rezervacija.GostID*/
                _gostID = value;
                GostIDID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Rezervacije.Rezervacija*/

        public bool Equals(Rezervacije_Rezervacija other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Rezervacije.BrojRezervacijaPoSobi*/
    public class Rezervacije_BrojRezervacijaPoSobi : global::Rezervacije.BrojRezervacijaPoSobi, IQueryableEntity<Rezervacije.BrojRezervacijaPoSobi>, System.IEquatable<Rezervacije_BrojRezervacijaPoSobi>, IDetachOverride/*DataStructureInfo QueryableClassInterace Rezervacije.BrojRezervacijaPoSobi*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Rezervacije.BrojRezervacijaPoSobi ToSimple()
        {
            var item = this;
            return new Rezervacije.BrojRezervacijaPoSobi
            {
                ID = item.ID,
                BrojRezervacija = item.BrojRezervacija,
                Ime = item.Ime/*DataStructureInfo AssignSimpleProperty Rezervacije.BrojRezervacijaPoSobi*/
            };
        }

        private Common.Queryable.Rezervacije_Soba _base;

        /*DataStructureQueryable PropertyAttribute Rezervacije.BrojRezervacijaPoSobi.Base*/
        public virtual Common.Queryable.Rezervacije_Soba Base
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.BrojRezervacijaPoSobi.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.BrojRezervacijaPoSobi.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Rezervacije.BrojRezervacijaPoSobi*/

        public bool Equals(Rezervacije_BrojRezervacijaPoSobi other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Rezervacije.BrowseSoba*/
    public class Rezervacije_BrowseSoba : global::Rezervacije.BrowseSoba, IQueryableEntity<Rezervacije.BrowseSoba>, System.IEquatable<Rezervacije_BrowseSoba>, IDetachOverride/*DataStructureInfo QueryableClassInterace Rezervacije.BrowseSoba*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Rezervacije.BrowseSoba ToSimple()
        {
            var item = this;
            return new Rezervacije.BrowseSoba
            {
                ID = item.ID,
                BrojSobe = item.BrojSobe,
                HotelName = item.HotelName,
                BrojRezervacija = item.BrojRezervacija/*DataStructureInfo AssignSimpleProperty Rezervacije.BrowseSoba*/
            };
        }

        private Common.Queryable.Rezervacije_Soba _base;

        /*DataStructureQueryable PropertyAttribute Rezervacije.BrowseSoba.Base*/
        public virtual Common.Queryable.Rezervacije_Soba Base
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.BrowseSoba.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.BrowseSoba.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Rezervacije.BrowseSoba*/

        public bool Equals(Rezervacije_BrowseSoba other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Rezervacije.Hotel*/
    public class Rezervacije_Hotel : global::Rezervacije.Hotel, IQueryableEntity<Rezervacije.Hotel>, System.IEquatable<Rezervacije_Hotel>, IDetachOverride/*DataStructureInfo QueryableClassInterace Rezervacije.Hotel*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Rezervacije.Hotel ToSimple()
        {
            var item = this;
            return new Rezervacije.Hotel
            {
                ID = item.ID,
                Ime = item.Ime,
                Adresa = item.Adresa,
                BrojZvjezdica = item.BrojZvjezdica/*DataStructureInfo AssignSimpleProperty Rezervacije.Hotel*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Rezervacije.Hotel*/

        public bool Equals(Rezervacije_Hotel other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Rezervacije.Gost*/
    public class Rezervacije_Gost : global::Rezervacije.Gost, IQueryableEntity<Rezervacije.Gost>, System.IEquatable<Rezervacije_Gost>, IDetachOverride/*DataStructureInfo QueryableClassInterace Rezervacije.Gost*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Rezervacije.Gost ToSimple()
        {
            var item = this;
            return new Rezervacije.Gost
            {
                ID = item.ID,
                Ime = item.Ime,
                Prezime = item.Prezime,
                BrojTelefona = item.BrojTelefona,
                Email = item.Email/*DataStructureInfo AssignSimpleProperty Rezervacije.Gost*/
            };
        }

        private Common.Queryable.Rezervacije_StraniGost _extension_StraniGost;

        /*DataStructureQueryable PropertyAttribute Rezervacije.Gost.Extension_StraniGost*/
        public virtual Common.Queryable.Rezervacije_StraniGost Extension_StraniGost
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.Gost.Extension_StraniGost*/
                return _extension_StraniGost;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.Gost.Extension_StraniGost*/
                _extension_StraniGost = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Rezervacije.Gost*/

        public bool Equals(Rezervacije_Gost other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Rezervacije.StraniGost*/
    public class Rezervacije_StraniGost : global::Rezervacije.StraniGost, IQueryableEntity<Rezervacije.StraniGost>, System.IEquatable<Rezervacije_StraniGost>, IDetachOverride/*DataStructureInfo QueryableClassInterace Rezervacije.StraniGost*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Rezervacije.StraniGost ToSimple()
        {
            var item = this;
            return new Rezervacije.StraniGost
            {
                ID = item.ID,
                ImePrevoditelja = item.ImePrevoditelja,
                PrezimePrevoditelja = item.PrezimePrevoditelja/*DataStructureInfo AssignSimpleProperty Rezervacije.StraniGost*/
            };
        }

        private Common.Queryable.Rezervacije_Gost _base;

        /*DataStructureQueryable PropertyAttribute Rezervacije.StraniGost.Base*/
        public virtual Common.Queryable.Rezervacije_Gost Base
        {
            get
            {
                /*DataStructureQueryable Getter Rezervacije.StraniGost.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Rezervacije.StraniGost.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Rezervacije.StraniGost*/

        public bool Equals(Rezervacije_StraniGost other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.AutoCodeCache*/
    public class Common_AutoCodeCache : global::Common.AutoCodeCache, IQueryableEntity<Common.AutoCodeCache>, System.IEquatable<Common_AutoCodeCache>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.AutoCodeCache*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.AutoCodeCache ToSimple()
        {
            var item = this;
            return new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.AutoCodeCache*/

        public bool Equals(Common_AutoCodeCache other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.FilterId*/
    public class Common_FilterId : global::Common.FilterId, IQueryableEntity<Common.FilterId>, System.IEquatable<Common_FilterId>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.FilterId*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.FilterId ToSimple()
        {
            var item = this;
            return new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.FilterId*/

        public bool Equals(Common_FilterId other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.KeepSynchronizedMetadata*/
    public class Common_KeepSynchronizedMetadata : global::Common.KeepSynchronizedMetadata, IQueryableEntity<Common.KeepSynchronizedMetadata>, System.IEquatable<Common_KeepSynchronizedMetadata>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.KeepSynchronizedMetadata*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.KeepSynchronizedMetadata ToSimple()
        {
            var item = this;
            return new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.KeepSynchronizedMetadata*/

        public bool Equals(Common_KeepSynchronizedMetadata other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.ExclusiveLock*/
    public class Common_ExclusiveLock : global::Common.ExclusiveLock, IQueryableEntity<Common.ExclusiveLock>, System.IEquatable<Common_ExclusiveLock>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.ExclusiveLock*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.ExclusiveLock ToSimple()
        {
            var item = this;
            return new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.ExclusiveLock*/

        public bool Equals(Common_ExclusiveLock other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogReader*/
    public class Common_LogReader : global::Common.LogReader, IQueryableEntity<Common.LogReader>, System.IEquatable<Common_LogReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogReader ToSimple()
        {
            var item = this;
            return new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                Created = item.Created,
                Description = item.Description,
                ItemId = item.ItemId/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.LogReader*/

        public bool Equals(Common_LogReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItemReader*/
    public class Common_LogRelatedItemReader : global::Common.LogRelatedItemReader, IQueryableEntity<Common.LogRelatedItemReader>, System.IEquatable<Common_LogRelatedItemReader>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItemReader*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItemReader ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                LogID = item.LogID,
                ItemId = item.ItemId/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItemReader.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItemReader.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItemReader.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItemReader*/

        public bool Equals(Common_LogRelatedItemReader other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Log*/
    public class Common_Log : global::Common.Log, IQueryableEntity<Common.Log>, System.IEquatable<Common_Log>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Log*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Log ToSimple()
        {
            var item = this;
            return new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Log*/

        public bool Equals(Common_Log other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.LogRelatedItem*/
    public class Common_LogRelatedItem : global::Common.LogRelatedItem, IQueryableEntity<Common.LogRelatedItem>, System.IEquatable<Common_LogRelatedItem>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.LogRelatedItem*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.LogRelatedItem ToSimple()
        {
            var item = this;
            return new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            };
        }

        private Common.Queryable.Common_Log _log;

        /*DataStructureQueryable PropertyAttribute Common.LogRelatedItem.Log*/
        public virtual Common.Queryable.Common_Log Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.LogRelatedItem.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.LogRelatedItem.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.LogRelatedItem*/

        public bool Equals(Common_LogRelatedItem other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RelatedEventsSource*/
    public class Common_RelatedEventsSource : global::Common.RelatedEventsSource, IQueryableEntity<Common.RelatedEventsSource>, System.IEquatable<Common_RelatedEventsSource>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RelatedEventsSource*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RelatedEventsSource ToSimple()
        {
            var item = this;
            return new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                Created = item.Created,
                Description = item.Description,
                ItemId = item.ItemId/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            };
        }

        private Common.Queryable.Common_LogReader _log;

        /*DataStructureQueryable PropertyAttribute Common.RelatedEventsSource.Log*/
        public virtual Common.Queryable.Common_LogReader Log
        {
            get
            {
                /*DataStructureQueryable Getter Common.RelatedEventsSource.Log*/
                return _log;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RelatedEventsSource.Log*/
                _log = value;
                LogID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RelatedEventsSource*/

        public bool Equals(Common_RelatedEventsSource other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Claim*/
    public class Common_Claim : global::Common.Claim, IQueryableEntity<Common.Claim>, System.IEquatable<Common_Claim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Claim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Claim ToSimple()
        {
            var item = this;
            return new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            };
        }

        private Common.Queryable.Common_MyClaim _extension_MyClaim;

        /*DataStructureQueryable PropertyAttribute Common.Claim.Extension_MyClaim*/
        public virtual Common.Queryable.Common_MyClaim Extension_MyClaim
        {
            get
            {
                /*DataStructureQueryable Getter Common.Claim.Extension_MyClaim*/
                return _extension_MyClaim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.Claim.Extension_MyClaim*/
                _extension_MyClaim = value;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.Claim*/

        public bool Equals(Common_Claim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.MyClaim*/
    public class Common_MyClaim : global::Common.MyClaim, IQueryableEntity<Common.MyClaim>, System.IEquatable<Common_MyClaim>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.MyClaim*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.MyClaim ToSimple()
        {
            var item = this;
            return new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            };
        }

        private Common.Queryable.Common_Claim _base;

        /*DataStructureQueryable PropertyAttribute Common.MyClaim.Base*/
        public virtual Common.Queryable.Common_Claim Base
        {
            get
            {
                /*DataStructureQueryable Getter Common.MyClaim.Base*/
                return _base;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.MyClaim.Base*/
                _base = value;
                ID = value != null ? value.ID : Guid.Empty;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.MyClaim*/

        public bool Equals(Common_MyClaim other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Principal*/
    public class Common_Principal : global::Common.Principal, IQueryableEntity<Common.Principal>, System.IEquatable<Common_Principal>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Principal*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Principal ToSimple()
        {
            var item = this;
            return new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Principal*/

        public bool Equals(Common_Principal other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalHasRole*/
    public class Common_PrincipalHasRole : global::Common.PrincipalHasRole, IQueryableEntity<Common.PrincipalHasRole>, System.IEquatable<Common_PrincipalHasRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalHasRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalHasRole ToSimple()
        {
            var item = this;
            return new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalHasRole.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalHasRole.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalHasRole.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalHasRole*/

        public bool Equals(Common_PrincipalHasRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.Role*/
    public class Common_Role : global::Common.Role, IQueryableEntity<Common.Role>, System.IEquatable<Common_Role>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.Role*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.Role ToSimple()
        {
            var item = this;
            return new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            };
        }

        /*DataStructureInfo QueryableClassMembers Common.Role*/

        public bool Equals(Common_Role other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RoleInheritsRole*/
    public class Common_RoleInheritsRole : global::Common.RoleInheritsRole, IQueryableEntity<Common.RoleInheritsRole>, System.IEquatable<Common_RoleInheritsRole>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RoleInheritsRole*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RoleInheritsRole ToSimple()
        {
            var item = this;
            return new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            };
        }

        private Common.Queryable.Common_Role _usersFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.UsersFrom*/
        public virtual Common.Queryable.Common_Role UsersFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.UsersFrom*/
                return _usersFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.UsersFrom*/
                _usersFrom = value;
                UsersFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Role _permissionsFrom;

        /*DataStructureQueryable PropertyAttribute Common.RoleInheritsRole.PermissionsFrom*/
        public virtual Common.Queryable.Common_Role PermissionsFrom
        {
            get
            {
                /*DataStructureQueryable Getter Common.RoleInheritsRole.PermissionsFrom*/
                return _permissionsFrom;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RoleInheritsRole.PermissionsFrom*/
                _permissionsFrom = value;
                PermissionsFromID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RoleInheritsRole*/

        public bool Equals(Common_RoleInheritsRole other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.PrincipalPermission*/
    public class Common_PrincipalPermission : global::Common.PrincipalPermission, IQueryableEntity<Common.PrincipalPermission>, System.IEquatable<Common_PrincipalPermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.PrincipalPermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.PrincipalPermission ToSimple()
        {
            var item = this;
            return new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            };
        }

        private Common.Queryable.Common_Principal _principal;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Principal*/
        public virtual Common.Queryable.Common_Principal Principal
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Principal*/
                return _principal;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Principal*/
                _principal = value;
                PrincipalID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.PrincipalPermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.PrincipalPermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.PrincipalPermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.PrincipalPermission*/

        public bool Equals(Common_PrincipalPermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*DataStructureInfo QueryableClassAttributes Common.RolePermission*/
    public class Common_RolePermission : global::Common.RolePermission, IQueryableEntity<Common.RolePermission>, System.IEquatable<Common_RolePermission>, IDetachOverride/*DataStructureInfo QueryableClassInterace Common.RolePermission*/
    {
        bool IDetachOverride.Detaching { get; set; }

        /// <summary>Converts the object with navigation properties to a simple object with primitive properties.</summary>
        public Common.RolePermission ToSimple()
        {
            var item = this;
            return new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            };
        }

        private Common.Queryable.Common_Role _role;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Role*/
        public virtual Common.Queryable.Common_Role Role
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Role*/
                return _role;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Role*/
                _role = value;
                RoleID = value != null ? (Guid?)value.ID : null;
            }
        }

        private Common.Queryable.Common_Claim _claim;

        /*DataStructureQueryable PropertyAttribute Common.RolePermission.Claim*/
        public virtual Common.Queryable.Common_Claim Claim
        {
            get
            {
                /*DataStructureQueryable Getter Common.RolePermission.Claim*/
                return _claim;
            }
            set
            {
                if (((IDetachOverride)this).Detaching) return;
                /*DataStructureQueryable Setter Common.RolePermission.Claim*/
                _claim = value;
                ClaimID = value != null ? (Guid?)value.ID : null;
            }
        }

        /*DataStructureInfo QueryableClassMembers Common.RolePermission*/

        public bool Equals(Common_RolePermission other)
        {
            return other != null && other.ID == ID;
        }
    }

    /*CommonQueryableMemebers*/
}

namespace Rhetos.Dom.DefaultConcepts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    public static class QueryExtensions
    {
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Book> ToSimple(this IQueryable<Common.Queryable.Bookstore_Book> query)
        {
            return query.Select(item => new Bookstore.Book
            {
                ID = item.ID,
                Code = item.Code,
                Title = item.Title,
                NumberOfPages = item.NumberOfPages,
                Created = item.Created,
                AuthorID = item.AuthorID/*DataStructureInfo AssignSimpleProperty Bookstore.Book*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.BookBrowse> ToSimple(this IQueryable<Common.Queryable.Bookstore_BookBrowse> query)
        {
            return query.Select(item => new Bookstore.BookBrowse
            {
                ID = item.ID,
                Title = item.Title,
                AuthorName = item.AuthorName,
                Extension_ChildBookAgeFrom = item.Extension_ChildBookAgeFrom/*DataStructureInfo AssignSimpleProperty Bookstore.BookBrowse*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.BooksThemes> ToSimple(this IQueryable<Common.Queryable.Bookstore_BooksThemes> query)
        {
            return query.Select(item => new Bookstore.BooksThemes
            {
                ID = item.ID,
                Title = item.Title,
                NumberOfThemes = item.NumberOfThemes/*DataStructureInfo AssignSimpleProperty Bookstore.BooksThemes*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Person> ToSimple(this IQueryable<Common.Queryable.Bookstore_Person> query)
        {
            return query.Select(item => new Bookstore.Person
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Person*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.ChildBook> ToSimple(this IQueryable<Common.Queryable.Bookstore_ChildBook> query)
        {
            return query.Select(item => new Bookstore.ChildBook
            {
                ID = item.ID,
                AgeFrom = item.AgeFrom,
                AgeTo = item.AgeTo/*DataStructureInfo AssignSimpleProperty Bookstore.ChildBook*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.ForeignBook> ToSimple(this IQueryable<Common.Queryable.Bookstore_ForeignBook> query)
        {
            return query.Select(item => new Bookstore.ForeignBook
            {
                ID = item.ID,
                OriginalLanguage = item.OriginalLanguage,
                TranslatorID = item.TranslatorID/*DataStructureInfo AssignSimpleProperty Bookstore.ForeignBook*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.Theme> ToSimple(this IQueryable<Common.Queryable.Bookstore_Theme> query)
        {
            return query.Select(item => new Bookstore.Theme
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Bookstore.Theme*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Bookstore.BookTheme> ToSimple(this IQueryable<Common.Queryable.Bookstore_BookTheme> query)
        {
            return query.Select(item => new Bookstore.BookTheme
            {
                ID = item.ID,
                BookID = item.BookID,
                ThemeID = item.ThemeID/*DataStructureInfo AssignSimpleProperty Bookstore.BookTheme*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Rezervacije.Soba> ToSimple(this IQueryable<Common.Queryable.Rezervacije_Soba> query)
        {
            return query.Select(item => new Rezervacije.Soba
            {
                ID = item.ID,
                Ime = item.Ime,
                Broj = item.Broj,
                TipSobeIDID = item.TipSobeIDID,
                HotelID = item.HotelID/*DataStructureInfo AssignSimpleProperty Rezervacije.Soba*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Rezervacije.TipSobe> ToSimple(this IQueryable<Common.Queryable.Rezervacije_TipSobe> query)
        {
            return query.Select(item => new Rezervacije.TipSobe
            {
                ID = item.ID,
                Ime = item.Ime,
                Cijena = item.Cijena/*DataStructureInfo AssignSimpleProperty Rezervacije.TipSobe*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Rezervacije.Rezervacija> ToSimple(this IQueryable<Common.Queryable.Rezervacije_Rezervacija> query)
        {
            return query.Select(item => new Rezervacije.Rezervacija
            {
                ID = item.ID,
                CheckIn = item.CheckIn,
                CheckOut = item.CheckOut,
                SobaIDID = item.SobaIDID,
                Created = item.Created,
                GostIDID = item.GostIDID/*DataStructureInfo AssignSimpleProperty Rezervacije.Rezervacija*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Rezervacije.BrojRezervacijaPoSobi> ToSimple(this IQueryable<Common.Queryable.Rezervacije_BrojRezervacijaPoSobi> query)
        {
            return query.Select(item => new Rezervacije.BrojRezervacijaPoSobi
            {
                ID = item.ID,
                BrojRezervacija = item.BrojRezervacija,
                Ime = item.Ime/*DataStructureInfo AssignSimpleProperty Rezervacije.BrojRezervacijaPoSobi*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Rezervacije.BrowseSoba> ToSimple(this IQueryable<Common.Queryable.Rezervacije_BrowseSoba> query)
        {
            return query.Select(item => new Rezervacije.BrowseSoba
            {
                ID = item.ID,
                BrojSobe = item.BrojSobe,
                HotelName = item.HotelName,
                BrojRezervacija = item.BrojRezervacija/*DataStructureInfo AssignSimpleProperty Rezervacije.BrowseSoba*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Rezervacije.Hotel> ToSimple(this IQueryable<Common.Queryable.Rezervacije_Hotel> query)
        {
            return query.Select(item => new Rezervacije.Hotel
            {
                ID = item.ID,
                Ime = item.Ime,
                Adresa = item.Adresa,
                BrojZvjezdica = item.BrojZvjezdica/*DataStructureInfo AssignSimpleProperty Rezervacije.Hotel*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Rezervacije.Gost> ToSimple(this IQueryable<Common.Queryable.Rezervacije_Gost> query)
        {
            return query.Select(item => new Rezervacije.Gost
            {
                ID = item.ID,
                Ime = item.Ime,
                Prezime = item.Prezime,
                BrojTelefona = item.BrojTelefona,
                Email = item.Email/*DataStructureInfo AssignSimpleProperty Rezervacije.Gost*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Rezervacije.StraniGost> ToSimple(this IQueryable<Common.Queryable.Rezervacije_StraniGost> query)
        {
            return query.Select(item => new Rezervacije.StraniGost
            {
                ID = item.ID,
                ImePrevoditelja = item.ImePrevoditelja,
                PrezimePrevoditelja = item.PrezimePrevoditelja/*DataStructureInfo AssignSimpleProperty Rezervacije.StraniGost*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.AutoCodeCache> ToSimple(this IQueryable<Common.Queryable.Common_AutoCodeCache> query)
        {
            return query.Select(item => new Common.AutoCodeCache
            {
                ID = item.ID,
                Entity = item.Entity,
                Property = item.Property,
                Grouping = item.Grouping,
                Prefix = item.Prefix,
                MinDigits = item.MinDigits,
                LastCode = item.LastCode/*DataStructureInfo AssignSimpleProperty Common.AutoCodeCache*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.FilterId> ToSimple(this IQueryable<Common.Queryable.Common_FilterId> query)
        {
            return query.Select(item => new Common.FilterId
            {
                ID = item.ID,
                Handle = item.Handle,
                Value = item.Value/*DataStructureInfo AssignSimpleProperty Common.FilterId*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.KeepSynchronizedMetadata> ToSimple(this IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> query)
        {
            return query.Select(item => new Common.KeepSynchronizedMetadata
            {
                ID = item.ID,
                Target = item.Target,
                Source = item.Source,
                Context = item.Context/*DataStructureInfo AssignSimpleProperty Common.KeepSynchronizedMetadata*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.ExclusiveLock> ToSimple(this IQueryable<Common.Queryable.Common_ExclusiveLock> query)
        {
            return query.Select(item => new Common.ExclusiveLock
            {
                ID = item.ID,
                ResourceType = item.ResourceType,
                ResourceID = item.ResourceID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                LockStart = item.LockStart,
                LockFinish = item.LockFinish/*DataStructureInfo AssignSimpleProperty Common.ExclusiveLock*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogReader> ToSimple(this IQueryable<Common.Queryable.Common_LogReader> query)
        {
            return query.Select(item => new Common.LogReader
            {
                ID = item.ID,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                Created = item.Created,
                Description = item.Description,
                ItemId = item.ItemId/*DataStructureInfo AssignSimpleProperty Common.LogReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItemReader> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItemReader> query)
        {
            return query.Select(item => new Common.LogRelatedItemReader
            {
                ID = item.ID,
                TableName = item.TableName,
                Relation = item.Relation,
                LogID = item.LogID,
                ItemId = item.ItemId/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItemReader*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Log> ToSimple(this IQueryable<Common.Queryable.Common_Log> query)
        {
            return query.Select(item => new Common.Log
            {
                ID = item.ID,
                Created = item.Created,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Description = item.Description/*DataStructureInfo AssignSimpleProperty Common.Log*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.LogRelatedItem> ToSimple(this IQueryable<Common.Queryable.Common_LogRelatedItem> query)
        {
            return query.Select(item => new Common.LogRelatedItem
            {
                ID = item.ID,
                LogID = item.LogID,
                TableName = item.TableName,
                ItemId = item.ItemId,
                Relation = item.Relation/*DataStructureInfo AssignSimpleProperty Common.LogRelatedItem*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RelatedEventsSource> ToSimple(this IQueryable<Common.Queryable.Common_RelatedEventsSource> query)
        {
            return query.Select(item => new Common.RelatedEventsSource
            {
                ID = item.ID,
                LogID = item.LogID,
                Relation = item.Relation,
                RelatedToTable = item.RelatedToTable,
                RelatedToItem = item.RelatedToItem,
                UserName = item.UserName,
                Workstation = item.Workstation,
                ContextInfo = item.ContextInfo,
                Action = item.Action,
                TableName = item.TableName,
                Created = item.Created,
                Description = item.Description,
                ItemId = item.ItemId/*DataStructureInfo AssignSimpleProperty Common.RelatedEventsSource*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Claim> ToSimple(this IQueryable<Common.Queryable.Common_Claim> query)
        {
            return query.Select(item => new Common.Claim
            {
                ID = item.ID,
                ClaimResource = item.ClaimResource,
                ClaimRight = item.ClaimRight,
                Active = item.Active/*DataStructureInfo AssignSimpleProperty Common.Claim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.MyClaim> ToSimple(this IQueryable<Common.Queryable.Common_MyClaim> query)
        {
            return query.Select(item => new Common.MyClaim
            {
                ID = item.ID,
                Applies = item.Applies/*DataStructureInfo AssignSimpleProperty Common.MyClaim*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Principal> ToSimple(this IQueryable<Common.Queryable.Common_Principal> query)
        {
            return query.Select(item => new Common.Principal
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Principal*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalHasRole> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalHasRole> query)
        {
            return query.Select(item => new Common.PrincipalHasRole
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                RoleID = item.RoleID/*DataStructureInfo AssignSimpleProperty Common.PrincipalHasRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.Role> ToSimple(this IQueryable<Common.Queryable.Common_Role> query)
        {
            return query.Select(item => new Common.Role
            {
                ID = item.ID,
                Name = item.Name/*DataStructureInfo AssignSimpleProperty Common.Role*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RoleInheritsRole> ToSimple(this IQueryable<Common.Queryable.Common_RoleInheritsRole> query)
        {
            return query.Select(item => new Common.RoleInheritsRole
            {
                ID = item.ID,
                UsersFromID = item.UsersFromID,
                PermissionsFromID = item.PermissionsFromID/*DataStructureInfo AssignSimpleProperty Common.RoleInheritsRole*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.PrincipalPermission> ToSimple(this IQueryable<Common.Queryable.Common_PrincipalPermission> query)
        {
            return query.Select(item => new Common.PrincipalPermission
            {
                ID = item.ID,
                PrincipalID = item.PrincipalID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.PrincipalPermission*/
            });
        }
        /// <summary>Converts the objects with navigation properties to simple objects with primitive properties.</summary>
        public static IQueryable<Common.RolePermission> ToSimple(this IQueryable<Common.Queryable.Common_RolePermission> query)
        {
            return query.Select(item => new Common.RolePermission
            {
                ID = item.ID,
                RoleID = item.RoleID,
                ClaimID = item.ClaimID,
                IsAuthorized = item.IsAuthorized/*DataStructureInfo AssignSimpleProperty Common.RolePermission*/
            });
        }
        /*QueryExtensionsMembers*/

        /// <summary>
        /// A specific overload of the 'ToSimple' method cannot be targeted from a generic method using generic type.
        /// This method uses reflection instead to find the specific 'ToSimple' method.
        /// </summary>
        public static IQueryable<TEntity> GenericToSimple<TEntity>(this IQueryable<IEntity> i)
            where TEntity : class, IEntity
	    {
            var method = typeof(QueryExtensions).GetMethod("ToSimple", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public, null, new Type[] { i.GetType() }, null);
            if (method == null)
                throw new Rhetos.FrameworkException("Cannot find 'ToSimple' method for argument type '" + i.GetType().ToString() + "'.");
            return (IQueryable<TEntity>)Rhetos.Utilities.ExceptionsUtility.InvokeEx(method, null, new object[] { i });
        }

        /// <summary>Converts the objects to simple object and the IEnumerable to List or Array, if not already.</summary>
        public static void LoadSimpleObjects<TEntity>(ref IEnumerable<TEntity> items)
            where TEntity: class, IEntity
        {
            var query = items as IQueryable<IQueryableEntity<TEntity>>;
            var navigationItems = items as IEnumerable<IQueryableEntity<TEntity>>;

            if (query != null)
                items = query.GenericToSimple<TEntity>().ToList(); // The IQueryable function allows ORM optimizations.
            else if (navigationItems != null)
                items = navigationItems.Select(item => item.ToSimple()).ToList();
            else
            {
                Rhetos.Utilities.CsUtility.Materialize(ref items);
                var itemsList = (IList<TEntity>)items;
                for (int i = 0; i < itemsList.Count(); i++)
                {
                    var navigationItem = itemsList[i] as IQueryableEntity<TEntity>;
                    if (navigationItem != null)
                        itemsList[i] = navigationItem.ToSimple();
                }
            }
        }
    }
}