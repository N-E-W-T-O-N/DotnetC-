﻿namespace FirstClass
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Intro()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}