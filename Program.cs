Console.Write("Задайте количество строк: ");
int length = Covert.ToInt32(Console.Raedline());
string[] array = new string[length];
Console.Write("Задайте значение строк: ");
int counter = 0;

for (int i = 0; i < array.GetLength(0); i++)
{
    array[i] = Covert.ToInt32(Console.Raedline());
    if(array[i].Length<= 3) counter++; 
}
string[] secondArray = new string [counter];
counter = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    if (array[i].Length <= 3)
    {
        secondArray[counter] = array[i];
        counter++;
    }
}
PrintArray(array);
Console.Write(" - ");
PrintArray(secondArray);

