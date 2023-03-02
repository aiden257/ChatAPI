
using System;

internal class ChatAPI
{
    public static string name;
    public static string answer;
    public static string computersname;
    public static string answer2;
    public static string result;
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello! Welcome to the chat api! What is your name?");
        name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}! Do you want to name me?");
        answer = Console.ReadLine();
        if(answer == "Yes" || answer == "yes")
        {
            Console.WriteLine($"Okay! What is my name, {name}");
            computersname = Console.ReadLine();
            Console.WriteLine($"My name is {computersname}! That is a good name for me, {name}!");
        }
        else
        {
            Console.WriteLine("Okay, I won't have a name");
        }
        Console.WriteLine($"How can I help you, {name}?");
        answer2 = Console.ReadLine();
        Question(answer2);
    }
    private static void Question(string answer)
    {
        if(answer == "Lets play ISpy")
        {
            Console.WriteLine("Okay! I spy with my robotic eye ... Something red.");
            string answer100 = "An apple";
            string guess = Console.ReadLine();
            if(guess == "An apple" || guess == "an apple")
            {
                Console.WriteLine("Correct!");
            }
            else 
            {
                Console.WriteLine($"Nice try, {name}. It's an apple!");
            }
            Console.WriteLine("Now it is your turn!");
            string humanrequest = Console.ReadLine();
            if(humanrequest == "I spy with my little eye something red")
            {
                Console.WriteLine("Is it an apple?");
                result = Console.ReadLine();
            }
            if(result == "An apple" && humanrequest == "I spy with my little eye something red")
            {
                Console.WriteLine("Yay! I won!");
            }
            else
            {
                Console.WriteLine("Okay, I give up. What is the color?");
                string color = Console.ReadLine();
                Console.WriteLine("Now, what is the object?");
                string gameobject = Console.ReadLine();
                Console.WriteLine($"Oh, the {gameobject} is(or) {color}!");
            }
        }
    }
