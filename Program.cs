// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Globalization;
using System.IO.Pipes;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

Console.WriteLine("Hello, World!");
#region TASK 1(DEEP COPY)
//int num1 = 5;
//int num2 = num1;
//num1 = num2 * 5;
//Console.WriteLine(num1);
//Console.WriteLine(num2);

//ex2;
//int a = 15;
//int b = a;
//a = a * 15;
//Console.WriteLine(a);
//Console.WriteLine(b);
#endregion
#region TASK2 (OBJECT TYPE)
//string name = "Vekil";
//object _name = "Vekil";// boxing ederek object turune cevirdik
//int bith = 28;
//object _bith = 28;      //boxing
//char type = 'A';
//object _type = 'A';      //boxing
//string surname = "Balayev";
//object _surname = "Balayev"; //boxing
//float price = 25.50f;
//object _price = 25.50;
#endregion
#region TASK 3(UNBOXING)
//object birth = 25;
//int abi = (int)birth;   //unboxing
//object name = "Taleh";
//string adi = (string)name; //unboxing
//object earpuds = 99.99;
//double price = (double)earpuds ; //unboxing
//object firstalfabet = 'A';
//char one = (char)firstalfabet; //unboxing
//object version = "MSI";
//string computer = (string)version;//unboxing
//object samsung = 1100;
//int smartfon = (int)samsung; //unboxing
#endregion
#region TASK 4(DYNAMIC)
//dynamic x = "Elmeddin";
//Console.WriteLine(x.GetType());
//dynamic smartfon = "Apple";
//Console.WriteLine(smartfon.GetType());
//dynamic firstsay = '1';
//Console.WriteLine(firstsay.GetType());
#endregion
#region TASK 5(PARSE METODU)//string-de olan deyerleri hedefe deyerlere cevirik.
//string weight = "123";
//int weight2 = (int.Parse(weight));
//Console.WriteLine(weight2 * 10);
//string price = "59.99";
//double price2 = double.Parse(price);
//Console.WriteLine((price2 * 20) / 100);
//string alfabet = "A";
//char alfabet2 = char.Parse(alfabet);
//Console.WriteLine(alfabet2);
//string Mercedes = "40000";
//int Mercedes2 = int.Parse(Mercedes);
//Console.WriteLine(Mercedes2);
//string APPLE = "1200 ";
//int APPLE2 = int.Parse(APPLE);
//Console.WriteLine((APPLE2 * 10) / 100);
//string Hummer = "17000";
//int Hummer2 = int.Parse(Hummer);
//Console.WriteLine(Hummer2);
#endregion
#region TASK6 (CONVERT. STRINGIN DIGER DEYISENLERE CEVRILMESI)
//string abi = "25";
//int birth = Convert.ToInt32(abi);
//Console.WriteLine(birth);

//EX2:
//string samsung = "1299 ";
//int price = Convert.ToInt32(samsung);
//Console.WriteLine(price);

//ex3 :
//string Apple = "6.3"; double size = Convert.ToDouble(Apple);//tek setirde yazmaq mumkundur
//Console.WriteLine(size);

//ex4 :
//string hyundaisonata="2.3";
//double weight = Convert.ToDouble(hyundaisonata);
//Console.WriteLine(weight);

//ex 5:
//string watch = "200";
//int price = Convert.ToInt32(watch);
//Console.WriteLine(price);

//ex6:
//string MSInotebook = "2099.99";
//Double saleprice = Convert.ToDouble(MSInotebook);
//Console.WriteLine(saleprice);

#endregion
#region TASK 7 CAST OPERATORU(IMPILICT TYPE CONVERSION AND EXPILICIT TYPE)
//int soundspeed = 340;
//long type = Convert.ToInt32(soundspeed);// CAST OPERATORU IMPILICT TYPE/CON
//Console.WriteLine(type);
//long photon = 3_000_000_000;
//int speed = (int)photon;        //CAST OPERATORU EXPILICT TYPE
//Console.WriteLine(speed);
//int Xioami = 800;
//byte price = (byte)Xioami;
//Console.WriteLine(price);
#endregion
#region Task 8 (LOGICAL OPERATIONS)
//bool Apple = true; bool samsung = false;
//bool Abi = Apple && samsung;
//bool erestun = Apple ^ samsung;
//bool kenan = Apple || samsung;
//Console.WriteLine(Abi);
//Console.WriteLine(erestun);
//Console.WriteLine(kenan);
#endregion
#region TASK 9(ARTIRMA VE AZALTMA OPERATORLARI)
//int birth = 20;         //artirma i++
//birth++;
//Console.WriteLine(birth);
//int birth = 20;               //Artirma ++i
//   ++birth;
//Console.WriteLine(birth);
//int Vusal = 27;
//int Abi = Vusal++;
//int Erestun = ++Abi;
//Console.WriteLine(Erestun);
#endregion
#region TASK 10 (TERNARY OPERATORU)//TERNARY OPERATORU  sart  + ? + tapsirig
//1CI Misal Yasi 25 -den kicik ,25-e beraber ve 25-den boyuk olan siyahi yazaq
//int age = 25;
//string result = age < 25 ? "A" : (age == 25 ? "B" : "C");
//   Console.WriteLine(result );
//int price = 1100;
//string result = price < 1100 ? "Xiaomi" : price == 1100 ? "Apple" : "Samsung";
//Console.WriteLine(result);
//istifadeci terefinden verilmis sayinin asagidaki sertlere gore hesabini hesablayan kodu hazirla
//num<3              =>num*5
//num>3 && num<10    =>num*3
//num>=9&& num%2==0  =>num*10
//num%2==1           =>num
#endregion
#region
//Console.WriteLine("Bir sayi yazin");
//int num = int.Parse(Console.ReadLine());
//int result = num < 3 ? num * 5 : num > 3 && num < 10 ? num * 3 : num >= 9 && num % 2 == 0 ? num * 10 : num % 2 == 1 ? num : -1;
//Console.WriteLine("result:" + result);
#endregion
#region TASK 11(TYPEOF operator)
//Type t = typeof(int);
//Console.WriteLine(t.Name);
//Console.WriteLine(t.BaseType);
//Console.WriteLine(t.IsClass);
//Console.WriteLine(t.IsClass);
//Console.WriteLine(t.IsValueType);
#endregion
#region TASK 12 (IS OPERATORU)
//object mercedes = true;
//Console.WriteLine(mercedes is bool);
//Console.WriteLine(mercedes is double);
//Console.WriteLine(mercedes is int);
//Console.WriteLine(mercedes is string);
//Console.WriteLine(mercedes is null);
#endregion
#region TASK 13 ( AS OPERATORU)
//object car = "Mercedes";
//string marka = car as string;
//Console.WriteLine(marka);
//object price = "1200";
//string dollar = price as string;
//Console.WriteLine(dollar);
#endregion

#region TASK 14 (Switch Statements)
//string name = "Lale";
//    switch(name)
//{
//case "Leyla" :
//Console.WriteLine("Leyla");
//        break;
//    case "Nuray":
//        Console.WriteLine("Nuray");
//        break;
//    case "Ayla":
//        Console.WriteLine("Ayla");
//        break;
//    case "Miray":
//        Console.WriteLine("Miray");
//        break;
//    case "Lale":
//        Console.WriteLine("Lale");
//        break;
//}
#endregion
#region
//int month = 10;
//switch(month)
//{
//    case 1:
//        Console.WriteLine("yanvar");
//        break;
//    case 2:
//        Console.WriteLine("fevral");
//        break;
//    case 3:
//        Console.WriteLine("mart");
//        break;
//    case 4:
//    case 5:
//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("Avqust");
//        break;
//    default:
//        Console.WriteLine("sayi yanlis daxil etmisiz");
//        break;
//}
#endregion
#region
//int age = 15;   //        yeninmetod
//Console.ReadLine();
//string name = age switch

