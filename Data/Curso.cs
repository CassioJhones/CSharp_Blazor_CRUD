namespace CassioJhones.Data
{
    public class Curso
    {
        public int Id { get; set; }
        public string TituloCurso { get; set; }    
        public string Cidade { get; set; } 
        public string Estado { get; set; }
        public int Dia { get; set; }
        public bool Online { get; set; }
        public double Valor { get; set; }
        public double MediaAprovacao { get; set; }
        
    }
}
