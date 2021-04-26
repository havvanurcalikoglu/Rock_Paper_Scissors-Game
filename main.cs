using System; 

  namespace Game
  {
    public class TechKariyer{

            int sayac = 0;
            int A_skor = 0;
            int B_skor = 0;
            int esitlik = 0;

            string[] secim = new string[3] { "ROCK", "PAPER", "SCISSOR" };
            Random random = new Random();

            while (sayac < 100)
            {

                int i = random.Next(0, 3);
                Console.WriteLine("Hangisini secmek istersiniz?" +" 1-ROCK\n2-PAPER\n3-SCISSOR");
                string A = Console.ReadLine().ToUpper();
                Console.WriteLine("B:" + secim[i]);

                if (A == "ROCK" && secim[i] == "SCISSOR")
                {
                    Console.WriteLine("A kazandı.");
                    A_skor += 1;
                    sayac++;
                }
                else if (A == "ROCK" && secim[i] == "PAPER")
                {
                    Console.WriteLine("B kazandı.");
                    B_skor += 1;
                    sayac++;
                }
                else if (A == "PAPER" && secim[i] == "ROCK")
                {
                    Console.WriteLine("A kazandı.");
                    A_skor += 1;
                    sayac++;
                }
                else if (A == "PAPER" && secim[i] == "SCISSOR")
                {
                    Console.WriteLine("B kazandı.");
                    B_skor += 1;
                    sayac++;
                }
                else if (A == "SCISSOR" && secim[i] == "ROCK")
                {
                    Console.WriteLine("B kazandı.");
                    B_skor += 1;
                    sayac++;
                }
                else if (A == "SCISSOR" && secim[i] == "PAPER")
                {
                    Console.WriteLine("A kazandı.");
                    A_skor += 1;
                    sayac++;
                }
                else
                {
                    Console.WriteLine("Beraber.");
                    esitlik += 1;
                    sayac++;
                }

            }

          static void Main(string[] args)
        {
            Console.WriteLine("Oyuncu A 100 maçta " + A_skor + " kazandı." + esitlik + " kez berabere kaldı.");
            Console.WriteLine("Oyuncu B 100 maçta " + B_skor + " kazandı." + esitlik + " kez berabere kaldı.");

        }
    }
  }

