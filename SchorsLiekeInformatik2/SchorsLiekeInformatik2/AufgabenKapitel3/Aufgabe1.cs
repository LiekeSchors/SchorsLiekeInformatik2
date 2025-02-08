using System;

namespace SchorsLiekeInformatik2.AufgabenKapitel3 {
    class Aufgabe1 {
        public void BerechneKapital(){
            // Aufgabe 3.1
            Console.WriteLine("Bitte geben Sie das Startkapital ein: ");
            double startKapital = 0;
            while (startKapital <= 0.0) {
                startKapital = (double) CheckDataTypeInInput(GeldbetragError, Datentyp.Double);
            }

            Console.WriteLine("Bitte geben Sie den Zinssatz in % ein: ");
            double zinssatz = 0;
            while (zinssatz <= 0.0) {
                zinssatz = (double) CheckDataTypeInInput(
                    "Bitte geben Sie einen Prozentsatz ein. Buchstaben sind nicht erlaubt.", Datentyp.Double);
            }

            Console.WriteLine("Bitte geben Sie die Spardauer in ganzen Jahren an: ");
            int dauer = 0;
            while (dauer <= 0) {
                dauer = (int) CheckDataTypeInInput(IntegerError, Datentyp.Integer);
            }

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

            endkapital = Math.Round(endkapital, 3); // Runden auf 3 Nachkommastellen (s. Endkapital in Aufgabe)
            string jahrSubstantivNumerus;
            if (dauer != 1) {
                jahrSubstantivNumerus = " Jahren: ";
            }
            else {
                jahrSubstantivNumerus = " Jahr: ";
            }

            Console.WriteLine("Endkapital nach " + dauer + jahrSubstantivNumerus + endkapital + " Euro");
        }

        // TODO: Fehlertexte in Art PropertiesFile auslagern
        public static string GeldbetragError = "Bitte geben Sie einen Geldbetrag > 0.0 ein. Buchstaben sind nicht erlaubt.";

        public static string IntegerError = "Bitte geben Sie eine Ganzzahl > 0 ein. Buchstaben sind nicht erlaubt.";

        /**
         * Methode, die den String-Input darauf ueberprueft, ob dieser in den gewuenschten Datentyp umgewandelt werden kann.
         * Dies wird solange gemacht, bis der Input passt.
         */
        public static Object CheckDataTypeInInput(string errorMessage, Datentyp datentyp){
            Object konvertierterInput = null;
            bool richtgerDatentyp = false;

            while (!richtgerDatentyp) {
                try {
                    string eingabeAlsString = Console.ReadLine(); // Muesste noch gegen NPE abgesichert werden
                    switch (datentyp) {
                        case Datentyp.Double:
                            konvertierterInput = Convert.ToDouble(eingabeAlsString);
                            richtgerDatentyp = true;
                            break;
                        case Datentyp.Integer:
                            konvertierterInput = Convert.ToInt32(eingabeAlsString); // ToInt32 konvertiert zu int
                            richtgerDatentyp = true;
                            break;
                        default:
                            Console.WriteLine("Dieser Datentyp kann noch nicht überprüft werden.");
                            break;
                    }
                }
                catch (FormatException) {
                    Console.WriteLine(errorMessage);
                    // Evtl. abbrechen, wenn die Eingabe zu oft falsch ist.
                }
            }

            return konvertierterInput;
        }
    }
}