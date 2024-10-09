using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Transactions;

int[] fib = new int[] { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };

for (int i = 0; i<10; i++) {

    Console.WriteLine(fib[i]);

}

Console.WriteLine("----------------------------");

for (int i = 2; i<22; i+=2) {

    Console.WriteLine(i);

}

Console.WriteLine("----------------------------");

for (int i = 1; i<6; i++) {

    for (int j = 1; j<6; j++) { 
        
        Console.Write(i*j + " ");

    }

    Console.WriteLine("");

}

Console.WriteLine("----------------------------");

string password = "qwerty";
string enter = "";

while (enter!=password) {
    enter = Console.ReadLine();

    if (enter!=password) {
        Console.WriteLine("Wrong password. Try again");
    }
}

Console.WriteLine("Correct password");