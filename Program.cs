
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;

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

Console.WriteLine();
Console.WriteLine($"Операторы сравнения");

double myGrade = 4.6;
double passingGrade = 4.0;
int myAge = 20;
int votingAge = 18;
bool isPassing = myGrade >= passingGrade;
bool isExactAge = myAge == votingAge;
bool canVote = myAge >= votingAge;
bool isNotFailing = myGrade != 2.0;

Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
Console.WriteLine($"Возраст {myAge} >= {votingAge}: {canVote}");

Console.WriteLine($"Балл {myGrade} != 2.0(not 2): {isNotFailing}");

bool hasPassingGrade = true;
bool hasAttendance = false;
bool hasDebt = true;

bool canGetScholarship = hasPassingGrade && hasAttendance;
bool canRetExam = hasPassingGrade || hasAttendance;
bool isDebtFree = !hasDebt;
Console.WriteLine($"{canGetScholarship}........ {canRetExam}........ {isDebtFree}");

Console.WriteLine($"");

bool CheckAndPrint(string label, bool value)
{
    Console.WriteLine($"Вычисл.: {label}");
    return value;
}
Console.WriteLine($"Проверяем &&");
bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
Console.WriteLine($"Result: {resultAnd}");

Console.WriteLine($"");
Console.WriteLine($"Проверяем ||");
bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
Console.WriteLine($"Result: {resultOr}");

//Шпора
// 1. ()
// 2. ++--!
// 3. * / %
// 4. + -
// 5. < > <= >=
// 6. == !=
// 7. &&
// 8. ||
// 9. = += -= *= /= %=

Console.WriteLine($"");
Console.WriteLine($"Приоритет операций");

int resultNoParens = 2 + 3 * 4;
int resultWithParens = (2 + 3) * 4;
Console.WriteLine($"2+3*4 = {resultNoParens}");
Console.WriteLine($"(2+3)*4 = {resultWithParens}");

bool logicResult = 5 > 3 && 2 < 4 || false;
bool logicResultParens = (5 > 3 && 2 < 4) || false;
Console.WriteLine($"5 > 3 && 2 < 4 || false = {logicResult}");
Console.WriteLine($"(5 > 3 && 2 < 4) || false = {logicResultParens}");