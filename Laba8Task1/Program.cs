using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using Laba8Task1.models;

namespace Laba8Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInformation control=new FileInformation();
            List<StorageCamera> storages=new List<StorageCamera>();
            control.FileInformationRead(storages);
            sign:
            Console.WriteLine("1.Add a new information");
            Console.WriteLine("2.Edit existing information");
            Console.WriteLine("3.Destroy existing information");
            Console.WriteLine("4.Show the existing information");
            Console.WriteLine("5.Sort existing information");
            Console.WriteLine("6.Exit");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                {
                    control.FileInformationWrite(storages);
                    goto sign;
                }
                case 2:
                {
                    control.FileInformationEdit(storages);
                    goto sign;
                }
                case 3:
                {
                    control.RemoveExistingInformation(storages);
                    goto sign;
                }
                case 4:
                {
                    foreach (StorageCamera informationUnit in storages)
                    {
                        Console.WriteLine(informationUnit);
                    }

                    Console.ReadLine();
                    goto sign;
                }
                case 5:
                {
                    control.SortInformation(storages);
                    goto sign;
                }
                case 6:
                {
                    return;
                }
                default:
                {
                    throw new ArgumentException("You typed the wrong symbol");
                }
            }
        }
        }
    }
