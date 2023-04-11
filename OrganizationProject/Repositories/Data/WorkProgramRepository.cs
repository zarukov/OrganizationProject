using OrganizationProject.Contexts;
using OrganizationProject.Models;

namespace OrganizationProject.Repositories.Data;

public class WorkProgramRepository : GeneralRepository<int, WorkProgram>
{
    private readonly MyContext context;

    public WorkProgramRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
