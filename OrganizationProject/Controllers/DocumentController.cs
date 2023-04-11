using OrganizationProject.Base;
using OrganizationProject.Models;
using OrganizationProject.Repositories.Data;
using Microsoft.AspNetCore.Mvc;


namespace OrganizationProject.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DocumentController : BaseController<int, Document, DocumentRepository>
{
    public DocumentController(DocumentRepository repository) : base(repository)
    {
    }
}