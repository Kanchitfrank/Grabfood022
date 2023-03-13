using System;

namespace GrabFood
{
    class Program
    {
        static void Main(string[] args){
            Console.Write("Day :");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Time :");
            int time = int.Parse(Console.ReadLine());
            int breakfast = 5;
            int weekend = 2;
            int coffee = 3;
            bool close =true;
            if(day == 6|| day == 7){
                while (close)
                {   Console.Write("Menu :");
                    string menu = Console.ReadLine();
                    switch(menu){
        case"Breakfast Set":
            if(time > 10){
                Console.WriteLine("Sorry your order is not available");
            }else if(breakfast<=0){
                Console.WriteLine("Sorry your order is out of stock");
            }else{
                Console.Write("");
                breakfast--;
            }
          break;
        case"Weekend Set":
            if(weekend <=0){
               Console.WriteLine("Sorry your order is out of stock");
            }else{
                Console.Write("");
                weekend--;
            }
          break;
        case"Coffee":
        if(coffee <=0){
            Console.WriteLine("Sorry your order is out of stock");
        }else{
            Console.Write("");
            coffee--;
        }
          break;
        case"End":
            close = false;
          break;  
        default:
            Console.WriteLine("Please enter a valid menu");
          break;
      }
                }
                
            }



        else if(day == 1||day == 2||day == 3||day == 4||day == 5){
            while (close)
                {   Console.Write("Menu :");
                    string menu = Console.ReadLine();
                    switch(menu){
        case"Breakfast Set":
            if(time > 10){
                Console.WriteLine("Sorry your order is not available");
            }else if(breakfast<=0){
                Console.WriteLine("Sorry your order is out of stock");
            }else{
                Console.Write("");
                breakfast--;
            }
          break;
        case"Weekend Set":
            Console.WriteLine("Sorry your order is not available");
          break;
        case"Coffee":
        if(coffee <=0){
            Console.WriteLine("Sorry your order is out of stock");
        }else{
            Console.Write("");
            coffee--;
        }
          break;
        case"End":
            close = false;
          break;  
        default:
            Console.WriteLine("Please enter a valid menu");
          break;
      }
                
        }



        }
    }
}
}