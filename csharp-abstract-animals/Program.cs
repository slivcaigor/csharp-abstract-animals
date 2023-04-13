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

            // Stampiamo a video animale
            Console.WriteLine($"Il Cane fa {cane.Verso()} Mangia {cane.Mangia()}, {FaiNuotare(cane)} e dorme {cane.Dormi()}"); 
            Console.WriteLine($"Il Passerotto fa {passerotto.Verso()} Mangia {passerotto.Mangia()}, {FaiVolare(passerotto)} e dorme {passerotto.Dormi()}"); 
            Console.WriteLine($"L'Aquila fa {aquila.Verso()} Mangia {aquila.Mangia()}, {FaiVolare(aquila)} e dorme {aquila.Dormi()}"); 
            Console.WriteLine($"Il Delfino fa {delfino.Verso()} Mangia {delfino.Mangia()}, {FaiNuotare(delfino)} e dorme {delfino.Dormi()}"); 
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
        public class Cane : Animale, INuotante
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

            // Classe Cane che implementa l'interfaccia INuotante
            public string Nuota()
            {
                return "sa nuotare";
            }
        }

        // Classe Passerotto che estende Animale
        public class Passerotto : Animale, IVolante
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

            // Classe Passerotto che implementa l'interfaccia IVolante
            public string Vola()
            {
                return "sa volare";
            }
        }

        // Classe Aquila che estende Animale
        public class Aquila : Animale, IVolante
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

            // Classe Aquila che implementa l'interfaccia IVolante
            public string Vola()
            {
                return "sa volare";
            }
        }

        // Classe Delfino che estende Animale
        public class Delfino : Animale, INuotante
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

            // Classe Delfino che implementa l'interfaccia INuotante
            public string Nuota()
            {
                return "sa nuotare";
            }
        }


        // Metodo che fa volare un animale che implementa l'interfaccia IVolante
        public static string FaiVolare(IVolante animale)
        {
            return animale.Vola();
        }

        // Metodo che fa nuotare un animale che implementa l'interfaccia INuotante
        public static string FaiNuotare(INuotante animale)
        {
            return animale.Nuota();
        }
    }
}