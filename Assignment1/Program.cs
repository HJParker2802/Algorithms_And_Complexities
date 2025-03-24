using Assignment1.Search;
using Assignment1.SearchAlgorithms;
using Assignment1.SortAlgorithms;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Objects
            //FileReader and creater
            FileReader read = new FileReader();
            TxtCreater TextMaker = new TxtCreater();

            //Sorters
            BubbleSort Bubble = new BubbleSort();
            InsertionSort Insertion = new InsertionSort();
            MergeSort Merge = new MergeSort();
            QuickSort Quick = new QuickSort();

            //Searchers
            BinarySearch Binary = new BinarySearch();
            SequentialSearch Sequential = new SequentialSearch();

            bool Done = false;
            while (!Done)//Loops so the user can go through tasks as many times as they desire
            {
                Console.WriteLine("Do you want to run the Tasks or UI? ");
                string Answer = Console.ReadLine().ToUpper();
                if (Answer.Contains("U"))//Allows user to run the UI that's previously made
                {
                    UserInterface();
                    Done = true;
                }
                else if (Answer.Contains("T"))//Allows user to run the Tasks
                {
                    Done = true;
                    Console.WriteLine("Task 1");
                    //Task 1
                    //====================================================================================================================================
                    //Creates the Share arrays
                    List<int> Share1_256 = read.ReadFile("Share_1_256.txt");
                    List<int> Share2_256 = read.ReadFile("Share_2_256.txt");
                    List<int> Share3_256 = read.ReadFile("Share_3_256.txt");

                    Console.WriteLine("Task 2");
                    //Task 2
                    //====================================================================================================================================
                    //Utilises 3 different sorting algorithms (4th one used at the end for merged arrays)
                    Bubble.Ascending(Share1_256);
                    Bubble.DisplayEverySet(Share1_256, 10);
                    
                    Insertion.Descending(Share2_256);
                    Insertion.DisplayEverySet(Share2_256, 10);
                    
                    Merge.Ascending(Share3_256);
                    Merge.DisplayEverySet(Share3_256, 10);
                    
                    Console.WriteLine("Task 3");
                    //Task3
                    //====================================================================================================================================
                    //Searches for a user defined value, if not found, console gives pre-made error message
                    Console.WriteLine("Do you want to search Share: 1, 2 or 3");
                    string strAnswer = Console.ReadLine();
                    bool Conversion = int.TryParse(strAnswer, out int ShareAnswer);
                    Console.WriteLine("What number do you want to find?");
                    string strKey = Console.ReadLine();
                    bool KeyConversion= int.TryParse(strKey, out int Key);
                    if (Conversion == true && KeyConversion == true) //Checks both conversions are true to ensure both are correct ints
                    {
                        if (ShareAnswer == 1)
                        {
                            var Index = Binary.SearchKey(Share1_256, 0, Share1_256.Count, Key);
                            Binary.Display(Index);
                        }
                        if (ShareAnswer == 2)
                        {
                            var Index = Sequential.SearchKey(Share2_256, 0, Share2_256.Count, Key);
                            Sequential.Display(Index);
                        }
                        if (ShareAnswer == 3)
                        {
                            var Index = Binary.SearchKey(Share3_256, 0, Share3_256.Count, Key);
                            Binary.Display(Index);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have not given a valid answer, restarting");
                        break;
                    }
                    
                    Console.WriteLine("Task 4");
                    //Task 4
                    //====================================================================================================================================
                    //Searches arrays for the key and returns the nearest similar value if value not found 
                    Console.WriteLine("Do you want to search Share: 1, 2 or 3");
                    strAnswer = Console.ReadLine();
                    Conversion = int.TryParse(strAnswer, out ShareAnswer);
                    Console.WriteLine("What number do you want to find?");
                    strKey = Console.ReadLine();
                    KeyConversion = int.TryParse(strKey, out Key);
                    if (Conversion == true)
                    {
                        if (ShareAnswer == 1)
                        {
                            var Index = Binary.SearchKey(Share1_256, 0, Share1_256.Count, Key);
                            Binary.Display_Nearest(Index);
                        }
                        if (ShareAnswer == 2)
                        {
                            var Index = Sequential.SearchKey(Share2_256, 0, Share2_256.Count, Key);
                            Sequential.Display_Nearest(Index);
                        }
                        if (ShareAnswer == 3)
                        {
                            var Index = Binary.SearchKey(Share3_256, 0, Share3_256.Count, Key);
                            Binary.Display_Nearest(Index);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have not given a valid answer, restarting");
                        break;
                    }

                    Console.WriteLine("Task 5");
                    //Task 5
                    //====================================================================================================================================
                    //Repeats previous tasks for 2048 txt files 
                    List<int> Share1_2048 = read.ReadFile("Share_1_2048.txt");
                    List<int> Share2_2048 = read.ReadFile("Share_2_2048.txt");
                    List<int> Share3_2048 = read.ReadFile("Share_3_2048.txt");

                    Bubble.Ascending(Share1_2048);
                    Bubble.DisplayEverySet(Share1_2048, 50);

                    Insertion.Descending(Share2_2048);
                    Insertion.DisplayEverySet(Share2_2048, 50);

                    Merge.Ascending(Share3_2048);
                    Merge.DisplayEverySet(Share3_2048, 50);

                    Console.WriteLine("\n\n Searching, if not found, error   \n\n");

                    Console.WriteLine("Do you want to search Share: 1, 2 or 3");
                    strAnswer = Console.ReadLine();
                    Conversion = int.TryParse(strAnswer, out ShareAnswer);
                    Console.WriteLine("What number do you want to find?");
                    strKey = Console.ReadLine();
                    KeyConversion = int.TryParse(strKey, out  Key);
                    if (Conversion == true)
                    {
                        if (ShareAnswer == 1)
                        {
                            var Index = Binary.SearchKey(Share1_256, 0, Share1_256.Count, Key);
                            Binary.Display(Index);
                        }
                        if (ShareAnswer == 2)
                        {
                            var Index = Sequential.SearchKey(Share2_256, 0, Share2_256.Count, Key);
                            Sequential.Display(Index);
                        }
                        if (ShareAnswer == 3)
                        {
                            var Index = Binary.SearchKey(Share3_256, 0, Share3_256.Count, Key);
                            Binary.Display(Index);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have not given a valid answer, restarting");
                        break;
                    }


                    Console.WriteLine("\n\n Searching, if not found, nearest shown   \n\n");

                    Console.WriteLine("Do you want to search Share: 1, 2 or 3");
                    strAnswer = Console.ReadLine();
                    Conversion = int.TryParse(strAnswer, out ShareAnswer);
                    Console.WriteLine("What number do you want to find?");
                    strKey = Console.ReadLine();
                    KeyConversion = int.TryParse(strKey, out Key);
                    if (Conversion == true)
                    {
                        if (ShareAnswer == 1)
                        {
                            var Index = Binary.SearchKey(Share1_256, 0, Share1_256.Count, Key);
                            Binary.Display_Nearest(Index);
                        }
                        if (ShareAnswer == 2)
                        {
                            var Index = Sequential.SearchKey(Share2_256, 0, Share2_256.Count, Key);
                            Sequential.Display_Nearest(Index);
                        }
                        if (ShareAnswer == 3)
                        {
                            var Index = Binary.SearchKey(Share3_256, 0, Share3_256.Count, Key);
                            Binary.Display_Nearest(Index);
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have not given a valid answer, restarting");
                        break;
                    }

                    Console.WriteLine("\n\n\nTask 6\n");
                    //Task 6
                    //=======================================================================================================
                    //Creates a merged array to sort, display and search
                    TextMaker.main("MergedFile.txt", "Share_1_256.txt", "Share_3_256.txt");
                    List<int> MergeArray = read.ReadFile("MergedFile.txt");

                    Quick.Ascending(MergeArray);
                    Quick.DisplayEverySet(MergeArray, 10);
                    Quick.Descending(MergeArray);
                    Quick.DisplayEverySet(MergeArray, 10);
                    Console.WriteLine("\n What number would you like to find?");
                    strKey = Console.ReadLine();
                    KeyConversion = int.TryParse(strKey, out Key);
                    if (KeyConversion == true)
                    {
                        
                        var index = Binary.SearchKey(MergeArray, 0, MergeArray.Count, Key);
                        Binary.Display(index);

                        Console.WriteLine("\nSearching again but showing nearest value\n");

                        index = Sequential.SearchKey(MergeArray, 0, MergeArray.Count, Key);
                        Sequential.Display_Nearest(index);
                    }
                    else
                    {
                        Console.WriteLine("You have entered an incorrect value");
                        break;
                    }
                    //Task 7
                    //=================================================================================================
                    //Creates a merged array of 2048 txt files to sort, display and search
                    Console.WriteLine("Task 7");

                    TextMaker.main("MergedFile2.txt", "Share_1_2048.txt", "Share_3_2048.txt");
                    List<int> MergeArray2 = read.ReadFile("MergedFile.txt");

                    Quick.Ascending(MergeArray2);
                    Quick.DisplayEverySet(MergeArray2, 10);
                    Quick.Descending(MergeArray2);
                    Quick.DisplayEverySet(MergeArray2, 10);
                    Console.WriteLine("\n What number would you like to find?");
                    strKey = Console.ReadLine();
                    KeyConversion = int.TryParse(strKey, out Key);
                    if (KeyConversion == true)
                    {

                        var index = Binary.SearchKey(MergeArray2, 0, MergeArray2.Count, Key);
                        Binary.Display(index);

                        Console.WriteLine("\nSearching again but showing nearest value\n");

                        index = Sequential.SearchKey(MergeArray2, 0, MergeArray2.Count, Key);
                        Sequential.Display_Nearest(index);
                    }
                    else
                    {
                        Console.WriteLine("You have entered an incorrect value");
                        break;
                    }
                    //
                }
                else
                {
                    Console.WriteLine("You have not given a valid input");
                }

                //This goes at end so at least one search or sort can be done
                Console.WriteLine("\n\nWould you like to continue?");
                string DoneAnswer = Console.ReadLine().ToUpper();
                if (DoneAnswer.Contains("N"))
                {
                    Done = true;
                    break;
                }
            }
            Console.WriteLine("Task completed successfully");
        }
        static void UserInterface()
        {
            Console.WriteLine("Do you want to run Testing Class?");
            string TestAnswer = Console.ReadLine().ToUpper();
            if (TestAnswer.Contains("Y"))
            {
                Testing Test = new Testing();
                Test.main();//This object tests that all sorting and searching classes are workings
            }
            //Declaring Objects
            //FileReader
            FileReader read = new FileReader();

            //Sorters
            BubbleSort Bubble = new BubbleSort();
            InsertionSort Insertion = new InsertionSort();
            MergeSort Merge = new MergeSort();
            QuickSort Quick = new QuickSort();

            //Searchers
            BinarySearch Binary = new BinarySearch();
            SequentialSearch Sequential = new SequentialSearch();

            bool Done = false;

            while (!Done)
            {
                Console.WriteLine("Would you like to Search or Sort?");
                string SearchOrSort = Console.ReadLine().ToUpper();
                if (SearchOrSort.Contains("S"+"E"))
                {
                    //SEARCHING
                    Console.WriteLine("Which file would you like to search?");
                    Console.WriteLine("Share_1_256?");
                    Console.WriteLine("Share_1_2048?");
                    Console.WriteLine("Share_2_256?");
                    Console.WriteLine("Share_2_2048?");
                    Console.WriteLine("Share_3_256?");
                    Console.WriteLine("Share_3_2048?\n");

                    string Choice = Console.ReadLine().ToUpper();
                    if ((Choice.Contains("1")) && (Choice.Contains("256")))
                    {
                        Console.WriteLine("You have chosen Share_1_256");
                        List<int> CurrentList = read.ReadFile("Share_1_256.txt");

                        Console.WriteLine("What search method would you like to use?\n" +
                            "Binary Search \n" +
                            "Sequential Search");
                        string SearchChoice = Console.ReadLine().ToUpper();
                        if (SearchChoice.Contains("BINARY"))
                        {
                            //To do Binary, the number must be sorted so will be sorted with Merge 
                            CurrentList = Merge.Ascending(CurrentList);
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Binary.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Binary.Display(KeyPlacement);
                            }
                        }
                        else if (SearchChoice.Contains("SEQUENT"))
                        {
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Sequential.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Sequential.Display(KeyPlacement);
                            }
                        }
                    }
                    else if ((Choice.Contains("1")) && (Choice.Contains("2048")))
                    {
                        Console.WriteLine("You have chosen Share_1_2048");
                        List<int> CurrentList = read.ReadFile("Share_1_2048.txt");

                        Console.WriteLine("What search method would you like to use?\n" +
                            "Binary Search \n" +
                            "Sequential Search");
                        string SearchChoice = Console.ReadLine().ToUpper();
                        if (SearchChoice.Contains("BINARY"))
                        {
                            //To do Binary, the number must be sorted so will be sorted with Merge 
                            CurrentList = Merge.Ascending(CurrentList);
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Binary.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Binary.Display(KeyPlacement);
                            }
                        }
                        else if (SearchChoice.Contains("SEQUENT"))
                        {
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Sequential.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Sequential.Display(KeyPlacement);
                            }
                        }
                    }
                    else if ((Choice.Contains("2")) && (Choice.Contains("256")))
                    {
                        Console.WriteLine("You have chosen Share_2_256");
                        List<int> CurrentList = read.ReadFile("Share_2_256.txt");

                        Console.WriteLine("What search method would you like to use?\n" +
                            "Binary Search \n" +
                            "Sequential Search");
                        string SearchChoice = Console.ReadLine().ToUpper();
                        if (SearchChoice.Contains("BINARY"))
                        {
                            //To do Binary, the number must be sorted so will be sorted with Merge 
                            CurrentList = Merge.Ascending(CurrentList);
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Binary.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Binary.Display(KeyPlacement);
                            }
                        }
                        else if (SearchChoice.Contains("SEQUENT"))
                        {
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Sequential.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Sequential.Display(KeyPlacement);
                            }
                        }
                    }
                    else if ((Choice.Contains("2")) && (Choice.Contains("2048")))
                    {
                        Console.WriteLine("You have chosen Share_2_2048");
                        List<int> CurrentList = read.ReadFile("Share_2_2048.txt");

                        Console.WriteLine("What search method would you like to use?\n" +
                            "Binary Search \n" +
                            "Sequential Search");
                        string SearchChoice = Console.ReadLine().ToUpper();
                        if (SearchChoice.Contains("BINARY"))
                        {
                            //To do Binary, the number must be sorted so will be sorted with Merge 
                            CurrentList = Merge.Ascending(CurrentList);
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Binary.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Binary.Display(KeyPlacement);
                            }
                        }
                        else if (SearchChoice.Contains("SEQUENT"))
                        {
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Sequential.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Sequential.Display(KeyPlacement);
                            }
                        }
                    }
                    else if ((Choice.Contains("3")) && (Choice.Contains("256")))
                    {
                        Console.WriteLine("You have chosen Share_3_256");
                        List<int> CurrentList = read.ReadFile("Share_3_256.txt");

                        Console.WriteLine("What search method would you like to use?\n" +
                            "Binary Search \n" +
                            "Sequential Search");
                        string SearchChoice = Console.ReadLine().ToUpper();
                        if (SearchChoice.Contains("BINARY"))
                        {
                            //To do Binary, the number must be sorted so will be sorted with Merge 
                            CurrentList = Merge.Ascending(CurrentList);
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Binary.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Binary.Display(KeyPlacement);
                            }
                        }
                        else if (SearchChoice.Contains("SEQUENT"))
                        {
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Sequential.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Sequential.Display(KeyPlacement);
                            }
                        }
                    }
                    else if ((Choice.Contains("3")) && (Choice.Contains("2048")))
                    {
                        Console.WriteLine("You have chosen Share_3_2048");
                        List<int> CurrentList = read.ReadFile("Share_3_2048.txt");


                        Console.WriteLine("What search method would you like to use?\n" +
                            "Binary Search \n" +
                            "Sequential Search");
                        string SearchChoice = Console.ReadLine().ToUpper();
                        if (SearchChoice.Contains("BINARY"))
                        {
                            //To do Binary, the number must be sorted so will be sorted with Merge 
                            CurrentList = Merge.Ascending(CurrentList);
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Binary.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Binary.Display(KeyPlacement);
                            }
                        }
                        else if (SearchChoice.Contains("SEQUENT"))
                        {
                            Console.WriteLine("What number would you like to find?");
                            string strKey = Console.ReadLine();
                            bool Conversion = int.TryParse(strKey, out int Key);
                            if (Conversion == true)
                            {
                                var KeyPlacement = Sequential.SearchKey(CurrentList, 0, CurrentList.Count, Key);
                                Sequential.Display(KeyPlacement);
                            }
                        }
                    }
                }
                else if (SearchOrSort.Contains("S"+"O"))
                {
                    //SORTING
                    Console.WriteLine("Which file would you like to Sort?");
                    Console.WriteLine("Share_1_256?");
                    Console.WriteLine("Share_1_2048?");
                    Console.WriteLine("Share_2_256?");
                    Console.WriteLine("Share_2_2048?");
                    Console.WriteLine("Share_3_256?");
                    Console.WriteLine("Share_3_2048?\n");

                    string Choice = Console.ReadLine().ToUpper();
                    if ((Choice.Contains("Share_3_2048") || ((Choice.Contains("3")) && (Choice.Contains("2048")))))
                    {
                        Console.WriteLine("You have chosen Share_3_2048");
                        List<int> CurrentList = read.ReadFile("Share_3_2048.txt");

                        Console.WriteLine("What sort method would you like to use? \n" +
                            "Bubble Sort \n" +
                            "Insertion Sort \n" +
                            "Merge Sort \n" +
                            "Quick Sort \n" +
                            "Or the most efficient? \n");
                        string SortChoice = Console.ReadLine().ToUpper();
                        Console.WriteLine("Do you want to sort in ascending or descending order?");
                        string OrderChoice = Console.ReadLine().ToUpper();
                        if (SortChoice.Contains("EFFICIENT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }

                        if (SortChoice.Contains("BUBBLE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Bubble.Ascending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Bubble.Descending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("INSERT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Insertion.Ascending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Insertion.Descending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("MERGE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("QUICK"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Quick.Ascending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Quick.Descending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                        }

                    }
                    else if ((Choice.Contains("Share_3_256") || ((Choice.Contains("3")) && (Choice.Contains("256")))))
                    {
                        Console.WriteLine("You have chosen Share_3_256");
                        List<int> CurrentList = read.ReadFile("Share_3_256.txt");

                        Console.WriteLine("What sort method would you like to use? \n" +
                            "Bubble Sort \n" +
                            "Insertion Sort \n" +
                            "Merge Sort \n" +
                            "Quick Sort \n" +
                            "Or the most efficient? \n");
                        string SortChoice = Console.ReadLine().ToUpper();
                        Console.WriteLine("Do you want to sort in ascending or descending order?");
                        string OrderChoice = Console.ReadLine().ToUpper();
                        if (SortChoice.Contains("EFFICIENT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("BUBBLE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Bubble.Ascending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Bubble.Descending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("INSERT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Insertion.Ascending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Insertion.Descending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("MERGE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("QUICK"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Quick.Ascending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Quick.Descending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                        }

                    }
                    else if ((Choice.Contains("Share_1_2048")) || ((Choice.Contains("1")) && (Choice.Contains("2048"))))
                    {
                        Console.WriteLine("You have chosen Share_1_2048");
                        List<int> CurrentList = read.ReadFile("Share_1_2048.txt");

                        Console.WriteLine("What sort method would you like to use? \n" +
                            "Bubble Sort \n" +
                            "Insertion Sort \n" +
                            "Merge Sort \n" +
                            "Quick Sort \n" +
                            "Or the most efficient? \n");
                        string SortChoice = Console.ReadLine().ToUpper();
                        Console.WriteLine("Do you want to sort in ascending or descending order?");
                        string OrderChoice = Console.ReadLine().ToUpper();
                        if (SortChoice.Contains("EFFICIENT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }

                        else if (SortChoice.Contains("BUBBLE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Bubble.Ascending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Bubble.Descending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("INSERT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Insertion.Ascending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Insertion.Descending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("MERGE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("QUICK"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Quick.Ascending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Quick.Descending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                        }

                    }
                    else if ((Choice.Contains("Share 1 256") ||((Choice.Contains("1"))&&(Choice.Contains("256")))))
                    {
                        Console.WriteLine("You have chosen Share_1_256");
                        List<int> CurrentList = read.ReadFile("Share_1_256.txt");

                        Console.WriteLine("What sort method would you like to use? \n" +
                            "Bubble Sort \n" +
                            "Insertion Sort \n" +
                            "Merge Sort \n" +
                            "Quick Sort \n" +
                            "Or the most efficient? \n");
                        string SortChoice = Console.ReadLine().ToUpper();
                        Console.WriteLine("Do you want to sort in ascending or descending order?");
                        string OrderChoice = Console.ReadLine().ToUpper();
                        if (SortChoice.Contains("EFFICIENT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }

                        else if (SortChoice.Contains("BUBBLE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Bubble.Ascending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Bubble.Descending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("INSERT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Insertion.Ascending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Insertion.Descending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("MERGE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("QUICK"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Quick.Ascending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Quick.Descending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                        }

                    }
                    else if ((Choice.Contains("Share_2_256") || ((Choice.Contains("2")) && (Choice.Contains("256")))))
                    {
                        Console.WriteLine("You have chosen Share_2_256");
                        List<int> CurrentList = read.ReadFile("Share_2_256.txt");

                        Console.WriteLine("What sort method would you like to use? \n" +
                            "Bubble Sort \n" +
                            "Insertion Sort \n" +
                            "Merge Sort \n" +
                            "Quick Sort \n" +
                            "Or the most efficient? \n");
                        string SortChoice = Console.ReadLine().ToUpper();
                        Console.WriteLine("Do you want to sort in ascending or descending order?");
                        string OrderChoice = Console.ReadLine().ToUpper();
                        if (SortChoice.Contains("EFFICIENT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }

                        else if (SortChoice.Contains("BUBBLE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Bubble.Ascending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Bubble.Descending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("INSERT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Insertion.Ascending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Insertion.Descending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("MERGE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("QUICK"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Quick.Ascending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Quick.Descending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                        }

                    }
                    else if ((Choice.Contains("Share_2_2048") || ((Choice.Contains("2")) && (Choice.Contains("2048")))))
                    {
                        Console.WriteLine("You have chosen Share_2_2048");
                        List<int> CurrentList = read.ReadFile("Share_2_2048.txt");

                        Console.WriteLine("What sort method would you like to use? \n" +
                            "Bubble Sort \n" +
                            "Insertion Sort \n" +
                            "Merge Sort \n" +
                            "Quick Sort \n" +
                            "Or the most efficient?");
                        string SortChoice = Console.ReadLine().ToUpper();
                        Console.WriteLine("Do you want to sort in ascending or descending order?");
                        string OrderChoice = Console.ReadLine().ToUpper();
                        if (SortChoice.Contains("EFFICIENT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }

                        else if (SortChoice.Contains("BUBBLE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Bubble.Ascending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Bubble.Descending(CurrentList);
                                Bubble.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("INSERT"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Insertion.Ascending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Insertion.Descending(CurrentList);
                                Insertion.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("MERGE"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Merge.Ascending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Merge.Descending(CurrentList);
                                Merge.Display(CurrentList);
                            }
                        }
                        else if (SortChoice.Contains("QUICK"))
                        {
                            if (OrderChoice.Contains("ASC"))
                            {
                                Quick.Ascending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                            else if (OrderChoice.Contains("DESC"))
                            {
                                Quick.Descending(CurrentList);
                                Quick.Display(CurrentList);
                            }
                        }

                    }

                }
                else
                {
                    Console.WriteLine("You have not picked a valid answer");
                }

                //This goes at end so at least one search or sort can be done
                Console.WriteLine("Would you like to continue?");
                string Answer = Console.ReadLine().ToUpper();
                if (Answer.Contains("N"))
                {
                    Done = true;
                    break;
                }
            }
        }
    }
}
