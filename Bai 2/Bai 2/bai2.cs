using System;

class ArrayProcessor
{
    private int[] arr;

    public ArrayProcessor(int size)
    {
        arr = new int[size];
    }

    public void Nhap()
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
    }

    public void Xuat()
    {
        Console.WriteLine("Cac phan tu trong mang la:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public void BubbleSort()
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            for (int j = 0; j < arr.Length - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Mang sau khi sap xep bang thuat toan Bubble Sort:");
        Xuat();
    }

    public void QuickSort(int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(left, right);
            QuickSort(left, pivotIndex - 1);
            QuickSort(pivotIndex + 1, right);
        }
    }

    private int Partition(int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                // Hoán đổi arr[i] và arr[j]
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        // Hoán đổi arr[i + 1] và arr[right] (pivot)
        int tempPivot = arr[i + 1];
        arr[i + 1] = arr[right];
        arr[right] = tempPivot;

        return i + 1;
    }
    public int LinearSearch(int key)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                return i; // Trả về chỉ số phần tử đầu tiên tìm thấy
            }
        }
        return -1; // Trả về -1 nếu không tìm thấy
    }

    public int BinarySearch(int key)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == key)
                return mid;  // Trả về chỉ số nếu tìm thấy
            else if (arr[mid] < key)
                left = mid + 1;  // Tìm bên phải
            else
                right = mid - 1; // Tìm bên trái
        }

        return -1; // Trả về -1 nếu không tìm thấy
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Nhập kích thước mảng
        Console.Write("Nhập kích thước mảng: ");
        int size = int.Parse(Console.ReadLine());

        // Tạo đối tượng ArrayProcessor
        ArrayProcessor arrayProcessor = new ArrayProcessor(size);

        // Nhập mảng
        arrayProcessor.Nhap();
        arrayProcessor.Xuat();

        // Sắp xếp mảng bằng Bubble Sort
        arrayProcessor.BubbleSort();

        // Sắp xếp lại mảng để tìm kiếm nhị phân
        Console.WriteLine("\nĐang sắp xếp lại mảng bằng QuickSort...");
        arrayProcessor.QuickSort(0, size - 1);
        arrayProcessor.Xuat
            ();

        // Tìm kiếm tuyến tính
        Console.Write("\nNhập giá trị để tìm kiếm tuyến tính: ");
        int linearSearchKey = int.Parse(Console.ReadLine());
        int linearResult = arrayProcessor.LinearSearch(linearSearchKey);
        if (linearResult != -1)
            Console.WriteLine($"Tìm thấy giá trị {linearSearchKey} tại vị trí {linearResult}");
        else
            Console.WriteLine("Không tìm thấy giá trị.");

        // Tìm kiếm nhị phân
        Console.Write("\nNhập giá trị để tìm kiếm nhị phân: ");
        int binarySearchKey = int.Parse(Console.ReadLine());
        int binaryResult = arrayProcessor.BinarySearch(binarySearchKey);
        if (binaryResult != -1)
            Console.WriteLine($"Tìm thấy giá trị {binarySearchKey} tại vị trí {binaryResult}");
        else
            Console.WriteLine("Không tìm thấy giá trị.");
    }
}