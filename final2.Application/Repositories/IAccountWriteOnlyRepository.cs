namespace final2.Application.Repositories
{
    using final2.Domain.Accounts;
    using System.Threading.Tasks;

    public interface IAccountWriteOnlyRepository
    {
        Task Add(Account account, Credit credit);
        Task Update(Account account, Transaction transaction);
        Task Delete(Account account);
    }
}
