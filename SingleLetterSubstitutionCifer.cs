using System;
namespace CryptoLibrary;
public class SingleLetterSubstitutionCifer : SubstitutionCifer
{
    protected override Dictionary<char, char> GenerateSubstitutionTable<String>(String key, CryptoOperations mode)
    {
        string key_str = key.ToString().ToLower();
        if (key_str.Length != 26)
        {
            throw new ArgumentOutOfRangeException("the key supplied to the single letter substitution cifer must be exactly 26 characters, since it represents a permutation of the entire alphabet.");
        }
        Dictionary<char, char> table = new();
        for (int i = 1; i < 27; i++)
        {
            if(!char.IsLetter(key_str[i]))
            {
                continue;
            }

            char current_letter = (char)('a' + i);
            char cifer_letter = key_str[i];
            switch (mode)
            {
                case CryptoOperations.Encrypt:
                    table[current_letter] = cifer_letter;
                    break;
                case CryptoOperations.Decrypt:
                    table[cifer_letter] = current_letter;
                    break;
            }
        }
        return table;
    }

}