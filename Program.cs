﻿using System;
namespace operatorler{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("*-*-*-*Atama Ve İşlemler");
    int x = 3;
    int y = 4;
    y = y + 2 ;
    
    Console.WriteLine(y);
    y/=2;
    Console.WriteLine(y);
   y/=1;
    Console.WriteLine(y);
    x*=2;
    Console.WriteLine(x);

    // Mantıksal Operatorler 
    //  ||(veya) , &&(ve) , !(değil) 
    Console.WriteLine("*-*-*-*Mantıksal Operatorler");
    bool isSucces = true ;
    bool isCompleted = false ;

    if(isSucces && isCompleted)
        Console.WriteLine("Perfect!");

   if(isSucces || isCompleted) 
        Console.Write("Great!");

    if(isSucces && !isCompleted) 
        Console.WriteLine("Fine!");
        
        Console.WriteLine("*-*-*-*İlişkisel Operatörler");
        //İlişkisel Operatörler
        // <,>, <=,>=,==,!=
        int a = 3 ;
        int b = 4 ;
        bool sonuc = a<b ;
        Console.WriteLine(sonuc);
        sonuc = a>b ;  
        Console.WriteLine(sonuc);
        sonuc = a>=b ;
        Console.WriteLine(sonuc);
        sonuc = a<=b ;
        Console.WriteLine(sonuc);
        sonuc = a==b ;
        Console.WriteLine(sonuc);
        sonuc = a!=b ;
        Console.WriteLine(sonuc);
         
        Console.WriteLine("*-*-*-*Aritmetik Operatorler");
        // /, *, +,-
        int sayi1   = 10 ; 
        int sayi2   = 5 ;
        int sonuc1  =  sayi1/sayi2 ; 
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 * sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1 + sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1+=1 ;
        Console.WriteLine(sonuc1);
        
        // % mod alır
        Console.WriteLine("*-*-*-*MOd ALMA % ");
        int sonuc2 = 20%3 ;
        Console.WriteLine(sonuc2);
        }
    }
}
