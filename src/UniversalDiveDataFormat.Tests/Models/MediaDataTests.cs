using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class MediaDataTests
{
	private const string Xml = """
	                           <mediadata>
	                               <audio id="audio_1">
	                                   <objectname>../abc/diving.wav</objectname>
	                               </audio>
	                               <audio id="audio_2">
	                                   <objectname>../abc/whale-singing.wav</objectname>
	                               </audio>
	                               <image id="img_kai">
	                                   <objectname>../images/kai.jpg</objectname>
	                               </image>
	                               <image id="img_whale">
	                                   <objectname>../images/whale.jpg</objectname>
	                               </image>
	                               <image id="image4" height="4000" width="3000" format="jpg">
	                                   <!-- absolute path (Unix world) -->
	                                   <objectname>/home/kai/diving/image4.jpg</objectname>
	                                   <imagedata>
	                                       <datetime>2007-01-06T10:17:41</datetime>
	                                       <aperture>2.8</aperture>                <!-- aperture: 2.8 -->
	                                       <!-- exposure compensation: -1 EV -->
	                                       <exposurecompensation>-1.0</exposurecompensation>
	                                       <filmspeed>400</filmspeed>              <!-- film speed: 400 ASA -->
	                                       <shutterspeed>0.002</shutterspeed>      <!-- shutter speed: 1/500 s -->
	                                       <focallength>0.035</focallength>        <!-- focal length of lens: 35 mm -->
	                                       <focusingdistance>1.3</focusingdistance>      <!-- focus distance of lens: 1.3 m -->
	                                       <meteringmethod>spot</meteringmethod>   <!-- spot-metering -->
	                                   </imagedata>
	                               </image>
	                               <video id="video_sail-dive-2000">
	                                   <objectname>/home/kai/logbook/videos/sail-dive-2000.mpg</objectname>
	                               </video>
	                               <!-- here more <audio>-, <image>-, or <video> elements -->
	                           </mediadata>
	                           """;
	
	[Fact]
	public void CanReadMediaData()
	{
		XmlSerializer serializer = new(typeof(MediaData));
		MediaData mediaData = serializer.Deserialize<MediaData>(Xml);
        mediaData.AudioFiles.Count.ShouldBe(2);
        mediaData.VideoFiles.Count.ShouldBe(1);
        mediaData.ImageFiles.Count.ShouldBe(3);
	}
}