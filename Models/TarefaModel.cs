using System.ComponentModel.DataAnnotations;

namespace ListaDeContatos.Models
{
    public class TarefaModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DateTime { get; set; }

        public bool fulfilled { get; set; }

        public string? ProjectTitle { get; set; }
        public int? ProjectId { get; set; }
    }
}
