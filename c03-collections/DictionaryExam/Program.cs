Dictionary<string, string> dic = new Dictionary<string, string>();

dic.Add("red", "mau do");
dic.Add("green", "mau xanh la cay");
dic.Add("blue", "mau xanh da troi");

Console.Write("Input a word: ");
string w = Console.ReadLine() ?? "";
if (dic.ContainsKey(w)){
    Console.WriteLine($"{w}: {dic[w]}");
} else {
    Console.WriteLine($"{w} not in dictionary!");
}