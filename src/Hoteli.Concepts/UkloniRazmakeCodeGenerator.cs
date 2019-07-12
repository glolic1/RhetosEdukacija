using System;
using System.Collections.Generic;
using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rhetos.Compiler;
using Rhetos.Extensibility;
using Rhetos.Dom.DefaultConcepts;

namespace Hoteli.Concepts
{
    [Export(typeof(IConceptCodeGenerator))]
    [ExportMetadata(MefProvider.Implements, typeof(UkloniRazmakePriSpremanjuInfo))]
    public class UkloniRazmakeCodeGenerator : IConceptCodeGenerator
    {
        public void GenerateCode(IConceptInfo conceptInfo, ICodeBuilder codeBuilder)
        {
            var info = (UkloniRazmakePriSpremanjuInfo)conceptInfo;

            string snippet =
            $@"foreach (var item in insertedNew.Concat(updatedNew))
                    item.{info.Property.Name} = item.{info.Property.Name}
                                                        .Replace("" "", string.Empty);
            ";
            codeBuilder.InsertCode(snippet,
                WritableOrmDataStructureCodeGenerator.InitializationTag,
                info.Property.DataStructure);
        }
    }

}
