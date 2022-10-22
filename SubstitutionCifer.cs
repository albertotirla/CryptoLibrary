using System.Text;

namespace CryptoLibrary;
public abstract class SubstitutionCifer : Cifer
{
    public override string Decrypt<T>(string ciferText, T key)
    {
        Dictionary<char, char> PermutationTable = GenerateSubstitutionTable(key, CryptoOperations.Decrypt);
        return ApplySubstitution(PermutationTable, ciferText);
    }

    private static string ApplySubstitution(Dictionary<char, char> permutationTable, string text)
    {
        StringBuilder result = new();
        foreach (char item in text)
        {
            result.Append(permutationTable[item]);
        }
        return result.ToString();
    }

    protected abstract Dictionary<char, char> GenerateSubstitutionTable<T>(T? key, CryptoOperations mode);

    public override string Encrypt<T>(string planeText, T key)
    {
Dictionary<char, char> PermutationTable = GenerateSubstitutionTable(key, CryptoOperations.Decrypt);
        return ApplySubstitution(PermutationTable, planeText);
    }
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}