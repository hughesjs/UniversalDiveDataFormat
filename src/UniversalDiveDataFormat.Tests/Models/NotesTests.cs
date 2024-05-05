using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class NotesTests
{
	private const string xml = """
	                           <notes>
	                               <para>
	                                   This is text in-between the text element. Using this, it's not possible to further format the text. The executing program formats the text.
	                               </para>
	                               <link ref="image_1"/>
	                               <link ref="image_2"/>
	                               <para>
	                                   Now an audio file and a video sequence do follow...
	                               </para>
	                               <link ref="audio_1"/>
	                               <link ref="video_1"/>
	                           </notes>
	                           """;
	
	[Fact]
	public void CanParseNotes()
	{
		XmlSerializer serializer = new(typeof(Notes));
		Notes notes = serializer.Deserialize<Notes>(xml);
		
		notes.Paragraphs.Select(p => p.Trim()).ToList().ShouldBeEquivalentTo(new List<string>
		{
			"This is text in-between the text element. Using this, it's not possible to further format the text. The executing program formats the text.",
			"Now an audio file and a video sequence do follow..."
		});
		notes.Links.Count.ShouldBe(4);
	}
}