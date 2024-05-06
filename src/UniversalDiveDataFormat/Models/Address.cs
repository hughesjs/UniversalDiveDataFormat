using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("address")]
public class Address: UddfModel
{
    [XmlElement("street")]
    public string? Street { get; init; }
    [XmlElement("city")]
    public string? City { get; init; }
    [XmlElement("postcode")]
    public string? Postcode { get; init; }
    
    [XmlElement("country")]
    public required string Country { get; init; }
    
    [XmlElement("province")]
    public string? Province { get; init; }
}