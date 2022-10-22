namespace CryptoLibrary;
public abstract class Cifer
{
public abstract string Encrypt<T>(string planeText, T key);
public abstract string Decrypt<T>(string ciferText, T key);
}
