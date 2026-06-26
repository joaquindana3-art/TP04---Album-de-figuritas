namespace TP04.Models;

public class Figurita
{
    
    public int idJugador {get; set;};
    private bool repetida;
    private int cantidad;
    public int id {get; set;}; 

    public void repetida(BD bd) {

        List<Figurita> repetidas = new List<Figurita>();
        List<Figurita> figuritas = bd.seleccionarFiguritas()[i]
        for (int i = 0; i < figuritas.Count; i++) {

            if (figuritas[i].idJugador == idJugador && id != figuritas[i].id) {

                repetidas.Add(bd.seleccionarFiguritas()[i]);

            }

        }
        if (i > 1) {

            figurita.repetida = true;
            for (int i2 = 0; i2 < repetidas.Count; i2++) {

                repetidas[i2].repetida = true;

            }

        }

    }

}