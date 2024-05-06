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

	public LinkResolutionService(bool failOnMissingLink = true)
	{
		_failOnMissingLink = failOnMissingLink;
		_linkableLookup = new();
		_links = [];
	}

	public void ResolveAllLinksInObjectGraph(object root)
	{
		// Maybe make everything inherit from an empty base and use that rather than object
		if (!IsInModelNamespace(root.GetType()))
		{
			throw new ArgumentException("The root object must belong to the UDDF Models namespace");
		}

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

	private void FindAllLinkablesAndLinksInSubgraph(object root)
	{
		foreach (object model in AllModelObjectsInGraph(root))
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

	private bool IsInModelNamespace(Type t) => t.Namespace!.StartsWith("UniversalDiveDataFormat.Models");
	private bool IsList(Type type) => type.IsGenericType && type.GetGenericTypeDefinition().IsAssignableTo(typeof(IList));

	IEnumerable<object> AllModelObjectsInGraph(object root)
	{
		PropertyInfo[] properties = root.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.GetProperty);

		foreach (PropertyInfo property in properties)
		{
			object? propertyValue = property.GetValue(root);
			if (propertyValue is null) continue;
			if (IsList(property.PropertyType))
			{
				IList list = (IList)propertyValue!;
				foreach (object? item in  list)
				{
					if (item is null) continue;
					if (IsInModelNamespace(item.GetType())) // This could be moved out and read reflectively
					{
						yield return item;
						foreach (var innerObject in AllModelObjectsInGraph(item))
						{
							yield return innerObject;
						}
					}
				}
				continue;
			}
			
			if (!IsInModelNamespace(property.PropertyType)) continue;
			
			yield return propertyValue;
			foreach (var innerObject in AllModelObjectsInGraph(propertyValue))
			{
				yield return innerObject;
			}
		}

	}

}
