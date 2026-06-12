using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dtos.Comment;
using api.interfaces;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositoriy
{
    public class CommentRepository : ICommentRepository
    {
        private readonly ApplicationDBContext _context;

        public CommentRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<Comment> CreateAsync(Comment commentModel)
        {
            await _context.Comments.AddAsync(commentModel);
            await _context.SaveChangesAsync();
            return commentModel;
        }

        public async Task<Comment?> DeleteASync(int commentId)
        {
            var comment = await _context.Comments.FirstOrDefaultAsync(c => c.Id == commentId);

            if (comment == null)
                return null;

            _context.Comments.Remove(comment);
            _context.SaveChanges();

            return comment;
        }

        public async Task<List<Comment>> GetAllAsync()
        {
            return await _context.Comments.ToListAsync();
        }

        public async Task<Comment> GetByIdASync(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            
            if (comment == null)
                return null;

            return comment;
        }

        public async Task<Comment?> UpdateASync(int commentId, Comment commentModel)
        {
            var existingComment = await _context.Comments.FindAsync(commentId);

            if (existingComment == null)
                return null;
            
            existingComment.Title = commentModel.Title;
            existingComment.Content = commentModel.Content;

            await _context.SaveChangesAsync();
            
            return existingComment;
        }
    }
}