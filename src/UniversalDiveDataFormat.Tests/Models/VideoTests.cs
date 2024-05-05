using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class VideoTests
{
	private const string Xml = """
	                           <video id="video_pirate-diving">
	                               <title>Under Pirate Divers</title>
	                               <objectname>../abc/pirate-diving.avi</objectname>
	                           </video>
	                           """;
	
	[Fact]
	public void CanReadVideo()
	{
		XmlSerializer serializer = new(typeof(Video));
		Video video = serializer.Deserialize<Video>(Xml);
		video.Id.ShouldBe("video_pirate-diving");
		video.Title.ShouldBe("Under Pirate Divers");
		video.ObjectName.ShouldBe("../abc/pirate-diving.avi");
	}
}