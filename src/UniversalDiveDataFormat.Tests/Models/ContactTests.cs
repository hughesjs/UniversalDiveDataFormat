using System.Xml.Serialization;
using Shouldly;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Tests.Models;

public class ContactTests
{
    public const string Xml = """
                              <contact>
                                  <language>English</language>
                                  <language>French</language>
                                  <phone>01234/987654</phone>
                                  <phone>01234/123123</phone>
                                  <mobilephone>0123/232323232</mobilephone>
                                  <mobilephone>0123/323232323</mobilephone>
                                  <fax>0123/232323231</fax>
                                  <fax>4444/232323231</fax>
                                  <email>walter.walrus@divedeep.info</email>
                                  <email>walter.asdf@divedeep.info</email>
                                  <homepage>http://www.divedeep.info/walter/</homepage>
                                  <homepage>http://www.divedeep.se/walter/</homepage>
                              </contact>
                              """;
    
    [Fact]
    public void CanReadContact()
    {
        XmlSerializer serializer = new(typeof(Contact));
        Contact contact = (Contact)serializer.Deserialize(new StringReader(Xml))!;

        contact.Emails.ShouldBe(new[] { "walter.walrus@divedeep.info", "walter.asdf@divedeep.info" });
        contact.Phones.ShouldBe(new[] { "01234/987654", "01234/123123" });
        contact.MobilePhones.ShouldBe(new[] { "0123/232323232", "0123/323232323" });
        contact.Faxes.ShouldBe(new[] { "0123/232323231", "4444/232323231" });
        contact.Homepages.ShouldBe(new[] { "http://www.divedeep.info/walter/", "http://www.divedeep.se/walter/" });
        contact.Languages.ShouldBe(new[] { "English", "French" });
    }
}