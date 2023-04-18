// Array

var array = new int[] { 1, 2, 3};

Array.Sort(str);     // Array sort
Array.Clear(str);    // Clears the content of array
Array.Reverse(str);  // Reverse the array

var max = array.Max();

var min = array.Min();

var binary = Convert.ToString(11, 2); // Int to binary


// Stack

var stack = new Stack<char>();
stack.Push();
stack.Pop();
stack.Count;


// List

var list = new List<int>{1, 2, 3};


// Dictionary

var dic = new Dictionary<int, int>();

var dict = new Dictionary<char, char>
{
    [')'] = '(',
    [']'] = '[',
    ['}'] = '{'
};

dict.ContainsKey(')')
    
dict.Values.Max();

dict.Keys
  

// Set

var hashSet = new HashSet<int>();
hashSet.Contains();


// Math

Math.Sqrt(16); // 4 // Retuens double

Math.Pow(3, 2) // 9 // Returns double

Math.Max(firstVal, secondVal); // Returns max value

Console.WriteLine(4 % 2); // 0
Console.WriteLine(0 % 2); // 0
Console.WriteLine(1 % 2); // 1

Console.WriteLine(4 / 2); // 2
Console.WriteLine(0 / 2); // 0
Console.WriteLine(1 / 2); // 0.5 -> 0


// Reverse String
char[] stringArray = r.ToCharArray();
Array.Reverse(stringArray);
string reverseString = new string(stringArray);


// Console

var input = Console.ReadLine();

Console.WriteLine("Radius: {0}, Area: {1}", 0, 1);
