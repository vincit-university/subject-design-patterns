class ContadorSingleton:
    _instance = None
    _valor = 0
    
    @property
    def valor(self):
        return self._valor
    
    def __new__(self):
        if self._instance is None:
            self._instance = super(ContadorSingleton, self).__new__(self)

        return self._instance
    
    def incrementar(self):
        self._valor += 1