using System.Security.Cryptography;

using AesAlgorithms;

// input a string to encrypt.
Console.Write("input a message: ");
string msg = Console.ReadLine() ?? "message default";

// Encrypt & Decrpypted with Default Params
string strEncrypted = (AesAlgUtil.EncryptDefaultParams(msg));
Console.WriteLine("encrypted message: " + strEncrypted);
string strDecrypted = (AesAlgUtil.DecryptDefaultParams(strEncrypted));
Console.WriteLine("decrypted message: " + strDecrypted);


// Create a new instance of the AesCryptoServiceProvider class.
// This generates a new key and initialization vector (IV).
using (var myAes = Aes.Create())
{
    // Encrypt the string to an array of bytes.
    byte[] encrypted = AesAlgUtil.EncryptStringToBytes_Aes(msg, myAes.Key, myAes.IV);

    // Decrypt the bytes to a string.
    string roundtrip = AesAlgUtil.DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV);

    //Display the original data and the decrypted data.
    Console.WriteLine("Original:   {0}", msg);
    Console.WriteLine("Round Trip: {0}", roundtrip);
}