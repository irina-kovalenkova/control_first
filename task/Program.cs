Console.Clear();
string[] CreateArray() 
{
    Console.Write("Нow many arrays do you want: ");
    int quentityArray = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[quentityArray];

    for(int i = 0; i < quentityArray; i++)
    {
        Console.Write("Enter some text: ");
        string? value = Console.ReadLine();
        while(value == String.Empty)
        {
            Console.Write("You didn't enter a value. Enter some elements: ");
            value = Console.ReadLine();
        }
        if(value != null) array[i] = value;
    }
    return array;
}

int CountElements(string[] array) 
{
    int quantity = 0;
    int count = 3;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= count) quantity ++;
    }
    return quantity;
}

string[] NewSmallArray(string[] array, int quantityElements) 
{
    
    string[] newArray = new string[quantityElements];

    for(int i = 0, j = 0; i < array.Length; i++, j++)
    {
        int size = array[i].Length;
        int countsize = 3;
        if(size <= countsize) 
        {
            newArray[j] = array[i];
        }
        else j--;
    }
    return newArray;
}

void ShowArray(string[] array) 
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write("'" + array[i] + "'" + ",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
    Console.WriteLine();
}

string[] myArray = CreateArray();
ShowArray(myArray);
int sumOfExectElements = CountElements(myArray);
string[] newArray = NewSmallArray(myArray, sumOfExectElements);
Console.WriteLine("Array of less than 3 elements:");
ShowArray(newArray);