namespace nameespaceArchivo;
public class Archivo
{
    private string nombre;
    private double tamano;
    DateTime ultimaModificacion;

    public Archivo(string nombre, double tamano, DateTime ultimaModificacion)
    {
        this.Nombre = nombre;
        this.Tamano = tamano;
        this.UltimaModificacion = ultimaModificacion;
    }

    public string Nombre { get => nombre; set => nombre = value; }
    public double Tamano { get => tamano; set => tamano = value; }
    public DateTime UltimaModificacion { get => ultimaModificacion; set => ultimaModificacion = value; }

    public string ToString()
    {
        return $"{UltimaModificacion}\t\t{Tamano}\t\t{Nombre}";
    }
}