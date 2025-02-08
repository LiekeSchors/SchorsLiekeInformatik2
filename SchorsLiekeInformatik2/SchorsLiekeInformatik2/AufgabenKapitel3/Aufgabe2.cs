using System;

namespace SchorsLiekeInformatik2.AufgabenKapitel3 {
    public class Aufgabe2 {
        public void GebeAbbaAus(){
            // Aufgabe 3.2
            // Loesung 1
            // Verwendung der ASCII-Codes, um die Buchstaben zu verwenden.
            char grossesA = Convert.ToChar(65);
            char grossesB = Convert.ToChar(66);

            Console.WriteLine(grossesA.ToString() + grossesB + grossesB +
                              grossesA); // Der erste ToString()-Aufruf reicht, sodass alles als String intepretiert wird

            // Loesung 2
            int grossesCAsciiCode = 67; // Praesentation der Buchstaben durch Ableitung von einem anderen Buchstaben
            Console.WriteLine(Convert.ToChar(grossesCAsciiCode - 2).ToString() + Convert.ToChar(grossesCAsciiCode - 1) +
                              Convert.ToChar(grossesCAsciiCode - 1) + Convert.ToChar(grossesCAsciiCode - 2));
            
            // Loesung 3
            Console.WriteLine("\u0041" + "\u0042" + "\u0042" + "\u0041"); // Praesentation mit Hilfe der Unicode-Codes
            
            // Loesung 4
            // Ohne Verwendung von den Grossbuchstaben: Kleinbuchstaben zu Uppercase. 
            Console.WriteLine("a".ToUpper() + "b".ToUpper() + "b".ToUpper() + "a".ToUpper());
        }
    }
}