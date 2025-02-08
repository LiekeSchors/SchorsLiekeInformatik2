using System;

namespace SchorsLiekeInformatik2.AufgabenKapitel3 {
    class Aufgabe1 {
        public void BerechneKapital(){
            // Aufgabe 3.1
            Console.WriteLine("Bitte geben Sie das Startkapital ein: ");
            double startKapital = CheckDoubleDataTypeInInput(GeldbetragError);
            // TODO: Pruefen, dass groesser 0
            
            
            Console.WriteLine("Bitte geben Sie den Zinssatz in % ein: ");
            double zinssatz = CheckDoubleDataTypeInInput(
                "Bitte geben Sie einen Prozentsatz ein. Buchstaben sind nicht erlaubt.");
            
            Console.WriteLine("Bitte geben Sie die Spardauer in ganzen Jahren an: ");
            int dauer = CheckIntegerDataTypeInInput(IntegerError);
            // TODO: Pruefen, dass groesser 0
            
            
            Console.WriteLine("Startkapital: " + startKapital + " Euro");
            Console.WriteLine("Zinssatz: " + zinssatz + "%");

            double endkapital = startKapital; // Fuer den Anfang ist das Endkapital so gross wie das Endkapital.
            for (int i = 0; i < dauer; i++) {
                // das wird der Dauer entsprechend wiederholt, mit immer dem neuen Endkapital als neuer Input
                endkapital += endkapital * (zinssatz / 100);

                if (i != dauer - 1) {
                    // Fuer jedes Jahr die neue Ausgangslage anzeigen, ausser fuer das letzte.
                    int jahr = i + 1;
                    Console.WriteLine("Kapital nach Jahr " + jahr + ": " + endkapital + " Euro");
                }
            }

            endkapital = Math.Round(endkapital, 2);
            string jahrSubstantivNumerus;
            if (dauer != 1) {
                jahrSubstantivNumerus = "Jahren: ";
            }
            else {
                jahrSubstantivNumerus = "Jahr: ";
            }

            Console.WriteLine("Endkapital nach " + dauer + jahrSubstantivNumerus + endkapital + " Euro");
        }


        // TODO ACHTUNG
        // TODO ACHTUNG: Nicht auskommentieren! Wird in Aufgabe 3 benoetigt 
        // TODO ACHTUNG

        // TODO: Methode so anpassen, dass nur eine notwendig ist und Pruefung abhaengig vom Input erfolgt.


        public static string GeldbetragError = "Bitte geben Sie einen Geldbetrag ein. Buchstaben sind nicht erlaubt.";

        /**
         * Methode, die den String-Input darauf ueberprueft, ob dieser in ein Double umgewandelt werden kann.
         * Dies wird solange gemacht, bis der Input passt.
         */
        public static double CheckDoubleDataTypeInInput(string errorMessage){
            double eingabeAlsDouble = 0.0;

            bool richtgerDatentyp = false;

            while (!richtgerDatentyp) {
                try {
                    string eingabeAlsString = Console.ReadLine(); // TODO: Nullsafe machen
                    eingabeAlsDouble = Convert.ToDouble(eingabeAlsString);
                    richtgerDatentyp = true;
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine(errorMessage);
                    // Evtl. abbrechen, wenn die Eingabe zu oft falsch ist.
                }
            }

            return eingabeAlsDouble;
        }

        public static string IntegerError = "Bitte geben Sie eine Ganzzahl ein. Buchstaben sind nicht erlaubt.";

        /**
         * Methode, die den String-Input darauf ueberprueft, ob dieser in einen Integer umgewandelt werden kann.
         * Dies wird solange gemacht, bis der Input passt.
         */
        public static int CheckIntegerDataTypeInInput(string errorMessage){
            int eingabeAlsInteger = 0;

            bool richtgerDatentyp = false;

            while (!richtgerDatentyp) {
                try {
                    string eingabeAlsString = Console.ReadLine(); // TODO: Nullsafe machen
                    eingabeAlsInteger = Convert.ToInt32(eingabeAlsString);
                    richtgerDatentyp = true;
                    break;
                }
                catch (FormatException) {
                    Console.WriteLine(errorMessage);
                    // Evtl. abbrechen, wenn die Eingabe zu oft falsch ist.
                }
            }

            return eingabeAlsInteger;
        }
    }
}