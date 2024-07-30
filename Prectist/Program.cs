
//Finding palindrome name 

//Console.WriteLine("enter name");
//string name = Console.ReadLine();
//string name2 = "";

//for(int i=name.Length-1; i>=0; i--)
//{
//    name2 = name2 + name[i];
//}
//Console.WriteLine(name2);
//if (name2 == name)
//{
//    Console.WriteLine(name + " is palindrome name");
//}


//finding digit and alfabate

//char a = Convert.ToChar(Console.ReadLine());
//if (char.IsDigit(a))
//{
//    Console.WriteLine(a+" is an digit");
//}
//else if (char.IsLetter(a))
//{
//    Console.WriteLine(a + " is an alfabate");
//}


//string a = "12542724524514";
//char b =Convert.ToChar(Console.ReadLine());
//int count = 0;
//foreach (char c in a)
//{
//    if(c == b)
//    {
//    count++; 
//    }
//}
//Console.WriteLine(b+" is come in a "+count + " time");

//int[] a = [25, 26, 24, 84, 62, 42];
//Console.WriteLine(a.Length);


//printing revearce array 

//int[] a =new int[10];

//int[] b = new int[10];

//for(int i = 0; i<10; i++)
//{
//    a[i] = Convert.ToInt32(Console.ReadLine());
//}
//int c = 0;
//for(int j = a.Length - 1; j >= 0; j--)
//{
//    b[c] = a[j];
//    c++;
//}

//Console.WriteLine("revears array is ");
//for(int i = 0; i < b.Length; i++)
//{
//    Console.WriteLine(b[i]);
//}


//finding sum of an array number

//int[] num = new int[10];
//int sum = 0;
//for (int i = 0; i < num.Length; i++)
//{
//    num[i] = Convert.ToInt32(Console.ReadLine());
//}
//for (int i = 0;i < num.Length; i++)
//{
//    sum += num[i];
//}
//Console.WriteLine("total numbers sum is "+sum);




using System;

//public int FinalValueAfterOperations(string[] operations)
{
    int X = 0;
    string[] ope = ["--X", "X++", "X++"];

    foreach (string o in ope)
    {
        X = X + Convert.ToInt32(o);
    }
    Console.WriteLine(X);
}



//    char x =' ';
//    int count = 0;
//    Console.WriteLine("Enter number for word you want to enter");
//    int num = Convert.ToInt32(Console.ReadLine());
//    int[] arr =new int[num];
//    string[] words =new string[num];
//    Console.WriteLine("Enter word");
//for (int i = 0; i < num; i++)
//    {
//        words[i] = Console.ReadLine();
//}

//    Console.WriteLine("Which char you are finding");
//x = Convert.ToChar(Console.ReadLine());

//for (int i = 0; i < words.Length; i++)
//    {
//    bool ismatch = true;
//        foreach(char j in words[i])
//        {
//            if (x == j)
//            {
//                ismatch = false;
//                break;
//            }
//        }
//         if (ismatch==false)
//         {
//             arr[count] = i;
//                count++;
//            }
//    }

//    Console.WriteLine("index value match is");
//    foreach (int c in arr)
//    {
//    Console.WriteLine(c); 
//    }