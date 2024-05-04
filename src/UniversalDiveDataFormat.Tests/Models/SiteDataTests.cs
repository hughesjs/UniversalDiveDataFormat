using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class SiteDataTests
{
	private const string Xml = """
	                           <sitedata>
	                               <maximumdepth>58.0</maximumdepth>
	                               <averagevisibility>25.0</averagevisibility>
	                               <density>1030.0</density>   <!-- Salzwasser -->
	                               <bottom>sandy ground</bottom>
	                               <wreck>
	                                   <name>Thistlegorm</name>
	                                   <shiptype>freighter</shiptype>
	                                   <nationality>English</nationality>
	                                   <built>
	                                       <shipyard>Vulcan, Stettin</shipyard>
	                                       <datetime>1916</datetime>
	                                   </built>
	                                   <shipdimension>
	                                       <length>140.0</length>
	                                       <beam>13.0</beam>
	                                       <draught>6.0</draught>
	                                       <displacement>4.385E6</displacement>
	                                   </shipdimension>
	                                   <sunk>
	                                       <datetime>1919-06-21T13:05:00</datetime>
	                                   </sunk>
	                                   <notes>
	                                       <para>
	                                           Magnificent wreck located in the Red Sea. Very impressive dive! :-)
	                                       </para>
	                                   </notes>
	                               </wreck>
	                           </sitedata>
	                           """;
	
	[Fact]
	public void CanReadSiteData()
	{
		XmlSerializer serializer = new(typeof(SiteData));
		SiteData siteData = serializer.Deserialize<SiteData>(Xml);
		siteData.MaximumDepthInMeters.ShouldBe(58.0f);
		siteData.AverageVisibilityInMeters.ShouldBe(25.0f);
		siteData.DensityInKgPerMeterCubed.ShouldBe(1030.0f);
		siteData.Bottom.ShouldBe("sandy ground");
		siteData.Wreck.ShouldNotBeNull();
	}
}