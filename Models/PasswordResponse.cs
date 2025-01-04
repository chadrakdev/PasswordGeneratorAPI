namespace PasswordGeneratorAPI.Models;

public class PasswordResponse
{
    public int Status { get; set; }
    public PasswordResponseData? Data { get; set; }
    
    public string? Error { get; set; }
}