using UniversalDiveDataFormat.Models;

namespace UniversalDiveDataFormat.Services;

public interface IUddfDeserialiser
{
	T Deserialise<T>(string xml) where T : UddfModel;
	T Deserialise<T>(TextReader reader) where T : UddfModel;
	T Deserialise<T>(Stream stream) where T : UddfModel;
}