//Example 19
// Console.WriteLine("Введите пятизначное число");
// int num_int = Convert.ToInt32(Console.ReadLine()); //Взял переменную int, нужна для проверки
// string num = num_int.ToString(); // это основная переменная. Равна num_int, только string
// string array = ""; // пустая переменная для перевертывания исходного числа
// if (num_int > 9999)// условие для проверки
// {
//         for (int i = 4; i !=-1;) // цикл для перевертывания
//     {
//         array= array + num[i]; // Добовляю в строку array элемент из строки num, начиная с конца, с 5 элемента
//         i = i-1; // меняю i, чтобы получить предыдуший элемент строки num
//     }
//     if (array == num) // если строки равны, то число является палиндромом, иначе не является
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет");
//     }
// }
// else
// {
//     Console.WriteLine("Число не пятизначное");
// }

//Examole 21
// double[] A = new double[3]; //создаем массив, тип double для мат.операций
// double[] B = new double[3];
// Console.WriteLine("Введите x координату точки А");
// A[0] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y координату точки А");
// A[1] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z координату точки А");
// A[2] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x координату точки B");
// B[0] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y координату точки B");
// B[1] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z координату точки B");
// B[2] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Sqrt(Math.Pow(B[0]-A[0],2)+Math.Pow(B[1] - A[1],2)+ Math.Pow(B[2]-A[2],2)));

//Example 23
int num = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i !=num+1;)
{
    if (i == 1 && num == 1)
    {
     Console.Write(Math.Pow(i,3));   
    }
    if (i == num && i !=1)
    {
       Console.Write(Math.Pow(i,3));   
    }
    if ((i == 1 && i!=num) || i < num )
    {
        Console.Write(Math.Pow(i,3)+",");
    }
    i++;
}