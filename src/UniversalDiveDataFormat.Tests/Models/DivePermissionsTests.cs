using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.ExtensionMethods;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class DivePermissionsTests
{
    private const string Xml = """
                               <divepermissions>
                                   <permit>
                                       <name>DiveCard</name>
                                       <region>Austria</region>
                                       <issuedate>
                                           <datetime>2004-08-24</datetime>
                                       </issuedate>
                                       <validdate>
                                           <datetime>2005-08-23</datetime>
                                       </validdate>
                                   </permit>
                               
                                   <permit>
                                       <name>DiveCard2</name>
                                       <region>Sealand</region>
                                       <issuedate>
                                           <datetime>2005-08-24</datetime>
                                       </issuedate>
                                       <validdate>
                                           <datetime>2005-08-23</datetime>
                                       </validdate>
                                   </permit>
                               </divepermissions>
                               """;
    
    [Fact]
    public void CanReadDivePermissions()
    {
        XmlSerializer serializer = new(typeof(DivePermissions));
        DivePermissions divePermissions = serializer.Deserialize<DivePermissions>(Xml);
        divePermissions.Permits.Count.ShouldBe(2);
    }
}