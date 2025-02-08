using System;
using static SchorsLiekeInformatik2.AufgabenKapitel3.Aufgabe1;

namespace SchorsLiekeInformatik2.AufgabenKapitel3
{
    public class Aufgabe3
    {
        public void BerechneErloes() {
            // Aufgabe 3.3
            double fixKosten;
            double produktKosten;
            double erloes;
            int produktionsMenge;
        
            Console.WriteLine("Bitte geben Sie die fixen Kosten ein: ");
            fixKosten = CheckDoubleDataTypeInInput(GeldbetragError);
        
            Console.WriteLine("Bitte geben Sie die Kosten für ein Produkt ein: ");
            produktKosten = CheckDoubleDataTypeInInput(GeldbetragError);
        
            Console.WriteLine("Bitte geben Sie den Erlös für ein Produkt ein: ");
            erloes = CheckDoubleDataTypeInInput(GeldbetragError);
        
            Console.WriteLine("Wie viele Produkte sollen hergestellt werden?");
            produktionsMenge = Convert.ToInt32(Console.ReadLine()); // int32 kovertiert zu int
        
            double gesamtKosten = fixKosten + (produktKosten * produktionsMenge);
            double gesamtErloes = erloes * produktionsMenge;
            double gewinn = gesamtErloes - gesamtKosten;
        
            Console.WriteLine("Der Gewinn beträgt: " + gewinn + " Euro!");
        }
    }
}