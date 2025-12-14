using System.ComponentModel.DataAnnotations;

namespace AspNetBeginner.Mvc.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
