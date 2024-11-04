using FaculdadeVincit.DesignPatterns.BulderPattern;

var sanduicheBuilder = new SanduicheBuilder();
var sanduiche = sanduicheBuilder.SetPao("Americano")
                                .SetCarne("blend bovino-suino")
                                .SetQueijo("Cheddar")
                                .SetTemSalada(false)
                                .Build();

sanduiche.MostrarInformacoesPedido();