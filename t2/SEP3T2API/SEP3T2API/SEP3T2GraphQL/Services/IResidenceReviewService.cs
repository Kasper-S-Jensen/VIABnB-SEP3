﻿using System.Threading.Tasks;
using SEP3T2GraphQL.Models;

namespace SEP3T2GraphQL.Services
{
    public interface IResidenceReviewService
    {
        public Task<ResidenceReview> CreateAsync(Residence residence, ResidenceReview residenceReview); 
    }
}