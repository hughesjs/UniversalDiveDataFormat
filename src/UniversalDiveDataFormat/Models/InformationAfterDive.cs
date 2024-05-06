using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("informationafterdive")]
public class InformationAfterDive: UddfModel
{
	
	[XmlElement("anysymptoms")]
	public AnySymptoms? AnySymptoms { get; init; }
	
	[XmlElement("averagedepth")]
	public float? AverageDepthInMeters { get; init; }
	
	[XmlElement("current")]
	public Current? Current { get; init; }
	
	[XmlElement("desaturationtime")]
	public float? DesaturationTimeInSeconds { get; init; }
	
	[XmlElement("diveduration")]
	public float? DiveDurationInSeconds { get; init; }
	
	[XmlElement("diveplan")]
	public DivePlanType? DivePlan { get; init; }
	
	[XmlElement("divetable")]
	public DiveTable? DiveTable { get; init; }
	
	[XmlElement("equipmentmalfunction")]
	public List<EquipmentMalfunction> EquipmentMalfunctions { get; init; } = [];
	
	[XmlElement("equipmentused")]
	public EquipmentUsed? EquipmentUsed { get; init; }
	
	[XmlElement("globalalarmsgiven")]
	public GlobalAlarmsGiven? GlobalAlarmsGiven { get; init; }
	
	[XmlElement("greatestdepth")]
	public float? GreatestDepthInMeters { get; init; }
	
	[XmlElement("highestpo2")]
	public float? HighestPartialPressureOfO2InPascals { get; init; }
	
	[XmlElement("lowesttemperature")]
	public float? LowestTemperatureInKelvin { get; init; }
	
	[XmlElement("noflighttime")]
	public float? NoFlightTimeInSeconds { get; init; }
	
	[XmlElement("notes")]
	public Notes? Notes { get; init; }
	
	[XmlElement("observations")]
	public Observations? Observations { get; init; }
	
	[XmlElement("pressuredrop")]
	public float? PressureDropInPascals { get; init; }
	
	[XmlElement("problems")]
	public List<ProblemType> Problems { get; init; } = [];
	
	[XmlElement("program")]
	public ProgramType? Program { get; init; }
	
	[XmlElement("rating")]
	public List<Rating> Ratings { get; init; } = [];
	
	[XmlElement("surfaceintervalafterdive")]
	public SurfaceIntervalAfterDive? SurfaceIntervalAfterDive { get; init; }
	
	[XmlElement("thermalcomfort")]
	public ThermalComfortType? ThermalComfort { get; init; }
	
	[XmlElement("visibility")]
	public float? VisibilityInMeters { get; init; }
	
	[XmlElement("workload")]
	public WorkloadType? Workload { get; init; }
}