Console.WriteLine("Введите размер массива");

int M = Convert.ToInt32(Console.ReadLine());
int [] array = new int [M];
int counter = 0;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($" Введите элемент массива с порядковым номером {i}");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0){
        counter ++;
    }
}
Console.WriteLine($"Массив, котоырй вы ввели: [{String.Join(", ", array)}]");
Console.WriteLine($"Количество положительных чисел в массиве равно: {String.Join(", ", counter)}");