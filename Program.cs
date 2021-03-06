//author: YASSIR RCHI
using System;
using System.Reflection.PortableExecutable;

namespace practice
{





    class Program
    {
        static void Main(string[] args)
        {
            string stringTobeAnalysed = Console.ReadLine(); //io file later TXT





            int word = 0, integer = 0, real = 0, ponct = 0;

            bool numberFound = false;
            bool numbersAfterPoint = false;
            bool ponctDetected = false;
            bool existingSpace = true;
            bool letterDetected = false;



            foreach (char character in stringTobeAnalysed)

                

            {

              
                if ((character == '0' || character == '1' || character == '2' || character == '3' || character == '4' || character == '5' || character == '6' || character == '7' || character == '8' || character == '9'))
                {




                    numberFound = true;
                    existingSpace = false;





                }
                else if (character == '.' && numberFound == true)
                {




                    real++;
                    numbersAfterPoint = true;
                    





                }
                else if (((character != '.' || character != '0' || character != '1' || character != '2' || character != '3' || character != '4' || character != '5' || character != '6' || character != '7' || character != '8' || character != '9') && numberFound == true))
                {



                    if (numbersAfterPoint == false)
                        integer++;
                    numbersAfterPoint = false;
                    numberFound = false;
                    existingSpace = false;




                }

                else if (character == ' ')
                {
                   if ((numberFound == false && ponctDetected == false && existingSpace==false) || ponctDetected==true && letterDetected==true)
                        word++;
                    numberFound = false;
                    numbersAfterPoint = false;
                    ponctDetected = false;
                    existingSpace = true;
                    letterDetected = false;




                }



                else if ((character == '?' || character == ',' || character == ';' || character == '!' || character == ':') || ((character == '.') && numberFound == false))
                {



                    ponct++;
                    ponctDetected = true;
                    existingSpace = false;
                   




                }



                else
                {
                    existingSpace = false;
                    letterDetected = true;
                    ponctDetected = false;
                }












                

            }
            if (numberFound == true && numbersAfterPoint == false)




                integer++;


    
            if (letterDetected==true || (letterDetected==true && ponctDetected==true))
                word++;
            if (letterDetected == true && existingSpace == true)
                word--;
            
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



            Console.WriteLine("number of real numbers is : " + real);
            for (int i = 0; i < real; i++)
                Console.Write('*');
            Console.WriteLine();





        }
    }
}