//{
//    5 => "Abi ",
//    7 =>" Vusal",
//    10 => "Erestun",
//    15=>"False"
//};

//Console.WriteLine(name);
#endregion
#region
//int price = 1200;
//string name = "Apple";
//Console.ReadLine();
//switch(price)
//{
//    case 1:
//     Console.WriteLine("Samsung");
//        break;
//        case 2  :
//        Console.WriteLine("Xioami");
//        break;
//       case 3:
//            Console.WriteLine("vivo");
//        break;
//    case 4:
//        Console.WriteLine("Apple");
//        break;
//    default:
//        Console.WriteLine("hec biri");
//        break;
//}
//Console.WriteLine(name);
#endregion

#region                       TASK 15(if else Statements)
//prototip
//if (true)
//{

//}
//else if (false)
//{

//}
//else (false)
// {
//}
//ex1:
//bool married =true;
//if( married )
//{
//    Console.WriteLine("Allah xoxbext elesin");
//}
#endregion
#region
//int num = 3;
// if(num>5)
//{
//    Console.WriteLine("num 5-den boyukdur");
//}
// else
//{
//    Console.WriteLine("num -den kicikdir");
//}
#endregion
#region
//int num = 100;
//if(num>100)
//{
//    Console.WriteLine("num 100-e beraberdir");
//}
//else 
//{
//    Console.WriteLine("num 100-den boyukdur");
//}
#endregion
#region
//int num = int.Parse(Console.ReadLine());
//if (num>50&& num<150)
//{
//    Console.WriteLine(" num>50&& num<150 ");
//}
//else if (num>150&& num<160)
//{
//    Console.WriteLine(" num>150&& num<160");
//}
//else if(num>175 &&num<180)
//{
//    Console.WriteLine("num>175 &&num<180  ")
//}
#endregion
#region//alinan  iki mehsulun qiymeti 200azn cox olarsa 25 % endirim paketini ekrana yazdir
//Console.Write("birinci malin qiymeti");
//int birincimalinqiymeti = int.Parse(Console.ReadLine());
//Console.Write("ikinci malin qiymeti");
//int ikincimalinqiymeti = int.Parse(Console.ReadLine());
//if( birincimalinqiymeti + ikincimalinqiymeti ==500)
//{
//    int umumimebleg = birincimalinqiymeti + ikincimalinqiymeti;
//    Console.WriteLine(umumimebleg * 75 / 100);
//}
//else if (birincimalinqiymeti + ikincimalinqiymeti < 200) 
//{
//    int umumimebleg = birincimalinqiymeti + ikincimalinqiymeti;
//    Console.WriteLine(umumimebleg * 50 / 100);
//}
//else if( birincimalinqiymeti + ikincimalinqiymeti> 500)
//{
//    int umumimebleg = birincimalinqiymeti + ikincimalinqiymeti;
//    Console.WriteLine("Ustegel tozsoran hediyye");
//}
#endregion
#region//giris sifesi teleb dene mobil tetbiqin giris hissesi ekrana yazdir
//Console.WriteLine("Istifadeci adinizi  daxil edin");
//string IDname= Console.ReadLine();
//Console.WriteLine("istifadeci kodunuzu daxil edin");
//string code = Console.ReadLine();
//if( IDname=="Musa" && code=="1234")
//{
//    Console.WriteLine("Giris  qebul edildi");
//}
//else
//{
//    Console.WriteLine("giris yanlisdir");
//}
#endregion
#region //ENGLISH VERSION
//Console.WriteLine("Enter name");
//string IDname = Console.ReadLine();
//Console.WriteLine("Enter code");
//string code = Console.ReadLine();
//if(IDname=="Samir"&&code=="1997")
//{
//    Console.WriteLine("Enter success");
//}
//else
//{
//    Console.WriteLine(" False Enter");
//}
#endregion
#region ( CALCULATOR -IF STATMENTS)
//Console.WriteLine(" Enter 1 number enter");
//int number1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter 2 number enter");
//int number2 = int.Parse(Console.ReadLine());
//Console.WriteLine("please enter aritmetric operators +,-,/,*) ");
//char write = char.Parse(Console.ReadLine());
//if (write == '+')
//{
//    Console.WriteLine("number1+numbe2");
//}
//else if (write == '-')
//{
//    Console.WriteLine("number1-number2");
//}
//else if (write == '*')
//{
//    Console.WriteLine("number1 * number2");
//}
//else if (write == '/')
//{
//    Console.WriteLine("number1 / number2");
//}
#endregion
#region
//Console.WriteLine("Lutfen 1 sayiyi girin");
//int sayi1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Lutfen 2 sayiyi girin");
//int sayi2 = int.Parse(Console.ReadLine());
//Console.WriteLine("Lutfen yapilacak islemi belirtiniz + ,-, *, /)");
//char islem = char.Parse(Console.ReadLine());
//if (islem == '+')
//{
//    Console.WriteLine(sayi1 + sayi2);
//}
//else if (islem == '-')
//{
//    Console.WriteLine(sayi1 - sayi2);
//}
//else if (islem == '/')
//{
//    Console.WriteLine(sayi1 / sayi2);

//}
//else if (islem == '*')
//{
//    Console.WriteLine(sayi1 * sayi2);

//}
#endregion
#region(Switch case Calculator)
//Console.WriteLine("Lutfen 1 sayiyi girin");
//        int sayi1 = int.Parse(Console.ReadLine());
//       Console.WriteLine("Lutfen 2 sayiyi girin");
//        int sayi2 = int.Parse(Console.ReadLine());
//          Console.WriteLine("Lutfen yapilacak islemi belirtiniz + ,-, *, /)");
//          char islem = char.Parse(Console.ReadLine());
//          int sonuc = islem switch
//         {
//        '+' => sayi1 + sayi2,
//          '-' => sayi1 - sayi2,
//          '/' => sayi1 / sayi2,
//            _ => sayi1 * sayi2
//             };
//           Console.WriteLine(sonuc);
#endregion
#region
//Console.WriteLine("please 1 number enter");
//int num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("please 2 number enter");
//int num2 = int.Parse(Console.ReadLine());
//Console.WriteLine("please enter process operators +,-,*,/)");
//char process = char.Parse(Console.ReadLine());
//int result = process switch
//{
//    '+' => num1 + num2,
//    '-' => num1 - num2,
//    '/' => num1 / num2,
//    '*' => num1 * num2
//};
//Console.WriteLine(result);
#endregion
#region 

//int num = int.Parse(Console.ReadLine());
//if (num == 10)
//{
//    Console.WriteLine("dogru sayi daxil etmisiz");
//}
//else
//{
//    Console.WriteLine("yanlis sayi daxil etmisiz");
//}
#endregion
#region(daxil etdiyiniz ededin tek ve cut olmasini ekrana yazdir)
//int num = int.Parse(Console.ReadLine());
//if (num % 2 == 0)
//{
//    Console.WriteLine("daxil eded cut ededdir");
//}
//else
//{
//    Console.WriteLine("daxil eded tek ededdir");
//}
#endregion
#region(daxil edilen ededlerden sadece tek ededleri ekrana yazdir)
//int num = int.Parse(Console.ReadLine());
//if(num%2==1)
//{
//    Console.WriteLine("daxil etdiyiniz eded tek ededdir");
//}
//else
//{
//    Console.WriteLine("Daxil etdiyiniz eded cut ededdir");
//}
#endregion
#region (daxil olan ededlerden sadece musbet olanlari ekrana yazdir)
//int num = int.Parse(Console.ReadLine());
//if(num>0)
//{
//    Console.WriteLine("daxil etdiyiniz eded musbetdir");
//}
//else
//{
//    Console.WriteLine("daxil etdiyiniz eded menfidir");
//}
#endregion
#region(daxil edilmis ededin 143 ededi ile muqayisesi)
//int number = 143;
//string result = number switch
//{
//    > 50 => "50-den boyukdur",
//    <50=>"50 -den kicikdir",
//    _=>"50-de beraberdir"

