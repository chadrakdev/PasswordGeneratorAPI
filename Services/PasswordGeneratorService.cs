using System.Text;
using PasswordGeneratorAPI.Models;

namespace PasswordGeneratorAPI.Services;

public class PasswordGeneratorService
{
    private readonly PasswordCriteria _passwordCriteria;

    public PasswordGeneratorService(PasswordCriteria passwordCriteria)
    {
        this._passwordCriteria = passwordCriteria;
    }
    
    public string GeneratePassword()
    {
        int length = _passwordCriteria.GetRandomLength();
        var password = new StringBuilder();

        string lowerCaseChars = "abcdefghijklmnopqrstuvwxyz";
        string upperCaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "0123456789";
        string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

        string allowedChars = string.Empty;

        if (_passwordCriteria.IsMixedCase)
        {
            allowedChars += lowerCaseChars + upperCaseChars;
        }
        else
        {
            allowedChars += lowerCaseChars;
        }

        if (_passwordCriteria.IsAlphanumeric)
        {
            allowedChars += numbers;
        }

        if (_passwordCriteria.IncludeSpecialCharacters)
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