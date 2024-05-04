using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class CameraTests
{
	private const string Xml = """
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
	                                       <shop>
	                                           <name>Diveterminal</name>
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
	                               </flash>
	                           </camera>
	                           """;
	
	[Fact]
	public void CanReadCamera()
	{
		XmlSerializer serializer = new(typeof(Camera));
		Camera camera = serializer.Deserialize<Camera>(Xml);
		
		camera.Id.ShouldBe("Analogue-Camera");
		camera.Body.Id.ShouldBe("Nikonos_V");
		camera.Flash.ShouldNotBeNull();
		camera.Housing.ShouldNotBeNull();
		camera.Lens.ShouldNotBeNull();
	}
}