

// ============================================================
//  Aufgabe: Programmablaufplan – BMI-Rechner
//  Fach:    C# Grundlagen
//  Name:    [DEIN NAME HIER]
//  Datum:   [DATUM HIER]
// ============================================================
//
// AUFGABE 1 – Beantworte folgende Fragen hier als Kommentar:
//
// Frage 1: Wie viele Entscheidungsknoten (Rauten) hat der PAP?
// Antwort: 6
//
// Frage 2: Unter welchen Bedingungen endet das Programm frühzeitig?
// Antwort: tryparse scheitert oder größe !(größe >=)
// 
// Frage 3: Warum wird TryParse statt Convert.ToDouble() verwendet?
// Antwort: Weil so erkannt wird, ob er der Eingabewert numerisch und ein Fehler wegen falschen Zeichen verhindert wird 
//
// Frage 4: Welchen Datentyp sollen gewicht und groesse haben, und warum?
// Antwort: da mit Kommazahlen gearbeitet wird, empfiehlt sich double
//
// ============================================================

// TODO: Schreibe dein Programm unterhalb dieser Zeile.
//       Orientiere dich dabei am PAP in der README.md.
//       Jeder Schritt im PAP sollte einer Zeile / einem Block in deinem Code entsprechen.

using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;


//Variablen
string name;
double height=0;
double weight=0;
bool check = false;
string input;
double bmi = 0;
string categorie = "";

//Programmstart String
Console.WriteLine("╔══════════════════════════════════╗");
Console.WriteLine("║        BMI - Rechner v1.0        ║");
Console.WriteLine("╚══════════════════════════════════╝");
//Eingabe Name
Console.WriteLine("BITTE NAMEN EINGEBEN!");
name = Console.ReadLine();
//Eingabe Gewicht
Console.WriteLine("BITTE GEWICHT IN KG EINGEBEN!");
input = Console.ReadLine(); 
//Test Gewicht
check = double.TryParse(input, out weight);
//Test bestanden
if (check)
{   // Eingabe Größe
    Console.WriteLine("BITTE GRÖSSE IN METER EINGEBEN!");
    input = Console.ReadLine();
    //Test Größe 1
    check = double.TryParse(input, out height);
    if (check)
    //Test Größe 2
    {
        if (height > 0)
        {
            //bmi berechnen
            bmi = weight / Math.Pow(height, 2);

            //Zuweisung Kategorie
            if (bmi < 18.5)
                categorie = "\"UNTERGEWICHT\"";
            else if (bmi < 25)
                categorie = "\"NORMALGEWICHT\"";
            else if (bmi < 30)
                categorie = "\"ÜBERGEWICHT\"";
            else
                categorie = "\"STARKES ÜBERGEWICHT\"";


            //Endausgabe

            Console.WriteLine("──────────────────────────────────");
            Console.WriteLine($"📊 Ergebnis für {name}");
            Console.WriteLine("──────────────────────────────────");
            Console.WriteLine($"BMI: {bmi}");
            Console.WriteLine($"Kategorie: {categorie}");
            Console.WriteLine("──────────────────────────────────");






        }
        else
            //Fehlermeldung Größe
            Console.WriteLine("GRÖSSE MUSS > 0 SEIN.");
    }
    else
        Console.WriteLine("KEINE ZAHL EINGEGEBEN");



}

else
    Console.WriteLine("KEINE ZAHL EINGEGEBEN");













// ── Schritt 1: Programmtitel ausgeben ───────────────────────
// Tipp: Nutze Console.WriteLine() für die Titelbox.
// TODO: Ausgabe der Titelzeile (wie im Beispiel in der README)


// ── Schritt 2: Eingabe – Name ────────────────────────────────
// TODO: Benutzernamen einlesen (string, kein TryParse nötig)


// ── Schritt 3: Eingabe – Gewicht mit Validierung ─────────────
// TODO: Gewicht als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)


// ── Schritt 4: Eingabe – Größe mit Validierung ───────────────
// TODO: Körpergröße als Text einlesen
// TODO: Mit double.TryParse() in eine Zahl umwandeln
// TODO: Falls ungültig → Fehlermeldung ausgeben und Programm beenden (return)
// TODO: Zusätzlich prüfen: Ist die Größe größer als 0?
//       Falls nicht → eigene Fehlermeldung und Programm beenden (return)


// ── Schritt 5: BMI berechnen ─────────────────────────────────
// Formel: BMI = Gewicht / (Größe * Größe)
// TODO: BMI berechnen und in einer Variablen speichern


// ── Schritt 6: Kategorie bestimmen ───────────────────────────
// TODO: Erstelle eine string-Variable "kategorie"
// TODO: Bestimme die Kategorie über eine if-else-if-Kette:
//       BMI < 18.5        → "Untergewicht"
//       BMI < 25.0        → "Normalgewicht"
//       BMI < 30.0        → "Übergewicht"
//       sonst (else)      → "Starkes Übergewicht"
//
// 💭 Denkfrage: Warum reicht bei "Normalgewicht" die Bedingung BMI < 25.0 aus,
//               obwohl laut WHO-Tabelle auch BMI >= 18.5 gelten muss?


// ── Schritt 7: Ergebnis ausgeben ─────────────────────────────
// TODO: Gib Name, BMI (auf 2 Dezimalstellen) und Kategorie formatiert aus
// Tipp: Nutze z.B. $"{bmi:F2}" für 2 Nachkommastellen
