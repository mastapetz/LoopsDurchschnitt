namespace LoopsDurchschnitt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            notenDurchschnitt();

        }
        static int notenEingabe;
        static string notenString = "0";
        static int stringToNumber;
        static int notenCount;
        static int notenSumme = 0;
        static int notenAvg;
        //static int notenAvgMod;
        static double notenAvgD;
        static void notenDurchschnitt()
        {


            while (notenEingabe != -1)
            {
                Console.WriteLine("Bitte Note eingen. -1 Bendet die eingabe");
                //notenEingabe = Convert.ToInt32(Console.ReadLine());
                notenString = Console.ReadLine();
                if (int.TryParse(notenString, out stringToNumber))
                {
                    notenEingabe = stringToNumber;
                }
                else
                {
                    Console.WriteLine("Muss eine Zahl Sein.");
                    continue;
                }
                if (notenEingabe > 0 && notenEingabe < 7)
                {
                    notenCount++;
                    notenSumme += notenEingabe;
                    notenAvg = notenSumme / notenCount;
                    //notenAvgMod = notenSumme % notenCount; //Zeigt NICHT das richtige an
                    notenAvgD = (double)notenSumme / (double)notenCount;
                    Console.WriteLine("Noten: {0} Durchschnitt: {1} \n In doubles {2}", notenCount, notenAvg, notenAvgD);

                }
                else
                {
                    Console.WriteLine("Notenwerte zwischen 1 und 6!");
                }
            }
            //Console.WriteLine("bei {0} Schülern  is der Enddurchschnit {1}", notenCount, notenAvg);
            Console.WriteLine("Endwert: \n Noten: {0} Durchschnitt: {1} \n In doubles {2}", notenCount, notenAvg, notenAvgD);
            Console.ReadKey();

        }
    }
}