using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PresseMots.Models
{
    public class StoryTag
    {
        public int Id { get; set; }
        public int StoryId { get; set; }
        public virtual Story Story { get; set; }
        public int TagId { get; set; }
        public virtual Tag Tag { get; set; }

    }
}
