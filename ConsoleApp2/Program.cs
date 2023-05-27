////1
//Random rnd = new Random();
//int temperature = 0;
//for (int i = 1; i < 2; i++)
//{
//    int a = rnd.Next(1, 101);
//    temperature = a;
//    Console.WriteLine("Текущая температура: " + temperature);
//    if (temperature > 90)
//    {
//        Console.WriteLine("Остановка работы устройства!!!");
//        break;
//    }
//}
//Console.WriteLine();

//2
Console.Write("Укажите количество квадратов: ");
int quantity = Convert.ToInt32(Console.ReadLine());//вводим количество квадратов

Console.Write("Укажите сторону квадрата: ");
int weigth = Convert.ToInt32(Console.ReadLine());//вводим длину стороны квадратов

for (int i = 0; i < quantity; i++)//для введенного количества квадратов выполняем цикл
{
    for (int j = 0; j < weigth; j++)//заполняется верхняя сторона квадрата в соответствии с вводимой длиной квадрата
    {
        Console.Write("*");//вводимая длина квадрата заполняется звездочками
        Console.Write(" ");// пробел
    }
    Console.WriteLine();
    for (int k = 0; k < weigth - 2; k++)//заполняется левая сторона квадрата
    {
        Console.Write("*");
        for (int l = 0; l < weigth + weigth - 2; l++)//заполняется правая сторона квадрата
        {
            Console.Write(" ");
        }
        Console.Write("*");
        Console.WriteLine();
    }
    for (int m = 0; m < weigth; m++)//заполняется нижняя сторона квадрата
    {
        Console.Write("*");
        Console.Write(" ");
    }

    Console.WriteLine();
}