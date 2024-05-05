using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DiveComputerControlTests
{
	private const string Xml = """
	                           <divecomputercontrol>
	                               <getdcdata>
	                                   <!-- download only data concerning defined breathing gas mixes, -->
	                                   <!-- and all dive profile data to the calling soaftware         -->
	                                   <getdcgasdefinitionsdata/>
	                                   <getdcprofiledata/>
	                               </getdcdata>
	                               <setdcdata>
	                                   <setdcaltitude>0.0</setdcaltitude>
	                               </setdcdata>
	                           </divecomputercontrol>
	                           """;
	
	[Fact]
	public void CanReadDiveComputerControl()
	{
		XmlSerializer serializer = new(typeof(DiveComputerControl));
		DiveComputerControl diveComputerControl = serializer.Deserialize<DiveComputerControl>(Xml);
		diveComputerControl.GetDiveComputerData.ShouldNotBeNull();
		diveComputerControl.SetDiveComputerData.ShouldNotBeNull();
	}
}