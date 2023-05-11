using DesAlgorithms;

// input a string to encrypt.
Console.Write("input a message: ");
string sData = Console.ReadLine() ?? "message";

string encrypted = DesAlgUtil.EncryptText(sData);
Console.WriteLine("encrypted message: "+ encrypted);

Console.WriteLine("decrypted message: " + DesAlgUtil.DecryptText(encrypted));