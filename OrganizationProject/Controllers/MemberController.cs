using OrganizationProject.Base;
using OrganizationProject.Models;
using OrganizationProject.Repositories.Data;
using Microsoft.AspNetCore.Mvc;


namespace OrganizationProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MemberController : BaseController<int, Member, MemberRepository>
{
    public MemberController(MemberRepository repository) : base(repository)
    {
    }
}