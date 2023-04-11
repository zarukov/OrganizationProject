using OrganizationProject.Base;
using OrganizationProject.Models;
using OrganizationProject.Repositories.Data;
using Microsoft.AspNetCore.Mvc;


namespace OrganizationProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkProgramController : BaseController<int, WorkProgram, WorkProgramRepository>
{
    public WorkProgramController(WorkProgramRepository repository) : base(repository)
    {
    }
}