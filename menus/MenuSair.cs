using MusicExplorer.Models;

namespace MusicExplorer.Menu;

internal class MenuSair : Menu {
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) {
        Console.WriteLine("Tchau tchau :)");
    }
}