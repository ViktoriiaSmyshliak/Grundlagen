using System;

public static class Branching
{
    // IF statements
    public static void IfStatements()
    {
        // check current time
        DateTime now = DateTime.Now;

        // output greeting before 9:00
        if (now.Hour < 9)
        {
            Console.WriteLine("Guten Morgen!");
        }

        // sun condition
        bool sonneScheint = true;

        // output depending on sun
        if (sonneScheint)
        {
            Console.WriteLine("Ich sollte die Blumen gießen.");
        }
        else
        {
            Console.WriteLine("Wann wird's mal wieder richtig Sommer?");
        }

        // vacation and weekend logic
        bool urlaub = false;
        bool wochenende = true;

        if (urlaub)
        {
            Console.WriteLine("Am Strand ist es so schön!");
        }
        else if (wochenende)
        {
            Console.WriteLine("Ab in den Garten...");
        }
        else
        {
            Console.WriteLine("Ich muss wohl lernen.");
        }
    }

    // SWITCH statement
    public static void SwitchStatement()
    {
        int note = 1;
        bool zertifikat = true;
        // convert numeric grade to text
       switch (note)
    {
        case 1 when zertifikat:
            Console.WriteLine("Sie haben am Kurs mit sehr gutem Erfolg teilgenommen.");
            break;

        case 2 when zertifikat:
            Console.WriteLine("Sie haben am Kurs mit gutem Erfolg teilgenommen.");
            break;

        case 3 when zertifikat:
        case 4 when zertifikat:
            Console.WriteLine("Sie haben am Kurs mit Erfolg teilgenommen.");
            break;

        case 5 when zertifikat:
        case 6 when zertifikat:
            Console.WriteLine("Sie haben am Kurs teilgenommen.");
            break;

        case 1:
            Console.WriteLine("Die Note 1 ist sehr gut.");
            break;

        case 2:
            Console.WriteLine("Die Note 2 ist gut.");
            break;

        case 3:
            Console.WriteLine("Die Note 3 ist befriedigend.");
            break;

        case 4:
            Console.WriteLine("Die Note 4 ist ausreichend.");
            break;

        case 5:
            Console.WriteLine("Die Note 5 ist mangelhaft.");
            break;

        case 6:
            Console.WriteLine("Die Note 6 ist ungenügend.");
            break;

        default:
            Console.WriteLine("Sie haben am Kurs nicht teilgenommen.");
            break;
    }

    }

    // SWITCH with certificate logic
    public static void SwitchWithCertificate()
    {
        int note = 3;
        bool zertifikat = true;

        // switch with grouped cases
        switch (note)
        {
            case 1:
                Console.WriteLine(
                    zertifikat
                        ? "Sie haben am Kurs mit sehr gutem Erfolg teilgenommen."
                        : "sehr gut"
                );
                break;

            case 2:
                Console.WriteLine(
                    zertifikat
                        ? "Sie haben am Kurs mit gutem Erfolg teilgenommen."
                        : "gut"
                );
                break;

            case 3:
            case 4:
                Console.WriteLine(
                    zertifikat
                        ? "Sie haben am Kurs mit Erfolg teilgenommen."
                        : "befriedigend / ausreichend"
                );
                break;

            case 5:
            case 6:
                Console.WriteLine(
                    zertifikat
                        ? "Sie haben am Kurs teilgenommen."
                        : "mangelhaft / ungenügend"
                );
                break;

            default:
                Console.WriteLine("Sie haben am Kurs nicht teilgenommen.");
                break;
        }
    }
}
