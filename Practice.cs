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
			decimal pi = 3.1415926535M;


			int birthYear = 2000;				

			//1. CHAR CONVERSION 
			//1.1 CHAR to STRING
			//string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
			string charToStringImplicit = sex.ToString();               //Преобразование с использованием встроенного метода
			string charToStringImplicit2 = Convert.ToString(sex);		//Преобразование с использованием метода класса System.Convert
			//string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
			string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

			//1.2 CHAR to BOOL
			//bool char_to_bool = Convert.ToBoolean(sex);				//InvalidCastException документация говорит что конвертерование Convert.ToBoolean(char) не поддерживается.
			//bool char_to_bool = (bool) sex;							//Не удается преобразовать тип
			bool char_to_bool;
			if (sex == 'M') { char_to_bool = true; }
			else			{ char_to_bool = false; }					//преобразование конкретного символа в bool
			char_to_bool = (sex=='M') ? true : false;                   //Тоже самое, используя тернарную запиь

			//1.3 CHAR to DECIMAL
			decimal char_to_decimal = (decimal)place;                   //Результат 51(число соответствует коду символа '3' в таблица unicode)
			//decimal char_to_decimal2 = Convert.ToDecimal(place);      //InvalidCastException документация говорит что конвертерование Convert.ToBoolean(char) не поддерживается.
			decimal char_to_decimal3 = place;

			//1.4 CHAR to INT
			int char_to_int = (int)sex;							// Оказывается выше пол введен символом кириллицы =))
			int char_to_int2 = Convert.ToInt32(sex);			// Результат 1052(число соответствует коду символа 'М' в таблица unicode)
			int char_to_int3 = (int)place;                      // Результат 51(число соответствует коду символа '3' в таблица unicode)
			int char_to_int4 = place;                           // Результат 51(число соответствует коду символа '3' в таблица unicode)
			int char_to_int5 = Convert.ToInt32(place);			// Результат 51(число соответствует коду символа '3' в таблица unicode)
			//int char_to_int7 = Int32.Parse(sex);				//Отсутствует необходимый перегруженный метод  =(

			//2. STRING CONVERSION
			//2.1 STRING to CHAR
			//char string_to_char = Convert.ToChar(hasPhoto);					//Исключение.Длина строки должна составлять один символ.
			string string_one_sym = "M";
			char string_to_char = Convert.ToChar(string_one_sym);				//Результат 'М'
			char string_to_char2 = hasPhoto.ToCharArray()[0];					//Результат 'T'
			char string_to_char3 = Convert.ToChar(hasPhoto.Substring(0, 1));    //Результат 'T'
			//char string_to_char4 = Char.Parse(hasPhoto);						//Исключение. Длина строки должна составлять один символ
			char string_to_char5 = Char.Parse(string_one_sym);                  //Результат 'М'

			//2.2 STRING to BOOL
			bool str_to_bool = Convert.ToBoolean(hasPhoto);                     //Результат true
			bool str_to_bool2 = ((hasPhoto == "True") || (hasPhoto == "true")) ? true : false;  //Результат true
			bool str_to_bool3 = Boolean.Parse(hasPhoto);                        //Результат true

			//2.3 STRING to DECIMAL
			//decimal str_to_decimal = Decimal.Parse(hasPhoto);					//Исключение. Входная строка имеет неверный формат
			//decimal str_to_decimal2 = Convert.ToDecimal(hasPhoto);            //Исключение. Входная строка имеет неверный формат
			decimal str_to_decimal3 = Decimal.Parse(flatNumber);				//Результат 34
			decimal str_to_decimal4 = Convert.ToDecimal(flatNumber);            //Результат 34
			//decimal str_to_decimal5 = (decimal)flatNumber;						//Ошибка. Не удается преобразовать тип string в тип decimal

			//2.4 STRING to INT
			int str_to_int = Int32.Parse(flatNumber);                           //Результат 34
			int str_to_int2 = Convert.ToInt32(flatNumber);                      //Результат 34
			// Можно  в цикле через Substring или ToCharArray вытягивать каждый символ из строки и умножая каждый на нужную степень, прибавлять к decimal переменной
			
			//3. BOOL CONVERSION

			//3.1 BOOL to CHAR
			//char bool_to_char = Convert.ToChar(hasFree2Pages);				//Исключение. Недопустимое приведение bool к char
			char bool_to_char2 = hasFree2Pages ? 'T' : 'F';						//Результат 'F'
			char bool_to_char3 = hasFree2Pages ? '1' : '0';                     //Результат '0'

			//3.2 BOOL to STRING
			string bool_to_string = Convert.ToString(hasFree2Pages);            //Результат "False"
			string bool_to_string2 = hasFree2Pages.ToString();                  //Результат "False"
			string bool_to_string3 = hasFree2Pages ? "True" : "False";          //Результат "False"
			string bool_to_string4;
			if(hasFree2Pages)	{bool_to_string4 = "True";}
			else				{bool_to_string4 = "False"; }                   //Результат "False"

			//3.3 BOOL to DECIMAL
			//decimal bool_to_decimal = (decimal)hasFree2Pages;
			decimal bool_to_decimal2 = Convert.ToDecimal(hasFree2Pages);        //Результат 0
			decimal bool_to_decimal3 = hasFree2Pages ? 1 : 0;                   //Результат 0

			//3.4 BOOL to INT
			int bool_to_int = Convert.ToInt32(hasFree2Pages);					//Результат 0
			int bool_to_int2 = hasFree2Pages ? 1 : 0;                           //Результат 0

			//4. DECIMAL CONVERSION

			//4.1 DECIMAL to CHAR
			//char decimal_to_char = Convert.ToChar(pi);						//Исключение. Недопустимое приведение decimal к char
			//char decimal_to_char2 = Char.Parse(pi.ToString());                //Исключение.Длина строки должна быть дин символ
			char decimal_to_char2 = Char.Parse(pi.ToString().Substring(0,1));	//Результат 3 (сивол '3')
			char decimal_to_char3 = (char)pi;                                   //Результат 3  (соответствует служебному символу ETX(конец текста) в таблице unicode)
			char decimal_to_char4 = (char)51;									//Результат 51 (соответствует символу '3' в таблице unicode)

			//4.2 DECIMAL to BOOL
			bool decimal_to_bool = pi == 0 ? false : true;						//Результат true
			bool decimal_to_bool2 = Convert.ToBoolean(pi);                      //Результат true
			//bool decimal_to_bool3 = Boolean.Parse(pi.ToString());				//Исключение, Строка не распознана как действительное логическое значение

			//4.3 DECIMAL to STRING
			string decimal_to_string = pi.ToString();                           //Результат "3.1415926535"
			string decimal_to_string2 = Convert.ToString(pi);                   //Результат "3.1415926535"

			//4.4 DECIMAL to INT
			int decimal_to_int = Convert.ToInt32(pi);                           //Результат 3
			int decimal_to_int2 = (int)pi;                                      //Результат 3
			//int decimal_to_int3 = Int32.Parse(pi.ToString());					//Исключение.Входная строка имела неверный формат

			//5. INT CONVERSION         

			//5.1 INT to CHAR
			char int_to_char = (char)birthYear;                                 //Результат 2000  (соответствует символу 'ߐ' в таблице unicode)
			char int_to_char2 = Convert.ToChar(birthYear);                      //Результат 2000  (соответствует символу 'ߐ' в таблице unicode)
			//char int_to_char3 = Char.Parse(birthYear.ToString());             ///Исключение.Длина строки должна составлять один знак

			//5.2 INT to BOOL
			bool int_to_bool = birthYear == 0 ? false : true;                   //Результат true
			bool int_to_bool2 = Convert.ToBoolean(birthYear);                   //Результат true
			//bool int_to_bool3 = Boolean.Parse(birthYear.ToString());			//Исключение, Строка не распознана как действительное логическое значение

			//5.3 INT to DECIMAL
			decimal int_to_decimal = birthYear;                                 //Результат 2000
			decimal int_to_decimal2 = (decimal)birthYear;						//Результат 2000
			decimal int_to_decimal3 = Convert.ToDecimal(birthYear);             //Результат 2000

			//5.4 INT to STRING
			string int_to_string = Convert.ToString(birthYear);                 //Результат "2000"
			string int_to_string2 = birthYear.ToString();                       //Результат "2000"

		}
	}
}
