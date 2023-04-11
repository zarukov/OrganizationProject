using Microsoft.EntityFrameworkCore;
using OrganizationProject.Contexts;
using OrganizationProject.Handler;
using OrganizationProject.Models;
using OrganizationProject.ViewModels;

namespace OrganizationProject.Repositories.Data;

public class AccountRepository : GeneralRepository<string, Account>
{
    private readonly MyContext context;

    public AccountRepository(MyContext context) : base(context)
	{
        this.context = context;
    }

    public async Task<int> Register (RegisterVM registerVM)
    {
        int result = 0;

        Member member = new Member
        {
            NIM = registerVM.NIM,
            Name = registerVM.Name,
            MajorName = registerVM.MajorName,
            BirthDate = registerVM.BirthDate,
            TitleName = registerVM.TitleName,
            PhoneNumber = registerVM.PhoneNumber,
            Address = registerVM.Address,
            Email = registerVM.Email,
        };
        context.Members.Add(member);
        await context.SaveChangesAsync();

        Account account = new Account
        {
            MemberNIM = registerVM.NIM,
            Password = Hashing.HashPassword(registerVM.Password)
        };
        context.Accounts.Add(account);
        await context.SaveChangesAsync();

        AccountRole accountRole = new AccountRole
        {
            AccountId = registerVM.NIM,
            RoleId = 5
        };
        context.AccountRoles.Add(accountRole);
        await context.SaveChangesAsync();
        return result;
    }

    public async Task<bool> Login(LoginVM loginVM)
    {
        var result = await context.Members
            .Include(m => m.Account)
            .Select(m => new LoginVM
            {
                Email = m.Email,
                Password = m.Account.Password
            }).SingleOrDefaultAsync(l => l.Email == loginVM.Email);
        if (result == null)
        {
            return false;
        }
        return Hashing.ValidatePassword(loginVM.Password, result.Password);
    }
    public async Task<UserdataVM> GetUserdata(string email)
    {
        var userdata = (from m in context.Members
                        join a in context.Accounts
                        on m.NIM equals a.MemberNIM
                        join ar in context.AccountRoles
                        on a.MemberNIM equals ar.AccountId
                        join r in context.Roles
                        on ar.RoleId equals r.Id
                        where m.Email == email
                        select new UserdataVM
                        {
                            Email = m.Email,
                            Name = m.Name
                        }).FirstOrDefault();

        return userdata;
    }
    public async Task<IEnumerable<string>> GetRolesByID(string email)
    {
        var getId = await context.Members.FirstOrDefaultAsync(m => m.Email == email);
        return await context.AccountRoles.Where(ar => ar.AccountId == getId.NIM).Join(
            context.Roles,
            ar => ar.RoleId,
            r => r.Id,
            (ar, r) => r.Name).ToListAsync();
    }
}
