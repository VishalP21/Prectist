
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



//char x = ' ';
//Console.WriteLine("Enter number for word you want to enter");
//int num = Convert.ToInt32(Console.ReadLine());
//List<int> Li = new List<int>();
//string[] words = new string[num];
//Console.WriteLine("Enter word");
//for (int i = 0; i < num; i++)
//{
//    words[i] = Console.ReadLine();
//}

//Console.WriteLine("Which char you are finding");
//x = Convert.ToChar(Console.ReadLine());

//for (int i = 0; i < words.Length; i++)
//{
//    bool ismatch = true;
//    foreach (char j in words[i])
//    {
//        if (x == j)
//        {
//            ismatch = false;
//            break;
//        }
//    }
//    if (ismatch == false)
//    {
//        Li.Add(i);
//    }
//}

//Console.WriteLine("index value match is");
//foreach (int c in Li)
//{
//    Console.WriteLine(c);
//}


/*public class Solution {
    public int CountSeniors(string[] details) {
       int count = 0;
foreach(string v in details)
{
    for(int i = 0; i<v.Length; i++)
    {
        if(v[i] >= 'A' && v[i]<='Z')
        {
            if ((v[i + 1]) >= 54 )
            {
                if ((v[i + 2]) > 48 || (v[i+2]==48 && (v[i + 1]) > 54))
                {
                    count++;
                }
            }
             
            }
        }
    }

return count;
    }
}*/


//string[] details = ["5612624052M0130", "5378802576M6424", "5447619845F0171", "2941701174O9078"];
//int count = 0;
//foreach(string v in details)
//{
//    for(int i = 0; i<v.Length; i++)
//    {
//        if(v[i] >= 'A' && v[i]<='Z')
//        {
//            if ((v[i + 1]) > 54 )
//            {
//            count++; 
//            }
//            if((v[i + 1]) == 54)
//            {
//                if((v[i + 2]) > 48)
//                {
//                    count++;
//                }
//            }
//        }
//    }
//}
//return count;


//Console.WriteLine(count);


//string[] operations = ["X++", "++X", "--X", "X--"];
//int X = 0;
//foreach(string operation in operations)
//{
//   if(operation=="X++" || operation == "++X")
//    {
//        X++;
//    }
//    else
//    {
//        X--;
//    }
//}
//return X;

//int count = 0;
//string[] words = ["|||"];
//string separator = ".";

//foreach (string word in words)
//{
//    if(word.StartsWith('$'))
//    {
//        sam = word + ".";
//        for (int i = 0; i < sam.Length; i++)
//        {
//            if (sam[i] == '$')
//            {
//                ramu += sam[i];
//            }
//            else if (sam[i] >= 'a' && sam[i] <= 'z')
//            {

//                text += sam[i];
//            }
//            else
//            {
//                li.Add(text);
//                text = "";
//            }

//        }

//    }
//    else if (word.StartsWith('|'))
//    {
//        for (int i = 0; i < sam.Length; i++)
//        {
//            if (sam[i] == '|')
//            {
//                ramu += sam[i];
//            }
//            else if (sam[i] >= 'a' && sam[i] <= 'z')
//            {
//                text += sam[i];
//            }
//            else
//            {
//                li.Add(text);
//                text = "";
//            }

//        }
//    }
//    else
//    {
//        sam = word + ".";
//        for (int i = 0; i < sam.Length; i++)
//        {

//            if (sam[i] >= 'a' && sam[i] <= 'z')
//            {
//                text += sam[i];
//            }
//            else
//            {
//                li.Add(text);
//                text = "";
//            }
//        }
//    }

//}
//return li;



//string text = "";
//string sam = "";
//string ramu = "";
//List<string> li = new List<string>();
//foreach (string word in words)
//{
//    sam = word + ".";
//for (int i = 0; i < sam.Length; i++)
//{

