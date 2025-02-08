using System;

namespace SchorsLiekeInformatik2.AufgabenKapitel3 {
    public class Aufgabe4 {
        public void LoeseLineareGleichung(){
            // Aufgabe 3.4
            Console.WriteLine("Gleichung: ax + b = 0");

            Console.WriteLine("Geben Sie einen Werte für die Variable a ein: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben Sie einen Werte für die Variable b ein: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int x = -b / a;

            Console.WriteLine("Die Lösung lautet: x = " + x);
        }
    }
}