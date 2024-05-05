using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("setdcdata")]
public class SetDiveComputerData
{
	[XmlElement("setdcalarmtime")]
	public SetDiveComputerAlarmTime? SetDiveComputerAlarmTime { get; init; }
	
	[XmlElement("setdcaltitude")]
	public float? SetDiveComputerAltitudeInMeters { get; init; }
	
	[XmlElement("setdcbuddydata")]
	public SetDiveComputerBuddyData? SetDiveComputerBuddyData { get; init; }
	
	[XmlElement("setdcdatetime")]
	public SetDiveComputerDateTime? SetDiveComputerDateTime { get; init; }
	
	[XmlElement("setdcdecomodel")]
	public SetDiveComputerDecoModel? SetDiveComputerDecoModel { get; init; }
	
	[XmlElement("setdcdivedepthalarm")]
	public SetDiveComputerDiveDepthAlarm? SetDiveComputerDiveDepthAlarm { get; init; }
	
	[XmlElement("setdcdivepo2alarm")]
	public SetDiveComputerPartialPressureOfO2Alarm? SetDiveComputerPartialPressureOfO2Alarm { get; init; }
	
	[XmlElement("setdcdivesitedata")]
	public SetDiveComputerDiveSiteData? SetDiveComputerDiveSiteData { get; init; }
	
	[XmlElement("setdcdivetimealarm")]
	public SetDiveComputerDiveTimeAlarm? SetDiveComputerDiveTimeAlarm { get; init; }
	
	[XmlElement("setdcendndtalarm")]
	public SetDiveComputerEndNoDecoTimeAlarm? SetDiveComputerEndNoDecoTimeAlarm { get; init; }
	
	[XmlElement("setdcgasdefinitionsdata")]
	public SetDiveComputerGasDefinitionsData? SetDiveComputerGasDefinitionsData { get; init; }
	
	[XmlElement("setdcownerdata")]
	public SetDiveComputerOwnerData? SetDiveComputerOwnerData { get; init; }
	
	[XmlElement("setdcpassword")]
	public SetDiveComputerPassword? SetDiveComputerPassword { get; init; }
	
	[XmlElement("setdcgeneratordata")]
	public SetDiveComputerGeneratorData? SetDiveComputerGeneratorData { get; init; }
	
}

[XmlRoot("setdcgeneratordata")]
public class SetDiveComputerGeneratorData;

[XmlRoot("setdcownerdata")]
public class SetDiveComputerOwnerData;

[XmlRoot("setgasdefinitionsdata")]
public class SetDiveComputerGasDefinitionsData;