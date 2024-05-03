using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class GeneratorTests
{
    private const string ExampleXml = """
                                      <generator>
                                          <!-- description of the software which generates this UDDF file -->
                                          <name>DSL - Diver's Super Logbook</name>
                                          <type>logbook</type>
                                          <manufacturer>
                                              <name>Diveheroes Company</name>
                                              <aliasname>Diveheroes Company</aliasname>
                                              <aliasname>Diveheroes Company</aliasname>
                                              <aliasname>Diveheroes Company</aliasname>
                                              <aliasname>Diveheroes Company</aliasname>
                                          </manufacturer>
                                          <version>3.14159</version>
                                          <!-- date and time of generation of the UDDF file -->
                                          <datetime>2004-09-30T15:21:00</datetime>
                                      </generator>
                                      """;
    
    [Fact]
    public void CanDeserializeSimpleGenerator()
    {
        XmlSerializer serializer = new(typeof(Generator));

        Generator res = (Generator)serializer.Deserialize(new StringReader(ExampleXml))!;
        
        res.Name.ShouldBe("DSL - Diver's Super Logbook");
        res.SourceType.ShouldBe(SourceType.Logbook);
        res.Version.ShouldBe("3.14159");
        res.DateTime.ShouldBe(new DateTime(2004, 9, 30, 15, 21, 0));
        res.Manufacturer.ShouldNotBeNull();
    }
}