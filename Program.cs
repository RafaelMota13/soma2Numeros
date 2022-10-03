double primeiro, segundo, resultado;

Console.Write("\nDigite o primeiro número: ");
    primeiro = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
     segundo = Convert.ToDouble(Console.ReadLine());

resultado = primeiro + segundo;

Console.Write($"\n{primeiro} + {segundo} = ");

Console.ForegroundColor = ConsoleColor.DarkGreen;


Console.WriteLine($"{resultado}\n");

Console.ResetColor();




