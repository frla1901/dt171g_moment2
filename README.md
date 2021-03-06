# dt171g_moment1

## Programmeringsspråket C#

### Delmoment 2 i kursen DT071G Programmering i C#.NET

#### Justeringar 2021-11-20
Justerade den första inlämnade versionen enligt information om inmatat värde = inmatat i kommandotolken/terminal. Missuppfattade uppgiften och hårdkodade in värden istället för att låta användaren göra det själv. 

Valde justera _Main_ metoden genom att skapa 3 olika frågor i terminalen så att användaren skriver in: 
1. år
2. månad 
3. dag

Dessa konverteras till intgers year, month & day genom int.Parse och därefter datumets kontrolleras validitet innan ZellerAlgoritm körs. Se nedan kod som är den justerade versionen! 

**frida@MacBook-Pro dt171g_moment2 % dotnet run**

**Vilket år är du född? (ÅÅÅÅ)** 

**1977**

**Vilken månad är du född? (MM)**

**05**

**Vilket dag är du född? (DD)**

**07**

**Korrekt inmatat datum**

**Det var en lördag**

**Tryck på valfri tangent.**                                                                

**frida@MacBook-Pro dt171g_moment2 %**

#### Syfte
* kunna skapa enklare program i programmeringspråket C#.
* kunna använda en modern utvecklingsmiljö för programmering.
* ha erhållit en förståelse för vikten av felhantering i skapade program.

De nya kunskaperna kommer jag sedan att kunna använda och applicera i resterande laborationer och projektuppgift i kursen.

#### Förberedelser
Läste kapitel 2-4 i kursboken _"C# 8.0 and .NET Core 3.0 Modern Cross-plattform Development (Fourth edition)"_ av Mark J Price. 

Gick igenom [Microsoft Docs](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/) information om program struktur. Sen sökte jag information gällande Zeller's algoritm. 

#### Konsolapplikation 
##### Inmatat datum visar vilken veckodag det var.
Skapade en ny applikationsmall liknade förra momentet och påbörjade arbetet med klassen WeekDay. Metoden ZellerAlgoritm fungerade med enkel input data vilket jag testade först i metoden, _Main_. 

ZellerAlgoritm(1977,05,07);

**frida@MacBook-Pro dt171g_moment2 % dotnet run**

**Det var en lördag**

**frida@MacBook-Pro dt171g_moment2 %** 

Därefter började jag arbetet med att säkerställa att datumet som matats in var ett giltigt datum. För att testa detta så justerade jag metoden, _Main_ med en if/else sats.

if (isValidDate(1977,05,07)) 

{

Console.WriteLine("Korrekt inmatat datum");

ZellerAlgoritm(1977,05,07);

}

else
       
Console.WriteLine("Tyvärr var detta inte ett giltigt datum! Skriv datumet i formatet ÅÅÅÅ,MM,DD")

**frida@MacBook-Pro dt171g_moment2 % dotnet run**

**Korrekt inmatat datum**

**Det var en lördag**

**frida@MacBook-Pro dt171g_moment2 %** 

