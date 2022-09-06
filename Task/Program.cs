void TransformToLength3Less(string[] initArr, string[] finArr)
{
    int count = 0;
    for (int i = 0; i < initArr.Length; i++)
    {
        if (initArr[i].Length <= 3)
        {
            finArr[count] = initArr[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.Write("Введите элементы через пробел: ");
var initialArray = Console.ReadLine()
                            .Split()
                            .ToArray();
string[] finalArray = new string[initialArray.Length];

TransformToLength3Less(initialArray, finalArray);
PrintArray(finalArray);
