

//Csharp-Hometask



//2) Parametr olaraq string qebul eden metod yazmalisiz.
//    Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. 
//    (Cavid gelirse , ekranda divaC gorsensin).


////????

//string name = "Cavid";
//string reverseName = ReverseString(name);
//Console.WriteLine(reverseName);


//string ReverseString(string input)
//{
//    char[] charArray = input.ToCharArray();
//    Array.Reverse(charArray);
//    return new string(charArray);
//}

//Console.WriteLine();

























// Csharp-StringMethods-Practise





//8

//string PowerOfTwo(int n)
//{
//    if ( n == 1)
//    {
//        return "Quvvetidir";
//    }

//    if ( n < 2)
//    {
//        return "Quvveti deyil";
//    }


//    for ( int i = 2; i <= n; i*=2 )
//    {
//        if (i % n == 0)
//        {
//            return "Quvvetidir";
//        }
//    }
//    return "Quvveti deyil";
//}

//string result = PowerOfTwo(64);
//Console.WriteLine(result);


/////////////////////////////////////////////


//string PowerOfFive(int n)
//{
//    if (n == 1)
//    {
//        return "Quvvetidir";
//    }
//    if (n < 1)
//    {
//        return "Quvveti deyil";
//    }

//    for (int i = 5; i <= n; i *= 5)
//    {
//        if (i % n == 0)
//        {
//            return "Quvvetidir";
//        }
//    }
//    return "Quvveti deyil";
//}

//string result = PowerOfFive(1);
//Console.WriteLine(result);



////////////////////////////////////////////////////




//int[] arr = { 1, 2, 3, 4, 5 };

//arr[1] = 100;




//List<int> datas = new() { 1, 2, 3, 4, 5 };
//datas.Add(100);



//string name = "test";

//string newName = name + "salam";




//string name = "salam";

//name = " sagol";




//using System.Text;
/////
//StringBuilder str = new StringBuilder("salam");


//str.Append(" sagol");

//Console.WriteLine(str);


//using System.Text;

//StringBuilder name = new StringBuilder("SALAM");


//name.Append(", sagol");

//Console.WriteLine(name);


//int age = 27;
//Console.WriteLine(age.ToString().GetType());
//Console.WriteLine(age);



//string name = "bayraq";
//Console.WriteLine(name.Length);


//string surname = "gerb";
//Console.WriteLine(surname.Length);

////////////////
///

//string name = "bayraq";

//string surname = " gerb";

//string result = string.Concat(name, surname);

//Console.WriteLine(result);


//////////////////////////////////

//string str1 = "salamlar";

//string str2 = " necesiz?";

//string result = string.Concat(str1, str2);

//Console.WriteLine(result);



/////////////////////////////////////// 




//string result = "";

//string result2 = string.Empty;


//var result3 = result2 + "salam";
//Console.WriteLine(result3);


///////////////////



//string result2 = string.Empty;


//string result1 = "salam";

//string result3 = "klkl";

//var result5 = result1 + result2 + result3;

//Console.WriteLine(result5);




/////////////////

//string t = "sdsdsd   ";

//string text = string.Empty;

//if (string.IsNullOrEmpty(t))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("fill");
//}



//////////////////////



//string text = "    ";

//if (string.IsNullOrWhiteSpace(text))
//{
//    Console.WriteLine("empty");
//}
//else
//{
//    Console.WriteLine("fill");
//}



/////////////////



//string text = "AZerbaijan";
//Console.WriteLine(text.ToUpper());
//Console.WriteLine(text.ToLower());




////////////////////




//string str1 = "apple";
//string str2 = "Apple";

//Console.WriteLine(str1.ToLower() == str2.ToLower());






//string str1 = "    apple";
//string str2 = "Apple";


//Console.WriteLine(str1.Trim().ToLower() == str2.Trim().ToLower()) ;







////////////////////////////////////////////////


//string str1 = "  dkjdkapple ";
//string str2 = "Apple";

//Console.WriteLine(str1.Trim().ToLower() == str2.Trim().ToLower());




//string str1 = "    apple";
//string str2 = "Apple";


//Console.WriteLine(str1.Equals(str2));





//string str1 = "    apple";
//string str2 = "Apple";


//Console.WriteLine(str1.Trim().ToLower().Equals(str2.Trim().ToLower()));







//string str1 = "    apple";
//string str2 = "Apple";


////Console.WriteLine(CheckStr(str1).Equals(CheckStr(str2)));



////string CheckStr(string str)
////{
////    return str.Trim().ToLower();
////}







//string str1 = "    apple";
//string str2 = "Apple";




//string str = "This is the \"Salam\" class. ";
//Console.WriteLine(str);


//string message = $"Welcome to {str}";

//Console.WriteLine(message);





//string text = "Azerbaijan";
//Console.WriteLine(string.Format("Azerbaijan"));




/////////////////



//string authors = "sakjskajskj, djhsjs, ududhousa, ioudhshdoas isds,";
//Console.WriteLine(authors);

//string[] authorsList = authors.Split(',');

//foreach (var item in authorsList)
//{
//    Console.WriteLine(item);
//}





//string text = "Salam Azerbaijan";

//Console.WriteLine(text.Replace("Salam","sagol"));





//string name = "salam pb-101";
//Console.WriteLine(name.Replace("salam","sagol"));



/////////////////





//string text = "Salam Azerbaijan";



//Console.WriteLine(text.Substring(0,9));



////////



//string text1= "Salam Azerbaijan";



//Console.WriteLine(text1.Substring(2));



///////








//string text1 = "Salam Azerbaijan";

//string result = text1.Substring(0, 5) + "...";

//Console.WriteLine(result);



///////////////////////





//string text1 = "Salam Azerbaijan";



//Console.WriteLine(text1.Contains("Azf"));





///////////////////////////






//bool CheckCharInStr(string str, char elem)
//{
//    return str.Trim().Contains(elem.ToString().ToLower());

//}

//Console.WriteLine(CheckCharInStr("Baku" , 'B'));







//bool CheckCharInStr(string str, string elem)
//{
//    return str.Trim().ToLower().Contains(elem.ToString().ToLower());

//}

//Console.WriteLine(CheckCharInStr("Baku", "b"));


////////////////////////////////////////


 

//bool CheckCharInStr(string str, string elem)
//{
//    return str.Trim().ToLower().Contains(elem.ToString().ToLower());
//}

//Console.WriteLine("Add text: ");
//string str = Console.ReadLine();

//Console.WriteLine("Add search text");
//string searchText = Console.ReadLine();

//if (CheckCharInStr(str, searchText))
//{
//    Console.WriteLine("found");
//}
//else
//{
//    Console.WriteLine("not found");
//}













