﻿using System.Transactions;

namespace Day2_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region using jagged array

            //Console.Write("Enter number of tracks:");
            //int numOfTracks = int.Parse(Console.ReadLine());


            //int[][] tracks = new int[numOfTracks][];

            //for (int i = 0; i < numOfTracks; i++)
            //{
            //    Console.Write($"Enter number of students for track[{i+1}]: ");
            //    int numOfStudents = int.Parse(Console.ReadLine());

            //    tracks[i]= new int[numOfStudents];

            //    for (int j = 0; j < tracks[i].Length; j++)
            //    {
            //        Console.Write($"Enter age for student{j+1}: ");
            //        int age = int.Parse(Console.ReadLine());
            //        tracks[i][j] = age;
            //    }
            //}
            //Console.WriteLine("==========================================");

            //for(int i =0; i < tracks.Length; i++)
            //{
            //    Console.WriteLine($"Track [{i+1}]");
            //    int sum = 0;
            //    for (int j = 0;j < tracks[i].Length;j++) 
            //    {
            //        Console.WriteLine($"Student{j+1} age: {tracks[i][j]}");
            //        sum += tracks[i][j];
            //    }
            //    int avg = sum / tracks[i].Length;
            //    Console.WriteLine($"Avg age of students in Track [{i + 1}] => {avg}");
            //}

            #endregion

            #region 2D array 

            //Console.Write("Enter number of tracks: ");
            //int numOfTracks = int.Parse(Console.ReadLine());

            //Console.Write("Enter number of students for each track: ");
            //int numOfStudents = int.Parse(Console.ReadLine());

            //int[,] arr = new int[numOfTracks, numOfStudents];

            //for (int i = 0; i < numOfTracks; i++)
            //{
            //    Console.WriteLine($"Enter students ages for track [{i + 1}]: ");

            //    for (int j = 0; j < numOfStudents; j++)
            //    {
            //        Console.Write($"student {j + 1} age: ");
            //        arr[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //Console.WriteLine("==================================================");

            //for (int i = 0; i < numOfTracks; i++)
            //{
            //    int sum = 0;
            //    Console.WriteLine($"Track [{i + 1}]");
            //    for (int j = 0; j < numOfStudents; j++)
            //    {
            //        Console.WriteLine($"student{j + 1} age => {arr[i, j]}");
            //        sum += arr[i, j];
            //    }
            //    int avg = sum / numOfStudents;
            //    Console.WriteLine($"Avg of ages for track[{i}]: {avg}");
            //    Console.WriteLine("-------------------------");
            //}

            #endregion

            Console.ReadKey(true);
            
        }
    }
}
