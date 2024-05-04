using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class EquipmentConfigurationTests
{
	private const string Xml = """
	                               <equipmentconfiguration id="warmwassertauchen">
	                                   <name>Standard-Warmwasserausrüstung</name>
	                                   <link ref="bcd_1"/>
	                                   <link ref="divecomputer_1"/>
	                                   <link ref="mask_2"/>
	                                   <link ref="compass_1"/>
	                                   <link ref="fins_1"/>
	                                   <link ref="tank_1"/>
	                               </equipmentconfiguration>
	                           """;
	
	[Fact]
	public void CanReadEquipmentConfiguration()
	{
		XmlSerializer serializer = new(typeof(EquipmentConfiguration));
		EquipmentConfiguration equipmentConfiguration = serializer.Deserialize<EquipmentConfiguration>(Xml);
		
		equipmentConfiguration.Id.ShouldBe("warmwassertauchen");
		equipmentConfiguration.Name.ShouldBe("Standard-Warmwasserausrüstung");
		equipmentConfiguration.Links.Count.ShouldBe(6);
	}
}