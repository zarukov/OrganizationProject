using OrganizationProject.Contexts;
using OrganizationProject.Models;

namespace OrganizationProject.Repositories.Data;

public class MemberRepository : GeneralRepository<int, Member>
{
    private readonly MyContext context;

    public MemberRepository(MyContext context) : base(context)
	{
        this.context = context;
    }
}
