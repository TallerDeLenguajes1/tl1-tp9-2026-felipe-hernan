using System.IO;
using nameespaceArchivo;
//path a nalizar 
string? path = "";
do
{
    Console.WriteLine("Ingrese el nombre de un directorio ");
    path = Console.ReadLine();
    if (!Directory.Exists(path))
    {
       Console.WriteLine("No existe el directorio");
    }

} while (!Directory.Exists(path));

mostrarDirectorios(path);
List<Archivo> listaArchivos = new List<Archivo>();
listarArchivos(listaArchivos,path);
mostrarArchivos(listaArchivos);
string nombreInforme = "reporte_archivos";
creaInformeCSV(listaArchivos,path,nombreInforme);



void mostrarDirectorios(string ruta){

    string[] directorios = Directory.GetDirectories(ruta);
    Console.WriteLine("----Nombre----");
    foreach (var item in directorios)
    {
            Console.WriteLine($"{Path.GetFileName(item)}");
    }
}

void listarArchivos(List<Archivo> listaArchivos, string path)
{
    string[] archivos = Directory.GetFiles(path);
    foreach (var item in archivos)
    {
        if (Path.GetExtension(item) !="")
        {
            FileInfo f = new FileInfo(item);
            double tamano = Math.Round(f.Length/1024.0,2);
            listaArchivos.Add(new Archivo(f.Name,tamano,f.LastWriteTime));
        }
    }
}

void mostrarArchivos(List<Archivo> listaArchivos)
{

    Console.WriteLine("Ultima modificacion\t\tTamaño (KB)\t\tNombre");
    foreach (var item in listaArchivos)
    {
        Console.WriteLine(item.ToString());
    }
}

void creaInformeCSV(List<Archivo> listaArchivos,string path,string nombre)
{
    string ruta = Path.Combine(path,nombre+".csv");
    string linea = $"Nombre,Tamaño (KB),Ultima modificacion";
    List<string> infoArchivo = [linea];
    foreach (var item in listaArchivos)
    {
        linea = $"{item.Nombre.Replace(',','-')},{item.Tamano.ToString().Replace(',','.')},{item.UltimaModificacion}";
        infoArchivo.Add(linea);
    }
    File.WriteAllLines(ruta, infoArchivo.ToArray(),System.Text.Encoding.UTF8);
}
