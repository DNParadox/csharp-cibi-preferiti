internal class Program
{
    public static void Main(string[] args)
    {


        // {
        // Snack 1
        //    Console.WriteLine("Inserisci un numero");
        //    int Es1Numero1 = Convert.ToInt32(Console.ReadLine());

        //  Console.WriteLine("Inserisci un numero");
        //    int Es1numero2 = Convert.ToInt32(Console.ReadLine());
        //    /*L’utente inserisce due numeri in successione.
        //    Il software stampa il maggiore.*/


        //check if the numbers are the same value
        //        if(Es1Numero1 != Es1numero2)
        //       {
        //           //check if the first is bigger then the second
        //            if (Es1Numero1 > Es1numero2)
        //            {
        //                Console.WriteLine("il primo numero è maggiore del secondo");
        //            } else
        //           {
        //                Console.WriteLine("il secondo numero è maggiore del primo");
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("i numeri sono uguali");
        //        }
        //    }


        // Snack 2
        // {
        //    Console.WriteLine("Dimmi una parola");
        //    string Es2parola1 = Console.ReadLine();

       //     Console.WriteLine("Dimmi una parola");
      //      string Es2parola2 = Console.ReadLine();

       //     if (Es2parola1.Length > Es2parola2.Length)
       //     {
       //         Console.WriteLine("Parola 1 è più lunga" +  Es2parola1);
       //     }
       //     else
       //     {
       //         Console.WriteLine("Parola 2 è più lunga " + Es2parola2);
       //     }
       //  }

        // Snack 3
        //{

        //    int sum = 0;

        //    for (int i = 0; i <= 10; i++)
        //    {

        //        Console.WriteLine("inserisci numero");
        //        int numbertosum = Convert.ToInt32(Console.ReadLine());
               
        //        sum += numbertosum;


        //    }

        //    Console.WriteLine("la somma é {0}", sum);

        //}
        // Snack 4

        //{
        //    // Calcola la somma e la media dei numeri da 2 a 10

        //    int media = 0;
        //    int totalciclo = 0;
        //    for ( int i = 2; i < 11; i++)
        //    {
        //        media += i;
        //        totalciclo++;
        //    }

        //    float total = media / totalciclo;
        //    Console.WriteLine(total + "è la tua media");

      //  }

        // Snack 5
        {

            // int number1 = 5;
            // int sum = 0;


            //for (int i = 0; i <= 10; i++)
            //{

            //    console.writeline("inserisci numero");

            //   var test = console.readline();
            //    sum = number1 * i;


            //}

            // console.writeline("somma dinamica" + test2);

            // console.writeline("la somma é " + sum);


            // snack 4 media + somma 

        }
        // Snack 6
        {
            //    /*In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
            //    Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla
            //    festa.*/

            //    string[] nomiInvitati = { "luca", "paolo", "lorenzo" };

            //    Console.WriteLine("scrivi il tuo nome");
            //    string UserName = Console.ReadLine();
            //    bool isIn = false;

            //    for (int i = 0; i < nomiInvitati.Length; i++)
            //    {
            //        if (nomiInvitati[i].Equals(UserName))
            //        {
            //            isIn = true;
            //        }
            //    }

            //    if (isIn)
            //    {
            //        Console.WriteLine("sei nella lista");
            //    } else
            //    {
            //        Console.WriteLine("non sei nella lista");
            //    }
        }
        // Snack 7
        {
            /* Crea un array vuoto.
            Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
            nell’array.*/
            //int[] arrayToSave = new int[6];

            //for (int i = 0; i < arrayToSave.Length; i++)
            //{
            //    Console.WriteLine("scegli un numero");
            //    int userNumber = Convert.ToInt32(Console.ReadLine());

            //    if (userNumber % 2 == 1)
            //    {
            //        arrayToSave[i] = userNumber;
            //    }

            //}

            //for (int i = 0; i < arrayToSave.Length; i++)
            //{
            //    Console.Write(arrayToSave[i] + "-");
            //}
        }
        // Snack 8
        {
            //*Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
            //    posizione dispari.*/
            //    int[] arrayToSave = {1,2,3,4,5,6,7};
            //    int sum = 0;
            //    for (int i = 0; i < arrayToSave.Length; i++)
            //    {
            //        if(i % 2 == 1)
            //        {
            //            sum += arrayToSave[i];
            //        }
            //    }

            //    Console.WriteLine(sum);
        }
        //{
        //    /*Fai inserire un numero, che chiameremo N, all’utente.
        //    Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
        //    Ogni volta che ne crei uno, stampalo a schermo.*/

        //    Console.WriteLine("scegli un numero");
        //    int userNumber = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i < userNumber; i++)
        //    {
        //        int[] arrayToSave = new int[10];

        //        for (int j = 0; j < arrayToSave.Length; j++)
        //        {
        //            Random rd = new Random();
        //            arrayToSave[i] = rd.Next(1, 100);
        //            Console.Write(arrayToSave[i] + "-");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        //{
        //    Console.WriteLine("insert a word");
        //    string firstWord = Console.ReadLine();

        //    Console.WriteLine("insert another word");
        //    string secondWord = Console.ReadLine();

        //    string wardToPrint = checkWordLength(firstWord, secondWord);

        //    string checkWordLength(string word1, string word2)
        //    {
        //        if (word1.Length != word2.Length)
        //        {
        //            //check if the first is bigger then the second
        //            if (word1.Length > word2.Length)
        //            {
        //                return word1;
        //            }
        //            else
        //            {
        //                return word2;
        //            }
        //        }
        //        else
        //        {
        //            return word2 + " è lunga quanto " + word1;
        //        }
        //    }

        //    Console.WriteLine(wardToPrint);


        //}

        //{
        //    checkNumeber();

        //    void checkNumeber()
        //    {
        //        Console.WriteLine("scegli un numero");
        //        int userNumber = Convert.ToInt32(Console.ReadLine());

        //        if(userNumber % 2 == 0)
        //        {
        //            Console.WriteLine("il numero è pari");
        //        } else
        //        {
        //            Console.WriteLine("il numero è dispari");
        //        }
        //    }
        //}
    }

}