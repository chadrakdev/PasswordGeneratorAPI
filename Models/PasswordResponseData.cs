namespace PasswordGeneratorAPI.Models;

public class PasswordResponseData
{
    public string Response { get; set; }
    public PasswordCriteria criteria { get; set; }
}