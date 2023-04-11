using OrganizationProject.Base;
using OrganizationProject.Models;
using OrganizationProject.Repositories.Data;
using Microsoft.AspNetCore.Mvc;


namespace OrganizationProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController : BaseController<int, Department, DepartmentRepository>
{
    public DepartmentController(DepartmentRepository repository) : base(repository)
    {

    }
}