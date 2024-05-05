using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SpeciesTests
{
    private const string Xml = """
                               <species id="rainbow-wrasse-1">
                                   <trivialname>Rainbow wrasse</trivialname>
                                   <scientificname>Coris julis</scientificname>
                                   <abundance occurrence="single-individual">1</abundance>         <!-- here: single fish -->
                                   <sex>male</sex>                                 <!-- here: male -->
                                   <lifestage>adult</lifestage>                    <!-- here: adult fish -->
                                   <size>0.13</size>                               <!-- length of fish 13 cm -->
                                   <notes>
                                       <link ref="img_coris_julis_001"/>              <!-- 1 photo taken of male fish -->
                                   </notes>
                               </species>
                               """;
    
    [Fact]
    public void CanReadSpecies()
    {
        XmlSerializer serializer = new(typeof(Species));
        Species species = serializer.Deserialize<Species>(Xml);
        species.Id.ShouldBe("rainbow-wrasse-1");
        species.TrivialName.ShouldBe("Rainbow wrasse");
        species.ScientificName.ShouldBe("Coris julis");
        species.Abundance.ShouldNotBeNull();
        species.Sex.ShouldBe(Sex.Male);
        species.LifeStage.ShouldBe(LifeStage.Adult);
        species.SizeInMeters.ShouldBe(0.13f);
        species.Notes.ShouldNotBeNull();
    }

}