using PasswordGeneratorAPI.Models;

namespace PasswordGeneratorAPI.Services;

public interface IPasswordService
{
    string GeneratePassword(PasswordCriteria criteria);
}