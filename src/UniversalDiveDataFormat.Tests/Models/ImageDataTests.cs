using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class ImageDataTests
{
	public const string Xml = """
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
	                          """;
	
	[Fact]
	public void CanReadImageData()
	{
		XmlSerializer serializer = new(typeof(ImageData));
		ImageData imageData = serializer.Deserialize<ImageData>(Xml);
		imageData.DateTime.ShouldBe(new DateTime(2007, 1, 6, 10, 17, 41));
		imageData.Aperture.ShouldBe(2.8f);
		imageData.Exposure.ShouldBe(-1.0f);
		imageData.FilmSpeed.ShouldBe(400);
		imageData.ShutterSpeedInSeconds.ShouldBe(0.002f);
		imageData.FocalLengthInMeters.ShouldBe(0.035f);
		imageData.FocussingDistanceInMeters.ShouldBe(1.3f);
		imageData.MeteringMethod.ShouldBe(MeteringMethod.Spot);
	}
}