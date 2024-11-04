using System.Xml.Linq;
using Newtonsoft.Json;

namespace FaculdadeVincit.DesignPatterns.AdapterPattern;

public class XmlToJsonAdapter : IJsonMessage
{
    private readonly XmlMessage _xmlMessage;

    public XmlToJsonAdapter(XmlMessage xmlMessage)
    {
        _xmlMessage = xmlMessage;
    }

    public string Json {
        get {
            var xml = _xmlMessage.Xml;
            var xmlElement = XElement.Parse(xml);
            var result = JsonConvert.SerializeXNode(xmlElement);

            return result;
        }
    }

}
