using System.Xml.Serialization;

namespace UniversalDiveDataFormat.Models;

public abstract class TaxonomicClass
{
	[XmlElement("species")]
	public List<Species> Species { get; init; } = [];
}

[XmlRoot("chlorophyceae")]
public class Chlorophyceae: TaxonomicClass;

[XmlRoot("floravarious")]
public class Floravarious: TaxonomicClass;

[XmlRoot("phaeophyceae")]
public class Phaeophyceae: TaxonomicClass;

[XmlRoot("rhodophyceae")]
public class Rhodophyceae: TaxonomicClass;

[XmlRoot("spermatophyta")]
public class Spermatophyta: TaxonomicClass;

[XmlRoot("ascidiacea")]
public class Ascidiacea: TaxonomicClass;

[XmlRoot("bryozoa")]
public class Bryozoa: TaxonomicClass;

[XmlRoot("cnidaria")]
public class Cnidaria: TaxonomicClass;

[XmlRoot("coelenterata")]
public class Coelenterata: TaxonomicClass;

[XmlRoot("crustacea")]
public class Crustacea: TaxonomicClass;

[XmlRoot("ctenophora")]
public class Ctenophora: TaxonomicClass;

[XmlRoot("echinodermata")]
public class Echinodermata: TaxonomicClass;

[XmlRoot("mollusca")]
public class Mollusca: TaxonomicClass;

[XmlRoot("phoronidea")]
public class Phoronidea: TaxonomicClass;

[XmlRoot("plathelminthes")]
public class Plathelminthes: TaxonomicClass;

[XmlRoot("porifera")]
public class Porifera: TaxonomicClass;

[XmlRoot("invertebratavarious")]
public class InvertebrataVarious: TaxonomicClass;

[XmlRoot("amphibia")]
public class Amphibia: TaxonomicClass;

[XmlRoot("chondrichthyes")]
public class Chondrichthyes: TaxonomicClass;

[XmlRoot("mammalia")]
public class Mammalia: TaxonomicClass;

[XmlRoot("osteichthyes")]
public class Osteichthyes: TaxonomicClass;

[XmlRoot("reptilia")]
public class Reptilia: TaxonomicClass;

[XmlRoot("vertebratavarious")]
public class VertebrataVarious: TaxonomicClass;