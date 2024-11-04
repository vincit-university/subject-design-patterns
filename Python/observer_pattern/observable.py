from abc import ABC, abstractmethod
from typing import TypeVar, Generic

TValue = TypeVar("TValue")

class Observable(Generic[TValue]):
    @abstractmethod
    def update(self, value : TValue):
        pass