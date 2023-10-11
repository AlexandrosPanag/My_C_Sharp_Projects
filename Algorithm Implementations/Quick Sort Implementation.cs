//By Alexandros Panagiotakopoulos - alexandrospanag.github.io

class Program
{
    static void Main(string[] args)
    {
        int[] arr = GenerateRandomArray(); // generate a random integer array for sorting
        Console.WriteLine("Original Array:");
        DisplayArray(arr); // display the original array
        QuickSort(arr, 0, arr.Length - 1); // sort the array using QuickSort algorithm
        Console.WriteLine("\nSorted Array:");
        DisplayArray(arr); // display the sorted array
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivot = Partition(arr, low, high); // get pivot index
            QuickSort(arr, low, pivot - 1); // sort left partition
            QuickSort(arr, pivot + 1, high); // sort right partition
        }
    }

    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // choose last element as pivot
        int i = low - 1; // index of smaller element

        for (int j = low; j <= high - 1; j++)
        {
            // If current element is smaller than or equal to pivot
            if (arr[j] <= pivot)
            {
                i++; // increment index of smaller element
                Swap(ref arr[i], ref arr[j]); // swap arr[i] and arr[j]
            }
        }
        Swap(ref arr[i + 1], ref arr[high]); // swap pivot and arr[i+1]
        return i + 1; // return pivot index
    }

    static int[] GenerateRandomArray()
    {
        Random rand = new Random();
        int[] arr = new int[10]; // allocate memory for 10 elements
        for (int i = 0; i < 10; i++)
        {
            arr[i] = rand.Next(1, 50); // generate random integers between 1 and 49
        }
        return arr;
    }

    static void DisplayArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }

    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}
