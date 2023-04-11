using OrganizationProject.Contexts;
using OrganizationProject.Models;

namespace OrganizationProject.Repositories.Data;

public class FinanceRepository : GeneralRepository<int, Finance>
{
    private readonly MyContext context;

    public FinanceRepository(MyContext context)	: base(context)
	{
        this.context = context;
    }
}
