using System;
using static SchorsLiekeInformatik2.AufgabenKapitel3.Aufgabe1;

namespace SchorsLiekeInformatik2.AufgabenKapitel3 {
    public class Aufgabe3 {
        public void BerechneErloes(){
            // Aufgabe 3.3
            double fixKosten = 0.0;
            double produktKosten = 0.0;
            double erloes = 0.0;
            int produktionsMenge = 0;

            Console.WriteLine("Berechnen Sie den Erlös Ihres Produkts.");

            Console.WriteLine("Bitte geben Sie die einmaligen Fixkosten ein: ");
            while (fixKosten <= 0) {
                fixKosten = (double)CheckDataTypeInInput(GeldbetragError, Datentyp.Double);
            }

            Console.WriteLine("Wie viele Produkte sollen hergestellt werden?");
            while (produktionsMenge <= 0) {
                produktionsMenge = (int)CheckDataTypeInInput(IntegerError, Datentyp.Integer);
            }

            Console.WriteLine("Bitte geben Sie die Kosten für ein Produkt ein: ");
            while (produktKosten <= 0) {
                produktKosten = (double)CheckDataTypeInInput(GeldbetragError, Datentyp.Double);
            }

            Console.WriteLine("Bitte geben Sie den Erlös für ein Produkt ein: ");
            while (erloes <= 0) {
                erloes = (double)CheckDataTypeInInput(GeldbetragError, Datentyp.Double);
            }

            double gesamtKosten =
                fixKosten + (produktKosten * produktionsMenge); // Die Fixkosten werden nur 1x berechnet
            double gesamtErloes = erloes * produktionsMenge;
            double gewinn = gesamtErloes - gesamtKosten;

            Console.WriteLine("Der Gewinn beträgt: " + gewinn + "€!");
        }
    }
}