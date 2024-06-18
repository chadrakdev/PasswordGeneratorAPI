namespace PasswordGeneratorAPI.Models;

public class PasswordCriteria
{
    public int Length { get; set; }
    public bool HasUppercase { get; set; }
    public bool HasLowercase { get; set; }
    public bool HasNumbers { get; set; }
    public bool HasSpecialCharacters { get; set; }
}