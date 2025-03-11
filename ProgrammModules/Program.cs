
//static int t1(string str) { 

//     return str.Split(" ").Length;

//}

//static void t2(string str)
//{
//    string[] a = str.Split(" ");
//    string otvet = "";

//    foreach (var item in a)
//    {
//        otvet += item.Reverse() + " ";
//    }
//    Console.WriteLine(otvet);
//}

//static bool include(char c, char[] a) {

//    foreach (var item in a)
//    {
//        if (item == c) return true;
//    }
//    return false;

//}

//static int t3(string str)
//{
//    char[] vowels = new char[] { 'a', 'e', 'y', 'u', 'o', 'i' };
//    int counter = 0;

//    for (int i = 0; i < str.Length; i++) {

//        int z = include(str[i], vowels) ? counter++ : 1;

//    }

//    return counter;
//}

//static int t4(string str, string subStr)
//{
//    int i = 0;
//    int counter = 0;
//    while (i < str.Length) {

//        var z = str.IndexOf(subStr, i);

//        z != -1 ? 


//    }

//}

using ProgrammModules;

internal partial class Program
{
    private static void Main(string[] args)
    {
        var z = new Morze();

        Console.WriteLine( z.encripter("sos"));
        

    }
}