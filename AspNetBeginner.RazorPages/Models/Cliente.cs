using System.ComponentModel.DataAnnotations;

namespace AspNetBeginner.RazorPages.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
        public bool Ativo { get; set; }
    }
}
