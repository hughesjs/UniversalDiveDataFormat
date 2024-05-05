using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class ProfileDataTests
{
	private const string Xml = """
	                           <profiledata>
	                                  <repetitiongroup id="rep_2002_a">
	                                      <!-- the first dive within a <repetitiongroup> section should have an infinite surface interval -->
	                                      <dive id="dive1_2002">
	                                          <surfaceintervalbeforedive>
	                                              <infinity/>
	                                          </surfaceintervalbeforedive>
	                                          <!-- more dive data -->
	                                      </dive>
	                                      <!-- all following dives in a <repetitiongroup> show a finite surface interval -->
	                                      <dive id="dive2_2002">
	                                          <surfaceintervalbeforedive>
	                                              <passedtime>17580.0</passedtime>
	                                          </surfaceintervalbeforedive>
	                                          <!-- more dive data -->
	                                      </dive>
	                                      <dive id="dive3_2002">
	                                          <!-- description of next dive -->
	                                      </dive>
	                                      <!-- here more dives can appear -->
	                                  </repetitiongroup>
	                                  <repetitiongroup id="rep_2003_a">
	                                      <!-- the first dive within a <repetitiongroup> section should have an infinite surface interval -->
	                                      <dive id="dive1_2003">
	                                          <surfaceintervalbeforedive>
	                                              <infinity/>
	                                          </surfaceintervalbeforedive>
	                                          <!-- more dive data -->
	                                      </dive>
	                                      <!-- here more dives (every one with a finite surface interval) -->
	                                  </repetitiongroup>
	                                  <!-- here can follow more <repetitiongroup> sections -->
	                           </profiledata>
	                           """;
	
	[Fact]
	public void CanReadProfileData()
	{
		XmlSerializer serializer = new(typeof(ProfileData));
		ProfileData profileData = serializer.Deserialize<ProfileData>(Xml);
		profileData.RepetitionGroups.Count.ShouldBe(2);
	}
}