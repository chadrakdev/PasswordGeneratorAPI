namespace PasswordGeneratorAPI.Models
{
    public class PasswordCriteria
    {
        public int MinLength { get; set; } = 8;
        public int MaxLength { get; set; } = 16;
        public bool IsMixedCase { get; set; } = true;
        public bool IsAlphanumeric { get; set; } = true;
        public bool IncludeSpecialCharacters { get; set; } = true;

        public int GetRandomLength()
        {
            var random = new Random();
            return random.Next(MinLength, MaxLength + 1);
        }
    }
}