namespace aplicativoweb.Models;
public class Curso{
    public Curso(string TituloInterno,string TituloMarketing,string Descricao)
    {
        this.Id = numCurso;
        numCurso++;
        this.Descricao = Descricao;
        this.TituloInterno = TituloInterno;
        this.TituloMarketing = TituloMarketing;
    }

    public int Id { get; set; }
    public string? TituloMarketing { get; set; }
    public string? TituloInterno { get; set; }
    public string? Descricao { get; set; }
    public static int numCurso; 
}
