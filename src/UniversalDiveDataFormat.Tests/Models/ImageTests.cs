using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class ImageTests
{
	[Fact]
	public void CanReadSimpleImage()
	{
		const string xml = """
		                   <image id="image1">
		                       <objectname>image1.jpg</objectname>
		                   </image>
		                   """;

		XmlSerializer serializer = new(typeof(Image));
		Image image = serializer.Deserialize<Image>(xml);
		image.Id.ShouldBe("image1");
		image.ObjectName.ShouldBe("image1.jpg");
	}

	[Fact]
	public void CanReadImageWithExtraParams()
	{
		const string xml = """
		                   <image id="image2" height="1500" width="2000" format="jpg">
		                       <!-- here an absolute path (Windows world) is given to the image -->
		                       <objectname>d:/abc/image2.jpg</objectname>
		                   </image>
		                   """;
		
		XmlSerializer serializer = new(typeof(Image));
		Image image = serializer.Deserialize<Image>(xml);
		image.Id.ShouldBe("image2");
		image.Height.ShouldBe(1500);
		image.Width.ShouldBe(2000);
		image.Format.ShouldBe("jpg");
		image.ObjectName.ShouldBe("d:/abc/image2.jpg");
	}

	[Fact]
	public void CanReadImageWithImageData()
	{
		const string xml = """
		                   <image id="image3" height="1500" width="2000">
		                       <title>Buddy Mike lost a fin...</title>
		                       <!-- absolute path (Unix world) -->
		                       <objectname>/home/kai/diving/image3.jpg</objectname>
		                       <imagedata>
		                           <aperture>4.0</aperture>                <!-- aperture: 4 -->
		                           <filmspeed>100</filmspeed>              <!-- film speed: 100 ASA -->
		                           <shutterspeed>0.008</shutterspeed>      <!-- shutter speed: 1/125 s -->
		                           <focallength>0.02</focallength>         <!-- focal length: 20 mm -->
		                       </imagedata>
		                   </image>
		                   """;
		
		XmlSerializer serializer = new(typeof(Image));
		Image image = serializer.Deserialize<Image>(xml);
		image.Id.ShouldBe("image3");
		image.Height.ShouldBe(1500);
		image.Width.ShouldBe(2000);
		image.Title.ShouldBe("Buddy Mike lost a fin...");
		image.ObjectName.ShouldBe("/home/kai/diving/image3.jpg");
		image.ImageData.ShouldNotBeNull();
	}
}