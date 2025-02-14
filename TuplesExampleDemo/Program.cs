﻿// See https://aka.ms/new-console-template for more information

// -------------------------------------------------------------- Intro to Tuples in C# -----------------------------------------------------------------------------------------

#region Tumples Intro 1
//var validateAddressResult = ValidateAddress("123 sesame st");

//if (validateAddressResult)
//{
//    Console.WriteLine("Your validated address is{}");
//}
//else
//{
//    Console.WriteLine("That is an invalid address");
//}


//bool ValidateAddress(string address)
//{
//    if (address.Equals("123 sesame st"))
//    {
//        return true;oMVC\NewRepo
//    }
//    else
//    {
//        return false;
//    }
//}
#endregion



#region Tumples Intro 2 
var validateAddressResult = ValidateAddress("123 sesame st");

// We can use tuple structures by assigning independent variables as shown below.
// This is called a Deconstructor structure, and it acts as a separator that splits our tuples into separate parts.
(string message, bool valid) = ValidateAddress("123 sesame st");


// We can use any of the tuple values by assigning the relevant parameter to a variable and utilizing the data. In the example below, we only use the validMessage variable.
(string validMessage, _) = ValidateAddress("123 sesame st");


if (validateAddressResult.isValid)
{
    Console.WriteLine($"Your validated address is {validateAddressResult.address}");
}
else
{
    Console.WriteLine("That is an invalid address");
}


(string address, bool isValid) ValidateAddress(string address)
{
    if (address.Equals("123 sesame st"))
    {
        return ("123 sesame st", true);
    }
    else
    {
        return (address, false);
    }
}

#endregion


#region Tumples Intro 3


// We can create a tuple list and use it inside a loop.
var students = new List<(string Name, int Age, double Grade)>
{
    ("Alex",18,3.2),
    ("Ortega",21,2.2),
    ("Carlos",30,3.8),
    ("Lugano",27,3.9),

};


foreach (var student in students)
{
    Console.WriteLine($"Name: {student.Name} Age: {student.Age} Grade:{student.Grade}");
}

#endregion
