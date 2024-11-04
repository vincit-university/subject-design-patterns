from typing import TypeVar, Generic, List

from observable import Observable

TValue = TypeVar("TValue")

class Publisher(Generic[TValue]):
    def __init__(self):
        self.observables: List[Observable[TValue]] = []
        
    def add_observable(self, observable: Observable[TValue]):
        self.observables.append(observable)
        
    def remove_observable(self, observable: Observable[TValue]):
        self.observables.remove(observable)
        
    def notify_observables(self, value : TValue):
        for observable in self.observables:
            observable.update(value)