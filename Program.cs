using System;

namespace ShuffleCards
{
    internal class Program
    {
        public static int[] ShuffleCards (int K) {

            var listOfCards = new int[K];
            for ( var i = 0; i<listOfCards.Length; i++) {
                listOfCards[i] = i+1;
            }
            
            var randomGenerator = new Random();
            for (var i=0; i<listOfCards.Length; i++) {
                var currentCard = listOfCards [i];
                var shufflePostion = randomGenerator.Next(0,K);
                listOfCards[i] = listOfCards[shufflePostion];
                listOfCards[shufflePostion] = currentCard;
            }

            return listOfCards;
        }
        static void Main(string[] args)
        {
            var K = 12;
            var listOfCards = ShuffleCards(K);
            Console.WriteLine(string.Join(", ",listOfCards));
        }
    }
}