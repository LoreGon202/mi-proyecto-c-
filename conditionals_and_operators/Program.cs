// string nameInput= string.empty;
Console.WriteLine("Ingrese un número: ");
string? input = Console.ReadLine();
if (string.IsNullOrEmpty(input) || !int.TryParse(input, out int num))
{
    Console.WriteLine("Entrada inválida. Por favor ingrese un número entero.");
    return;
}

if (num > 0) Console.WriteLine("Positivo");
else if (num < 0) Console.WriteLine("Negativo");
else Console.WriteLine("Es cero");