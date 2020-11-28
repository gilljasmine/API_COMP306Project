using Jasmine_Akshil_GroupProject_COMP306.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jasmine_Akshil_GroupProject_COMP306.Data
{
    public class SqlReviewRepo : IReviewRepo
    {
        private readonly ReviewContext reviewContext;
        public SqlReviewRepo(ReviewContext _context)
        {
            reviewContext = _context;
        }

       

        public IEnumerable<Review> GetAllReviews()
        {
            return reviewContext.Reviews.ToList();
        }

        public Review GetReviewById(int id)
        {
            return reviewContext.Reviews.FirstOrDefault(p => p.FacultyId == id);
        }

        public Review Delete(int id)
        {
            Review dbEntry = reviewContext.Reviews.FirstOrDefault(p => p.FacultyId == id);

            if (dbEntry != null)
            {
                reviewContext.Reviews.Remove(dbEntry);
                reviewContext.SaveChanges();
            }
            return dbEntry;
          
        }

        public Review PutReview(int id, Review review)
        {
            throw new NotImplementedException();
        }

        public void CreateReview(Review rev)
        {
            if (rev == null)
            {
                throw new ArgumentNullException(nameof(rev));
            }

            reviewContext.Reviews.Add(rev);
        }

        public bool SaveChanges()
        {
            return (reviewContext.SaveChanges() >= 0);
        }

        public void UpdateReview(Review rev)
        {
           //nthing
        }
    }
}
