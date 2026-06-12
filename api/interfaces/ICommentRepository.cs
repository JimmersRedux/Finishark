using api.Dtos.Comment;
using api.Models;

namespace api.interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync();
        Task<Comment> GetByIdASync(int id);
        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> UpdateASync(int commentId, Comment commentModel);
        Task<Comment?> DeleteASync(int commentId);
    }
}