# Informationen

## Projekt

### Allgemein

In diesem Projekt werden primär die Grundlagen von [System.Data.DataSet](https://docs.microsoft.com/de-de/dotnet/api/system.data.dataset) in *C#* erlernt.
Der DataSet-Designer von Visual Studio wird eingesetzt.
Weiterhin wird das professionelle Arbeiten mit dem Versionskontrollsystem [Git](https://git-scm.com/) und dem Dokumentationsgenerator [Doxygen](https://www.doxygen.nl/) trainiert.

### Aufgabenstellung

Eine tastaturgesteuerte Konsolenanwendung simuliert ein Einkaufszentrum.
Der Zustand des Einkaufszentrums kann als Datensatz gespeichert und geladen werden.
Die Daten sind zur Programmlaufzeit in einem *DataSet* enthalten.
Die Datenverarbeitung erfolgt durch sinnvoll strukturierte Klassenobjekte.

Das Einkaufszentrum besteht aus

- mehreren Geschäften,
- mit vielen verschiedenen Produkten (Nahrung, Kleidung, Geräte, Spielzeug etc.),
- festem Personal (Manager, Mitarbeiter, Lieferanten),
- registrierten Kunden, die mit einer Warscheinlichkeit Einkäufe tätigen,
- einem realitätsnahen Finanzsystem (Einnahmen, Ausgaben)

## Repository

### Branches

In der Entwicklungsphase wird der Code incl. Dokumentation etc. in **dev** geschrieben.
Zu geeigneten Zeitpunkten wird eine Testphase initiiert.
Auftretende Bugs, Fehler etc. werden in **test** behoben bzw. korrigiert.
Wenn große Änderungen notwendig sind, werden diese in **dev** getätigt.
In **master** werden die erfolgreich getesteten Versionen veröffentlicht.

- **master** Release **&larr; test** Test **&harr; dev** Entwicklung

Ein Hotfix für **master** wird in **hf** implementiert und getestet.
Er muss zeitnah in **dev** integriert werden bevor eine neu Testphase beginnt.

- **hf** Hotfix &harr; **master &rarr; dev**
