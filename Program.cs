// Console.WriteLine("Банковский счёт");

// double balance = 1000;
// Console.WriteLine($"Начальный баланс: {balance}");

// balance += 500;
// Console.WriteLine($"После пополнения на 500: {balance}");

// balance -= 200;
// Console.WriteLine($"После покупки: {balance}");

// balance *= 1.05;
// Console.WriteLine($"После начисления: {balance}");

// balance /= 2;
// Console.WriteLine($"После деления: {balance}");

// Console.WriteLine("Постфикс vs префикс");

// int lnum = 1;
// Console.WriteLine($"lnum++: {lnum++}");
// Console.WriteLine($"after: {lnum}");

// int weeknum = 1;
// Console.WriteLine($"++weeknum: {++weeknum}");
// Console.WriteLine($"after: {weeknum}");

// Console.WriteLine($"");
// Console.WriteLine($"Практ. ловушка");

// int attempts = 0;
// Console.WriteLine($"Num {++attempts}");
// Console.WriteLine($"Num {++attempts}");
// Console.WriteLine($"Всего попыток: {attempts}");

// Console.WriteLine();
// Console.WriteLine($"Операторы сравнения");

// double myGrade = 4.6;
// double passingGrade = 4.0;
// int myAge = 20;
// int votingAge = 18;
// bool isPassing = myGrade >= passingGrade;
// bool isExactAge = myAge == votingAge;
// bool canVote = myAge >= votingAge;
// bool isNotFailing = myGrade != 2.0;

// Console.WriteLine($"Балл {myGrade} >= {passingGrade}: {isPassing}");
// Console.WriteLine($"Возраст {myAge} == {votingAge}: {isExactAge}");
// Console.WriteLine($"Возраст {myAge} >= {votingAge}: {canVote}");

// Console.WriteLine($"Балл {myGrade} != 2.0(not 2): {isNotFailing}");

// bool hasPassingGrade = true;
// bool hasAttendance = false;
// bool hasDebt = true;

// bool canGetScholarship = hasPassingGrade && hasAttendance;
// bool canRetExam = hasPassingGrade || hasAttendance;
// bool isDebtFree = !hasDebt;
// Console.WriteLine($"{canGetScholarship}........ {canRetExam}........ {isDebtFree}");

// Console.WriteLine($"");

// bool CheckAndPrint(string label, bool value)
// {
//     Console.WriteLine($"Вычисл.: {label}");
//     return value;
// }
// Console.WriteLine($"Проверяем &&");
// bool resultAnd = CheckAndPrint("A", false) && CheckAndPrint("B", true);
// Console.WriteLine($"Result: {resultAnd}");

// Console.WriteLine($"");
// Console.WriteLine($"Проверяем ||");
// bool resultOr = CheckAndPrint("C", true) || CheckAndPrint("D", false);
// Console.WriteLine($"Result: {resultOr}");

// //Шпора
// // 1. ()
// // 2. ++--!
// // 3. * / %
// // 4. + -
// // 5. < > <= >=
// // 6. == !=
// // 7. &&
// // 8. ||
// // 9. = += -= *= /= %=

// Console.WriteLine($"");
// Console.WriteLine($"Приоритет операций");

// int resultNoParens = 2 + 3 * 4;
// int resultWithParens = (2 + 3) * 4;
// Console.WriteLine($"2+3*4 = {resultNoParens}");
// Console.WriteLine($"(2+3)*4 = {resultWithParens}");

// bool logicResult = 5 > 3 && 2 < 4 || false;
// bool logicResultParens = (5 > 3 && 2 < 4) || false;
// Console.WriteLine($"5 > 3 && 2 < 4 || false = {logicResult}");
// Console.WriteLine($"(5 > 3 && 2 < 4) || false = {logicResultParens}");

// Console.WriteLine($"");
// Console.WriteLine("Приёмная комиссия");

// Console.Write("Введите средний балл аттестата: ");
// double averageScore = double.Parse(Console.ReadLine());

// Console.Write("Введите баллы за экзамен (0-100): ");
// int examScore = int.Parse(Console.ReadLine());

// Console.Write("Есть льгота? (1 — да, 0 — нет): ");
// int benefitInput = int.Parse(Console.ReadLine());
// bool hasBenefit = (benefitInput == 1);

// bool hasGoodCertificate = averageScore >= 4.0;

// bool hasGoodExam = examScore >= 60;

// bool isEligibleByRules = (hasGoodCertificate == hasGoodExam) || hasBenefit;

// double totalScore = averageScore * 10;
// totalScore += examScore;

// Console.WriteLine($"");
// Console.WriteLine($"Result");
// Console.WriteLine($"Good аттестат (>= 4.0): {hasGoodCertificate}");
// Console.WriteLine($"Good exam (>=60): {hasGoodExam}");
// Console.WriteLine($"Benefit: {hasBenefit}");
// Console.WriteLine($"Проходит по правилам: {isEligibleByRules}");
// Console.WriteLine($"Итоговый балл: {totalScore}");


// Console.WriteLine();
// Console.Write("Please num: ");
// int num = int.Parse(Console.ReadLine());

// bool isEven = (num % 2) == 0;
// Console.WriteLine($"Num even: {isEven}");

// Console.WriteLine();

// int Number1 = 68;
// Console.WriteLine($"Number1++: {Number1++}"); // Здесь ещё находиться знач. 68 и выводит его после чего add единицу
// Console.WriteLine($"after: {Number1}"); // Здесь измен. знач. Number1 and оно равно 69

// int Number2 = 66;
// Console.WriteLine($"++Number2: {++Number2}"); // Здесь сначала прибавляется единица, а уже потом выводится result

Console.WriteLine();
Console.Write("Сумма покупки: ");
double sumPurchase = double.Parse(Console.ReadLine());

Console.Write("Есть карта пост. клиента(1 — есть, 0 — нету? ");
bool cardPeople = (int.Parse(Console.ReadLine()) == 1);

Console.Write("Кол-во товаров в чеке: ");
int quantity = int.Parse(Console.ReadLine());

bool eligibleForDiscount = (sumPurchase >= 3000 && quantity >= 3) || cardPeople;

Console.WriteLine();
Console.WriteLine($"Сумма >= 3000: {sumPurchase >= 3000}");
Console.WriteLine($"Товаров в чеке >= 3: {quantity >= 3}");
Console.WriteLine($"Карта пост. клиента: {cardPeople}");
Console.WriteLine($"Скидка выдана: {eligibleForDiscount}");