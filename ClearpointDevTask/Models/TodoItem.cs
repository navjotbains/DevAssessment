using System.ComponentModel.DataAnnotations;

namespace ClearpointDevTask.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }

        [Required]
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Description { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public bool IsCompleted { get; set; }
    }
}