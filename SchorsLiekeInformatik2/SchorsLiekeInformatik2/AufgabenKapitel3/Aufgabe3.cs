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
            fixKosten = (double) CheckDataTypeInInput(GeldbetragError, Datentyp.Double);
        
            Console.WriteLine("Bitte geben Sie die Kosten für ein Produkt ein: ");
            produktKosten = (double) CheckDataTypeInInput(GeldbetragError, Datentyp.Double);
        
            Console.WriteLine("Bitte geben Sie den Erlös für ein Produkt ein: ");
            erloes = (double) CheckDataTypeInInput(GeldbetragError, Datentyp.Double);
        
            Console.WriteLine("Wie viele Produkte sollen hergestellt werden?");
            produktionsMenge = (int) CheckDataTypeInInput(IntegerError, Datentyp.Integer);
        
            double gesamtKosten = fixKosten + (produktKosten * produktionsMenge); // Die Fixkosten werden nur 1x berechnet
            double gesamtErloes = erloes * produktionsMenge;
            double gewinn = gesamtErloes - gesamtKosten;
        
            Console.WriteLine("Der Gewinn beträgt: " + gewinn + " Euro!");
        }
    }
}