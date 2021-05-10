
namespace Weelo.Application.Services
{
    public interface IDataProtectionHelper: IDecrypt, IEncrypt
    {
        
        
    }
    public interface IDecrypt {
        string Decrypt(string cipherText);
    }
    public interface IEncrypt
    {
        string Encrypt(string textToEncrypt);
    }



}