//вариант 16 уровень средний
Console.WriteLine("Введите элементы масcива");
int[] mas = new int[5];
for (int i = 0; i < mas.Length; i++)
{
    mas[i] = int.Parse(Console.ReadLine());
}
for (int i = 0; i < mas.Length; i++)
{
    Console.Write(mas[i] + " ");
}
int sum = 0;
int a = 0;
for (int i = 0; i < mas.Length; i++)
{
    if (mas[i] > 0)
    {
        sum += mas[i];
        a++;
    }
    else if (mas[i] < 0) break;
}
Console.WriteLine("sum =" + sum);
Console.WriteLine("кол-во элементов = " + a);