//};
//Console.WriteLine(result);
#endregion
#region(daxil edilecek her hansi ededin 100 ededile ile muqayisesi)
//int num = int.Parse(Console.ReadLine());
//string result = num switch
//{
//    > 100 => "100-den boyukdur",
//    < 100 => "100-den kicikdir",
//    _ => "100-e beraberdir"
//};
//Console.WriteLine(result);
#endregion
#region(daxil edilecek her hansi ededin menfi ve musbet olmagini ekrana yazdir)
//int num = int.Parse(Console.ReadLine());
//string result = num switch
//{
//    > 0 => "number positive",
//    < 0 => "number negative",
//    _=> "number zero"
//};
//Console.WriteLine(result);
#endregion

#region                        TASK 16          (LOOPS-FOR,WHILE,DO WHILE)
//ex1(consola yazilmis yazini ekrana yazdir
//for(int num=0;num<20;num++)
//{
//    Console.WriteLine("Asgerov Qosqar");
//}
#endregion
#region(console.w yazilmis yazini serte uygun ekrana yazdir)
//for(int num=100;num<=150;num++)
//{
//    Console.WriteLine("Salam Azerbaycan");
//}
#endregion
#region(Consol.w veril yazini serte uygun 1 azaldaraq yazin)
//for (int num =120; num > 100; num--)
//{
//    Console.WriteLine("hello world");
//}    
#endregion
#region(Consol.w yazini serte uygun 5 artiraraq yazin)
//for (int num = 0; num < 100; num += 5)
//   Console.WriteLine("Erestun");
#endregion
#region (verilmis ededi 3 artiraraq 200-qeder  ededleri ekrana yazdir
//for (int num = 0; num < 200;num+= 3)
//  Console.WriteLine(num );
#endregion
#region(1 -den 100 -e qeder olan cut ededleri ekrana cixart)
//for(int num=1; num<100;num++)
//{
// if(num%2==0)
//    {
//        Console.WriteLine(num);
//    }
//}
#endregion
#region (200-den 10 qeder tek ededleri ekrana yazdir)
//for(int num=200;num>10;num--)
//{
//    if(num%2==1)
//    {
//        Console.WriteLine(num);
//    }
//}
#endregion
#region(1-den 300-e qeder 5 artiraraq tek ededleri ekrana yazdir0
//for(int num=1;num<300;num+=5)
//{
//if(num%2==1)
//    {
//        Console.WriteLine(num);
//    }
//}
#endregion
#region(WHILE SONSUZ DONGULER) (while/d verilen sayi 1 artiraraq ekrana yazdirmaq)
//int num = 1;
//while(num<23)
//{
//    Console.WriteLine(num);
//    num++;
//}
#endregion
#region(while/d 1000-e qeder olan cut ededleri 2 hasil olmaqla ekrana yazdir)
//int num = 1;
//while(num<1000)
//{
//    if(num%2==0)
//    {

//    }
//    Console.WriteLine(num);
//    num *= 2;
//}
#endregion
#region(1000-den 10 qeder 2-ye bolunerek cut ededleri yazin)
//int num = 10000;
//while(num>10)
//{
//    if(num%2==0)
//    {

//    }
//    num /= 2;
//    Console.WriteLine(num);
//}
#endregion
#region(girilen istenilen eded 1 azaldaraq ededleri ve ustegel "Hello World" sozunu ekrana yazdir)
//int num = int.Parse(Console.ReadLine());
//while(num>0)
//{
//    Console.WriteLine(num);
//    Console.WriteLine("Hello world");
//    num--;
//}
#endregion
#region(1 ile 100 arasindaki cut ededlerin cemini yazin)
//int num = 1, toplam = 0;
//while(num<100)
//{
//    if(num%2==0)
//    {

//    }
//    toplam += num;
//    num++;
//}
//Console.WriteLine(toplam);
#endregion
#region(1-den 50 -e qeder tek ededlerin cemi yazin)
//int num = 1, toplam = 0;
//while (num < 50)
//{
//    if (num % 2 == 1)
//    {

//    }
//    toplam += num;
//    num++;
//}
//Console.WriteLine(toplam);
#endregion
#region(1-den 15-e qeder ededlerin cemini yazin)
//int num = 1, toplam = 1;
//while(num<15)
//{
//    toplam *= num;
//    num++;

//}
//Console.WriteLine(toplam);
#endregion
#region(scope-dan istifade etmedikde (;) isaresinden istifade edilir.
//for (int num = 0; num < 15; num++) ;
//Console.WriteLine("Samsung galaxy");
#endregion
#region TASK 17 (ARRAY)
#region ARRAY-de LOOPS (FOR)
//string[] personnels = new string[10];
//personnels[0]= "Abi";
//personnels[1] = "Erestun";
//personnels[2] = "Kenan";
//personnels[3] = "Yolcu";
//personnels[4] = "Musa";
//personnels[5] = "Orxan";
//personnels[6] = "Asif";
//personnels[7] = "Samir";
//personnels[8] = "Pasa";
//personnels[9] = "Vekil";
//for (int num = 0; num <5; num++)
//{
//    Console.WriteLine(personnels[6]);
//}
//EX 2:
//int[] numbers = new int[] { 23, 32, 67, 56, 12, 45 };
//int[] numbers2 = new int[10];
//numbers[0] = 23;
//numbers[1] = 32;
//numbers[2] = 67;
//numbers[3] = 56;
//numbers[4] = 12;
//numbers[5] = 45;


//for (int i = 0; i < 6; i++)
//{
//    //Console.WriteLine(numbers[i]);
//    Console.WriteLine($"a[{i + 1}] :{numbers[i]}");
//}

#endregion
#region ARRAY (DO WHILE)
//string[] personnels = new string[10];
//personnels[0] = "abi";
//personnels[1] = "erestun";
//personnels[2] = "kenan";
//personnels[3] = "yolcu";
//personnels[4] = "musa";
//personnels[5] = "orxan";
//personnels[6] = "asif";
//personnels[7] = "samir";
//personnels[8] = "pasa";
//personnels[9] = "vekil";
//int i = 0;
//do
//{
//    Console.WriteLine(personnels[i]);
//    i++;
//} while (i < 10);
#endregion
#region ONE-DIMENSIAL ARRAY
//byte[] numbers = new byte[7];
//numbers[0] = 4;
//numbers[1] = 5;
//numbers[2] = 95;
//numbers[3] = 45;
//numbers[4] = 79;
//Console.WriteLine(numbers[1]);
//Console.WriteLine(numbers[2]);
//Console.WriteLine(numbers[3]);
//Console.WriteLine(numbers[4]);

