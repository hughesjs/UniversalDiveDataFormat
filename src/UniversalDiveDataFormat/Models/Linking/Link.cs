using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models.Linking;

[XmlRoot("link")]
public class Link
{
	[XmlAttribute("ref")]
	public required string Ref { get; init; }
	
	[XmlIgnore]
	public ILinkable? LinkedObject { get; private set; }
	
	[XmlIgnore]
	public bool IsResolved => LinkedObject is not null;
	
	public void SetLinkedObject(ILinkable? linkedObject)
	{
		LinkedObject = linkedObject;
	}
}