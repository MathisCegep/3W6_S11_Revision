using System.Collections.Generic;

namespace PresseMots.Models.ViewModels
{
    public class CommentsVM
    {
        public int WordCount { get; set; }
        public string StoryTitle { get; set; }
        public string ShortStory { get; set; }
        public int? StoryId { get; set; }
        public IEnumerable<Comment> Comment { get; set; }
    }
}
