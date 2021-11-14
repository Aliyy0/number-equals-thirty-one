using System;

namespace c_
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,total,total2;
            Console.ForegroundColor=ConsoleColor.White;
            Console.Write("Please enter number = ");
           
            number=Convert.ToInt32(Console.ReadLine());
           if(number>31){
               total=number - 31;  
               if(number>total){
                   Console.ForegroundColor=ConsoleColor.Cyan;
                   total2=number-total;
                   Console.WriteLine(number+"-"+"31"+"="+total);
                   Console.WriteLine(number+"-"+total+"="+total2);   
               }    
           }
           else{
               Console.ForegroundColor=ConsoleColor.Magenta;
               total=number+ 31;
               total2=total-number;
               Console.WriteLine(number+"+"+31+"="+total);
               Console.WriteLine(total+"-"+number+"="+total2);
           }           
        }
    }
}
