using System.Security.Cryptography;
using System.Text;
using RsaAlgorithms;

try
{
    //input a message
    Console.Write("input a message: ");
    var plainTextData = Console.ReadLine() ?? "Data to Encrypt";

    //Create a UnicodeEncoder to convert between byte array and string.
    UnicodeEncoding ByteConverter = new UnicodeEncoding();
    //Create byte arrays to hold original, encrypted, and decrypted data.
    byte[] dataToEncrypt = ByteConverter.GetBytes(plainTextData);
    byte[] encryptedData;
    byte[] decryptedData;

    //Create a new instance of RSACryptoServiceProvider to generate
    //public and private key data.
    using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
    {

        //Pass the data to ENCRYPT, the public key information (using RSACryptoServiceProvider.ExportParameters(false), and a boolean flag specifying no OAEP padding.
        encryptedData = RsaAlgUtil.RSAEncrypt(dataToEncrypt, RSA.ExportParameters(false), false);
        Console.WriteLine("encrypted message: "+  Convert.ToBase64String(encryptedData));

        //Pass the data to DECRYPT, the private key information (using RSACryptoServiceProvider.ExportParameters(true), and a boolean flag specifying no OAEP padding.
        decryptedData = RsaAlgUtil.RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
        //Display the decrypted plaintext to the console. 
        Console.WriteLine("Decrypted message: {0}", ByteConverter.GetString(decryptedData));
    }
}
catch (ArgumentNullException)
{
    //Catch this exception in case the encryption did not succeed.
    Console.WriteLine("Encryption failed.");
}