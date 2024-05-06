using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class WreckTests
{
    private const string Xml = """
                               <wreck>
                                   <name>Tuckerkahn</name>
                                   <shiptype>tanker</shiptype>
                                   <nationality>German</nationality>
                                   <built>
                                       <shipyard>Blohm &amp; Voss</shipyard>
                                       <launchingdate>
                                           <datetime>1943-06-14</datetime>
                                       </launchingdate>
                                   </built>
                                   <shipdimension>
                                       <length>156.2</length>
                                       <beam>12.6</beam>
                                       <draught>5.7</draught>
                                       <displacement>123456.7</displacement>
                                   </shipdimension>
                                   <sunk>
                                       <datetime>1985-05-24T15:46:00</datetime>
                                   </sunk>
                                   <notes>
                                       <!-- here additional remarks and/or photos, videos of the wreck -->
                                   </notes>
                               </wreck>
                               """;

    [Fact]
    public void CanReadWreck()
    {
        XmlSerializer serializer = new(typeof(Wreck));
        Wreck wreck = serializer.Deserialize<Wreck>(Xml);
        wreck.Name.ShouldBe("Tuckerkahn");
        wreck.ShipType.ShouldBe("tanker");
        wreck.Nationality.ShouldBe("German");
        wreck.Built.ShouldNotBeNull();
        wreck.ShipDimension.ShouldNotBeNull();
        wreck.Sunk.ShouldNotBeNull();
    }
}