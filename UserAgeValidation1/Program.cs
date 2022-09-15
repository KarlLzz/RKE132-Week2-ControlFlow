// See https://aka.ms/new-console-template for more information

//rakendus küsib kasutajal sisetada vanus
//kui kasutaja vanus on väiksem kui 13 siis konsoolis kuvatakse
//"you are too young to use Instagram"
//muul juhul
//konsoolis kuvatakse "Welcome to Instagram"
using System;

Console.WriteLine("Enter your age: ");

int userAge = Int32.Parse(Console.ReadLine());//"13" - heap, 13 - stack

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram!");
}
else
{
    Console.WriteLine("You are too young to use Instagram.");
}
 


