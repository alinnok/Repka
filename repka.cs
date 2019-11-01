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
           grandfather.name="Дедка";
           
           Grandmother grandmother = new Grandmother();
           grandmother.name = "Бабка";
         
           Granddauther granddauther = new Granddauther();
            granddauther.name = "Внучка";
           
           Dog dog = new Dog();
           dog.name = "Жучка";
                      
           Cat cat = new Cat();
           cat.name = "Кошка";
           
           Mouse mouse = new Mouse();
           mouse.name = "Мышка";
           
           List<string>Heroes = new List<string>();
            List<string>Line=new List<string>();
            if (grandfather.CanTurn)   
            {    
                Dobavim(grandfather.name);
                Dobavim(grandmother.name);
                Dobavim(granddauther.name);
                Dobavim(dog.name);
                Dobavim(cat.name);
                Dobavim(mouse.name);
            }
            else {
                Console.WriteLine("Герои сегодня не могут тянуть репку, попробуйте завтра");
                return;}

        
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
                    else {Console.WriteLine("Не может быть 2 одинаковых героя");}
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



            
            
            
    



