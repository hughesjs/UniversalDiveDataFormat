using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class FaunaTests
{
	private const string Xml = """
	                           <fauna>
	                               <invertebrata>                <!-- invertebrates -->
	                                   <porifera>                <!-- sponges -->
	                                   </porifera>
	                                   <coelenterata>            <!-- coelenteratas -->
	                                   </coelenterata>
	                                   <cnidaria>                <!-- cnidarians -->
	                                   </cnidaria>
	                                   <ctenophora>              <!-- ctenophoranes -->
	                                   </ctenophora>
	                                   <plathelminthes>          <!-- flatworms -->
	                                   </plathelminthes>
	                                   <bryozoa>                 <!-- bryozoans -->
	                                   </bryozoa>
	                                   <phoronidea>              <!-- phoronids -->
	                                   </phoronidea>
	                                   <ascidiacea>              <!-- seasquirts -->
	                                   </ascidiacea>
	                                   <echinodermata>           <!-- echinoderms -->
	                                   </echinodermata>
	                                   <mollusca>                <!-- molluscs -->
	                                   </mollusca>
	                                   <crustacea>               <!-- crustaceans -->
	                                   </crustacea>
	                                   <invertebratavarious>     <!-- all other invertebrates -->
	                                   </invertebratavarious>
	                               </invertebrata>
	                               <vertebrata>                  <!-- vertebrates -->
	                                   <chondrichthyes>          <!-- cartilaginous fishes - sharks, rays -->
	                                   </chondrichthyes>
	                                   <osteichthyes>            <!-- Knochenfische -->
	                                   </osteichthyes>
	                                   <mammalia>                <!-- mammalians -->
	                                   </mammalia>
	                                   <amphibia>                <!-- amphibians -->
	                                   </amphibia>
	                                   <reptilia>                <!-- reptiles -->
	                                   </reptilia>
	                                   <vertebratavarious>       <!-- all other vertebrates-->
	                                   </vertebratavarious>
	                               </vertebrata>
	                           </fauna>
	                           """;
	
	[Fact]
	public void CanReadFauna()
	{
		XmlSerializer serializer = new(typeof(Fauna));
		Fauna fauna = serializer.Deserialize<Fauna>(Xml);
		fauna.Invertebrata.ShouldNotBeNull();
		fauna.Vertebrata.ShouldNotBeNull();
	}	
}