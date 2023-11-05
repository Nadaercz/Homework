using System.Collections.Generic;

string input = String.Empty;
Dictionary<string, string> slovnik = new();
string[] finishwords = { "exit", "uloz" };
string[] helpwords = { "nacti", "ukaz" };
Console.WriteLine("Dobry den, vytvorime slovnik.");
Console.WriteLine("Kdyz budete chtit ukoncit zadani slov napiste : Exit");
Console.WriteLine("Kdyz budete chtit vypsat slovnik napiste : Ukaz");
Console.WriteLine("Kdyz budete chtit ulozit slovnik napiste : Uloz");
Console.WriteLine("Kdyz budete chtit nacist slovnik napiste : Nacti");

Console.WriteLine();
do
{
    Console.WriteLine("Zadejte slovo a jeho preklad pres carku");
    input = Console.ReadLine().ToLowerInvariant();
    string[] inputArray = input.Split(',');
    if (inputArray.Length >= 2)
    {
        if (slovnik.ContainsKey(inputArray[0]))
        {
            Console.WriteLine("Toto slovo uz v slovniku existuje");
        }
        else
        {
            slovnik.Add(inputArray[0], inputArray[1]);
        }
    }
    else if ((inputArray.Length <= 1) && (!finishwords.Contains(input)) && (!helpwords.Contains(input)))
    {
        Console.WriteLine("Zadali jste jenom 1 slovo, melo by byt 2");
    }
    else
    {
        switch (inputArray[0])
        {
            case "exit":
                {
                    Console.WriteLine("zadani slov je ukonceno");
                    break;
                }
            case "ukaz":
                {
                    if (slovnik.Count != 0)
                    {
                        Console.WriteLine("Vas slovnik ma {0} par slov. A je tady:", slovnik.Count);
                        foreach (var par in slovnik)
                        {
                            Console.WriteLine("preklad slova {0} je {1}", par.Key, par.Value);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vas slovnik je prazdny");
                    }
                    break;
                }
            case "uloz":
                {
                    File.WriteAllLines("mujSlovnik.txt",
                        slovnik.Select(x => x.Key + "=" + x.Value).ToArray());
                    Console.WriteLine("Slovnik je ulozen do souboru mujSlovnik.txt");
                    break;
                }
            case "nacti":
                {
                    string path = Path.GetFullPath("mujSlovnik.txt");
                    slovnik = File.ReadAllLines(path)
                                        .Select(x => x.Split('='))
                                        .ToDictionary(x => x[0], x => x[1]);
                    break;
                }
            default:
                Console.WriteLine("Ten comand je neznamy");
                break;
        }
    }

} while (!finishwords.Contains(input));


