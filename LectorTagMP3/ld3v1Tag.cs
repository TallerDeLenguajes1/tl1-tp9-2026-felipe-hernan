
/// <summary> 
/// Espacio de nombres que contiene la definición de la clase <see cref="Archivo"/>. 
//// </summary>
namespace espacioArchivo;

/// <summary> 
/// Representa la información de una etiqueta de metadatos de un archivo de audio. 
/// Almacena datos como el título, artista, álbum, año, comentario y género. 
/// </summary>
public class Archivo
{
    private string? header;
    private string? titulo;
    private string? artista;
    private string? album;
    private int year;
    private string? comentario;
    private string? genero;

    /// <summary>
    /// Obtiene o establece el encabezado de la etiqueta de metadatos.
    /// Generalmente corresponde al identificador de la etiqueta (por ejemplo, "TAG").
    /// </summary>
    /// <value>
    /// Cadena que representa el encabezado de la etiqueta de metadatos.
    /// </value>
    public string Header { get => header; set => header = value; }

    /// <summary>
    /// Obtiene o establece el título de la pista de audio.
    /// </summary>
    /// <value>
    /// Título del archivo de audio.
    /// </value>
    public string Titulo { get => titulo; set => titulo = value; }

    /// <summary>
    /// Obtiene o establece el nombre del artista o intérprete.
    /// </summary>
    /// <value>
    /// Nombre del artista.
    /// </value>
    public string Artista { get => artista; set => artista = value; }

    /// <summary>
    /// Obtiene o establece el nombre del álbum al que pertenece la pista.
    /// </summary>
    /// <value>
    /// Nombre del álbum.
    /// </value>
    public string Album { get => album; set => album = value; }

    /// <summary>
    /// Obtiene o establece el año de publicación de la pista.
    /// </summary>
    /// <value>
    /// Año de publicación del archivo de audio.
    /// </value>
    public int Year { get => year; set => year = value; }

    /// <summary>
    /// Obtiene o establece un comentario asociado al archivo de audio.
    /// </summary>
    /// <value>
    /// Comentario descriptivo del archivo.
    /// </value>
    public string Comentario { get => comentario; set => comentario = value; }

    /// <summary>
    /// Obtiene o establece el género musical de la pista.
    /// </summary>
    /// <value>
    /// Género del archivo de audio.
    /// </value>
    public string Genero { get => genero; set => genero = value; }
}
