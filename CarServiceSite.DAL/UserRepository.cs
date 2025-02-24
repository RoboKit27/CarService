using CarServiceSite.Core.Dtos;

namespace CarServiceSite.DAL
{
    public class UserRepository
    {
        private Context _context;

        public UserRepository()
        {
            this._context = new Context();
        }

        public UserDto GetUserById(int id)
        {
            return this._context.Users.Where(u => u.Id == id).First();
        }

        public void AddCommentByUserId(CommentDto comment, int userId)
        {
            _context.Comments.Add(comment);
            _context.Users.Where(u => u.Id == userId).First().Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}
