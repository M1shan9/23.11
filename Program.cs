using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _23._11
{
    internal class Program
    {
  /// <summary>
  /// Программа для сравнения строк 
  /// </summary>
  /// <param name="args"></param>
        static void Main(string[] args)
        {
   
   Console.WriteLine("Exercise one (Compare())");
   string a, b;
   Console.WriteLine("enter the first word:");
   a = Convert.ToString(Console.ReadLine());
   Console.WriteLine("enter the second word:");
   b = Convert.ToString(Console.ReadLine());
   string s1 = a;
   string s2 = b;

   int result = string.Compare(s1, s2);
   if (result < 0)
   {
    Console.WriteLine("string s1 before string s2");
   }
   else if (result > 0)
   {
    Console.WriteLine("string s1 stand behind string s2");
   }
   else
   {
    Console.WriteLine("strings s1 and s2 identical");
   }
   


   Console.WriteLine("");
   Console.WriteLine("");
   Console.WriteLine("");
   /// <summary>
   /// совпадают ли заданные строки или нет.
   /// </summary>
   /// <param name="args"></param>
   Console.WriteLine("Exercise two (Equals())");
   string myString1 = "GeeksforGeeks";
   string myString2 = "Geeks";
   string myString3 = "GeeksforGeeks";

   if (String.Equals(myString1, myString2))
    Console.WriteLine($"{myString1} and {myString2} are same.");

   else
    Console.WriteLine($"{myString1} and {myString2} are different.");

   if (String.Equals(myString1, myString3))
    Console.WriteLine($"{myString1} and {myString3} are same.");

   else
    Console.WriteLine($"{myString1} and {myString3} are different.");

   if (String.Equals(myString2, myString3))
    Console.WriteLine($"{myString2} and {myString3} are same.");

   else
    Console.WriteLine($"{myString2} and {myString3} are different.");


   

   Console.WriteLine("");
   Console.WriteLine("");
   Console.WriteLine("");

   /// <summary>
   /// Программа для сравнения строк 
   /// </summary>
   /// <param name="args"></param>
   Console.WriteLine("Exercise three (CompareOrdinal())");
   string x, y, z;
   Console.WriteLine("enter the first word:");
   x = Convert.ToString(Console.ReadLine());
   Console.WriteLine("enter the second word:");
   y = Convert.ToString(Console.ReadLine());
   Console.WriteLine("enter the third word:");
   z = Convert.ToString(Console.ReadLine());
   string s10 = x;
   string s20 = y;
   string s30 = s20;
   string s40 = z;
   string s50 = s40;
   Console.WriteLine("String1 = " + s10);
   Console.WriteLine("String2 = " + s20);
   Console.WriteLine("String3 = " + s30);
   Console.WriteLine("String4 = " + s40);
   Console.WriteLine("String5 = " + s50);
   Console.WriteLine("");
   Console.WriteLine("Is s1 and s2 equal? = " + s10.Equals(s20));
   Console.WriteLine("Is s2 and s3 equal? = " + s20.Equals(s30));
   Console.WriteLine("Is s3 and s4 equal? = " + s30.Equals(s40));
   Console.WriteLine("Is s4 and s5 equal? = " + s40.Equals(s50));
   Console.WriteLine("");
   Console.WriteLine(string.CompareOrdinal(s10, s20));
   Console.WriteLine(string.CompareOrdinal(s20, s30));
   Console.WriteLine(string.CompareOrdinal(s30, s40));
   Console.WriteLine(string.CompareOrdinal(s40, s50));
  

   Console.WriteLine("");
   Console.WriteLine("");
   Console.WriteLine("");


   /// <summary>
   /// Определяет индекс первого вхождения символа в строке.
   /// </summary>
   /// <param name="args"></param>
   Console.WriteLine("Exercise four (IndexOf())");
   string s6 = "It's a beautiful day";
   char ch = 'a';
   int indexOfChar = s6.IndexOf(ch);
   Console.WriteLine("index of the first character: ");
   Console.WriteLine(indexOfChar);

   string substring = "be";
   int indexOfSubstring = s6.IndexOf(substring);
   Console.WriteLine("index of the second character: ");
   Console.WriteLine(indexOfSubstring);

   
  

   Console.WriteLine("");
   Console.WriteLine("");
   Console.WriteLine("");

   /// <summary>
   /// Определяет присутствует ли указанная строка в строке или нет.
   /// </summary>
   /// <param name="args"></param>
   Console.WriteLine("Exercise five (Contains())");
   string str = "I love ice cream";

   bool check;

   // check if str contains "ice cream"
   check = str.Contains("ice cream");
   Console.WriteLine("contains ice cream: " + check);

   // check if str contains "chocolate"
   check = str.Contains("chocolate");
   Console.WriteLine("contains chocolate: " + check);

   // returns true
   check = str.Contains("");
   Console.WriteLine("contains \"\": " + check);

   Console.WriteLine("");
   Console.WriteLine("");
   Console.WriteLine("");

   /// <summary>
   /// Программа порядкового сравнения 
   /// </summary>
   /// <param name="args"></param>

   
   Console.WriteLine("Exercise six (==)");
   string s01 = "hello!";
   string s02 = "HeLLo!";
   Console.WriteLine(s01 == s02.ToLower());  

   string s03 = "Hello!";
   Console.WriteLine(s01 == s03);  
   
  


   Console.WriteLine("");
   Console.WriteLine("");
   Console.WriteLine("");

   /// <summary>
   /// Программа порядкового сравнения 
   /// </summary>
   /// <param name="args"></param>


   Console.WriteLine("Exercise seven (!=)");

   int k = 1 + 1 + 2 + 3;
   int l = 6;
   Console.WriteLine(k != l); 

   string s11 = "Hello";
   string s22 = "Hello";
   Console.WriteLine(s11 != s22);  

   object o1 = 1;
   object o2 = 1;
   Console.WriteLine(o1 != o2); 
   Console.ReadLine();
  }
 }
}
