using System.Text;
using espacioArchivo;

// Ruta del archivo MP3 a analizar
var fileName = @"C:\Users\felip\OneDrive\Documentos\Facet\Taller 1\tp9\ambiente.mp3";

// Apertura del archivo en modo lectura
using FileStream fs = new FileStream(fileName, FileMode.Open);

// Las etiquetas ID3v1 se encuentran en los últimos 128 bytes del archivo.
// Seek desplaza el puntero 128 bytes hacia atrás desde el final.
fs.Seek(-128, SeekOrigin.End);

// Se crea un buffer para almacenar los 128 bytes de la etiqueta
byte[] tag = new byte[128];

// Lectura de los 128 bytes de la etiqueta ID3v1
int leidos = fs.Read(tag, 0, 128);

// Creación del objeto que almacenará los datos obtenidos
Archivo datos = new Archivo();

// Lectura de la cabecera ("TAG")
datos.Header = Encoding.UTF8.GetString(tag, 0, 3);

// Lectura del título (30 bytes)
datos.Titulo = Encoding.UTF8.GetString(tag, 3, 30);

// Lectura del artista (30 bytes)
datos.Artista = Encoding.UTF8.GetString(tag, 33, 30);

// Lectura del álbum (30 bytes)
datos.Album = Encoding.UTF8.GetString(tag, 63, 30);

// Lectura y conversión del año (4 bytes)
datos.Year = int.Parse(Encoding.UTF8.GetString(tag, 93, 4));

// Lectura del comentario (30 bytes)
datos.Comentario = Encoding.UTF8.GetString(tag, 97, 30);

// Lectura del género (1 byte)
datos.Genero = Encoding.UTF8.GetString(tag, 127, 1);

// Muestra por pantalla los datos principales de la canción
Console.WriteLine(
    $"Titulo : {datos.Titulo}\n" +
    $"Artista: {datos.Artista}\n" +
    $"Album: {datos.Album}\n" +
    $"Año de lanzamiento: {datos.Year}"
);