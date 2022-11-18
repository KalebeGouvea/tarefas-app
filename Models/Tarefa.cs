using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace tarefas_app.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

        [Display(Name = "Data de conclusão")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
        public bool Status { get; set; }
    }
}