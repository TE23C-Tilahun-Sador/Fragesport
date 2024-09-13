using System.Runtime.CompilerServices;



int score = 0;

Console.WriteLine("Användarnamn: ");
string name = Console.ReadLine();
name = name.ToLower();

Console.Clear();
Console.WriteLine($"Välkommen till min frågesport {name}!");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Detta är en frågesport om geografi");
Console.WriteLine("Vill du vara med?");
Console.WriteLine("");
Console.WriteLine("Skriv <starta> för att starta frågesporten: ");
string starta = Console.ReadLine();

if (starta.ToLower() == "starta")
{
   Console.Clear();
   Console.WriteLine("Vad heter världens största land? svara endast med <a>, <b> eller <c>");
   Console.WriteLine("a) China");
   Console.WriteLine("b) Asien");
   Console.WriteLine("c) Ryssland");

   string svar1 = Console.ReadLine();
   svar1 = svar1.ToLower();

   while (svar1 != "a" && svar1 != "b" && svar1 != "c")
   {
      svar1 = Console.ReadLine();
   }

   if (svar1 == "a" || svar1 == "b")
   {
      Console.WriteLine("Inkorrekt!(du kan inte vara seriös)");
      Console.ReadLine();
   }

   else if (svar1 == "c")
   {
      Console.WriteLine("Korrekt!");
      Console.ReadLine();
      score++;
   }

   Console.Clear();
   Console.WriteLine("Vad för språk pratar man i Etiopien? svara endast med <a>, <b> eller <c>");
   Console.WriteLine("a) Swahili");
   Console.WriteLine("b) Amhariska");
   Console.WriteLine("c) Igbo");

   string svar2 = Console.ReadLine();
   svar2 = svar2.ToLower();

   while (svar2 != "a" && svar2 != "b" && svar2 != "c")
   {
      svar2 = Console.ReadLine();
   }

   if (svar2 == "a" || svar2 == "c")
   {
      Console.WriteLine("Inkorrekt!");
      Console.ReadLine();
   }

   else if (svar2 == "b")
   {
      Console.WriteLine("Korrekt!(du måste väll ha gissat)");
      Console.ReadLine();
      score++;
   }

   Console.Clear();
   Console.WriteLine("Vad heter världens mest torraste geografiska område? svara endast med <a>, <b> eller <c>");
   Console.WriteLine("a) Antartisk");
   Console.WriteLine("b) Sahara öknen");
   Console.WriteLine("c) Death Valley");

   string svar3 = Console.ReadLine();
   svar3 = svar3.ToLower();


   while (svar3 != "a" && svar3 != "b" && svar3 != "c")
   {
      svar3 = Console.ReadLine();
   }

   if (svar3 == "c" || svar3 == "b")
   {
      Console.WriteLine("Inkorrekt!");
      Console.ReadLine();
   }

   else if (svar3 == "a")
   {
      Console.WriteLine("Korrekt!(den där var lite klurig)");
      Console.ReadLine();
      score++;
   }

   if (score > 2)
   {
      Console.Clear();
      Console.WriteLine($"du fick {score} poäng! Fyfan var bra");
      Console.WriteLine("");
      Console.WriteLine("Klicka på <Backspace> för att avsluta: ");
      Console.WriteLine("Klicka på <Enter> för mer instruktioner: ");
      if (Console.ReadKey().Key == ConsoleKey.Backspace)
      {
         Environment.Exit(0);
      }
   }

   else if (score < 2)
   {
      Console.Clear();
      Console.WriteLine($"du fick {score} poäng! du kan väll göra bättre");
      Console.WriteLine("");
      Console.WriteLine("Klicka på <backspace> för att avsluta: ");
      Console.WriteLine("Klicka på <Enter> för mer instruktioner: ");
      if (Console.ReadKey().Key == ConsoleKey.Backspace)
      {
         Environment.Exit(0);
      }
   }
   else if (score == 2)
   {
      
      Console.Clear();
      Console.WriteLine($"du fick {score} poäng! du kan väll göra bättre");
      Console.WriteLine("");
      Console.WriteLine("Klicka på <backspace> för att avsluta: ");
      Console.WriteLine("Klicka på <Enter> för mer instruktioner: ");
      if (Console.ReadKey().Key == ConsoleKey.Backspace)
      {
         Environment.Exit(0);
      }


   }



}

