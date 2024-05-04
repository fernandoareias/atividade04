﻿using System;
using Atividade04.BFF.DTOs.Retailer.v1.Requests;

namespace Atividade04.BFF.Models.Interfaces.Services
{
    public interface IRetailerServices 
    {
        Task<Retailer> Create(CreateRetalierRequest request);
    }
}
