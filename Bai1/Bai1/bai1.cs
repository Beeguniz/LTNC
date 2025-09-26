using System;
using System.Data;

class MaTran
{
    private int[,] matrix; //Mang 2 chieu
    private int rows;
    private int cols;
    public MaTran(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        matrix = new int[rows, cols];
    }
    public void Nhap()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Nhap phan tu [{i + 1},{j + 1}]:");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }

    public void Xuat()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    public static MaTran Cong(MaTran A, MaTran B)
    {
        if (A.rows != B.rows || A.cols != B.cols)
        {
            Console.Write("Hai ma tran khong cung kich thuoc");
            Console.WriteLine();
        }

        MaTran C = new MaTran(A.rows, A.cols);
        for(int i = 0; i < A.rows; i++)
        {
            for(int j = 0; j < A.cols; j++)
            {
                C.matrix[i, j] = A.matrix[i, j] + B.matrix[i, j];
            }
        }
        return C;
    }

    public static MaTran Nhan(MaTran A, MaTran B)
    {
        if (A.cols != B.rows)
        {
            Console.Write("Hai ma tran khong the nhan");
            Console.WriteLine();
        }
        MaTran C = new MaTran(A.rows, B.cols);
        for (int i = 0; i < A.rows; i++)
        {
            for (int j = 0; j < B.cols; j++)
            {
                C.matrix[i, j] = 0;
                for (int k = 0; k < A.cols; k++)
                {
                    C.matrix[i, j] += A.matrix[i, k] * B.matrix[k, j];
                }
            }
        }
        return C;
    }

    public static MaTran ChuyenVi(MaTran A)
    {
        MaTran C = new MaTran(A.cols, A.rows);
        for (int i = 0; i < A.rows; i++)
        {
            for (int j = 0; j < A.cols; j++)
            {
                C.matrix[j, i] = A.matrix[i, j];
            }
        }
        return C;
    }

    public static MaTran TimMinMax(MaTran A)
    {
        int max = A.matrix[0, 0];
        int min = A.matrix[0, 0];
        for (int i = 0; i < A.rows; i++)
        {
            for (int j = 0; j < A.cols; j++)
            {
                if (A.matrix[i, j] > max)
                {
                    max = A.matrix[i, j];
                }
                if (A.matrix[i, j] < min)
                {
                    min = A.matrix[i, j];
                }
            }
        }
        MaTran result = new MaTran(1, 2);
        result.matrix[0, 0] = max;
        result.matrix[0, 1] = min;
        return result;
    }
}

class Progarm
{
    static void Main()
    {
        Console.Write("Nhap so dong ma tran A:");
        int dongA = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot ma tran A:");
        int cotA = int.Parse(Console.ReadLine());

        MaTran mtA = new MaTran(dongA, cotA);
        mtA.Nhap();
        mtA.Xuat();

        //Console.Write("Nhap so dong ma tran B:");
        //int dongB = int.Parse(Console.ReadLine());
        //Console.Write("Nhap so cot ma tran B:");
        //int cotB = int.Parse(Console.ReadLine());
        //while(dongA != dongB || cotA != cotB)
        //{
        //    Console.WriteLine("Ban nhap 2 ma tran khong cung kich thuoc vui long nhap lai:");
        //    Console.Write("Nhap so dong ma tran B:");
        //    dongB = int.Parse(Console.ReadLine());
        //    Console.Write("Nhap so cot ma tran B:");
        //    cotB = int.Parse(Console.ReadLine());
        //}    

        //while (cotA != dongB)
        //{
        //    Console.WriteLine("So cot ma tran A khong bang so dong ma tran B, vui long nhap lai:");
        //    Console.Write("Nhap so dong ma tran B:");
        //    dongB = int.Parse(Console.ReadLine());
        //    Console.Write("Nhap so cot ma tran B:");
        //    cotB = int.Parse(Console.ReadLine());
        //}

        //MaTran mtB = new MaTran(dongB, cotB);
        //mtB.Nhap();
        //mtB.Xuat();
        //Console.WriteLine("Ma tran C = A + B la:");
        //MaTran mtC = MaTran.Cong(mtA, mtB);
        //mtC.Xuat();

        //Console.WriteLine("Ma tran C = A x B la:");
        //MaTran mtC = MaTran.Nhan(mtA, mtB);
        //mtC.Xuat();
        //MaTran mtC = MaTran.ChuyenVi(mtA);
        //Console.WriteLine("Ma tran C = A^T la:");
        //mtC.Xuat();

        MaTran mtC = MaTran.TimMinMax(mtA);
        Console.WriteLine("Gia tri max, min");
        mtC.Xuat();
        Console.ReadKey();
    }
}
