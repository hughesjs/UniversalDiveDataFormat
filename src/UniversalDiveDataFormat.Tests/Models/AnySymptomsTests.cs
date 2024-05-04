using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class AnySymptomsTests
{
	private const string Xml = """
	                           <anysymptoms>
	                               <notes>
	                                   <para>
	                                       About one hour after finishing the dive some itching occurs at arms and back,
	                                       the areas are coloured reddish. The following picture was taken about 70 min
	                                       after the dive:
	                                   </para>
	                                   <link ref="reddish_skin_after_70min"/>
	                                   <para>
	                                       This picture was taken about two hours after the dive:
	                                   </para>
	                                   <link ref="reddish_skin_after_120min"/>
	                               </notes>
	                           </anysymptoms>
	                           """;
	
	[Fact]
	public void CanReadAnySymptoms()
	{
		XmlSerializer serializer = new(typeof(AnySymptoms));
		AnySymptoms anySymptoms = serializer.Deserialize<AnySymptoms>(Xml);
		anySymptoms.Notes.ShouldNotBeNull();
	}
}