using System.Text.RegularExpressions;


#region task1
Regex phonePattern = new Regex(@"^(\+)?(38)?0([-\s]?\d{2})([-\s]?\d{3})([-\s]?\d{2}){2}$");
string phoneNumber = Console.ReadLine();
if (phonePattern.IsMatch(phoneNumber))
    Console.WriteLine("Phone number is correct");
else
    Console.WriteLine("Phone number is incorrect");
#endregion

#region task2
Regex emailPattern = new Regex(@"^[a-zA-Z][a-zA-Z0-9.]*@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
string emailText = Console.ReadLine();
if (emailPattern.IsMatch(emailText))
    Console.WriteLine("Email is correct");
else
    Console.WriteLine("Email is incorrect");
#endregion
