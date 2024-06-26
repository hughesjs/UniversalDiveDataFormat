using System.Collections;
using System.Reflection;
using UniversalDiveDataFormat.Models;
using UniversalDiveDataFormat.Models.Linking;

namespace UniversalDiveDataFormat.Services;

// I don't generally work with XML, so if there's a built-in way to do this, let me know
// This is also a bit smarter than the UDDF spec says it should be, not requiring elements to already
// be declared before their link since it does a full parse before resolving the links
public class LinkResolutionService
{
	private readonly Dictionary<string, ILinkable> _linkableLookup;
	private readonly List<Link> _links;

	private readonly bool _failOnMissingLink;
	
	private static bool IsInModelNamespace(Type t) => t.IsAssignableTo(typeof(UddfModel));
	private static bool IsList(Type type) => type.IsGenericType && type.GetGenericTypeDefinition().IsAssignableTo(typeof(IEnumerable));
	private static bool IsListOfModelObjects(Type type) => IsList(type) && IsInModelNamespace(type.GetGenericArguments().Single());


	public LinkResolutionService(bool failOnMissingLink = true)
	{
		_failOnMissingLink = failOnMissingLink;
		_linkableLookup = new();
		_links = [];
	}

	public void ResolveAllLinksInObjectGraph(UddfModel root)
	{
		_linkableLookup.Clear();
		_links.Clear();
		FindAllLinkablesAndLinksInSubgraph(root);
		BuildLinks();
	}

	private void BuildLinks()
	{
		foreach (Link link in _links)
		{
			if (!_linkableLookup.TryGetValue(link.Ref, out ILinkable? linkable) && _failOnMissingLink)
			{
				throw new ArgumentException($"The linkable with id {link.Ref} could not be found");
			}

			link.SetLinkedObject(linkable);
		}
	}
	
	private void FindAllLinkablesAndLinksInSubgraph(UddfModel? root)
	{
		if (root is null) return;
		PropertyInfo[] properties = root.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty);
		ProcessModelObject(root);
		foreach (PropertyInfo property in properties)
		{
			object? propertyValue = property.GetValue(root);
			if (propertyValue is null) continue;
			if (IsListOfModelObjects(property.PropertyType))
			{
				((IEnumerable)propertyValue).Cast<UddfModel?>().ToList().ForEach(FindAllLinkablesAndLinksInSubgraph);
				continue;
			}
			
			if (!IsInModelNamespace(property.PropertyType)) continue;
			FindAllLinkablesAndLinksInSubgraph((UddfModel)propertyValue);
		}
	}
	
	private void ProcessModelObject(object model)
	{
		if (model.GetType().IsAssignableTo(typeof(ILinkable)))
		{
			ILinkable linkable = (ILinkable)model;
			if (linkable.Id is not null)
			{
				_linkableLookup[linkable.Id] = linkable;
			}
		}
		
		if (model is Link link)
		{
			_links.Add(link);
		}
	}

}
