using Rhetos.Dsl;
using Rhetos.Dsl.DefaultConcepts;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hoteli.Concepts
{
    [Export(typeof(IConceptInfo))]
    [ConceptKeyword("UkloniRazmakePriSpremanju")]
    public class UkloniRazmakePriSpremanjuInfo : IConceptInfo
    {
       [ConceptKey]
       public ShortStringPropertyInfo Property { get; set; }
    }
}
