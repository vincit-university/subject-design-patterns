from xml_message import XmlMessage
from xml_to_json_adapter import XmlToJsonAdapter

xml_message = XmlMessage()
adapted_message = XmlToJsonAdapter(xml_message)

xml = xml_message.get_xml()
json = adapted_message.get_json()

print("[XML]")
print(xml)
print("{JSON}")
print(json)