﻿using System.Threading.Tasks;
using SEP3BlazorT1Client.Models;

namespace SEP3BlazorT1Client.Data
{
    public interface IConceptService
    {
        Task<ConceptMessage> getMessage(int id);
    }
}