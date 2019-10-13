using System;
using System.Collections.Generic;

namespace _950_RevealCardsInIncreasingOrder
{
    internal class Solution
    {
        public int[] DeckRevealedIncreasing(int[] deck)
        {
            Array.Sort(deck);

            var indexedQueue = new Queue<int>();
            for (int i = 0; i < deck.Length; i++)
                indexedQueue.Enqueue(i);

            return RevealCards(indexedQueue, deck);
        }

        private int[] RevealCards(Queue<int> indexedQueue, int[] deck)
        {
            var revealedCards = new int[deck.Length];
            for (int i = 0; i < deck.Length; i++)
            {
                var topDeck = indexedQueue.Dequeue();
                revealedCards[topDeck] = deck[i];

                if (indexedQueue.Count > 0)
                    indexedQueue.Enqueue(indexedQueue.Dequeue());
            }

            return revealedCards;
        }
    }
}
