using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class ObservationsTests
{
	private const string Xml = """
	                           <observations>
	                               <fauna>
	                                   <!-- here listed all animals seen during the dive -->
	                               </fauna>
	                               <flora>
	                                   <!-- here listed all plants recognized during the dive -->
	                               </flora>
	                               <notes>
	                                   <!-- here additional general information (text, images etc.) -->
	                               </notes>
	                           </observations>
	                           """;
	
	[Fact]
	public void CanReadObservations()
	{
		XmlSerializer serializer = new(typeof(Observations));
		Observations observations = serializer.Deserialize<Observations>(Xml);
		observations.Fauna.ShouldNotBeNull();
		observations.Flora.ShouldNotBeNull();
		observations.Notes.ShouldNotBeNull();
	}
}