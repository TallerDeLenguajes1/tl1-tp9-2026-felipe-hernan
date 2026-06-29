/// <summary>
/// Espacio de nombres que contiene la definición de la clase <see cref="Archivo"/>.
/// </summary>
namespace nameespaceArchivo;

/// <summary>
/// Representa un archivo con su nombre, tamaño y fecha de última modificación.
/// </summary>
public class Archivo
{
    /// <summary>
    /// Nombre del archivo.
    /// </summary>
    private string nombre;
    /// <summary>
    /// Tamaño del archivo.
    /// </summary>
    private double tamano;
    /// <summary>
    /// Fecha y hora de la última modificación del archivo.
    /// </summary>
    DateTime ultimaModificacion;

    /// <summary>
    /// Constructor de la clase <see cref="Archivo"/>.
    /// </summary>
    /// <param name="nombre">Nombre del archivo.</param>
    /// <param name="tamano">Tamaño del archivo.</param>
    /// <param name="ultimaModificacion">Fecha y hora de la última modificación.</param>
    public Archivo(string nombre, double tamano, DateTime ultimaModificacion)
    {
        this.nombre = nombre;
        this.tamano = tamano;
        this.ultimaModificacion = ultimaModificacion;
    }

    /// <summary>
    /// Obtiene o establece el nombre del archivo.
    /// </summary>
    public string Nombre { get => nombre; set => nombre = value; }

    /// <summary>
    /// Obtiene o establece el tamaño del archivo.
    /// </summary>
    public double Tamano { get => tamano; set => tamano = value; }

    /// <summary>
    /// Obtiene o establece la fecha y hora de la última modificación del archivo.
    /// </summary>
    public DateTime UltimaModificacion { get => ultimaModificacion; set => ultimaModificacion = value; }

    /// <summary>
    /// Devuelve una representación en formato de texto con la información del archivo.
    /// </summary>
    /// <returns>
    /// Una cadena que contiene la fecha de última modificación, el tamaño y el nombre del archivo.
    /// </returns>
    public override string ToString()
    {
        return $"{UltimaModificacion}\t\t{Tamano}\t\t{Nombre}";
    }
}