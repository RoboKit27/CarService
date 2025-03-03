using CarServiceSite.Core.Dtos;
using Microsoft.EntityFrameworkCore;

namespace CarServiceSite.DAL
{
    public class UserRepository
    {
        private Context _context;

        public UserRepository()
        {
            this._context = SingleContext.GetInstance().Context;
        }

        public UserDto GetUserById(int id)
        {
            return this._context.Users.Include(a => a.Role).Where(u => u.Id == id).First();
        }

        public void AddCommentByUserId(CommentDto comment, int userId)
        {
            comment.Users.Add(_context.Users.Where(u => u.Id == userId).FirstOrDefault());
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }
    }
}
