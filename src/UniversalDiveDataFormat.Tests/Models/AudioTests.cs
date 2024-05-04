using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;


public class AudioTests
{
	private const string Xml = """
	                           <audio id="audio_diving">
	                               <title>Sounds of bubbles under water</title>
	                               <objectname>../abc/diving.wav</objectname>
	                           </audio>
	                           """;
	[Fact]
	public void CanReadAudio()
	{
		XmlSerializer serializer = new(typeof(Audio));
		Audio audio = serializer.Deserialize<Audio>(Xml);
		audio.Id.ShouldBe("audio_diving");
		audio.Title.ShouldBe("Sounds of bubbles under water");
		audio.ObjectName.ShouldBe("../abc/diving.wav");
	}
}