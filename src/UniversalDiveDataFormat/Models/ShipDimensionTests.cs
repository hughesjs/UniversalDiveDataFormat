using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using Xunit;

namespace UniversalDiveDataFormat.Models;

public class ShipDimensionTests
{
	private const string Xml = """
	                           <shipdimension>
	                               <length>156.2</length>
	                               <beam>12.6</beam>
	                               <draught>5.7</draught>
	                               <displacement>123456.7</displacement>
	                               <tonnage>170000.0</tonnag>
	                           </shipdimension>
	                           """;
	
	[Fact]
	public void CanReadShipDimension()
	{
		XmlSerializer serializer = new(typeof(ShipDimension));
		ShipDimension shipDimension = serializer.Deserialize<ShipDimension>(Xml);
		shipDimension.LengthInMeters.ShouldBe(156.2f);
		shipDimension.BeamInMeters.ShouldBe(12.6f);
		shipDimension.DraughtInMeters.ShouldBe(5.7f);
		shipDimension.DisplacementInKilograms.ShouldBe(123456.7f);
		shipDimension.TonnageInKilograms.ShouldBe(170000.0f);
	}
}