//EX 2 :
//string[] names = new string[5];
//names[0] = " Abi";
//names[1] = "elis";
//names[2] = "Ali";
//names[3] = "Idris";
//Console.WriteLine(names[1]);
#endregion
#region FOREACH ARRAY
//int[] numbers = new int[] { 23, 32, 67, 56, 12, 45 };
//int[] numbers2 = new int[7];
//numbers[0] = 23;
//numbers[1] = 32;
//numbers[2] = 67;
//numbers[3] = 56;
//numbers[4] = 12;
//numbers[5] = 45;

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
//EX 2:
//string[] names = new string[] { "Abi", "Ali", "Azim", "Idris" };
//names[0] = "Abi";
//names[1] = "Ali";
//names[2] = "Azim";
//names[3] = "Idris";
//foreach (string name in names)
//{
//    Console.WriteLine(name);
//}
#endregion
#region ARRAYS
//Array numbers= new int[10];
//numbers.SetValue(23, 1);
//numbers.SetValue(12, 4);
//numbers.SetValue(13, 5);
//numbers.SetValue(14, 3);
//object value = numbers.GetValue(4);
//Console.WriteLine(value);
//Ex 2:
//Array births = new int[5];
//births.SetValue(12, 3);
//births.SetValue(13, 4);
//births.SetValue(14, 2);
//births.SetValue(15, 1);
//object value=births.GetValue(1);
//Console.WriteLine(births);
#endregion
#region Array CLEAR/copy/INDEXOF/REVERSE
//EX 1; CLEAR
//Array names = new [] { "Abi", "Kenan", "Hilal", "Orxan" };
//for (int i = 0; i < names.Length; i++)
//Console.WriteLine(names.GetValue(i));
//Array.Clear(names, 0,0);
//Console.WriteLine("Goster");
//for (int i = 0; i < names.Length; i++)
//    Console.WriteLine(names.GetValue(i));

//Ex 2:COPY

// Array names = new[]  {"Abi" , "Erestun ", "Kenan", "Musa",};
//string [] names2= new string [ names.Length];
//Array.Copy(names, names2,1);
//for (int i =0;i<names.Length; i++)
//Console.WriteLine(names2[i]);


//Array names = new[] { "Abi", "Erestun ", "Kenan", "Musa", };
//string[] names2 = new string[names.Length];
//Array.Copy(names, 2, names2, 0,2);  //(burada 2 kopyalama sayini gosterir))
//for (int i = 0; i < names2.Length; i++)
//    Console.WriteLine(names2[i]);

//Array biths = new int[] { 13, 25, 63, 14, 17 };
//int[] youngbiths = new int[biths.Length];
//Array.Copy(biths, 4, youngbiths, 0, 1);// burada 4 -sira sayisini , 1 copyalanacaq  ededin sayini ifade edir.
//for (int i = 0; i < biths.Length; i++)
//    Console.WriteLine(youngbiths[i]);
#endregion
#region IndexOf
//Array names = new[] { "Abi", "Elmeddin", "Erestun ", "Ilyas ", "Tural" };
//Array.IndexOf(names, "Erestun");
//int index = Array.IndexOf(names, "Ali");
//if (index != -1)
//{
//    Console.WriteLine("Var");

//}

//Array date = new[] { 12, 25, 1, 4, 17 };
//Array.IndexOf(date, 12);
//int index =Array.IndexOf(date, 12);
//if (index == -1 )
//{
//    Console.WriteLine("var");
//}
#endregion
#region REVERSE
//Array names = new[] { "Abi", "Erestun ", "Kenan", "Musa", };
//for (int i = 0; i< names.Length ; i++)
//Console.WriteLine(names.GetValue(i));
//Array.Reverse(names);
//Console.WriteLine("names");
//Array.Reverse(names, 0, 3);
//Console.WriteLine("   ");
//for (int i=0; i<names.Length; i++)
//Console.WriteLine(names.GetValue(i));

//EX 2:
//Array num = new[] { 12, 25, 41, 1, 3 };
//Array.Reverse(num, 0, 5);
//Console.WriteLine("   ");
//for (int i = 0; i < num.Length; i++)
//    Console.WriteLine(num.GetValue(i));
#endregion
#region ARRAY(Sort metodu /IsReadonly property /IsFixedSize property /Rank property /CreatInstance
#region SORT METHODS
//Array names = new[] { "Abi", "Erestun ", "Kenan", "Musa", };
//for (int i = 0; i < names.Length; i++)
//Array.Sort(names);
//for (int i = 0; i < names.Length; i++)
// Console.WriteLine(names.GetValue(i));

//Array num = new[] { 1, 5, 69, 87, 56 };
//for (int i = 0; i < num.Length; i++)
//    Console.WriteLine(num.GetValue(i));
//Array.Sort(num);
//for (int i = 0; i < num.Length; i++)
// Console.WriteLine(num.GetValue(i));
#endregion
#region (IsReadonly)
//Array names = new[] { "Abi", "Erestun ", "Kenan", "Musa", };
//Console.WriteLine(names.IsReadOnly);

//ex 2:
//Array num = new[] { 12, 52, 41, 3 };
//Console.WriteLine(num.IsReadOnly);
#endregion
#region IsFixedSize
// Array num = new[] { 12, 52, 41, 3 };
//Console.WriteLine(num.IsFixedSize);
#endregion
#region Rank property
//Array names = new[]{"Abi","Erestun", "Kenan", "Orxan","Musa"};
//Console.WriteLine(names.Rank);
//Ex 2 :
//int[,,] num = new int[1, 5, 6];//Cox boyutlu 
//Console.WriteLine(num.Rank);
#endregion
#region CreatInstance
//Array num = new[ ] { 1,2, 5, 6 };
//Array num= Array.CreateInstance(typeof(int)3);
#endregion
#region Rangs and Indices System.Index (^)
//EX 1:
//int[] numbers = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
//Index index = 5; //==> soldan 0 - n - 1
//Index index2 = ^6;//==> saydan n - 1
//Console.WriteLine(numbers[index2]);

//EX 2:
//String[] names = { "Abi", "Musa", "Samir", "Haci" };
//Index num = 3;
//Index num2 = ^3;
//Console.WriteLine(names[num]);

//EX 3:
//int[] price = new[] { 15, 25, 35,45, 55, 65 };
//Index num = 3;
//Index num2 = ^5;
//Console.WriteLine(price[num2]);

//EX 4:
//char[] mark = { 'A', 'B', 'C', 'D', 'E', 'F' };
//Index num = 3;
//Index num2 = ^5;
//Console.WriteLine(mark[num2]);
#endregion
#region Ranges and Indices  System.Range Turu
//EX 1:
//int[] numbers = { 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
//Range num = 5..8;
//Console.WriteLine(numbers[num]);

//EX2 :
//char[] mark = { 'A', 'B', 'C', 'D', 'E', 'F' };
//Range num = 1..5;
////Index num2 = ^5;
//Console.WriteLine(mark[num]);

//int[] num = new[]{ 3, 5, 7, 9, 1, 2, 31, 321, 534, 5643, 457, 56, 78 };
//Range range = 1..3;

//var numbers2 = num[range];
//Console.WriteLine(num[range]);
#endregion
#region  (COX BOYUTLU ARRAY)
//int[ , ] numbers = new int[4, 3];
//numbers[0, 0] = 3;
//numbers[0, 1] = 5;
//numbers[0, 2] = 7;
//numbers[0, 3] = 5;
//Console.WriteLine(numbers.Rank);

