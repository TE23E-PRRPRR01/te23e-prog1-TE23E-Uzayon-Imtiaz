// Console.Clear();
// // Console.WriteLine("Hello, World!");
// // Console.Write("Skriv ditt namn: ");
// // string namn = Console.ReadLine();

// // Console.Write("Ange gatunamn: ");
// // string gatunamn = Console.ReadLine();

// // Console.Write("Ange hemma stad: ");
// // string hemmaStad = Console.ReadLine();

// // // Console.WriteLine(namn);
// // // Console.WriteLine(gatunamn);
// // // Console.WriteLine(hemmaStad);

// // Console.WriteLine($"Hej {namn}. Du bor på {gatunamn}, {hemmaStad}");

// // // Loopa 10 gånger.
// // for (int i = 0; i < 10; i++)
// // {
// //     Console.WriteLine("Katt");
// // }

// // Console.WriteLine("Ange ett lösenord: ");
// // string lösenord = Console.ReadLine();
// // if (lösenord == "Hej")
// // {
// //     for (int i = 0; i < 5; i++)
// //     {
// //         Console.WriteLine("Hej! Välkommen.");
// //     }

// // }
// // else
// // {
// //     for (int i = 0; i < 10; i++)
// //     {
// //         Console.WriteLine("Fel lösenord.");
// //     }
// // }

// Console.Write("Ange ditt namn: ");
// string namn = Console.ReadLine();

// // for (int i = 0; i < 5; i++)
// // {
// //     Console.WriteLine("Ange lösenord: ");
// //     string lösenord = Console.ReadLine();
// //     if (lösenord == "Hej")
// //     {
// //         break;
// //     }
// //     else
// //     {
// //         Console.WriteLine("Fel lösenord.");
// //     }
// // }

// while (true)
// {
//     Console.Write("Ange lösenord: ");
//     string lösenord = Console.ReadLine();
//     if (lösenord == "Hej")
//     {
//         break;
//     }
// }
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine("Välkommen");
// }

// Console.Write("Hur gammal är du? ");
// int ålder = int.Parse(Console.ReadLine());

// Console.WriteLine($"Hej {namn} du är {ålder} år.");

// int nyÅlder = ålder + 6;

// Console.WriteLine($"År 2030 är du {nyÅlder} år gammal.");

// // Console.Write("Vilken månad är du född? (jan, feb, ...) ");
// // string månad = Console.ReadLine();

// // if (månad == "jan")
// // {
// //     Console.WriteLine("Du är född i Januari.");
// // }
// // else if (månad == "feb")
// // {
// //     Console.WriteLine("Du är född i Februari.");
// // }
// // else if (månad == "mar")
// // {
// //     Console.WriteLine("Du är född i Mars.");
// // }
// // else if (månad == "apr")
// // {
// //     Console.WriteLine("Du är född i April.");
// // }
// // else if (månad == "maj")
// // {
// //     Console.WriteLine("Du är född i Maj.");
// // }
// // else if (månad == "jun")
// // {
// //     Console.WriteLine("Du är född i Juni.");
// // }
// // else if (månad == "jul")
// // {
// //     Console.WriteLine("Du är född i July.");
// // }
// // else if (månad == "aug")
// // {
// //     Console.WriteLine("Du är född i Augusti.");
// // }
// // else if (månad == "sep")
// // {
// //     Console.WriteLine("Du är född i September.");
// // }
// // else if (månad == "okt")
// // {
// //     Console.WriteLine("Du är född i Oktober.");
// // }
// // else if (månad == "nov")
// // {
// //     Console.WriteLine("Du är född i November.");
// // }
// // else if (månad == "dec")
// // {
// //     Console.WriteLine("Du är född i December.");
// // }
// Console.Write("Vilken månad är du född i? (1-12): ");
// int månadTal = int.Parse(Console.ReadLine());
// string månad = "";
// if (månadTal == 1)
// {
//     Console.WriteLine("Du är född i Januari.");
//     månad = "Januari";
// }
// else if (månadTal == 2)
// {
//     Console.WriteLine("Du är född i Februari.");
//     månad = "Februari";
// }
// else if (månadTal == 3)
// {
//     Console.WriteLine("Du är född i Mars.");
//     månad = "Mars";
// }
// else if (månadTal == 4)
// {
//     Console.WriteLine("Du är född i April.");
//     månad = "April";
// }
// else if (månadTal == 5)
// {
//     Console.WriteLine("Du är född i Maj.");
//     månad = "Maj";
// }
// else if (månadTal == 6)
// {
//     Console.WriteLine("Du är född i Juni.");
//     månad = "Juni";
// }
// else if (månadTal == 7)
// {
//     Console.WriteLine("Du är född i July.");
//     månad = "July";
// }
// else if (månadTal == 8)
// {
//     Console.WriteLine("Du är född i Augusti.");
//     månad = "Augusti";
// }
// else if (månadTal == 9)
// {
//     Console.WriteLine("Du är född i September.");
//     månad = "September";
// }
// else if (månadTal == 10)
// {
//     Console.WriteLine("Du är född i Oktober.");
//     månad = "Oktober";
// }
// else if (månadTal == 11)
// {
//     Console.WriteLine("Du är född i November.");
//     månad = "November";
// }
// else if (månadTal == 12)
// {
//     Console.WriteLine("Du är född i December.");
//     månad = "December";
// }

// Console.Write("Hur många gånger vill du loopa? ");
// int antalLoop = int.Parse(Console.ReadLine());

// Console.WriteLine($"Du vill loopa {antalLoop} gånger.");
// for (int i = 0; i < antalLoop; i++)
// {
//     Console.WriteLine($"Din månad är {månad}.");
// }
Console.Clear();
Console.Write("Ange tal 1: ");
int tal1 = int.Parse(Console.ReadLine());
Console.Write("Ange tal 2: ");
int tal2 = int.Parse(Console.ReadLine());
int summa = tal1 + tal2;
Console.WriteLine($"Summan av tal 1 och tal 2 är {summa}.");
int produkt = tal1 * tal2;
Console.WriteLine($"Produkten av tal 1 och tal 2 är {produkt}.");
int diffrens = tal1 - tal2;
Console.WriteLine($"Diffrensen av tal 1 och tal 2 är {diffrens}.");
int kvot = tal1 / tal2;
Console.WriteLine($"Kvoten av tal 1 och tal 2 är {kvot}.");
