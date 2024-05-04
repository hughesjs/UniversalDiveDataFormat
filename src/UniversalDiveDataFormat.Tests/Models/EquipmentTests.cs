using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class EquipmentTests
{
	private const string Xml = """
	                           <equipment>
	                               <buoyancycontroldevice id="my_bcd">
	                                   <name>ABC</name>
	                                   <manufacturer>
	                                       <name>James Miller</name>
	                                   </manufacturer>
	                                   <model>Underwater Camping Team</model>
	                                   <serialnumber>123456789</serialnumber>
	                                   <purchase>
	                                       <datetime>1960-05-31</datetime>
	                                       <price currency="DM">100.00</price>
	                                       <shop>
	                                           <name>Dive Deep Down</name>
	                                           <address>
	                                               <!-- address of shop -->
	                                           </address>
	                                           <contact>
	                                               <!-- phone number, email address etc. -->
	                                           </contact>
	                                           <notes>
	                                               <!-- additional remarks -->
	                                           </notes>
	                                       </shop>
	                                   </purchase>
	                                   <!-- service every year -->
	                                   <serviceinterval>365</serviceinterval>
	                                   <nextservicedate>
	                                       <datetime>2006-05-31</datetime>
	                                   </nextservicedate>
	                               </buoyancycontroldevice>
	                               <boots id="my_boots">
	                                   <name>noname</name>
	                                   <manufacturer>
	                                       <name>Not Known</name>
	                                   </manufacturer>
	                                   <model>Size 48</model>
	                                   <!-- no serial number in this case :-) -->
	                                   <purchase>
	                                       <datetime>1970-10-07</datetime>
	                                       <price currency="DM">10.00</price>
	                                       <shop>
	                                           <name>Not-for-Diving</name>
	                                           <address>
	                                               <!-- address of shop -->
	                                           </address>
	                                           <contact>
	                                               <!-- phone number, email address etc. -->
	                                           </contact>
	                                           <notes>
	                                               <!-- additional remarks -->
	                                           </notes>
	                                       </shop>
	                                   </purchase>
	                                   <!-- better wash them once per month... ;-) -->
	                                   <serviceinterval>30</serviceinterval>
	                                   <!-- a certain service interval does not exist ;-) -->
	                               </boots>
	                               <camera id="Analogue-Camera">
	                                   <body id="Nikonos_V">
	                                       <name>Nikonos V</name>
	                                       <manufacturer>
	                                           <name>Nikon</name>
	                                       </manufacturer>
	                                       <model>V</model>
	                                       <serialnumber>987654321</serialnumber>
	                                       <purchase>
	                                           <datetime>1997-06-12</datetime>
	                                           <price currency="DM">850.00</price>
	                                           <shop>
	                                               <name>Photoshop</name>
	                                               <address>
	                                                   <!-- address of shop -->
	                                               </address>
	                                               <contact>
	                                                   <!-- phone number, email address etc. -->
	                                               </contact>
	                                               <notes>
	                                                   <!-- additional remarks -->
	                                               </notes>
	                                           </shop>
	                                       </purchase>
	                                       <serviceinterval>365</serviceinterval>
	                                       <nextservicedate>
	                                           <datetime>2007-03-11</datetime>
	                                       </nextservicedate>
	                                   </body>
	                                   <lens id="Nikonos_35mm">
	                                       <name>35 mm lens</name>
	                                       <manufacturer>
	                                           <name>Nikon</name>
	                                       </manufacturer>
	                                       <model>35 mm</model>
	                                       <serialnumber>123459876</serialnumber>
	                                       <purchase>
	                                           <datetime>1997-06-12</datetime>
	                                           <price currency="DM">430.00</price>
	                                           <shop>
	                                               <name>Photoshop</name>
	                                               <address>
	                                                   <!-- address of shop -->
	                                               </address>
	                                               <contact>
	                                                   <!-- phone number, email address etc. -->
	                                               </contact>
	                                               <notes>
	                                                   <!-- additional remarks -->
	                                               </notes>
	                                           </shop>
	                                       </purchase>
	                                       <serviceinterval>365</serviceinterval>
	                                       <nextservicedate>
	                                           <datetime>2007-03-11</datetime>
	                                       </nextservicedate>
	                                   </lens>
	                                   <lens id="Nikonos_20mm">
	                                       <name>20 mm lens</name>
	                                       <manufacturer>
	                                           <name>Nikon</name>
	                                       </manufacturer>
	                                       <model>20 mm</model>
	                                       <serialnumber>567890123</serialnumber>
	                                       <purchase>
	                                           <datetime>1999-11-23</datetime>
	                                           <price currency="DM">900.00</price>
	                                           <shop>
	                                               <name>Second hand</name>
	                                               <address>
	                                                   <!-- address of shop -->
	                                               </address>
	                                               <contact>
	                                                   <!-- phone number, email address etc. -->
	                                               </contact>
	                                               <notes>
	                                                   <!-- additional remarks -->
	                                               </notes>
	                                           </shop>
	                                       </purchase>
	                                       <serviceinterval></serviceinterval>
	                                       <nextservicedate>
	                                           <datetime>2000-12-01</datetime>
	                                       </nextservicedate>
	                                   </lens>
	                                   <flash id="Ikelite_200">
	                                       <name>Substrobe 200</name>
	                                       <manufacturer>
	                                           <name>Ikelite</name>
	                                       </manufacturer>
	                                       <model>200</model>
	                                       <serialnumber>0987654321</serialnumber>
	                                       <purchase>
	                                           <datetime>1998-12-26</datetime>
	                                           <price currency="DM">1350.00</price>
	                                           <shop>Diveterminal</shop>
	                                       </purchase>
	                                   </flash>
	                               </camera>
	                               <camera id="Digital-Camera">
	                                   <body id="Olympus">
	                                       <name>Digital camera</name>
	                                       <manufacturer>
	                                           <name>Olympus</name>
	                                       </manufacturer>
	                                       <model>7070</model>
	                                       <serialnumber>123789</serialnumber>
	                                       <purchase>
	                                           <datetime>2000-02-30</datetime>
	                                           <price currency="EUR">500.00</price>
	                                           <shop>Diveshop</shop>
	                                       </purchase>
	                                       <serviceinterval>365</serviceinterval>
	                                   </body>
	                                   <lens id="Olympus_Zoom_in_Body">
	                                       <name>Zoom lens</name>
	                                       <manufacturer>
	                                           <name>Olympus</name>
	                                       </manufacturer>
	                                       <model>10-1000</model>
	                                       <serialnumber>01928374</serialnumber>
	                                       <purchase>
	                                           <datetime>2000-02-30</datetime>
	                                           <price currency="EUR">500.00</price>
	                                           <shop>Diveshop</shop>
	                                       </purchase>
	                                   </lens>
	                               </camera>
	                               <!-- here may appear some additional descriptions of parts of diving equipment -->
	                               <tank id="tank_1">
	                                   <name>favourite tank</name>
	                                   <manufacturer>
	                                       <name>Super tank manufacturer</name>
	                                   </manufacturer>
	                                   <model>As hard as steel</model>
	                                   <serialnumber>12345</serialnumber>
	                                   <purchase>
	                                       <datetime>
	                                           <!-- date of purchase of tank -->
	                                       </datetime>
	                                       <price currency="DM">250.00</price>
	                                       <shop>
	                                           <!-- information concerning the shop, where the tank was bought -->
	                                       </shop>
	                                   </purchase>
	                                   <nextservicedate>
	                                       <datetime>
	                                           <!-- date of next proof by safety standards authority -->
	                                       </datetime>
	                                   </nextservicedate>
	                                   <tankmaterial>steel</tankmaterial>    <!-- steel tank -->
	                                   <notes>
	                                       <link ref="steeltank_new"/>
	                                       <link ref="steeltank_2_years_later"/>
	                                   </notes>
	                               </tank>
	                               <!-- here more tank descriptions can be inserted -->
	                               <!-- here more other descriptions can appear -->
	                           </equipment>
	                                           
	                           """;
	
	[Fact]
	public void CanReadEquipment()
	{
		XmlSerializer serializer = new(typeof(Equipment));
		Equipment equipment = serializer.Deserialize<Equipment>(Xml);
		
		equipment.BuoyancyControlDevices.Count.ShouldBe(1);
		equipment.Boots.Count.ShouldBe(1);
		equipment.Cameras.Count.ShouldBe(1);
		equipment.Compasses.Count.ShouldBe(1);
		equipment.Compressors.Count.ShouldBe(1);
		equipment.DiveComputers.Count.ShouldBe(1);
		equipment.Fins.Count.ShouldBe(1);
		equipment.Gloves.Count.ShouldBe(1);
		equipment.Knives.Count.ShouldBe(1);
		equipment.Lights.Count.ShouldBe(1);
		equipment.Masks.Count.ShouldBe(1);
		equipment.Rebreathers.Count.ShouldBe(1);
		equipment.Regulators.Count.ShouldBe(1);
		equipment.Scooters.Count.ShouldBe(1);
		equipment.Suits.Count.ShouldBe(1);
		equipment.Tanks.Count.ShouldBe(1);
		equipment.VideoCameras.Count.ShouldBe(1);
		equipment.Watches.Count.ShouldBe(1);
	}	
}