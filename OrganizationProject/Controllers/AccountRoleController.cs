using OrganizationProject.Base;
using OrganizationProject.Models;
using OrganizationProject.Repositories.Data;
using Microsoft.AspNetCore.Mvc;


namespace OrganizationProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AccountRoleController : BaseController<int, AccountRole, AccountRoleRepository>
{
	public AccountRoleController(AccountRoleRepository repository) : base(repository)
	{

	}
}
