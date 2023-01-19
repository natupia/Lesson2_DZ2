// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int InputInt(string message) 
{
    Console.Write(message + " > ");                   
    string inputValue = Console.ReadLine();           
    int result = Convert.ToInt32(inputValue);         
    return result;                                    
}
bool ValidateNumberRank3(int number)
{
    if (number > 99)                 
    {
        return true;
    }
    System.Console.WriteLine("третьей цифры нет");  
    return false;
}

int number = InputInt ("Введите число");   
if (ValidateNumberRank3(number))
{
    string str = number.ToString();
    Console.WriteLine($"Третья цифра числа {number} равна {str[2]}");
}
