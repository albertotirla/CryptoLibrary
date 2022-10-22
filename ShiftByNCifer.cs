namespace CryptoLibrary;

public class ShiftByNCifer : SubstitutionCifer
{
    protected override Dictionary<char, char> GenerateSubstitutionTable<Int32>(Int32 key, CryptoOperations mode)
    {
        Dictionary<Char, char> res = new();
        for (int i = 0; i < 26; i++)
        {
            char current_letter = (char)('a' + i);
            char substitute_letter = '\t';//initialise the variable with a meaningless value, so that the compiler stops complaining 
            switch (mode)
            {
                case CryptoOperations.Encrypt:
                    substitute_letter = (char)(current_letter + Convert.ToInt32(key) % 26);
                    break;
                case CryptoOperations.Decrypt:
                    substitute_letter = (char)(current_letter - Convert.ToInt32(key) % 26 + 26);
                    break;
            }
            res[current_letter] = substitute_letter;
        }
        return res;
    }
}