//EX 2:
////int[,,] num = new int[2, 2, 4];
////num[0, 0, 0] = 1;
////num[0, 0, 1] = 2;
////num[0, 0, 2] = 3;
////num[0, 0, 3] = 4;
////num[0, 1, 0] = 5;
////num[0, 2, 0] = 6;
////num[0, 1, 2] = 7;
////num[0, 1, 3] = 8;
//num[1, 0, 0] = 9;
//num[1, 0, 1] = 10;
//num[1, 0, 2] = 11;
//num[1, 0, 3] = 12;
//num[1, 1, 0] = 13;
//num[1, 1, 1] = 14;
//num[1, 1, 2] = 15;
//num[1, 1, 3] = 16;
//Console.WriteLine(num.GetLength(0));
//Console.WriteLine(num.GetLength(1));
//Console.WriteLine(num.GetLength(2));

//EX 3:(LOOPS COX BOYUTLU ARRAY)
//int[,,] num = new int[3, 4, 5];
//num[0, 0, 0] = 1;
//num[0, 0, 1] = 2;
//num[0, 0, 2] = 3;
//num[0, 0, 3] = 4;
//num[0, 1, 0] = 5;
//num[0, 2, 0] = 6;
//num[0, 1, 2] = 7;
//num[0, 1, 3] = 8;
//num[1, 0, 0] = 9;
//num[1, 0, 1] = 10;
//num[1, 0, 2] = 11;
//num[1, 0, 3] = 12;
//num[1, 1, 0] = 13;
//num[1, 1, 1] = 14;
//num[1, 1, 2] = 15;
//num[1, 1, 3] = 16;

//for (int i = 0; i < num.GetLength(0) ; i++)
//{
//    for (int j = 0; j < num.GetLength(1) ; j++)
//     {
//        for (int h = 0; h < num.GetLength(2) ; h++)
//                   {
//            Console.WriteLine(num[i, j, h] + "        ");
//        }
//        Console.WriteLine("       ");
//    }
//}

#endregion
#region (DUZENSIZ MASSIVLER)

// EX 1: DUZEN MASSIVLERDE FERQLI MASSIVLERDE FERQLI ELEMANLARI CAGIRMA
//int[][] numbers = new int[3][];
//numbers[0] = new int[3] { 3, 5, 7 };
//numbers[1] = new int[5] { 3, 5, 7, 523, 10 };
//numbers[2] = new int[7] { 3, 5, 7, 523, 186, 99, 89 };
//Console.WriteLine(numbers[0][0]);
//numbers[0][0] = 13;
//Console.WriteLine(numbers[0][0]);
//Console.WriteLine(numbers[1][2]);
//Console.WriteLine(numbers[2][3]);

//EX 2: 
//string[][] names = new string[3][];
//names[0] = new string[5] { "Abi", "Ali", "Tural", "Elvan", "Elvin" };
//names[1] = new string[7] { "Musa", "Yolcu", " Orxan", "Samir", "Vekil", "Amin", "Taleh" };
////names[4] = new string[9] { "Erestun", "Hilal", "Samid", "Ezim", "Ibrahim", "Amin", "Asif", "Elmar", "Ruhin" };
//Console.WriteLine(names[0][2]);
//Console.WriteLine(names[0][4]);
//Console.WriteLine(names[1][4]);

//EX 3:
//int[][] numbers = new int[3][];
//numbers[0] = new int[3] { 3, 5, 7 };
//numbers[1] = new int[5] { 3, 5, 7, 523, 10 };
//numbers[2] = new int[7] { 3, 5, 7, 523, 186, 99, 89 };
//Console.WriteLine(numbers[0].Length + numbers[1].Length + numbers[2].Length);

//EX 4: MASSIVLERDE DEYER (DEYER ) ELEMAN SAYISINI TAPMA
//int[][] births = new int[3][];
//births[0] = new int[4] { 10, 12, 15, 17 };
//births[1] = new int[6] { 25, 22, 27, 26, 21, 29 };
//births[2] = new int[9] { 30, 32, 34, 35, 37, 39, 36, 38, 33, };
//Console.WriteLine((births[0].Length + births[1].Length + births[2].Length));
//Console.WriteLine(births[0][2]);

//int[][] births = new int[3][];
//births[0] = new int[4] { 10, 12, 15, 17 };
//births[1] = new int[6] { 25, 22, 27, 26, 21, 29 };
//births[2] = new int[9] { 30, 32, 34, 35, 37, 39, 36, 38, 33, };
//    for (int i = 0; i < births.GetLength(0) ; i++)
//{
//    for (int j = 0; j < births[i].Length; j++)
//    {

//        Console.Write(births[i][j] +"       ");


//    }
//    Console.WriteLine("       ");
//}




#endregion
#endregion
#endregion
#region TASK 18 (STRING)
#region task 1 
//string name= "";
//Console.WriteLine(string.IsNullOrWhiteSpace(name));
#endregion
#region Task 2
//string n = new string('0', 3);
//for(int i =0; i<n.Length; i++)
//    Console.WriteLine(n);
//Console.WriteLine(n);
#endregion
#region Task 3 ToString
//bool herbci = true;
//string x=herbci.ToString();
//Console.WriteLine(x);
#endregion
#region
//int num=215;
//string num2=num.ToString();
//Console.WriteLine(num2);

//EX 2:
//double amount = 215.50;
//string amountStr=amount.ToString("0.00");//c1,c2, c3, istifade edile biler
//Console.WriteLine(amountStr );

//VERSION ;
//double Apple = 1099.99;
//string price=Apple.ToString("0.00");
//Console.WriteLine(price);

//double Pi = 3.14;
//string num = Pi.ToString();
//Console.WriteLine(num);
//Ex 3:
//bool subay = true;
//string subayStr = subay.ToString();
//Console.WriteLine(subayStr);

//version ;
//bool futbolcu = true;
//string Ronaldo=futbolcu.ToString();
//Console.WriteLine(Ronaldo);
#endregion
#region TASK 2 ToChar []method/STRING LOOPS
//EX 1:
//char[] herfler= {'a','b','c','d'};
//Console.WriteLine($"herf sayi :{herfler.Length}");

//char[] numbers = { '1', '2', '3', '4', '5', '6', '7', '8', '9', };
//Console.WriteLine($" numbers :{numbers.Length}");
//EX 2: string 
//string herf = "abcd";
//Console.WriteLine($"herf sayi:{herf.Length}");
//Console.WriteLine(herf[0]);
//EX 3; String LOOPS:
//string herf ="abcd";
//for (int i = 0; i <herf.Length; i++)
//    Console.WriteLine(herf[i]);

//version tersden yazdirma:

//string herfStr = "abcde";
//for(int i=herfStr.Length-1; i>=0; i--)
//    Console.WriteLine(herfStr[i]);

//EX 3: BURADA ELMEDDIN ADININ BUTUN ELEMENTLERINI HEM ARDICIL HEMDE TERSDEN YAZDIRDIQ:

//string name = "Elmeddin";
//for (int i = 0; i <name.Length; i++)
//{
//    for (int j = name.Length - 1; j >= 0; j--)
//    {
//        Console.WriteLine(name[j]);
//    }
//    Console.WriteLine(name[i]);

//}

//EX 4;DO WHILE ,WHILE LOOPS
//string name = "Elmeddin";
//int i = 0;
//while (i<name.Length)
//{
//    Console.WriteLine(name[i]);
//    i++;
//}

//EX5 :FOREACH
//string name = "abcd";
//foreach(var item in name)
//    Console.WriteLine(item);

