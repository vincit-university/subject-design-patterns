import org.json.XML;
import org.json.JSONObject;

public class XmlToJsonAdapter implements IJsonMessage{
    private final XmlMessage xmlMessage;
    
    public XmlToJsonAdapter(XmlMessage xmlMessage) {
        this.xmlMessage = xmlMessage;
    }

    @Override
    public String getJson() {
        String xml = xmlMessage.getXml();
        JSONObject jsonObject = XML.toJSONObject(xml);

        return jsonObject.toString(4);
    }

}
