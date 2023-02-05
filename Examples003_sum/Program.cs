// Создать программу для вычисления суммы двух целых чисел

Console.Clear();
int numberA = new Random().Next(1,10); //1 2 3 4 ... 9
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
// Можно было ввести дополнительную переменную int result = numberA + numberB
Console.Write(numberA+numberB);