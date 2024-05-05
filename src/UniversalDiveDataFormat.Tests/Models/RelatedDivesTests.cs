using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class RelatedDivesTests
{
	private const string Xml = """
	                           <relateddives>
	                               <!-- six dives in this context -->
	                               <link ref="dive_45"/>
	                               <link ref="dive_46"/>
	                               <link ref="dive_47"/>
	                               <link ref="dive_48"/>
	                               <link ref="dive_49"/>
	                               <link ref="dive_50"/>
	                               
	                               <repetitiongroup id="rg1"/>
	                           </relateddives>
	                           """;
	
	[Fact]
	public void CanReadRelatedDives()
	{
		XmlSerializer serializer = new(typeof(RelatedDives));
		RelatedDives relatedDives = serializer.Deserialize<RelatedDives>(Xml);
		relatedDives.Links.Count.ShouldBe(6);
		relatedDives.RepetitionGroups.Count.ShouldBe(1);
	}
}