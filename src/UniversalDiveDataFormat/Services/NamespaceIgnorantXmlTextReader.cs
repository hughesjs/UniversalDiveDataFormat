using System.Xml;

namespace UniversalDiveDataFormat.Services;

// This is needed because not all sources set the xmlns correctly
public class NamespaceIgnorantXmlTextReader : XmlTextReader
{
	public NamespaceIgnorantXmlTextReader(TextReader reader): base(reader) { }
	public NamespaceIgnorantXmlTextReader(Stream stream): base(stream) { }

	public override string NamespaceURI => string.Empty;
}