using System.IO;
using nameespaceArchivo;
//path a nalizar 

/// <summary>
/// Solicita al usuario una ruta válida de un directorio.
/// </summary>
string? path = ObtenerRutaDirectorio();

/// <summary>
/// Muestra los subdirectorios del directorio seleccionado.
/// </summary>
MostrarDirectorios(path);

/// <summary>
/// Lista donde se almacenará la información de los archivos encontrados.
/// </summary>
List<Archivo> listaArchivos = new List<Archivo>();
ListarArchivos(listaArchivos,path);
MostrarArchivos(listaArchivos);
string nombreInforme = "reporte_archivos";
CreaInformeCSV(listaArchivos,path,nombreInforme);


/// <summary>
/// Muestra los nombres de todos los subdirectorios contenidos
/// en la ruta especificada.
/// </summary>
/// <param name="ruta">Ruta del directorio a analizar.</param>
void MostrarDirectorios(string ruta){

    string[] directorios = Directory.GetDirectories(ruta);
    Console.WriteLine("----Nombre----");
    foreach (var directorio in directorios)
    {
            Console.WriteLine($"{Path.GetFileName(directorio)}");
    }
}
/// <summary>
/// Obtiene la información de los archivos contenidos en un directorio
/// y la almacena en una lista.
/// </summary>
/// <param name="listaArchivos">Lista donde se guardarán los archivos encontrados.</param>
/// <param name="path">Ruta del directorio a analizar.</param>
void ListarArchivos(List<Archivo> listaArchivos, string path)
{
    string[] archivos = Directory.GetFiles(path);
    foreach (var archivo in archivos)
    {
        if (Path.GetExtension(archivo) !="")
        {
            FileInfo archivoInfo = new FileInfo(archivo);
            double tamano = Math.Round(archivoInfo.Length/1024.0,2);
            listaArchivos.Add(new Archivo(archivoInfo.Name,tamano,archivoInfo.LastWriteTime));
        }
    }
}
/// <summary>
/// Muestra por consola la información de todos los archivos de la lista.
/// </summary>
/// <param name="listaArchivos">Lista de archivos a mostrar.</param>
void MostrarArchivos(List<Archivo> listaArchivos)
{

    Console.WriteLine("Ultima modificacion\t\tTamaño (KB)\t\tNombre");
    foreach (var archivo in listaArchivos)
    {
        Console.WriteLine(archivo.ToString());
    }
}
/// <summary>
/// Genera un informe en formato CSV con la información de los archivos.
/// </summary>
/// <param name="listaArchivos">Lista de archivos a exportar.</param>
/// <param name="path">Directorio donde se guardará el informe.</param>
/// <param name="nombre">Nombre del archivo CSV (sin extensión).</param>
void CreaInformeCSV(List<Archivo> listaArchivos,string path,string nombre)
{
    string ruta = Path.Combine(path,nombre+".csv");
    string linea = $"Nombre,Tamaño (KB),Ultima modificacion";
    List<string> infoArchivo = [linea];
    foreach (var archivo in listaArchivos)
    {
        linea = $"{archivo.Nombre.Replace(',','-')},{archivo.Tamano.ToString().Replace(',','.')},{archivo.UltimaModificacion}";
        infoArchivo.Add(linea);
    }
    File.WriteAllLines(ruta, infoArchivo.ToArray(),System.Text.Encoding.UTF8);
}

/// <summary>
/// Solicita al usuario la ruta de un directorio y verifica que exista.
/// Continúa solicitando la ruta hasta que el usuario ingrese un directorio válido.
/// </summary>
/// <returns>
/// La ruta del directorio ingresada por el usuario.
/// </returns>
static string ObtenerRutaDirectorio()
{
    string? path;
    do
    {
        Console.WriteLine("Ingrese el nombre de un directorio ");
        path = Console.ReadLine();
        if (!Directory.Exists(path))
        {
            Console.WriteLine("No existe el directorio");
        }

    } while (!Directory.Exists(path));
    return path;
}