using Jasmine_Akshil_GroupProject_COMP306.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jasmine_Akshil_GroupProject_COMP306.Data
{
   public interface IReviewRepo
    {
        IEnumerable<Review> GetAllReviews();
        Review GetReviewById(int id);
        Review PutReview(int id, Review review);
        Review  Delete(int id);
        void CreateReview(Review rev);
        void UpdateReview(Review rev);
        bool SaveChanges();
    }
}
