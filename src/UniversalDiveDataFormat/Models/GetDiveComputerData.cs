using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("getdcdata")]
public class GetDiveComputerData
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
public class GetDcAllData; 

[XmlRoot("getdcbuddydata")]
public class GetDcBuddyData; 

[XmlRoot("getdcdivesitedata")]
public class GetDcDiveSiteData; 

[XmlRoot("getdcdivetripdata")]
public class GetDcDiveTripData; 

[XmlRoot("getdcgasdefinitionsdata")]
public class GetDcGasDefinitionsData; 

[XmlRoot("getdcgeneratordata")]
public class GetDcGeneratorData; 

[XmlRoot("getdcownerdata")]
public class GetDcOwnerData; 

[XmlRoot("getdcprofiledata")]
public class GetDcProfileData; 