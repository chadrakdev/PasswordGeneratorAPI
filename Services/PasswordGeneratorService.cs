using System.Text;
using PasswordGeneratorAPI.Models;

namespace PasswordGeneratorAPI.Services;

public class PasswordGeneratorService
{
    public string GeneratePassword(PasswordCriteria criteria)
    {
        int length = criteria.GetRandomLength();
        var password = new StringBuilder();

        string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "0123456789";
        string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

        string allowedChars = string.Empty;

        if (criteria.IsMixedCase)
        {
            allowedChars += lowerCaseChars + upperCaseChars;
        }
        else
        {
            allowedChars += lowerCaseChars;
        }

        if (criteria.IsAlphanumeric)
        {
            allowedChars += numbers;
        }

        if (criteria.IncludeSpecialCharacters)
        {
            allowedChars += specialChars;
        }

        var random = new Random();
        for (int i = 0; i < length; i++)
        {
            var randomIndex = random.Next(allowedChars.Length);
            password.Append(allowedChars[randomIndex]);
        }

        return password.ToString();
    }
}