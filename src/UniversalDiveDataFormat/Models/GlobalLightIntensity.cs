using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("globallightintensity")]
public enum GlobalLightIntensity
{
	//  undetermined, sunny, half-shadow, shadow, no-light 
	
	[XmlEnum("undetermined")]
	Undetermined,
	
	[XmlEnum("sunny")]
	Sunny,
	
	[XmlEnum("half-shadow")]
	HalfShadow,
	
	[XmlEnum("shadow")]
	Shadow,
	
	[XmlEnum("no-light")]
	NoLight
}