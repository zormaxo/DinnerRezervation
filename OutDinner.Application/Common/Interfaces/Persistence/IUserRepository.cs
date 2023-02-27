using OutDinner.Domain.Entities;

namespace OutDinner.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);


    void Add(User user);
}
