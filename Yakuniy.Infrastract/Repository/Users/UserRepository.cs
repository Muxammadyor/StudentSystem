using Yakuniy.Infrastract.EntityTypeConfigurations;
using Yakuniy.Domain.Contexts;
using Yakuniy.Infrastract.Contexts;

namespace Yakuniy.Infrastract.Repository.Users;

public sealed class UserRepository : GenericRepasitory<Student, int> , IUserRepository
{
    public UserRepository(AppDbContext appDbContext)
        : base(appDbContext)
    {
    }
}
