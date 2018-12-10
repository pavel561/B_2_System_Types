using System;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            string name = "Olga";
            string hasPhoto = "True";
            string flatNumber = "34";

            char sex = 'М';
            char place = '3';
            char hasFingerPrints = '0';

            bool hasFree2Pages = false;

            double visaPrice = 60;
            double photoPrice = 7.5;

            int birthYear = 2000;

            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING

            //string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

            //1.2 CHAR to BOOL

            //1.3 CHAR to DECIMAL
                    
            //1.4 CHAR to INT
           
            //2. STRING CONVERSION

            //2.1 STRING to CHAR

            //2.2 STRING to BOOL

            //2.3 STRING to DECIMAL
      
            //2.4 STRING to INT
          
            //3. BOOL CONVERSION

            //3.1 BOOL to CHAR
           
            //3.2 BOOL to STRING
           
            //3.3 BOOL to DECIMAL
          
            //3.4 BOOL to INT
          
            //4. DECIMAL CONVERSION

            //4.1 DECIMAL to CHAR
         
            //4.2 DECIMAL to BOOL
          
            //4.3 DECIMAL to STRING
          
            //4.4 DECIMAL to INT
          
            //5. INT CONVERSION         

            //5.1 INT to CHAR
          
            //5.2 INT to BOOL
           
            //5.3 INT to DECIMAL
         
            //5.4 INT to STRING
        }
    }
}
