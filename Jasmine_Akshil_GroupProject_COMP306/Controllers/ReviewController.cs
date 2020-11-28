using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Jasmine_Akshil_GroupProject_COMP306.Data;
using Jasmine_Akshil_GroupProject_COMP306.Dto;
using Jasmine_Akshil_GroupProject_COMP306.Models;
using Microsoft.AspNetCore.Mvc;

namespace Jasmine_Akshil_GroupProject_COMP306.Controllers
{
    [ApiController]
    [Route("api/reviews")]
    
    public class ReviewController : ControllerBase
    {
        private readonly IReviewRepo reviewRepo;
        private readonly IMapper mapper;
     
       
        public ReviewController(IReviewRepo review,IMapper _mapper)
        {
            reviewRepo = review;
            mapper = _mapper;
        }

       
        //GET api/reviews
        [HttpGet]
        public ActionResult<IEnumerable<Review>> GetAllReviews()
        {
            var reviewItems = reviewRepo.GetAllReviews();
            return Ok(mapper.Map<IEnumerable<ReviewReadDto>>(reviewItems));
        }
        //GET api/reviews/{id}
        [HttpGet("{id}", Name = "GetReviewById")]
        public ActionResult<Review> GetReviewById(int id)
        {
            var reviewItems = reviewRepo.GetReviewById(id);
            if(reviewItems!=null)
            {
                return Ok(mapper.Map<ReviewReadDto>(reviewItems));
            }
            return NotFound();
        }

        //POST api/reviews
        [HttpPost]
        public ActionResult<ReviewReadDto> CreateReview(ReviewCreateDto reviewCreateDto)
        {
            var reviewModel = mapper.Map<Review>(reviewCreateDto);
            reviewRepo.CreateReview(reviewModel);
            reviewRepo.SaveChanges();

            var reviewReadDto = mapper.Map<ReviewReadDto>(reviewModel);

            return CreatedAtRoute(nameof(GetReviewById), new { Id = reviewReadDto.FacultyId }, reviewReadDto);
        }
        //PUT api/reviews/{id}
        [HttpPut("{id}")]
        public ActionResult UpdateReview(int id, ReviewUpdateDto reviewUpdateDto)
        {
            var reviewModelFromRepo= reviewRepo.GetReviewById(id);
            if (reviewModelFromRepo == null)
            {
                return NotFound();
            }
            mapper.Map(reviewUpdateDto, reviewModelFromRepo);

            reviewRepo.UpdateReview(reviewModelFromRepo);

            reviewRepo.SaveChanges();

            return NoContent();
        }

        // DELETE: api/reviews/5
        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Review>> Delete(int id)
        {
           
                Review deletedProduct = reviewRepo.Delete(id);
                if (deletedProduct != null)
                {
                return Ok(deletedProduct);
            }
                return NotFound();
            
        }
    }
}
