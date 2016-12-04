using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
     public class Cat
     {
          public string Name;
          public int Age;

          private int Happiness;

          //생성자
          public Cat(string name, int age)
          {
               this.Name = name;
               this.Age = age;

               this.Happiness = 50;

          }

          public void Play()
          {
               Happiness += 10;

               if (Happiness > 100)
                    Happiness = 100;
          }

          public void Eat()
          {
               Happiness += 15;

               if (Happiness > 100)
                    Happiness = 100;
          }

          public string Express()
          {
               string message = "";

               if (Happiness >= 90)
                    message = "Excellent!!";
               else if (Happiness >= 80)
                    message = "I am very happy!";
               else if (Happiness >= 60)
                    message = "I am happy.";
               else if (Happiness >= 50)
                    message = "So so..";
               else if (Happiness >= 30)
                    message = "little bit sad...";
               else
                    message = "SAAAADDDD...";

               return this.Name + ":" + message;

          }


          public void GetBored()
          {
               Happiness -= 10;

               if (Happiness < 0)
                    Happiness = 0;
          }

     }
}
