using OrganizationProject.Base;
using OrganizationProject.Models;
using OrganizationProject.Repositories.Data;
using Microsoft.AspNetCore.Mvc;


namespace OrganizationProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RoleController : BaseController<int, Role, RoleRepository>
{
    public RoleController(RoleRepository repository) : base(repository)
    {
    }
}