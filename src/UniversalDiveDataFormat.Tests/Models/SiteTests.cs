using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;
using Environment = UniversalDiveDataFormat.Models.Environment;

namespace UniversalDiveDataFormat.Tests.Models;

public class SiteTests
{
	private const string Xml = """
	                           <site id="site_scapa_brummer">
	                               <!-- description of the first registered dive spot -->
	                               <name>brummer</name>
	                               <environment>ocean-sea</environment>
	                               <geography>
	                                   <location>scapa flow</location>
	                                   <province>orkney islands</province>
	                                   <country>uk</country>
	                                   <!-- degree of latitude: north > 0 / south < 0 -->
	                                   <latitude>58.897222</latitude>
	                                   <!-- degree of longitude: east > 0 / west < 0 -->
	                                   <longitude>-3.1519444</longitude>
	                                   <altitude>0.0</altitude>
	                               </geography>
	                               <sitedata>
	                                   <maximumdepth>37.0</maximumdepth>
	                                   <density>1030.0</density>   <!-- salt water -->
	                                   <bottom>sandy ground</bottom>
	                                   <wreck id="wreck_brummer">
	                                       <name>sms brummer</name>
	                                       <shiptype>light cruiser</shiptype>
	                                       <nationality>german</nationality>
	                                       <built>
	                                           <shipyard>vulcan, stettin</shipyard>
	                                           <launchingdate>
	                                               <datetime>1916</datetime>
	                                           </launchingdate>
	                                       </built>
	                                       <shipdimension>
	                                           <length>140.0</length>
	                                           <beam>13.0</beam>
	                                           <draught>6.0</draught>
	                                           <displacement>4.385e6</displacement>
	                                       </shipdimension>
	                                       <sunk>
	                                           <datetime>1919-06-21T13:05:00</datetime>
	                                       </sunk>
	                                       <notes>
	                                           <para>german high sea fleet</para>
	                                       </notes>
	                                   </wreck>
	                               </sitedata>
	                               <notes>
	                                   <para>really nice wreck dive!</para>
	                               </notes>
	                           </site>
	                           """;
	
	[Fact]
	public void CanReadSite()	
	{
		XmlSerializer serializer = new(typeof(Site));
		Site site = serializer.Deserialize<Site>(Xml);
		site.Id.ShouldBe("site_scapa_brummer");
		site.Name.ShouldBe("brummer");
		site.Environment.ShouldBe(Environment.OceanSea);
		site.Geography.ShouldNotBeNull();
		site.SiteData.ShouldNotBeNull();
		site.Notes.ShouldNotBeNull();
	}
}