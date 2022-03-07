//Task 1
short myNum1 = 66; 
short myNum2 = 777;  

// 3./4. Verify which variable is the largest + smallest

if (myNum1 < myNum2)
{
    Console.WriteLine($"Number {myNum2} is larger than {myNum1}");
    Console.WriteLine($"Number {myNum1} is smaller than {myNum2}");
}
else
{
    Console.WriteLine($"Number {myNum1} is larger than {myNum2}");
    Console.WriteLine($"Number {myNum2} is smaller than {myNum1}");
}

// 5. Verify if both variables are equals

if (myNum2 == myNum1)
{
    Console.WriteLine("Both numbers are equal");
}
else
{
    Console.WriteLine("Both numbers are not equal");
}

// 6./7.  Verify if there are any variables which are odd + even

if (myNum1 % 2 == 0)

{
    Console.WriteLine($"Number {myNum1} is even");
    }
else if(myNum1 % 2 == 1)
{
    Console.WriteLine($"Number {myNum1} is odd");
}

if (myNum2 % 2 == 0)

{
    Console.WriteLine($"Number {myNum2} is even");
}
else if (myNum2 % 2 == 1)   
{
    Console.WriteLine($"Number {myNum2} is odd");
}

// 8./9. Verify if there are any variables which are negative + positive

if (myNum1 < 0)

{ 
    Console.WriteLine($"Number {myNum1} is negative");
}
else if (myNum1 > 0)
{
    Console.WriteLine($"Number {myNum1} is positive");
}

if (myNum2 < 0)

{
    Console.WriteLine($"Number {myNum2} is negative");
}
else if (myNum2 > 0)
{
    Console.WriteLine($"Number {myNum2} is positive");
}

// 10. Verify if there are any variables which are less than 100

if (myNum1 < 100)
{ 
    Console.WriteLine($"Number {myNum1} is smaller than 100");
}

if (myNum2 < 100)
{
    Console.WriteLine($"Number {myNum2} is smaller than 100");
}

// 11.  Calculate sum of two elements, round to whole numbers and print information in the console.

var sum = myNum1 + myNum2;
Console.WriteLine($"The sum of {myNum1} and {myNum2} is {Math.Round((double)sum, 0)}");  //change declared data type from integer to floating type to execute

// 12. Calculate differences between both numbers, output it as positive number with two numbers after the coma

var differ = myNum1 - myNum2;
var positive = Math.Abs(Math.Round((double)differ, 2));  // change declared data type from integer to floating type to execute

Console.WriteLine($"The difference between {myNum1} and {myNum2} is {positive}");

//TASK 2

var time = 20;
var day = 17;
var month = 6;
var year = -2018;

if (time > 0 && time < 12)
{
    Console.WriteLine("Good morning Sunshine!");
}
if (time >= 13 && time <= 19)
{
    Console.WriteLine("Good afternoon. Work Hard!");
}
if (time >= 20 && time <= 24)
{
    Console.WriteLine("Good evening. Get some rest!");
}
else if (time < 0 || time > 24)
{
    Console.WriteLine("Time input incorrect. Try again!");
}
if ((day >= 1 && day <= 31) && (month >= 1 && month <= 12) && (year >= 1 && year <= 2022))
{
    Console.WriteLine($"{year}/{ month}/{day}");
}

else
{
    Console.WriteLine("Date input wrong. Try again!");
}