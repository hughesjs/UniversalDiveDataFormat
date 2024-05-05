using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DecoModelTests
{
	private const string Xml = """
	                           <decomodel>
	                               <!-- decompression model Bühlmann ZH-L16, version c - for use with dive computers -->
	                               <buehlmann id="zh-l16c">
	                                   <tissue gas="n2" number="1" halflife="240.0" a="1.2599" b="0.5050"/>
	                                   <tissue gas="n2" number="2" halflife="480.0" a="1.0" b="0.6514"/>
	                                   <tissue gas="n2" number="3" halflife="750.0" a="0.8618" b="0.7222"/>
	                                   <tissue gas="n2" number="4" halflife="1110.0" a="0.7562" b="0.7825"/>
	                                   <tissue gas="n2" number="5" halflife="1620.0" a="0.62" b="0.8126"/>
	                                   <tissue gas="n2" number="6" halflife="2298.0" a="0.5043" b="0.8434"/>
	                                   <tissue gas="n2" number="7" halflife="3258.0" a="0.441" b="0.8693"/>
	                                   <tissue gas="n2" number="8" halflife="4620.0" a="0.4" b="0.891"/>
	                                   <tissue gas="n2" number="9" halflife="6540.0" a="0.375" b="0.9092"/>
	                                   <tissue gas="n2" number="10" halflife="8760.0" a="0.35" b="0.9222"/>
	                                   <tissue gas="n2" number="11" halflife="11220.0" a="0.3295" b="0.9319"/>
	                                   <tissue gas="n2" number="12" halflife="14340.0" a="0.3065" b="0.9403"/>
	                                   <tissue gas="n2" number="13" halflife="18300.0" a="0.2835" b="0.9477"/>
	                                   <tissue gas="n2" number="14" halflife="23400.0" a="0.261" b="0.9544"/>
	                                   <tissue gas="n2" number="15" halflife="29880.0" a="0.248" b="0.9602"/>
	                                   <tissue gas="n2" number="16" halflife="38100.0" a="0.2327" b="0.9653"/>
	                              </buehlmann>
	                              <rgbm id="rgbm_1">
	                                   <tissue gas="n2" number="7" halflife="3258.0" a="0.441" b="0.8693"/>
	                              </rgbm>
	                              <vpm id="vpm-b">
	                                   <conservatism>0.42</conservatism>
	                                   <gamma>0.0179</gamma>
	                                   <gc>0.257</gc>
	                                   <lambda>367431.06061</lambda>
	                                   <r0>1.0e-6</r0>
	                                   <tissue gas="n2" number="8" halflife="4620.0" a="0.4" b="0.891"/>
	                              </vpm>
	                           </decomodel>
	                                           
	                           """;
	
	[Fact]
	public void CanReadDecoModel()
	{
		XmlSerializer serializer = new(typeof(DecoModel));
		DecoModel decomodel = serializer.Deserialize<DecoModel>(Xml);
		decomodel.BuehlmannModels.Count.ShouldBe(1);
		decomodel.RgbmModels.Count.ShouldBe(1);
		decomodel.VpmModels.Count.ShouldBe(1);
	}	
}