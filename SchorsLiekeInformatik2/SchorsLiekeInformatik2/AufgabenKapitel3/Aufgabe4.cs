using System;

namespace SchorsLiekeInformatik2.AufgabenKapitel3 {
    public class Aufgabe4 {
        public void LoeseLineareGleichung(){
            // Aufgabe 3.4
            Console.WriteLine("Gleichung: ax + b = 0");

            int a;
            Console.WriteLine("Geben Sie einen Wert für die Variable a ein: ");
            // Ueberprueft, ob die Eingabe als int geparsed werden kann und macht dies, wenn dem so ist, sonst folgt die Fehlermeldung.
            while (!int.TryParse(Console.ReadLine(), out a)) {
                Console.WriteLine("Geben Sie eine Ganzzahl ein. Buchstaben und Kommazahlen sind nicht erlaubt.");
            }
            
            int b;
            Console.WriteLine("Geben Sie einen Wert für die Variable b ein: ");
            while (!int.TryParse(Console.ReadLine(), out b)) {
                Console.WriteLine("Geben Sie eine Ganzzahl ein. Buchstaben und Kommazahlen sind nicht erlaubt.");
            }
            

            if (a == 0) {
                if (b == 0)
                    Console.WriteLine("Unendlich viele Lösungen: 0 = 0.");
                else
                    Console.WriteLine("Keine Lösung: Widerspruch.");
            }
            else {
                // Berechnung als double, da das Ergebnis keine Ganzzahl sein muss
                double x = -((double)b / a);
                Console.WriteLine("Die Lösung ist: x = " + x);
            }
        }
    }
}