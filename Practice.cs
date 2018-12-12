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
			//decimal char_to_decimal2 = Convert.ToDecimal(place);      //InvalidCastException документация говорит что конвертерование Convert.ToBoolean(char) не поддерживается.
			decimal char_to_decimal3 = place;

			//1.4 CHAR to INT
			int char_to_int = (int)sex;							// Оказывается выше пол введен символом кириллицы =))
			int char_to_int2 = Convert.ToInt32(sex);
			int char_to_int3 = (int)place;
			int char_to_int4 = place;
			int char_to_int5 = Convert.ToInt32(place);
			//int char_to_int6 = Convert.ToInt32(sex);
			//int char_to_int7 = Int32.Parse(sex);			//Отсутствует необходимый перегруженный метод  =(

			//2. STRING CONVERSION
			//2.1 STRING to CHAR
			//char string_to_char = Convert.ToChar(hasPhoto);					//Исключение.Длина строки должна составлять один символ.
			string string_one_sym = "M";
			char string_to_char = Convert.ToChar(string_one_sym);				//результат 'T'
			char string_to_char2 = hasPhoto.ToCharArray()[0];					//результат 'T'
			char string_to_char3 = Convert.ToChar(hasPhoto.Substring(0, 1));    //результат 'T'
			char string_to_char4 = Char.Parse(hasPhoto);
			char string_to_char5 = Char.Parse(string_one_sym);

			//2.2 STRING to BOOL
			bool str_to_bool = Convert.ToBoolean(hasPhoto);
			bool str_to_bool2 = ((hasPhoto == "True") || (hasPhoto == "true")) ? true : false;
			bool str_to_bool3 = Boolean.Parse(hasPhoto);

			//2.3 STRING to DECIMAL
			decimal str_to_decimal = Decimal.Parse(hasPhoto);
			decimal str_to_decimal2 = Convert.ToDecimal(hasPhoto);
			decimal str_to_decimal3 = Decimal.Parse(flatNumber);
			decimal str_to_decimal4 = Convert.ToDecimal(flatNumber);
			//decimal str_to_decimal5 = (decimal)flatNumber;	

			//2.4 STRING to INT
			int str_to_int = Int32.Parse(flatNumber);
			int str_to_int2 = Convert.ToInt32(flatNumber);
			// Можно  в цикле через Substring или ToCharArray вытягивать каждый символ из строки и умножая каждый на нужную степень, прибавлять к decimal переменной
			decimal str_to_decimal6 = 0;
			//for (int i = 0; i < decimal_str.Length; i++)
			//{
			//str_to_d
			//}


			//3. BOOL CONVERSION

			//3.1 BOOL to CHAR
			char bool_to_char = Convert.ToChar(hasFree2Pages);          //Исключение
			char bool_to_char2 = hasFree2Pages?  'T': 'F';              //
			char bool_to_char2 = hasFree2Pages ? '1' : '0';             //

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
