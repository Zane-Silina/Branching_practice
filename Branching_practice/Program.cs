short myNum1 = 66;
short myNum2 = 777;

if (myNum1 < myNum2)
{
    Console.WriteLine("Number " + myNum2 + " is larger than " + myNum1);

    Console.WriteLine("Number " + myNum1 + " is smaller than " + myNum2);
}

if (myNum2 == myNum1)

{
    Console.WriteLine("Both numbers are equal");

}
else
{
    Console.WriteLine("Both numbers are not equal");
}

if (myNum1 % 2 == 0)

{
    Console.WriteLine("Number " + myNum1 + " is even");
    }
    if (myNum2 % 2 == 1)
    {
        Console.WriteLine("The number " + myNum2 + " is odd");
    }

    if ((myNum1 < 0) && (myNum2 < 0))
{
    Console.WriteLine("Both numbers are negative");
        }
else
{ Console.WriteLine("Both numbers are positive");
    Console.WriteLine("There are no negative numbers");
}
   if (myNum1 < 100)
{ Console.WriteLine("Number " + myNum1 + " is smaller than 100");
}
var sum = myNum1 + myNum2;
Console.WriteLine(sum);

var differ = myNum1 - myNum2;
var positive = Math.Abs(differ);

Console.WriteLine(positive);