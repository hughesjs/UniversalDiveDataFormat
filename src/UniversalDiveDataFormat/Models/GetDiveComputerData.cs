using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("getdcdata")]
public class GetDiveComputerData: UddfModel
{
	[XmlElement("getdcalldata")]
	public GetDcAllData? GetDiveComputerAllData { get; init; }
	
	[XmlElement("getdcbuddydata")]
	public GetDcBuddyData? GetDiveComputerBuddyData { get; init; }
	
	[XmlElement("getdcdivesitedata")]
	public GetDcDiveSiteData? GetDiveComputerDiveSiteData { get; init; }
	
	[XmlElement("getdcdivetripdata")]
	public GetDcDiveTripData? GetDiveComputerDiveTripData { get; init; }
	
	[XmlElement("getdcgasdefinitionsdata")]
	public GetDcGasDefinitionsData? GetDiveComputerGasDefinitionsData { get; init; }
	
	[XmlElement("getdcgeneratordata")]
	public GetDcGeneratorData? GetDiveComputerGeneratorData { get; init; }
	
	[XmlElement("getdcownerdata")]
	public GetDcOwnerData? GetDiveComputerOwnerData { get; init; }
	
	[XmlElement("getdcprofiledata")]
	public GetDcProfileData? GetDiveComputerProfileData { get; init; }
}


[XmlRoot("getdcdata")]
public class GetDcAllData: UddfModel; 

[XmlRoot("getdcbuddydata")]
public class GetDcBuddyData: UddfModel; 

[XmlRoot("getdcdivesitedata")]
public class GetDcDiveSiteData: UddfModel; 

[XmlRoot("getdcdivetripdata")]
public class GetDcDiveTripData: UddfModel; 

[XmlRoot("getdcgasdefinitionsdata")]
public class GetDcGasDefinitionsData: UddfModel; 

[XmlRoot("getdcgeneratordata")]
public class GetDcGeneratorData: UddfModel; 

[XmlRoot("getdcownerdata")]
public class GetDcOwnerData: UddfModel; 

[XmlRoot("getdcprofiledata")]
public class GetDcProfileData: UddfModel; 