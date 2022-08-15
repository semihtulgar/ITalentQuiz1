// See https://aka.ms/new-console-template for more information

using Abstraction;

Cake cake = new Cake();
cake.Material = new List<string>() { "Yumurta", "Süt", "Şeker", "Portakal", "Kabarta Tozu" };
cake.PrepareCake(cake.Material);