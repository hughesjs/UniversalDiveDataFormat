using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests;

public class AddressTests
{
    private const string Xml = """
                               <address>
                                   <street>Waterroad 12</street>
                                   <city>Waterflood</city>
                                   <postcode>99999</postcode>
                                   <country>Wales</country>
                                   <province>Walhalla</province>
                               </address>
                               """;

    [Fact]
    public void CanReadAddress()
    {
        XmlSerializer serializer = new(typeof(Address));
        Address address = (Address)serializer.Deserialize(new StringReader(Xml))!;

        address.Street.ShouldBe("Waterroad 12");
        address.City.ShouldBe("Waterflood");
        address.Postcode.ShouldBe("99999");
        address.Country.ShouldBe("Wales");
        address.Province.ShouldBe("Walhalla");
    }
}