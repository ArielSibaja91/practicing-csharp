using PooCsharp.UFC;

Fighter brawler = new Fighter("Ilia Topuria", 29, "Boxing", 17);
var boxer = new Boxer("Tyson Fury", 36, "Boxing", 34, "Orthodox");

Console.WriteLine(brawler.BruceBuffer());
Console.WriteLine(boxer.BruceBuffer());
Console.WriteLine(brawler.BruceBuffer("In the red corner: "));
Console.WriteLine(brawler.BruceBuffer(3));