//    if (sam[i] >= 'a' && sam[i] <= 'z')
//    {
//        text += sam[i];
//    }
//    else if (sam[i] == '.')
//    {
//        li.Add(text);
//        text = "";
//    }
//        else
//        {
//            ramu += sam[i];
//        }
//}
//}
//li.RemoveAll(string.IsNullOrWhiteSpace);
//return li;


//foreach (string word in li)
//{
//    Console.WriteLine(word);
//}



//public class Solution
//{
//    public IList<string> SplitWordsBySeparator(IList<string> words, char separator)
//    {
//        List<string> result = new();

//        foreach (string word in words)
//        {
//            result.AddRange(word.Split(separator, StringSplitOptions.RemoveEmptyEntries));
//        }

//        return result;
//    }
//}


//int[] nums = [2, 7, 11, 15, 1,8];
//int target= 9;
//List<int> result = new List<int>();

//for(int i=0;i<nums.Length;i++)
//{
//    for(int j = i + 1; j < nums.Length; j++)
//    {
//        if(nums[i] + nums[j] == target)
//        {
//            result.Add(i);
//            result.Add(j);
//        }
//    }
//}
//return result;

//foreach(int i in result)
//{
//    Console.WriteLine(i);
//}







//string[] words = ["Hello", "Alaska", "Dad", "Peace"];
//string m = "";
//string sum = "";
//int count = 0;
//List<string> and = new List<string>();
////string[] ans = [];

//string first = "qwertyuiop";
//string second = "asdfghjkl";
//string theard = "zxcvbnm";

//foreach (var w in words)
//{
//    sum = "";
//    m = w.ToLower();
//    foreach (char i in m)
//    {
//        foreach (char j in first)
//        {
//            if (j == i)
//            {
//                sum = sum + j;
//                break;
//            }
//        }
//    }
//    if (sum == m)
//    {
//        count++;
//        and.Add(w);
//    }
//    sum = "";
//    foreach (char i in m)
//    {
//        foreach (char j in second)
//        {
//            if (j == i)
//            {
//                sum = sum + j;
//                break;
//            }
//        }
//    }
//    if (sum == m)
//    {
//        count++;
//        and.Add(w);
//    }
//    sum = "";
//    foreach (char i in m)
//    {
//        foreach (char j in theard)
//        {
//            if (j == i)
//            {
//                sum = sum + j;
//                break;
//            }
//        }
//    }
//    if (sum == m)
//    {
//        count++;
//        and.Add(w);
//    }
//}
//var ans = and.ToArray();

//return ans;


//string allowed = "cad";
//string[] words = ["cc", "acd", "b", "ba", "bac", "bad", "ac", "d"];
//List<char> allowedChars = new List<char>();
//string m = "";
//string g = "";
//int count = 0;

//foreach (char allo in allowed)
//{
//    allowedChars.Add(allo);
//}
//    foreach (string c in words)
//    {
//        m=m+c;
        
//      foreach (char aql in allowedChars)
//      {
//        foreach (char c2 in m)
//        {
//            if(c2 == aql)
//            {
//                g+=aql;
//            }
//            }
//      }
//      if(g.Length == m.Length)
//    {
//      Console.WriteLine(g);
//        count++;
//    }
//    g = "";
//    m = "";
//    }
//Console.WriteLine(count);



    //Leetcode Qustion no 1684

//string allowed = "cad";
//string[] words = ["cc", "acd", "b", "ba", "bac", "bad", "ac", "d"];
//List<char> allowedChars = new List<char>();
//string m = "";
//string g = "";
//int count = 0;

//foreach (char allo in allowed)
//{
//    allowedChars.Add(allo);
//}
//foreach (string c in words)
//{
//    m = m + c;

//    foreach (char aql in allowedChars)
//    {
//        foreach (char c2 in m)
//        {
//            if (c2 == aql)
//            {
//                g += aql;
//            }
//        }
//    }
//    if (g.Length == m.Length)
//    {
//        count++;
//    }
//    g = "";
//    m = "";
//}
//return count;

