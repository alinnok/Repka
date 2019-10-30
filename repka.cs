using System;
//using System.LINQ;
using System.Collections.Generic;
using Persons;

namespace repka
{
    public class Program
    {
        static void Main(string[] args)
        {
           //bool Turnip=false;
           Grandfather grandfather = new Grandfather();
           grandfather.CanTurn = true;
           grandfather.name = "Дедка";
           Grandmother grandmother = new Grandmother();
           grandmother.name = "Бабка";
           grandmother.CanTurn = true;
           Granddauther granddauther = new Granddauther();
           granddauther.name = "Внучка";
           granddauther.CanTurn = true;
           Dog dog = new Dog();
           dog.name = "Жучка";
           dog.CanTurn = true;
           
           Cat cat = new Cat();
           cat.name = "Кошка";
           cat.CanTurn = true;
           Mouse mouse = new Mouse();
           mouse.name = "Мышка";
           mouse.CanTurn = true;
           List<string>Heroes = new List<string>();
            List<string>Line=new List<string>();
           Dobavim(grandfather.name);
           Dobavim(grandmother.name);
           Dobavim(granddauther.name);
           Dobavim(dog.name);
           Dobavim(cat.name);
           Dobavim(mouse.name);
           int count= Heroes.Count;
           int i=0;
           foreach (string hero in Heroes)
           {
               if (i<count-1)
               {    if (Heroes[i]!=Heroes[i+1])
                    {
                       Line.Add(Heroes[i]);
                       foreach (string l in Line)
                       {
                           Console.WriteLine(l);
                       }
                       Console.WriteLine("тянут, потянут, вытянуть не могут"  );
                       i++;
                    }
               }
               else {
                   Line.Add(Heroes[i]);
                  
                   foreach (string l in Line)
                       {
                           Console.WriteLine(l);
                       } 
                    Console.WriteLine("вытянули репку!");
                   //Turnip=true;
               }
               
           }

           void Dobavim(string name)
           {
                 
                   Heroes.Add(name);
                                     
               }
           } 
    }
}



            
            
            
    



