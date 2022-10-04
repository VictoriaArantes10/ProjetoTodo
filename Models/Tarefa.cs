using System.ComponentModel.DataAnnotations;

namespace toDo.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public bool Status { get; set; }
    }
    



    
}