Console.WriteLine("Skriv <starta> för att starta om frågesporten: ");
string startaOm = Console.ReadLine();

while (startaOm.ToLower() == "starta")
{
   Console.Clear();
   Console.WriteLine("Vad heter världens största land? svara endast med <a>, <b> eller <c>");
   Console.WriteLine("a) China");
   Console.WriteLine("b) Asien");
   Console.WriteLine("c) Ryssland");

   string svar1 = Console.ReadLine();
   svar1 = svar1.ToLower();

   while (svar1 != "a" && svar1 != "b" && svar1 != "c")
   {
      svar1 = Console.ReadLine();
   }

   if (svar1 == "a" || svar1 == "b")
   {
      Console.WriteLine("Inkorrekt!(du kan inte vara seriös)");
      Console.ReadLine();
   }

   else if (svar1 == "c")
   {
      Console.WriteLine("Korrekt!");
      Console.ReadLine();
      score++;
   }

   Console.Clear();
   Console.WriteLine("Vad för språk pratar man i Etiopien? svara endast med <a>, <b> eller <c>");
   Console.WriteLine("a) Swahili");
   Console.WriteLine("b) Amhariska");
   Console.WriteLine("c) Igbo");

   string svar2 = Console.ReadLine();
   svar2 = svar2.ToLower();

   while (svar2 != "a" && svar2 != "b" && svar2 != "c")
   {
      svar2 = Console.ReadLine();
   }

   if (svar2 == "a" || svar2 == "c")
   {
      Console.WriteLine("Inkorrekt!");
      Console.ReadLine();
   }

   else if (svar2 == "b")
   {
      Console.WriteLine("Korrekt!(du måste väll ha gissat)");
      Console.ReadLine();
      score++;
   }

   Console.Clear();
   Console.WriteLine("Vad heter världens mest torraste geografiska område? svara endast med <a>, <b> eller <c>");
   Console.WriteLine("a) Antartisk");
   Console.WriteLine("b) Sahara öknen");
   Console.WriteLine("c) Death Valley");

   string svar3 = Console.ReadLine();
   svar3 = svar3.ToLower();


   while (svar3 != "a" && svar3 != "b" && svar3 != "c")
   {
      svar3 = Console.ReadLine();
   }

   if (svar3 == "c" || svar3 == "b")
   {
      Console.WriteLine("Inkorrekt!");
      Console.ReadLine();
   }

   else if (svar3 == "a")
   {
      Console.WriteLine("Korrekt!(den där var lite klurig)");
      Console.ReadLine();
      score++;
   }

   if (score > 2)
   {
      Console.Clear();
      Console.WriteLine($"du fick {score} poäng! Fyfan var bra");
      Console.WriteLine("");
      Console.WriteLine("Klicka på <Backspace> för att avsluta: ");
      Console.WriteLine("Klicka på <Enter> för mer instruktioner: ");
      if (Console.ReadKey().Key == ConsoleKey.Backspace)
      {
         Environment.Exit(0);
      }
   }

   else if (score < 2)
   {
      Console.Clear();
      Console.WriteLine($"du fick {score} poäng! du kan väll göra bättre");
      Console.WriteLine("");
      Console.WriteLine("Klicka på <Backspace> för att avsluta: ");
      Console.WriteLine("Klicka på <Enter> för mer instruktioner: ");
      if (Console.ReadKey().Key == ConsoleKey.Backspace)
      {
         Environment.Exit(0);
      }
   }
   else if (score == 2)
   {
      Console.Clear();
      Console.WriteLine($"du fick {score} poäng! du kan väll göra bättre");
      Console.WriteLine("");
      Console.WriteLine("Klicka på <Backspace> för att avsluta: ");
      Console.WriteLine("Klicka på <Enter> för mer instruktioner: ");
      if (Console.ReadKey().Key == ConsoleKey.Backspace)
      {
         Environment.Exit(0);
      }



   }



}




