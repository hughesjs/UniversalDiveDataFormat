using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class MedicationBeforeDiveTests
{
	private const string Xml = """
	                           <medicationbeforedive>
	                           <!-- if <medicationbeforedive> is given at least one <medicine> section must appear -->
	                               <medicine id="med_paracetamol">
	                                   <name>Paracetamol</name>
	                                   <!-- not periodically taken -->
	                                   <periodicallytaken>no</periodicallytaken>
	                                   <!-- taken five hours before the dive -->
	                                   <timespanbeforedive>18000.0</timespanbeforedive>
	                                   <notes>
	                                       <para>
	                                           Taken five hours before the planned start of the dive because
	                                           a severe headache was coming up...
	                                       </para>
	                                   </notes>
	                               </medicine>
	                               <medicine id="med_abc">
	                                   <!-- here description of another drug taken before the dive -->
	                               </medicine>
	                               <!-- here more descriptions of additional drugs taken can follow -->
	                           </medicationbeforedive>
	                           """;
	
	[Fact]
	public void CanReadMedicationBeforeDive()
	{
		XmlSerializer serializer = new(typeof(MedicationBeforeDive));
		MedicationBeforeDive medicationBeforeDive = serializer.Deserialize<MedicationBeforeDive>(Xml);
		medicationBeforeDive.Medicines.Count.ShouldBe(2);
	}	
}