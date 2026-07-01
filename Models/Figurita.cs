namespace TP04.Models;

public class Figurita
{
    
    public int idJugador {get; set;}
    List<Figurita> repetidas = new List<Figurita>();
    private int cantidad;
    public int id {get; set;}

    public void repetida(BD bd) {

        List<Figurita> figuritas = bd.seleccionarFiguritas();
        for (int i = 0; i < figuritas.Count; i++) {                                                                                

            if (figuritas[i].idJugador == idJugador && id != figuritas[i].id) {

                repetidas.Add(bd.seleccionarFiguritas()[i]);

            }

        }

    }

    public string abrir(BD bd) {

        string msg = "PA";
        return msg;

    }

}