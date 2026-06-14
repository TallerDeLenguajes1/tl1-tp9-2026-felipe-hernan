namespace espacioArchivo;

public class Archivo
{
    private string? header;
    private string? titulo;
    private string? artista;
    private string? album;
    private int year;
    private string? comentario;
    private string? genero;

    public string Header { get => header; set => header = value; }
    public string Titulo { get => titulo; set => titulo = value; }
    public string Artista { get => artista; set => artista = value; }
    public string Album { get => album; set => album = value; }
    public int Year { get => year; set => year = value; }
    public string Comentario { get => comentario; set => comentario = value; }
    public string Genero { get => genero; set => genero = value; }
}
