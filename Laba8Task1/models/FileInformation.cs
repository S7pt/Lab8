using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;

namespace Laba8Task1.models
{
    public class FileInformation
    {
        public void FileInformationRead(List<StorageCamera> storages)
        {
            string reader;
            string[] stringArray;
            using (StreamReader streamReader = new StreamReader("Storages.txt"))
            {
                while (streamReader.EndOfStream == false)
                {
                    reader = streamReader.ReadLine();
                    if (reader != "" && reader != " ")
                    {
                        stringArray = reader.Split("|");
                        storages.Add(new StorageCamera(stringArray[0], int.Parse(stringArray[1]),
                            int.Parse(stringArray[2]),
                            stringArray[3], stringArray[4]));
                    }
                }
            }
        }

        public void FileInformationWrite(List<StorageCamera> storages)
        {
            using (StreamWriter storageInformationWriter = new StreamWriter("Storages.txt"))
            {
                Console.WriteLine("Type storing date: ");
                string dateOfStoring = Console.ReadLine();
                Console.WriteLine("Type baggage weight");
                int weight = int.Parse(Console.ReadLine());
                Console.WriteLine("Type duration(in days)");
                int duration = int.Parse(Console.ReadLine());
                Console.WriteLine("Type owner name and surname");
                string ownerInitials = Console.ReadLine();
                Console.WriteLine("Type special notes(type none if you don't have)");
                string notes = Console.ReadLine();
                StorageCamera storageInformationToAdd = new StorageCamera(dateOfStoring, weight, duration,
                    ownerInitials, notes);
                storages.Add(storageInformationToAdd);
                foreach (StorageCamera storage in storages)
                {
                    storageInformationWriter.WriteLine(storage.ToString());
                }
            }

            File.WriteAllText("Storages.txt", String.Empty);
            using (StreamWriter storageInformationWriter = new StreamWriter("Storages.txt"))
            {
                foreach (StorageCamera storage in storages)
                {
                    storageInformationWriter.WriteLine(storage.ToString());
                }
            }
        }

        public void FileInformationEdit(List<StorageCamera> storages)
        {
            for (int i = 0; i < storages.Count; i++)
            {
                Console.WriteLine(i + 1 + "." + storages[i]);
            }

            Console.WriteLine("Type the number of student you want to edit");
            int number = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Select action:");
            Console.WriteLine("1.Edit date of storing");
            Console.WriteLine("2.Edit weight of baggage");
            Console.WriteLine("3.Edit keeping duration");
            Console.WriteLine("4.Edit owner initials");
            Console.WriteLine("5.Edit special notes");
            Console.WriteLine("6.Edit all parameters");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                {
                    Console.WriteLine("Type new date of storing");
                    storages[number].storeDate = Console.ReadLine();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Type new weight of baggage");
                    storages[number].baggageWeight = int.Parse(Console.ReadLine());
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Type new keeping duration");
                    storages[number].storingDuration = int.Parse(Console.ReadLine());
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Type owner initials");
                    storages[number].ownerNameAndSurname = Console.ReadLine();
                    break;
                }
                case 5:
                {
                    Console.WriteLine("Type special notes(none if you don't have any");
                    storages[number].specialNotes = Console.ReadLine();
                    break;
                }
                case 6:
                {
                    Console.WriteLine("Type new date of storing");
                    storages[number].storeDate = Console.ReadLine();
                    Console.WriteLine("Type new weight of baggage");
                    storages[number].baggageWeight = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type new keeping duration");
                    storages[number].storingDuration = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type new date");
                    Console.WriteLine("Type owner initials");
                    storages[number].ownerNameAndSurname = Console.ReadLine();
                    Console.WriteLine("Type special notes(none if you don't have any");
                    storages[number].specialNotes = Console.ReadLine();
                    break;
                }
                default:
                {
                    throw new ArgumentException("You typed the wrong symbol");
                }
            }

            using (StreamWriter storageInformationWriter = new StreamWriter("Storages.txt"))
            {
                File.WriteAllText("Storages.txt", String.Empty);
                foreach (StorageCamera storage in storages)
                {
                    storageInformationWriter.WriteLine(storage.ToString());
                }
            }
        }
        public void RemoveExistingInformation(List<StorageCamera> storages)
        {
            for (int i = 0; i < storages.Count; i++)
            {
                Console.WriteLine(i+1+"."+storages[i]);
            }
            Console.WriteLine("Type the number of information you want to remove");
            int number = int.Parse(Console.ReadLine())-1;
            storages.RemoveAt(number);
            File.WriteAllText("Storages.txt",String.Empty);
            using (StreamWriter sw=new StreamWriter("Storages.txt"))
            {
                foreach (StorageCamera informationUnit in storages)
                {
                    sw.WriteLine(informationUnit);
                }
            }
        }

        public void SortInformation(List<StorageCamera> storages)
        {
            Console.WriteLine("Choose option:");
            Console.WriteLine("1.Sort by duration");
            Console.WriteLine("2.Sort by weight");
            Console.WriteLine("3.Sort by initials");
            int number=Int32.Parse(Console.ReadLine());
            switch (number)
            {
                case 1:
                {
                    SortByDuration sorter=new SortByDuration();
                    storages.Sort(sorter);
                    break;
                }
                case 2:
                {
                    SortByWeight sorter=new SortByWeight();
                    storages.Sort(sorter);
                    break;
                }
                case 3:
                {
                    SortByNameAndSurname sorter=new SortByNameAndSurname();
                    storages.Sort(sorter);
                    break;
                }
                default:
                {
                    throw new Exception("You typed the wrong symbol");
                }
            }
            foreach (StorageCamera storage in storages)
            {
                Console.WriteLine(storage);        
            }
            File.WriteAllText("Storages.txt",String.Empty);
            using (StreamWriter sw=new StreamWriter("Storages.txt"))
            {
                foreach (StorageCamera informationUnit in storages)
                {
                    sw.WriteLine(informationUnit);
                }
            }
            
        }
    }
}