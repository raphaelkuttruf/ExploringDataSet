using System;

/// <summary>
/// Implemetierung einer Konsolenanwendung
/// 
/// Hier wird ein benutzerdefiniertes System.Data.DataSet erstellt und in einem Anwendungsbeispiel genutzt.
/// </summary>
namespace ExploringDataSet
{
    /// <summary>
    /// Programmeinstieg
    /// 
    /// Es ist nur ein kleines Konsolenprogramm.
    /// \image html ConsoleHelloWorld.png
    /// Bitte bleiben Sie ruhig, falls Sie einen Fehler entdecken.
    /// Feedback und Fehlerreports sind jeder Zeit willkommen.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Hauptfunktion des Programms
        /// 
        /// Es beginnt mit der Textausgabe "Hello World!"
        /// </summary>
        /// <param name="args">Nicht verwendet</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Erstelle Datensatz
            MallDataSet mall = new MallDataSet();
            mall.DataSetName = "Raphaels Mall";



            // Lade alten Datensatz aus Datei
            Console.WriteLine("Alten Datensatz laden? [ja]");
            if (Console.ReadLine().Contains("ja"))
                mall.ReadXml(mall.DataSetName);



            // Speichere aktuellen Datensatz in Datei
            mall.WriteXml(mall.DataSetName);
        }
    }
}
