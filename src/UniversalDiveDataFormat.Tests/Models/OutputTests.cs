using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class OutputTests
{
	private const string Xml = """
	                           <output>
	                               <!-- English is the language to be used in the output -->
	                               <lingo>en</lingo>
	                               <fileformat>tex</fileformat>
	                               <!-- The file extension must not be given in the file name, because -->
	                               <!-- it is specified through the output format in the line above -->
	                               <filename>kais_tab1</filename>
	                               <headline>Kai_s Special Decompression Table</headline>
	                               <remark>The best decompression table ever generated!!! ;-)</remark>
	                           </output>
	                           """;
	
	[Fact]
	public void CanReadOutput()
	{
		XmlSerializer serializer = new(typeof(Output));
		Output output = serializer.Deserialize<Output>(Xml);
		output.FileFormat.ShouldBe("tex");
		output.FileName.ShouldBe("kais_tab1");
		output.Headline.ShouldBe("Kai_s Special Decompression Table");
		output.Remark.ShouldBe("The best decompression table ever generated!!! ;-)");
	}
}