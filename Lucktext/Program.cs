// See https://aka.ms/new-console-template for more information
Console.WriteLine("Skriv in ditt namn:");

string name;
string M;
string dricka;
string sport;
string spel;

name = Console.ReadLine();

Console.WriteLine($"Hej {name}, Skriv ner din favorit maträtt");

M = Console.ReadLine();

Console.WriteLine("Skriv ett namn på en dricka.");
dricka = Console.ReadLine();

Console.WriteLine("Skriv ner din favorit sport");
sport = Console.ReadLine();

Console.WriteLine("Skriv ner ditt favorit spel");
spel = Console.ReadLine();

Console.WriteLine($"{name} har {M} som sin favorit maträtt och gillar att dricka {dricka} till det. Efter så gillar {name} att spela sin favorit sport {sport}. När {name} är hemma så spelar dem {spel}. ");

Console.ReadLine();

