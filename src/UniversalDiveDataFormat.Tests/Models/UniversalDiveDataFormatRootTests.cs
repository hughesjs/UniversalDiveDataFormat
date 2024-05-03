using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;

namespace UniversalDiveDataFormat.Tests.Models;

public class UniversalDiveDataFormatRootTests
{
	private const string Xml = """
	                           <uddf version="3.2.1">
	                               <!-- The order given in this example is compulsory and must not be altered! -->
	                               <generator>
	                                   <!-- "fingerprint" of the program generating the UDDF file -->
	                               </generator>
	                               <mediadata>
	                                   <!-- declaration of all audio, image, and video files for later cross-referencing inside the UDDF file -->
	                               </mediadata>
	                               <maker>
	                                   <!-- declaration of all manufacturer data for later cross-referencing inside the UDDF file -->
	                               </maker>
	                               <business>
	                                   <!-- declaration of all shop data for later cross-referencing inside the UDDF file -->
	                               </business>
	                               <diver>
	                                   <!-- description of the owner of this UDDF file and his five buddies -->
	                               </diver>
	                               <divesite>
	                                   <!-- description of all dive spots -->
	                               </divesite>
	                               <gasdefinitions>
	                                   <!-- description of the breathing gases used by the owner of the UDDF file -->
	                               </gasdefinitions>
	                               <decomodel>
	                                   <!-- description of the decompression model parameters used -->
	                               </decomodel>
	                               <profiledata>
	                                   <!-- description of the individual dive profiles -->
	                               </profiledata>
	                               <tablegeneration>
	                                   <!-- parameters for the generation of different table types -->
	                               </tablegeneration>
	                               <divetrip>
	                                   <!-- description of all dive trips -->
	                               </divetrip>
	                               <divecomputercontrol>
	                                   <!-- statements for setting on data on a divecomputer, or downloading data from a dive computer -->
	                               </divecomputercontrol>
	                           </uddf>
	                           """;
	
	[Fact]
	public void CanDeserialize()
	{
		XmlSerializer serializer = new(typeof(UniversalDiveDataFormat.Models.UniversalDiveDataFormatRoot));
		UniversalDiveDataFormat.Models.UniversalDiveDataFormatRoot uddf = serializer.Deserialize<UniversalDiveDataFormat.Models.UniversalDiveDataFormatRoot>(Xml);
		
		uddf.Version.ShouldBe("3.2.1");
		uddf.Generator.ShouldNotBeNull();
		uddf.Business.ShouldNotBeNull();
		uddf.Diver.ShouldNotBeNull();
		uddf.DiveSite.ShouldNotBeNull();
		uddf.GasDefinitions.ShouldNotBeNull();
		uddf.DecoModel.ShouldNotBeNull();
		uddf.ProfileData.ShouldNotBeNull();
		uddf.TableGeneration.ShouldNotBeNull();
		uddf.DiveTrip.ShouldNotBeNull();
		uddf.DiveComputerControl.ShouldNotBeNull();
	}
}