using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class VideoCameraTests
{
	private const string Xml = """
	                           <videocamera id="my_video_equipment">
	                               <body id="my_super_vidcam">
	                                   <name>DCR VX1000</name>
	                                   <manufacturer>
	                                       <name>Sony</name>
	                                   </manufacturer>
	                                   <model>VX1000</model>
	                                   <serialnumber>54321</serialnumber>
	                                   <purchase>
	                                       <datetime>1998-09-30</datetime>
	                                       <price currency="DM">7000.00</price>
	                                       <shop>Superstore</shop>
	                                   </purchase>
	                                   <!-- no service interval -->
	                               </body>
	                               <housing id="body_for_my_super_vidcam">
	                                   <name>VX1000</name>
	                                   <manufacturer>
	                                       <name>Amphibico</name>
	                                   </manufacturer>
	                                   <model>VX1000</model>
	                                   <serialnumber>76543</serialnumber>
	                                   <purchase>
	                                       <datetime>2000-06-30</datetime>
	                                       <price currency="DM">7000.00</price>
	                                       <shop>Dive Service Shark</shop>
	                                   </purchase>
	                                   <!-- no service interval -->
	                               </housing>
	                               <light id="videolight">
	                                   <name>Sunlight</name>
	                                   <manufacturer>
	                                       <name>Moonlight Inc.</name>
	                                   </manufacturer>
	                                   <model>1000 Watt</model>
	                                   <serialnumber>76543</serialnumber>
	                                   <purchase>
	                                       <datetime>2000-06-30</datetime>
	                                       <price currency="DM">1500.00</price>
	                                       <shop>Dive Service Shark</shop>
	                                   </purchase>
	                                   <!-- no service interval -->
	                               </light>
	                           </videocamera>
	                           """;
	
	[Fact]
	public void CanReadVideoCamera()
	{
		XmlSerializer serializer = new(typeof(VideoCamera));
		VideoCamera videoCamera = serializer.Deserialize<VideoCamera>(Xml);
		
		videoCamera.Id.ShouldBe("my_video_equipment");
		videoCamera.Body.ShouldNotBeNull();
		videoCamera.Housing.ShouldNotBeNull();
		videoCamera.Light.ShouldNotBeNull();
	}
}