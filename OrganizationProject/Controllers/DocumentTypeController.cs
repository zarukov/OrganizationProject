using OrganizationProject.Base;
using OrganizationProject.Models;
using OrganizationProject.Repositories.Data;
using Microsoft.AspNetCore.Mvc;


namespace OrganizationProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DocumentTypeController : BaseController<int, DocumentType, DocumentTypeRepository>
{
    public DocumentTypeController(DocumentTypeRepository repository) : base(repository)
    {
    }
}