//Version :
//string sentence = "Baki sabahin xeyir";
//foreach(var item in sentence)
//    Console.WriteLine(item);
#endregion
#region  Empty NULL
//string name = " ";
//Console.WriteLine(string.IsNullOrEmpty);
//Console.WriteLine(string.IsNullOrWhiteSpace);
#endregion
#region TASK 3 LOOPS STRING IFALERDE XARAKTERE ULASMA 
//EX 1; FOR
//string sentence = "Salam necesen";
//for (int i = 0; i < sentence.Length; i++)
//{
//    if (sentence[i] == 'e')
//        Console.WriteLine(i);

//}

//WHILE 
//string sentence = "Salam Dunya";
//    int i=0;
//while(sentence.Length>i)
//{
//    if (sentence[i]=='a')
//    {
//        Console.WriteLine(i);
//    }
//    i++;
//}
#endregion
#region    TASK 3 $ INTERPOLITION   $"  {...}...{...}'; BACWARD SLASL(\) VERBATIM OPERATOR @   

//EX 1:
//string name = "elemmeddin";
//int age = 28;
//bool subay = true;
//int price = 1300;
//Console.WriteLine($"{name},{age},{subay},{price}");

//EX 2:
//string name ="Elmeddin";
//string surname = "aliyev";
//int Kno = 12386;
//bool subay = true;
//Console.WriteLine($"{name},{surname},olan :{Kno}uygun");

//EX 3:  BACKWARD SLASH
//Console.WriteLine("\a"); //Melodikm ses verir.

//EX 4 : \
//    Console.WriteLine("\"name+surname+Adress");
//Console.WriteLine(" \"Bugun hava eladir \" ");
//Console.WriteLine(" \"her wey planlasdirilan \n kimi gedir \" ");
//Console.WriteLine(" \" elmeddin\" ");

//EX 5: @ VERBATIM OPERATORU 
//string sentence = @"salam necesen
//kefin halin necedi";
//Console.WriteLine(sentence);
//VERSION 2;
//string weather = @"Hava cox ""gozel"" ";
//Console.WriteLine(weather);
#endregion
#region TASK 4  STRING FUNCTIONS (Contains ,StartsWith,EndsWith,Equals,Compare ,CompareTo,IndexOf ,Insert)
//EX 1; CONTAINS
//string sentence = "Barselona dunyanin en guclu futboll komandasidir";
//bool result = sentence.Contains("dunya");
//Console.WriteLine(result);

// VERSION:
//string alfabet = "abcd";
//String alfabet2 = "abc";
//Console.WriteLine(alfabet.Contains(alfabet2));

//VERSION 3:
//string sentence = @"Static methods, classes* and variables have been a core functionality of many programing languages
//(C++, Java, C#, ..). The static keyword is versatile, but it also comes with downsides that need to be considered.";
//bool result = sentence.Contains("many");
//Console.WriteLine(result);

//EX 2: STARSWITH ,ENDSWITH
//string sentence = "Barselona dunyanin en guclu futboll komandasidir";
//bool result = sentence.StartsWith("Barselona");
//bool result2 = sentence.EndsWith('r');
//Console.WriteLine($"{result},{result2}");
//Console.WriteLine(result);

//EX 3:EQUALS
//string str1 = "ProGeek 2.0";
//string str2 = "ProGeek 2.0";
//Console.WriteLine( string.Equals(str1, str2));

//VER:
//string name = "elmeddin";
//string name1 = "Qosqar";
//Console.WriteLine(name.Equals(name1));

//VERSION :
//string team = "Barcelona";
//string team2 = "Juventus";
//if(team.Equals(team2))
//{
//    Console.WriteLine("Beraberdir");
//}
//else
//{
//    Console.WriteLine("Beraber deyil");
//}

//EX 4; COMPARE,COMPARE TO
//VER:
//string words = " Uzun ince bir yoldayim";
//Console.WriteLine(string.Compare(words, 9, words,8, 5));

//VER 2:
//string word = "Aliyev";
//string word2 = "Memmedov";
//Console.WriteLine(word.CompareTo(word2));

//VER 3:
//string name = "Gulay";
//string name2 = "Gunel";
//int result=string.Compare(name, name2);
//Console.WriteLine(result);

//VER 4: STRING.COMPARE IF STATEMENTS
//string name = "Gulay";
//string name2 = "Gunel";
//if(string.Compare(name,name2)==0)
//{
//    Console.WriteLine("Equals");
//}
//else
//{
//    Console.WriteLine("Not Equals");
//}

//EX 5: INDEXOF
//string words = " Uzun ince bir yoldayim";
//int result;
//Console.WriteLine(words.IndexOf(" Uzun"));
//Console.WriteLine(words.IndexOf("bir"));
//result = words.IndexOf('y', 0, 21);
//Console.WriteLine("Index of y:" +result);

//VERSION :INDEXOFANY
//string sentence = "Baki gozel weher, ozel diyar";
//char[] herf = { 'a', 'c', 'e' };
//int result =sentence.IndexOfAny(herf);
//Console.WriteLine(result);

//VERSION IF INDEXOFANY
//string sentence = "Baki gozel weher, ozel diyar";
//char[] herf = { 'a' ,'e' };
//int result = sentence.IndexOfAny(herf);
//if(result != -1 )
//{
//    Console.WriteLine("Herfler movcuddur");
//}
//else
//{
//    Console.WriteLine("movcud deyil");
//}

//VERSION ;LASTINDEXOF 
//string sentence = Console.ReadLine();
//Console.WriteLine(sentence.LastIndexOf("Messi"));

//Version 1:
//string sentence=Console.ReadLine();
//Console.WriteLine(sentence.LastIndexOf('z'));

//EX :INSERT
//EX 1:
//string word = "Uzun ince bir yoldayam";
//String newWord = word.Insert(9, "sessiz");
//Console.WriteLine(newWord);

//EX 2:
//string name = "Elmeddinin masini Cruze-dur";
//string name2 = name.Insert(11, "  ");
//Console.WriteLine(name2);

//EX 3:
//string uncles = "Sahmar,Elmar,Elmeddin,Ilyas,Natiq";
//string uncle = uncles.Insert(0, "Namiq ");
//Console.WriteLine(uncle);
#region TASK 6 (REMOVE ,REPLACE,SPLIT,JOIN,SUBSTRING,CONCAT,Padleft,Padright,ToUpper,TOLOWER,TRIM,FORMAT)
//EX :REMOVE
//EX 1:
//string sentence = "Uzun ince ,sessiz bir yoldayam";
//string newSentence = sentence.Remove(9,8);
//Console.WriteLine(newSentence);
//EX 2:
//string words = "Barcelona,Real Madrid,Juventus,Liverpul";
//String clubs = words.Remove(10, 12 );
//Console.WriteLine($"{clubs}");

//EX 3:
//string Laptop = "Msi CYBORG en yaxsi laptopdur";
//string laptop2 = Laptop.Remove(3);
//Console.WriteLine(laptop2);

//EX :REPLACE
//EX 1:
//string name = "Spiderman";
//string result = name.Replace("man", "woman");
//Console.WriteLine(result);
//EX 2;
//string sentence = "Uzun ince bir yoldayim";
//string newSentence = sentence.Replace("ince", "sessiz");
//Console.WriteLine(newSentence);
//EX 3:
//string name = "ana";
//string name2 = name.Replace('n', 't');
//Console.WriteLine(name2);

//EX 4:
//string sentence = "Barcelona Ispaniya komandasidir";
//string result = sentence.Replace("Ispaniya", "  en guclu ");
//Console.WriteLine(result);

//EX :SPLIT :
// EX 1:SPLIT FOREACH
//string sentence = "Uzun ince bir yoldayam";
//string []newWords=sentence.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
//foreach(var item in newWords)
//Console.WriteLine(item);

