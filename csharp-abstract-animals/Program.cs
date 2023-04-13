/*
Esercizio 1 : classi astratte
Dobbiamo realizzare un programma che rappresenti il regno animale.
Creiamo quindi una classe astratta Animale e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
Vogliamo che gli animali abbiano i seguenti metodi
void Dormi() (mostra a video “Zzz”)
void Verso() (mostra a video il verso fatto dall'animale specifico)
void Mangia() (mostra a video quello che mangia : erba, carne, ...?)
Quali di questi metodi devono essere implementati nella classe astratta e quali devono essere lasciati astratti e implementati dalle classi che la estendono?
Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.


Esercizio 2 : interfacce 
Alcuni degli animali che abbiamo creato volano, altri nuotano.
Gli animali che volano hanno il seguente metodo :
void Vola() (mostra a video “Sto volando!!!”)
Gli animali che nuotano hanno il seguente metodo :
void Nuota() (mostra a video “Sto nuotando!!!”)
Scrivere un programma avente 2 metodi :
void FaiVolare(IVolante animale)
void FaiNuotare(INuotante animale)
Questi metodi prendono come parametro un animale che può o volare / nuotare e richiamano il corrispondente metodo Vola() / Nuota().
Scrivere un programma che istanzi animali che volano o nuotano e richiamare i metodi FaiVolare / FaiNuotare passandoglieli come parametro.
*/
namespace csharp_abstract_animals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creiamo un'istanza di ogni animale
            Cane cane = new();
            Passerotto passerotto = new();
            Aquila aquila = new();
            Delfino delfino = new();

            // Stampiamo a video il verso fatto dall'animale

            //cane.Verso(); -> Void

            Console.WriteLine($"Il Cane fa '{cane.Verso()}' e dorme '{cane.Dormi()}'"); 
            Console.WriteLine($"Il Passerotto fa '{passerotto.Verso()}' e dorme '{passerotto.Dormi()}'"); 
            Console.WriteLine($"L'Aquila fa '{aquila.Verso()}' e dorme '{aquila.Dormi()}'"); 
            Console.WriteLine($"Il Delfino fa '{delfino.Verso()}' e dorme '{delfino.Dormi()}'"); 
        }

        // Classe astratta Animale
        public abstract class Animale
        {
            // Metodo Dormi
            public string Dormi()
            {
                return "Zzz";
            }

            // Metodo astratto Verso
            public abstract string Verso();
        }

        // Classe Cane che estende Animale
        public class Cane : Animale
        {
            // Implementazione del metodo Verso specifico per il Cane
            public override string Verso()
            {
                return "Bau!";
            }
        }

        // Classe Passerotto che estende Animale
        public class Passerotto : Animale
        {
            // Implementazione del metodo Verso specifico per il Passerotto
            public override string Verso()
            {
                return "Cip Cip!";
            }
        }

        // Classe Aquila che estende Animale
        public class Aquila : Animale
        {
            // Implementazione del metodo Verso specifico per l'Aquila
            public override string Verso()
            {
                return "Creeee!";
            }
        }

        // Classe Delfino che estende Animale
        public class Delfino : Animale
        {
            // Implementazione del metodo Verso specifico per il Delfino
            public override string Verso()
            {
                return "Eeek eek!";
            }
        }
    }
}