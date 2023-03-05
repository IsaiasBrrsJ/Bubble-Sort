var arr = new int[10];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 11);
}

Console.WriteLine("Array Original");
Array.ForEach(arr, i => Console.Write(i+" |"));
Console.WriteLine("\n=================================");

int j = 0;
bool swap = false;
while (j < arr.Length-1)
{
    
    if (arr[j] > arr[j+1])
    {
        int aux = arr[j];
        arr[j] = arr[j+1];
        arr[j+1] = aux;
        swap = true;
    }

    if (swap && j == arr.Length - 2) 
    {
        j = 0;
        swap = false;   
        continue;
    }

    if(swap == false && j == arr.Length - 1) { break; }

    j++;
}
Console.WriteLine("Bubble Sort");
Array.ForEach(arr, i => Console.Write(i+" |"));
Console.WriteLine("\n=================================");
