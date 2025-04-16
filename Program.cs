Console.Write("Please enter a number: ");

int.TryParse(Console.ReadLine(), out int number);

int[] array = new int[number];

for (int i = 0; i < number; i++)
{
    array[i] = number;
}

while (array.Length > 0)
{
    Console.WriteLine(string.Join(" ", array));
    
    Array.Resize(ref array, array.Length - 1);
}