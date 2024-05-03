using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("contact")]
public class Contact
{
    [XmlElement("email")]
    public List<string> Emails { get; init; } = [];
    [XmlElement("phone")]
    public List<string> Phones { get; init; } = [];
    [XmlElement("mobilephone")]
    public List<string> MobilePhones { get; init; } = [];
    [XmlElement("fax")]
    public List<string> Faxes { get; init; } = [];
    [XmlElement("homepage")]
    public List<string> Homepages { get; init; } = [];
    [XmlElement("language")]
    public List<string> Languages { get; init; } = [];
}