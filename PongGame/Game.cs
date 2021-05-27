using System;
using System.Threading;

namespace PongGame
{
    public class Game
    {
        private bool nooneHasWon = true;
        
        // TODO compito
        /*
         *
         *  ora la situazione è questa: c'è un giocatore "|", una palla "*" e gli spazi in mezzo
         *
         * consegna #1: Stampa anche l'altro giocatore
         *  per poter stampare l'altro giocatore la situazione dovrà seguire questo schema
         * |*   |   istante1: giocatore1 + palla + 3 spazi + giocatore2
         * | *  |   istante2: giocatore1 + 1 spazio + palla * 2 spazi + giocatore2
         * |  * |   istante2: giocatore1 + 2 spazi + palla * 1 spazi0 + giocatore2
         * |   *|   istante2: giocatore1 + 3 spazi + palla * 0 spazi + giocatore2
         *
         * modifica DrawBall per ottenere una situazione simile
         *
         * consegna #2: riesci a far tornare indietro la palla una volta arrivata in fondo
         * 
         */
        
        public void Run()
        {
            Console.WriteLine("Ora la funzione Run() della classe Game verrà eseguita");
            
            Console.WriteLine("=== Il gioco è iniziato ===");
            Thread.Sleep(3000);
            ClearConsole();
            
            
            
            int count = 0;
            while (nooneHasWon == true)
            {
               Thread.Sleep(1000); // wait for 1 second
                              
               ClearConsole();
               DrawBallAndPlayers(count);

               count++;
               if (count > 10) // TODO consegna2: qua capisci quando sei arrivato in fondo ai numeri e falli tornare indietro a 0
               {
                   nooneHasWon = false;
               }
            }
            
            Console.WriteLine("=== Il gioco è finito ===");
            Console.WriteLine("{0} ha vinto il gioco!", "tobia");
        }
        
        private void ClearConsole()
        {
            Console.ResetColor();
            Console.Clear();
        }

        private void DrawBallAndPlayers(int spacesNumber)
        {
            string spacesOnTheLeft = "";

            for (int i = 0; i < spacesNumber; i++) {
                spacesOnTheLeft = spacesOnTheLeft + " ";
            }

            string screenOfTheGame = "|" + spacesOnTheLeft + "--"; // TODO aggiungi qui gli spazi mancanti e l'altro giocatore, attento che gli spazi di destra diminuiscono mentre quelli di sinistra aumentano

            Console.WriteLine(screenOfTheGame);
        }
    }
}

