﻿using Microsoft.eShopWeb.Infrastructure.Identity;

namespace Microsoft.eShopWeb.PublicApi.UserManagementEndpoints;

public class UpdateUserRequest : BaseRequest
{
    public ApplicationUser User { get; set; }
}
