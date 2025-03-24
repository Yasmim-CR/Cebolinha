Console.WriteLine("Digite uma frase:");
string frase = Console.ReadLine()!;
string fraseModificada = frase
                    .Replace("r", "l")
                    .Replace("R", "L");

Console.WriteLine($"{fraseModificada}");