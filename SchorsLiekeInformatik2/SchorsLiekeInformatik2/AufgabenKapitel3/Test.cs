using static SchorsLiekeInformatik2.AufgabenKapitel3.Aufgabe1;
using System;

namespace SchorsLiekeInformatik2.AufgabenKapitel3 {
    public class Test {
        static void Main(){
            bool naechsteAufgabe;

            do {
                Console.WriteLine("Welche Aufgabe möchten Sie testen?");
                int aufgabe = 0;

                while (aufgabe < 1 || aufgabe > 4) {
                    Console.WriteLine("Wählen Sie eine Zahl von 1 bis 4.");
                    aufgabe = CheckIntegerDataTypeInInput(IntegerError);
                }

                switch (aufgabe) {
                    case 1:
                        Aufgabe1 aufgabe1 = new Aufgabe1();
                        aufgabe1.BerechneKapital();
                        break;
                    case 2:
                        Aufgabe2 aufgabe2 = new Aufgabe2();
                        aufgabe2.GebeABBAAus();
                        break;
                    case 3:
                        Aufgabe3 aufgabe3 = new Aufgabe3();
                        aufgabe3.BerechneErloes();
                        break;
                    case 4:
                        Aufgabe4 aufgabe4 = new Aufgabe4();
                        aufgabe4.LoeseLineareGleichung();
                        break;
                }

                Console.WriteLine("Möchten sie noch eine Aufgabe testen? Drücken Sie 'j' für 'Ja', 'n' für 'Nein'.");
                string wahl = Console.ReadLine();
                if (wahl == "j") {
                    naechsteAufgabe = true;
                }
                else {
                    naechsteAufgabe = false;
                    Console.WriteLine("Das Programm wird beendet...");
                }
                
                Console.WriteLine();
                
            } while (naechsteAufgabe);
        }
    }
}