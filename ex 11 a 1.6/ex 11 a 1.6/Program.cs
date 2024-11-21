using System;

using System.IO;



class Program

{

    static void Main()

    const string FILE_NAME = "Bonus3TXT";

    StreamReader Bonus;
    string linia;
    int NUMbILLETS;
    int billetsPremiats;
    int importTotal;

    fBonus= new Stream(FILE_NAME);
    importTotal=0;

    lina=fBonus.ReadLine();
    numBillets=Convert.ToInt32(linia);

    for(int i=1; i<=numBillets,i++);

     {
     linia=fBonus.ReadLine();

         if (linuia=="BONUS");

        {
        BILLETS pREMIATS++
        importTotal= importTotal+Convert.ToI328FbONUS.rEADlINE());
        }
     }
     {
    fBonus.Close();

       Console.WriteLine($"billetsPremiats PREMIATS"{ TOTALBILLETSPREMIATS} "");
      Console.WriteLine($"import total"{ importTotal total} "");
    ColeLine($"percentatge premiats"{ billets`premiats / numBilllets * 100} "");
     } 