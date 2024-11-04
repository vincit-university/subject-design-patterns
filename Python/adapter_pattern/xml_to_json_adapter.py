import json
import xmltodict

from json_message import JsonMessage

class XmlToJsonAdapter(JsonMessage):
    def __init__(self, xml_message):
        self.xml_message = xml_message
        
    def get_json(self):
        xml = self.xml_message.get_xml()
        json_data = json.dumps(xmltodict.parse(xml), indent=4)
        
        return json_data