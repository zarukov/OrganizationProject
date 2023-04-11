using OrganizationProject.Models;
using OrganizationProject.Contexts;

namespace OrganizationProject.Repositories.Data;

public class DocumentRepository : GeneralRepository<int, Document>
{
    private readonly MyContext context;

    public DocumentRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
