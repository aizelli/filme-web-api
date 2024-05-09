using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace filme_web_api.Models
{
    [Table("filmes")]
    public class Filme
    {
        public Filme(string titulo, string sinopse, string genero, string classificacao, DateTime data_lancamento)
        {
            Titulo = titulo;
            Sinopse = sinopse;
            Genero = genero;
            Classificacao = classificacao;
            Data_lancamento = data_lancamento;
        }

        public int Id { get; private set; }
        public string Titulo { get; private set; }
        public string Sinopse { get; private set; }
        public string Genero { get; private set; }
        public string Classificacao { get; private set; }
        [DataType(DataType.Date)]
        public DateTime Data_lancamento { get; private set; }
    }
}
