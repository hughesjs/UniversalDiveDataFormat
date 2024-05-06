using System.Xml.Serialization;
using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Services;

public class UddfDeserialiser: IUddfDeserialiser
{
	private readonly LinkResolutionService _linkResolutionService;
	public UddfDeserialiser(LinkResolutionService linkResolutionService)
	{
		_linkResolutionService = linkResolutionService;
	}
	
	public T Deserialise<T>(string xml) where T : UddfModel => Deserialise<T>(new StringReader(xml));

	public T Deserialise<T>(TextReader reader) where T : UddfModel
	{
		XmlSerializer serializer = new(typeof(T));
		T obj = (T)serializer.Deserialize(reader)!; // This should throw if the xml is invalid
		_linkResolutionService.ResolveAllLinksInObjectGraph(obj);
		return obj;
	}
	
	public T Deserialise<T>(Stream stream) where T : UddfModel
	{
		XmlSerializer serializer = new(typeof(T));
		T obj = (T)serializer.Deserialize(stream)!; // This should throw if the xml is invalid
		_linkResolutionService.ResolveAllLinksInObjectGraph(obj);
		return obj;
	}

}