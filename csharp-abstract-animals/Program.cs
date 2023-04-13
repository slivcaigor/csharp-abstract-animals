/*
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

            Console.WriteLine($"Il Cane fa {cane.Verso()} Mangia {cane.Mangia()} e dorme {cane.Dormi()}"); 
            Console.WriteLine($"Il Passerotto fa {passerotto.Verso()} Mangia {passerotto.Mangia()} e dorme {passerotto.Dormi()}"); 
            Console.WriteLine($"L'Aquila fa {aquila.Verso()} Mangia {aquila.Mangia()} e dorme {aquila.Dormi()}"); 
            Console.WriteLine($"Il Delfino fa {delfino.Verso()} Mangia {delfino.Mangia()} e dorme {delfino.Dormi()}"); 
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

            // Metodo Mangia
            public abstract string Mangia();
            
        }

        // Classe Cane che estende Animale
        public class Cane : Animale
        {
            // Implementazione del metodo Verso specifico per il Cane
            public override string Verso()
            {
                return "Bau!";
            }

            // Implementazione del metodo Mangia specifico per il Cane
            public override string Mangia()
            {
                return "Carne";
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

            // Implementazione del metodo Mangia specifico per il Passerotto
            public override string Mangia()
            {
                return "Semi e insetti";
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

            // Implementazione del metodo Mangia specifico per l'Aquila
            public override string Mangia()
            {
                return "Altri animali";
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

            // Implementazione del metodo Mangia specifico per il Delfino
            public override string Mangia()
            {
                return "Pesci e calamari";
            }
        }
    }
}