using System;

namespace SchorsLiekeInformatik2.AufgabenKapitel3 {
    public class Aufgabe2 {
        public void GebeAbbaAus(){
            // Aufgabe 3.2
            char grossesA = Convert.ToChar(65);
            char grossesB = Convert.ToChar(66);

            // Loesung 1
            Console.WriteLine(grossesA.ToString() + grossesB + grossesB +
                              grossesA); // Der erste ToString()-Aufruf reicht, sodass alles als String intepretiert wird

            // Loesung 2
            int grossesCAsciiCode = 67;
            Console.WriteLine(Convert.ToChar(grossesCAsciiCode - 2).ToString() + Convert.ToChar(grossesCAsciiCode - 1) +
                              Convert.ToChar(grossesCAsciiCode - 1) + Convert.ToChar(grossesCAsciiCode - 2));
        }
    }
}