using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class ManufacturerTests
{
    private const string Xml = """
                               <manufacturer id="manufacturer_lame_ducks">
                                   <name>Lame Ducks Inc.</name>
                                   <address>
                                       <street>Lake Road 12</street>
                                       <city>Laketown</city>
                                       <postcode>91827</postcode>
                                       <country>New Zealand</country>
                                       <province>Wellington District</province>
                                   </address>
                                   <contact>
                                   <phone>01234/987654</phone>
                                       <mobilephone>0123/232323232</mobilephone>
                                       <email>info@lame-ducks.com</email>
                                       <homepage>http://www.lame-ducks.com</homepage>
                                   </contact>
                               </manufacturer>
                               """;

    [Fact]
    public void CanReadManufacturer()
    {
        XmlSerializer xmlSerializer = new(typeof(Manufacturer));
        Manufacturer manufacturer = (Manufacturer)xmlSerializer.Deserialize(new StringReader(Xml))!;

        manufacturer.Id.ShouldBe("manufacturer_lame_ducks");
        manufacturer.Name.ShouldBe("Lame Ducks Inc.");
        manufacturer.Address.ShouldNotBeNull();
        manufacturer.Contact.ShouldNotBeNull();
    }
}