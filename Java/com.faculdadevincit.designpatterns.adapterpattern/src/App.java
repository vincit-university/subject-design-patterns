public class App {
    public static void main(String[] args) throws Exception {
        XmlMessage xmlMessage = new XmlMessage();
        IJsonMessage adaptedMessage = new XmlToJsonAdapter(xmlMessage);

        String xml = xmlMessage.getXml();
        String json = adaptedMessage.getJson();

        System.out.println("[XML]");
        System.out.println(xml);

        System.out.println("{JSON}");
        System.out.println(json);
    }
}
