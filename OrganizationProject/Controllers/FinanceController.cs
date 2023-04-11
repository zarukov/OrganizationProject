using OrganizationProject.Base;
using OrganizationProject.Models;
using OrganizationProject.Repositories.Data;
using Microsoft.AspNetCore.Mvc;


namespace OrganizationProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FinanceController : BaseController<int, Finance, FinanceRepository>
{
    public FinanceController(FinanceRepository repository) : base(repository)
    {
    }
}