//EX 2;SPLIT FOR
//string text = "Barselona,RealMadrid, Liverpul, Valensiya,";
//string[]clubs=text.Split(new char[] {','} ,StringSplitOptions.RemoveEmptyEntries);  
//for(int i = 0; i < clubs.Length; i++)
//{
//    Console.WriteLine(clubs[i]);
//}
//EX 3:
//string text = "Uzun ince bir yoldayim";
//string[]text2=text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//for (int i = 0; i < text2.Length; i++)
//    Console.WriteLine(text2[i]);

//EX : JOIN METHOD- ESASEN STRING MASSIVLERI ELEMENTLERINI BIRLESDIRMEK UCUN ISTIFADE EDILIR.

//EX 1:
// Creating an object array 
// Here, It is consist of four  
// elements only 
//object[] array = { "Hello", "Geeks", 12345, 786 };
// Using Join method 
// Here separator is ', '( comma ) 
//string s1 = string.Join(", ", array);
// Finally after joining process gets over 
// Getting the output of value of string s1 
//Console.WriteLine("Value of string  s1 is " + s1);

//EX 2:
//string[] names = { "Elmeddin ", "Ilyas", "Elmar", "Aslan" };
//string unit = string.Join(":", names);
//Console.WriteLine(unit);

//EX 3;
//string[] cars = { "Ferrari", "Mersedes", "BMW", "Toyota" };
//string newCars=string.Join("=", cars);
//Console.WriteLine(newCars);

//EX SUBSTRING:
//EX 1:
//string name = "Azerbaycan";
//string result = name.Substring(7, 3);
//Console.WriteLine(result);

//EX 2; SUBSTRING AND INDEXOF
//string sentence = "Uzun Ince bir , yoldayim";
//string result = sentence.Substring(0, sentence.IndexOf(','));
//Console.WriteLine(result);

//EX 3:
//string footballName ="Messi Xavi Eto! Ronaldo ";
//string result = footballName.Substring(0, footballName.IndexOf('!'));
//Console.WriteLine(result);

//EX 4:
//string name = "Elmeddin,ilyas,Sahmar,Yusif";
//string brother = name.Substring(9,5);
//Console.WriteLine(brother);

//EX :CONCAT :
//EX 1:
//string name = "Qosqar";
//string surname = "Asgerov";
//string age = "27";
//string fullName=string.Concat(name, surname, age);
//Console.WriteLine(fullName);
//INTERPOLTION
//Console.WriteLine($"{name},{surname},{age}");

//EX 2:
//string[]names = {"Emil","Elmar","Elnur"};
//string result = string.Concat(names);
//Console.WriteLine(result);

//EX 3:
//string brend = "Apple";
//string price = "1000";
//string colour = "Silver ";
//string result=string.Concat(brend    +  price  + colour);
//Console.WriteLine(result);

//EX ToUPPER ,ToLOWER
//EX 1:
//string name = "elmeddin";
//string result = name.ToUpper();
//Console.WriteLine(result);

//EX 2;
//Console.OutputEncoding = Encoding.Unicode;
//CultureInfo ci = new CultureInfo("az");
//Thread.CurrentThread.CurrentCulture = ci;
//string name ="Eliheyder";
//string result=name.ToUpper();
//Console.WriteLine(result);

//EX 3: ToUpper =>for =>foreach
//for (int i = 0; i < result.Length; i++)
//  Console.WriteLine(result[i]);
//foreach(var item in result)
//Console.WriteLine(item);

//EX PADRIGHT,PADLEFT
//EX 1:
//string name = "elmeddin";
//string result =name.PadRight(2);
//Console.WriteLine(result);

//EX 2:
//string surname = "Asgerov";
//string result;
//Console.WriteLine(result = surname.PadRight(20,'*'));

//EX 3:
//string str = "Icecream";
//char pad = '^';
//string result;
//// returns new string with length 20 
//// padded with '^' at right
//result = str.PadRight(20, pad);
//Console.WriteLine("|{0}|", result);
//// returns given string
//result = str.PadRight(2, pad);
//Console.WriteLine("|{0}|", result);
//// returns new string with length 8
//// padded with '^' at right
//result = str.PadRight(8, pad);
//Console.WriteLine("|{0}|", result);

//EX :TRIM,TRIMSTARTS,TRIMSEND
//EX 1:
//string sentence = "   her wey yolundadir ?";
//string result = sentence.Trim();
//Console.WriteLine(result);

//EX 2:
//char[] charsToTrim = { '?', '!' };
//string sentence = " Kodu duzgun daxil etdiniz  ? !";
//string result=sentence.Trim(charsToTrim);
//Console.WriteLine(result);

//EX :FORMAT METHODS :
//EX 1:
//string name ="Anar" ;
//double salary = 3000.80;
//string message = string.Format("{0},sizin geliriniz:{1} manatdir", name ,salary);
//Console.WriteLine(message);
//EX 2;
//string sisterName = "Gulcin ";
//string fruits = "apple";
//string result = String.Format("{0} eats {1}", sisterName, fruits);
//Console.WriteLine(result);
//EX 3;
//string name = "Elmeddin";
//string surname = "Aliyev";
//string fatherName = "Zaur";
//string birthTime = "03.12.1994";
//Console.WriteLine(@$"{name}
//{surname}
//{fatherName} oglu,
//{birthTime}");

// EXERCISES:
//EX 1:GIRILEN ADIN ONDEN 4 AXRADAN 5 XARAKTERINI EKRANA YAZDIR.
//string name = "Elmeddin";
//Console.WriteLine(name[3]);
//Console.WriteLine(name[name.Length-5]);
//EX 2:GIRILEN ADIN ONDEN 4 AXRADAN 5 XARAKTERINI EKRANA YAZDIR.
//string name = "Elmeddin";
//Console.WriteLine(name[0..^6]);

//EX 3:YAZILACAQ IFADEDE NE QEDER N herfi yazildigini ekrana yazdir
//Console.WriteLine("Ekrana metni daxil edin");
//string sentence = Console.ReadLine();
//string result;
//int num = 0;
//for (int i = 0; i < sentence.Length; i++)
//{

//    if (sentence[i] == 'n')
//    {
//        num++;

//    }
//    Console.WriteLine(num);
//}
//VERSION
//Console.WriteLine("Lutfen bir metin yaz");
//string sentence = Console.ReadLine();
//int eded = 0;
//for (int i = 0; i < sentence.Length; i++)
//{
//    if (sentence[i] == 'n')
//    {
//        eded++;
//    }
//    Console.WriteLine(eded);
//}

//EX :GIRILEN METINDE SOZLERIN SAYINI EKRANA YAZDIR

//Console.WriteLine("Ekran metni daxil edin");
//string sentence =Console.ReadLine();
//string[] words = sentence.Split(' ');
//Console.WriteLine(words.Length);
//VERSION 2
//Console.WriteLine("Ekrana  metni daxil edin");
//string sentence = Console.ReadLine();
//int num = 1;
//for (int i = 1;i<sentence.Length;i++)
//{
//    int index=sentence.IndexOf(" ");
//    if(index==-1)
//    {
//        break;

//    }
//    num++;
//    sentence = sentence.Substring(index+1);//index boslugu 0 -dan tapdigina gore ustune 1 gelirik

//}
//Console.WriteLine(num);
//QUIZ 1:
//string[] arr = { " 2023", "aprel", " .txt" };
//string fullName = string.Concat(arr);
//Console.WriteLine(fullName);

