﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface.Identity
{
    internal interface IAccount
    {
        Task<ServiceResponse> LoginAsync(LoginUserRequestDTO model);
        Task<ServiceResponse> CreateUserAsync(CreateUserRequestDTO model);
        Task<IEnumerable<GetUserWithClaimResponseDTO>> GetUsersWithClaimsAsync();
        Task SetUpAsync();
        Task<ServiceResponse> UpdateUserAsync(ChangeUserClaimRequestDTO model);
        Task SaveActivityAsync(ActivityTrackerRequestDTO model);
        Task<IEnumerable<ActivityTrackerResponseDTO>> GetActivitiesAsync();
    }
}
