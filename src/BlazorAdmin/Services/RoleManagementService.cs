﻿using System.Threading.Tasks;
using BlazorAdmin.Interfaces;
using BlazorAdmin.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace BlazorAdmin.Services;

public class RoleManagementService : IRoleManagementService
{
    private readonly HttpService _httpService;
    private readonly ILogger<RoleManagementService> _logger;

    public RoleManagementService(HttpService httpService, ILogger<RoleManagementService> logger)
    {
        _httpService = httpService;
        _logger = logger;
    }

    public async Task<RoleListResponse> List(){
        _logger.LogInformation("Fetching roles");
        var response = await _httpService.HttpGet<RoleListResponse>($"roles");
        return response;
    }

    public async Task<CreateRoleResponse> Create(CreateRoleRequest newRole)
    {
        _logger.LogInformation("Creating role");
        var response = await _httpService.HttpPost<CreateRoleResponse>($"roles", newRole);
        return response;
    }

    public Task<IdentityRole> Edit(IdentityRole role)
    {
        throw new System.NotImplementedException();
    }

    public Task<string> Delete(string id)
    {
        throw new System.NotImplementedException();
    }

    public Task<IdentityRole> GetById(string id)
    {
        throw new System.NotImplementedException();
    }
}
