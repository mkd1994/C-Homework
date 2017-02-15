using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Homework_DataStructures
{
    public class DataStructures
    {
        public void AvaregeListCount()
        {
            List<int> numbers = new List<int>();
            double a=0;
            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                string b = Console.ReadLine();
                if (b==string.Empty)
                {
                    break;
                }
                else
                {
                    var c = Int32.Parse(b);
                    numbers.Add(c);
                    a += c;
                    count++;
                }
            }

            Console.WriteLine( a/count);
        }

        public void Removal(List<int>arr)
        {
            int[] arr2 = new int[5];
            for (int i = 0; i < arr2.Length;i++)
            {
                arr2[i] = i;
                int a = arr.Count(emp => emp == arr2[i]);

                if (a % 2 != 0)
                {
                    arr.RemoveAll(emp => emp == arr2[i]);
                }
            }
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public void Words()
        {
            List<string> list = new List<string>(20);

            for (int i = 0; i < 20; i++)
            {
                string a = Console.ReadLine();
                list.Add(a);
            }
            for (int i = 0; i < list.Count; i++)
            {
                string b = list.ElementAt(i);
                var s = list.Where(emp => emp == b);
                Console.WriteLine("{0} is found {1} times", b, s);
            }
        }
        public void PokerDeal()
        {
            List<string> deck = new List<string>();
            string[] suit = new string[4] { "s", "h", "d", "c" };
            string[] card = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            for (int i = 0; i < suit.Length;)
            {
                for (int y = 0; y < card.Length;)
                {
                    deck.Add(card[y]+suit[i]);
                    ++y;
                }
                ++i;
            }

     //       Deck Creator end at this line
     //--------------------------------------------------------------

            Random rnd = new Random();
            List<string> hand = new List<string>();

            for (int i = 0; i < 5;)
            {
                int a = rnd.Next(1, 53);
                hand.Add(deck[a]);
                deck.RemoveAt(a);
                
               

               Console.Write(hand[i]+" ");
               ++i;
            }
    //Cards in hand shown are removed from deck
    //-------------------------------------------------------------------
            for (int i = 0; i < hand.Count; )
            {
                var card1 = hand.ElementAt(i);
                if (card1.Length == 3)
                {
                    var trimmed = card1.Substring(0, 3);
                    hand.Add(trimmed);

                }
                else
                {
                    var trimmed2 = card1.Substring(0, 2);
                    hand.Add(trimmed2);
                }
                ++i;
            }
            // Trimming the god damn suit of the cards
            //------------------------------------------------------------
            int [] matches = new int[5];
            for (int i = 0; i < hand.Count; )
            {
                matches[i] = hand.Count(emp => emp == hand[i]);
                if (matches[i] == 4)
                {
                    Console.WriteLine("You have a Quads");
                }
                else if (matches[i] == 3)
                {
                    Console.WriteLine("You have a Set");
                }
                else if (matches[i] == 2)
                {
                    Console.WriteLine("You have a Pair");
                }
                ++i;
            }
        }
    }
}
