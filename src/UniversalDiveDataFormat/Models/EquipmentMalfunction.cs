using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

[XmlRoot("equipmentmalfunction")]
public enum EquipmentMalfunction
{
	[XmlEnum("none")]
	None,
	
	[XmlEnum("face-mask")]
	FaceMask,
	
	[XmlEnum("fins")]
	Fins,
	
	[XmlEnum("weight-belt")]
	WeightBelt,
	
	[XmlEnum("buoyancy-control-device")]
	BuoyancyControlDevice,
	
	[XmlEnum("thermal-protection (suit)")]
	ThermalProtectionSuit,
	
	[XmlEnum("dive-computer")]
	DiveComputer,
	
	[XmlEnum("depth-gauge")]
	DepthGauge,
	
	[XmlEnum("pressure-gauge")]
	PressureGauge,
	
	[XmlEnum("breathing-apparatus")]
	BreathingApparatus,
	
	[XmlEnum("deco-reel")]
	DecoReel,
	
	[XmlEnum("other")]
	Other
}