//QUIZ 2:
//string[] chars = { "z", "x", "y", "z", "y" };
//for (int i = 0; i < chars.Length; i++)
//    for (int j = i+1; j < chars.Length; j++)
//        if (chars[i].CompareTo(chars[j]) ==0)
//            Console.WriteLine(chars[i]);
#endregion
#endregion
#endregion
#region  TASK 19 STRINGBUILDER
#region
//Ex 1;APPEND 
//string name = "Elmeddin";
//StringBuilder sb = new StringBuilder();
//sb.Append(name);
//sb.Append("Eliyev");
//Console.WriteLine(sb);

//EX 2:REMOVE 
//StringBuilder sb2 = new StringBuilder();
//sb2.Append("Elmeddin Eliyev");
//sb2.Remove(0, 2);
//Console.WriteLine(sb2);

//EX3 :REPLACE
//StringBuilder say=new StringBuilder();
//say.Append("Sanli Azerbaycan");
//say.Replace("Sanli", "Uca");
//Console.WriteLine(say);

//EX 4:INSERT
//StringBuilder @stringBuilder = new StringBuilder("Hello, C#");
// Insert Characters at specified position
//stringBuilder.Insert(6, " StringBuilder in");
//string result = @stringBuilder.ToString();
//Console.WriteLine(result);
//EX 2:
//StringBuilder word = new StringBuilder("Salam dunya");
//word.Insert(11, "Necesiz");
//Console.WriteLine(word);

//EX 5:Array
//StringBuilder word = new StringBuilder("Alfabet",50);
//word.Append(new char[] { 'A', 'B', 'C', 'D' });
//Console.WriteLine(word);
//StringBuilder sb1 = new StringBuilder("abc6urdfiuoytytrtytre8ru");
//StringBuilder sb2 = new StringBuilder("abc", 16);
//Console.WriteLine("a1) sb1.Length = {0}, sb1.Capacity = {1}", sb1.Length, sb1.Capacity);
//Console.WriteLine("a2) sb2.Length = {0}, sb2.Capacity = {1}", sb2.Length, sb2.Capacity);
//Console.WriteLine(34.40M);
//Console.WriteLine(5/10 );
#endregion
#endregion
#region  TASK 20 DATETIME
// EX 1: DateTime Create
//DateTime tarix = new DateTime(2023, 10, 15);
//Console.WriteLine(tarix.ToString());
//DateTime bugun = DateTime.Now;
//Console.WriteLine(bugun);
//EX 2:
//DateTime bugun2= new DateTime(2023, 03, 21, 10, 45, 50);
//Console.WriteLine($"{bugun2}");

//Ex 3:MaxValue,Minvalue
//Console.WriteLine(DateTime.MaxValue);
//Console.WriteLine(DateTime.MinValue);

//Ex 4:UTCNOW
//DateTime London = DateTime.UtcNow;
//Console.WriteLine(London);

//Ex 5: Properties
//DateTime dateTime = DateTime.Now;
//Console.WriteLine("Gunun adi : "+ dateTime.DayOfWeek);
//Console.WriteLine("Saat vaxti :"+dateTime.Hour);
//Console.WriteLine($"Ayin tarixi:"+dateTime.Month);
//Console.WriteLine("il :"+dateTime.Year);
//Console.WriteLine("Deqiqe:" +dateTime.Minute);
//Console.WriteLine("saniye muddeti:"+dateTime.Second);
//Console.WriteLine("muddet1:"+dateTime.Kind);
//Console.WriteLine("muddet2:"+dateTime.Nanosecond);
//Console.WriteLine("Muddet3:"+dateTime.Millisecond);

//EX 6:Additinal,ToString
//DateTime tarix = new DateTime(2024, 11, 14,10,55,45);
//Console.WriteLine(tarix.ToString());
//Console.WriteLine(tarix.Date);
//Console.WriteLine(tarix.ToString("dd.MM.yyyy"));
//Console.WriteLine(tarix.ToString("dd.MM.yyyy HH:mm:ss"));
//Console.WriteLine(tarix.AddDays(5));
//Console.WriteLine(tarix.AddYears(-6));
//Console.WriteLine(tarix.AddMinutes(4));

//EX 7 Equals
//DateTime tarix1 = new DateTime(2023, 11, 29);
//DateTime tarix2 = new DateTime(2023, 10, 29);
//if(tarix1.Equals(tarix2))
//{
//    Console.WriteLine("Beraberdir");
//}
//else
//{
//    Console.WriteLine("Beraber deyil");
//}
//EX 7.2 CompareTo
//DateTime tarix = new DateTime(2023, 10, 23);
//DateTime tarix2 = new DateTime(2023, 09, 23);
//int result =tarix.CompareTo(tarix2);
//if(result== 0)
//{
//    Console.WriteLine("her ikisi beraberdir");
//}
//else if(result== 1)
//{
//    Console.WriteLine("birinci tarix boyukdur");
//}
//else
//{
//    Console.WriteLine("ikinci boyukdur");
//}

//EX 7.3 COMPARE
//DateTime tarix = new DateTime(2024, 08, 25);
//DateTime tarix2 = new DateTime(2024, 08, 29);
//int result=DateTime.Compare(tarix, tarix2); 
//if (result == 0 )
//{
//    Console.WriteLine("Her ikisi beraberdir");
//}
//else if (result == 1 )
//{
//    Console.WriteLine("Birinci tarix oncedir");
//}
//else
//{
//    Console.WriteLine("birinci tarix once deyil");
//}

//EX 8:Subtract
//DateTime tarix = new DateTime(2024, 08, 25);
//DateTime tarix2 = new DateTime(2024, 08, 29);
//TimeSpan result=tarix2.Subtract(tarix);
//Console.WriteLine(result);

//DateTime freedomDay = new DateTime(1992, 10, 18);
//DateTime toDay = DateTime.Now;
//TimeSpan result=toDay.Subtract(freedomDay);
//Console.WriteLine(result);

//EX 9:ToString
//DateTime tarix = new DateTime(2023, 2, 5, 10, 20, 30, 18);
//string formatted = $"{tarix:D}";
//Console.WriteLine(formatted);
//Console.WriteLine(tarix);
//Console.WriteLine($"{tarix:d}");
//Console.WriteLine($"{tarix:f}");
//Console.WriteLine($"{tarix:F}");
//Console.WriteLine($"{tarix:g}");
//Console.WriteLine($"{tarix:G}");
//Console.WriteLine($"{tarix:M}");
//Console.WriteLine($"{tarix:O}");
//Console.WriteLine($"{tarix:R}");
//Console.WriteLine($"{tarix:s}");
//Console.WriteLine($"{tarix:T}");
//Console.WriteLine($"{tarix:u}");
//Console.WriteLine($"{tarix:U}");
//Console.WriteLine($"{tarix:dddd}");
//Console.WriteLine($"{tarix:gg}");
//Console.WriteLine($"{tarix:FFFFFFF}");
//Console.WriteLine($"{tarix:t}");
//Console.WriteLine($"{tarix:zzz}");
//Console.WriteLine($"{tarix:zz}");
//Console.WriteLine(tarix.ToString("zzz"));
//Console.WriteLine(tarix.ToString("HH:mm:ss"));

//EX 10:TimeSpan(iki tarix arasinda zaman hesablamasi)
//DateTime tarix=DateTime.Now;    
//DateTime tarix2=new DateTime(2002,03,27); ;
//TimeSpan result=tarix-tarix2;
//Console.WriteLine(result);
//Console.WriteLine(result.Days);
//Console.WriteLine(result.Hours);
//Console.WriteLine(result.TotalDays);


#endregion
