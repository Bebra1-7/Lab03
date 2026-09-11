Console.WriteLine("Банковский счёт");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500;
Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200;
Console.WriteLine($"После покупки: {balance}");

balance *= 1.05;
Console.WriteLine($"После начисления: {balance}");

balance /= 2;
Console.WriteLine($"После деления: {balance}");

Console.WriteLine("Постфикс vs префикс");

int lnum = 1;
Console.WriteLine($"lnum++: {lnum++}");
Console.WriteLine($"after: {lnum}");

int weeknum = 1;
Console.WriteLine($"++weeknum: {++weeknum}");
Console.WriteLine($"after: {weeknum}");

Console.WriteLine($"");
Console.WriteLine($"Практ. ловушка");

int attempts = 0;
Console.WriteLine($"Num {++attempts}");
Console.WriteLine($"Num {++attempts}");
Console.WriteLine($"Всего попыток: {attempts}");
