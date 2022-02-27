using laboratorio1Wilmer.Models;


namespace laboratorio1Wilmer.Models
{
    public interface  IOperaciones
    {
        Double Suma(Acciones acciones);
        Double Resta(Acciones acciones);
        Double Multiplicacion(Acciones acciones);
        Double Division(Acciones acciones);

    }
}

