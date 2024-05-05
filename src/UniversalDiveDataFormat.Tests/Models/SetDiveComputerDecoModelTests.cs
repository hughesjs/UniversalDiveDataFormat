using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests;

public class SetDiveComputerDecoModelTests
{
	private const string Xml = """
	                           <setdcdecomodel>
	                               <name>RGBM</name>
	                               <aliasname>rgbm</aliasname>
	                               <applicationdata>
	                                   <elderberries/>
	                               </applicationdata>
	                           </setdcdecomodel>
	                           """;
	
	[Fact]
	public void CanReadSetDcDecoModel()
	{
		XmlSerializer serializer = new(typeof(SetDiveComputerDecoModel));
		SetDiveComputerDecoModel setDcDecoModel = serializer.Deserialize<SetDiveComputerDecoModel>(Xml);
		setDcDecoModel.Name.ShouldBe("RGBM");
		setDcDecoModel.AliasNames.Count.ShouldBe(1);
		setDcDecoModel.ApplicationData.ShouldNotBeNull();
	}
}