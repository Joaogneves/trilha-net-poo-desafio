﻿using System.Text;
using DesafioPOO.Models;

Console.OutputEncoding = Encoding.UTF8;
// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new Iphone("16999999999", "Iphone 14 pro max", "12345678494443", 256000);
Nokia nokia = new Nokia("16998888888", "Nokia Tijolão", "05891238137789", 8000);

Console.WriteLine("-------------------------------------------------------------------------");

Console.WriteLine("Testes Iphone: ");
Console.WriteLine("Numero: " + iphone.Numero);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine("-------------------------------------------------------------------------");

Console.WriteLine("Testes Nokia: ");
Console.WriteLine("Numero: " + nokia.Numero);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Snake");