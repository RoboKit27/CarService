using CarServiceSite.Core.OutputModels;

namespace CarServiceSite.Core.InputModels
{
    public class CommentInputModel
    {
        public int Rating { get; set; }
        public string? Text { get; set; }
        public UserOutputModel Author { get; set; }
    }
}
