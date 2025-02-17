using System;

namespace SchorsLiekeInformatik2.AufgabenKapitel3 {
    public class Aufgabe4 {
        public void LoeseLineareGleichung(){
            // Aufgabe 3.4
            Console.WriteLine("Gleichung: ax + b = 0");

            // a und b duerfen nicht 0 sein, da dies zu unendlichen oder unrealistischen Ergebnissen fuehrt. (0 = 0 (unendlich) oder 0 != 0)

            int a;
            Console.WriteLine("Geben Sie einen Wert für die Variable a ein: ");
            // Ueberprueft, ob die Eingabe als int geparsed werden kann und macht dies, wenn dem so ist, sonst folgt die Fehlermeldung.
            while (!int.TryParse(Console.ReadLine(), out a) || a == 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a darf nicht 0 und muss eine Zahl sein.");
                Console.ResetColor();
            }

            int b;
            Console.WriteLine("Geben Sie einen Wert für die Variable b ein: ");
            while (!int.TryParse(Console.ReadLine(), out b) || b == 0) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("b darf nicht 0 und muss eine Zahl sein.");
                Console.ResetColor();
            }

            // Berechnung als double, da das Ergebnis keine Ganzzahl sein muss
            double x = -((double)b / a);
            Console.WriteLine("Die Lösung ist: x = " + x);
        }
    }
}