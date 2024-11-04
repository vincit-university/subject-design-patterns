from abc import ABC, abstractmethod

class JsonMessage(ABC):
    @abstractmethod
    def get_json(self):
        pass