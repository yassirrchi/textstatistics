using System;

namespace practice
{


        
    class Program
    {
        static void Main(string[] args)
        {
            string stringTobeAnalysed = Console.ReadLine();
     

            
            int word=0, integer=0, real=0, ponct=0;
            
            bool numberFound = false;
            bool numbersAfterPoint=false;
            bool ponctDetected = false;

            foreach (char character in stringTobeAnalysed)

            {//im 19.5
                if ((character == '0' || character == '1' || character == '2' || character == '3' || character == '4' || character == '5' || character == '6' || character == '7' || character == '8' || character == '9'))
                {


                    numberFound = true;
                   



                }
                else if (character == '.' && numberFound == true)
                {


                    real++;
                    numbersAfterPoint = true;



                }
                else if (((character != '.' || character != '0' || character != '1' || character != '2' || character != '3' || character != '4' || character != '5' || character != '6' || character != '7' || character != '8' || character != '9') && numberFound == true))
                {

                      if(numbersAfterPoint==false)
                        integer++;
                    numbersAfterPoint = false;
                    numberFound = false;



                }
                
                else if (character == ' ')
                {  if(numberFound==false && ponctDetected==false)
                    word++;
             
                    numberFound = false;
                    numbersAfterPoint = false;
                    ponctDetected = false;

                }

                else if( (character == '?' || character == ',' || character == ';' || character == '!' || character == ':' )|| ((character == '.')&&numberFound==false))
                {

                    ponct++;
                    ponctDetected = true;


                }
                

                


                

                else {
                    continue;
                }
               


                






            }
            if (numberFound==true && numbersAfterPoint==false) 

                
                    integer++;
            
            
            if (word > 0)
                word++;
            Console.WriteLine("number of words is " + word);
            for (int i = 0; i < word; i++)
                Console.Write('*');
            Console.WriteLine();

            Console.WriteLine("number of ponct is " + ponct);
            for (int i = 0; i < ponct; i++)
                Console.Write('*');
            Console.WriteLine();

            Console.WriteLine("number of integers is : " + integer);
            for (int i = 0; i < integer; i++)
                Console.Write('*');
            Console.WriteLine();

            Console.WriteLine ( "number of real numbers is : "+real);
            for (int i = 0; i < real; i++)
                Console.Write('*');
            Console.WriteLine();



        }
    }
}
