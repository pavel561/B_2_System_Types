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

			//Проверка true false для переменных
			// Было интересно, позволяет ли язык C# проводить логические операции с переменными как в языках С и С++  (об этом я задавал вопрос на лекции)
			/*
			 * Дело в том, что я имею опыт программирования микропроцессорных систем, код для которых пишется исключительно на C, или в крайнем случае на C++.
			 * Например, компилятор языка C и C++ воспринимает без ошибок конструкции вида:
			 * 
			 * int peremennaya = 1000;
			 * int peremennaya2 = 0;
			 * while(peremennaya)
			 * {
			 *		peremennaya--;
			 * }
			 * 
			 * или
			 * 
			 * if(peremennaya){}
			 * 
			 * или 
			 * 
			 * if(peremennaya && peremennaya2)
			 * 
			 * Компилятор языка C и С++ интерпретирует значение переменной как true для положительных чисел, и как false для нуля (и для отрицательных вроде бы тоже)
			 */

			//if (birthYear) { }				//Ошибка: не удается неявно преобразовать тип int в bool.  Я ответил на свой вопрос =))				

			//1. CHAR CONVERSION 
			//1.1 CHAR to STRING

			//string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
			string charToStringImplicit = sex.ToString();               //Преобразование с использованием встроенного метода
			string charToStringImplicit2 = Convert.ToString(sex);		//Преобразование с использованием метода класса System.Convert

			//string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
			string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

			//1.2 CHAR to BOOL
			//bool char_to_bool = Convert.ToBoolean(sex);                 //InvalidCastException документация говорит что конвертерование Convert.ToBoolean(char) не поддерживается.
			//bool char_to_bool = (bool) sex;								//Не удается преобразовать тип
			bool char_to_bool;
			if (sex == 'M') { char_to_bool = true; }
			else			{ char_to_bool = false; }					//преобразование конкретного символа в bool
			char_to_bool = (sex=='M') ? true : false;                   //Тоже самое используя тернарную запиь

			//1.3 CHAR to DECIMAL
			decimal char_to_decimal = (decimal)place;                   //
			//decimal char_to_decimal2 = Convert.ToDecimal(place);        //InvalidCastException документация говорит что конвертерование Convert.ToBoolean(char) не поддерживается.
			decimal char_to_decimal3 = place;

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
