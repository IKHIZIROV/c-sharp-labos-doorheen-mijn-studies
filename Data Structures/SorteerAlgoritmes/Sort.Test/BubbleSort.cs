﻿using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Sort.Test
{
    public class BubbleSort
    {

        public void Sort(int[] list)              // lijst met lengte n
        {
            var n = list.Length;
            for (int f = 1; f <= n - 1; f++)      // iteraties
            {
                for (int g = 0; g < n - f; g++)   // overloop van links naar rechts
                {
                    if (list[g] > list[g + 1])    // compare
                    {
                        var temp = list[g];       // swap
                        list[g] = list[g + 1];
                        list[g + 1] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// De iets intelligentere versie die reeds stopt wanneer er geen swap meer nodig was binnen de laatste iteratie
        /// </summary>
        /// <param name="list"></param>
        public void SortIntelligent(int[] list)              // lijst met lengte n
        {
            var n = list.Length;
            for (int f = 1; f <= n - 1; f++)      // iteraties
            {
                var hasSwapped = false;             //swap done indicator
                for (int g = 0; g < n - f; g++)   // overloop van links naar rechts
                {
                    if (list[g] > list[g + 1])    // compare
                    {
                        var temp = list[g];       // swap
                        list[g] = list[g + 1];
                        list[g + 1] = temp;
                        hasSwapped = true;        //noteer dat we minstens 1 swap hebben uitgevoerd
                    }
                }
                //geen enkele swap binnen 1 iteratie => lijst is gesorteerd !!!
                if (!hasSwapped)
                {
                    Debug.WriteLine($"Bubble sorted detected no swaps done after {f} out of {n - 1} iterations");
                    return;
                }
            }
        }

        /// <summary>
        /// De recursieve versie
        /// </summary>
        /// <param name="list"></param>
        public void SortRecursive(int[] list)              // lijst met lengte n
        {
            SortRecursive(list, list.Length - 1);
        }

        //Waarom recursief ?
        //We kunnen immers de verschillende iteraties van de bubblesort aanzien als een kleinere versie van hetzelfde
        //Elke iteratie doet net hetzelfde, alleen 1 item minder bekijken.
        //Dit geven we aan met de endIndex. Daar stopt een iteratie
        //Voor de 1e iteratie is dat het einde van de array en voor de volgende telkens 1 item minder.
        //De base case is als we enkel nog index = 0 moeten sorteren. Dan is de lijst immers sowieso volledig gesorteerd.

        /// <summary>
        /// Doe de bubble sort recursief. Deze methode doet 1 iteratie en roept vervolgens zichzelf aan voor de volgende iteratie.
        /// We gebruiken hier tevens de intelligentere versie met de swapCheck controle.
        /// </summary>
        /// <param name="list"></param>
        /// <param name="endIndex"></param>
        private void SortRecursive(int[] list, int endIndex)
        {
            var hasSwapped = false;               //swap done indicator

            if (endIndex == 0)              // base case (nog maar 1 getal te sorteren)
                return;

            for (int g = 0; g < endIndex; g++)   // overloop van links naar rechts tot aan de eindIndex
            {
                if (list[g] > list[g + 1])    // compare
                {
                    var temp = list[g];       // swap
                    list[g] = list[g + 1];
                    list[g + 1] = temp;
                    hasSwapped = true;        //noteer dat we minstens 1 swap hebben uitgevoerd
                }
            }
            //geen enkele swap binnen 1 iteratie => lijst is gesorteerd, dus ook niet verder doen.
            if (!hasSwapped)
            {
                Debug.WriteLine($"Bubble sorted detected no swaps done after {list.Length - endIndex} out of {list.Length - 1} iterations");
                return;
            }
            SortRecursive(list, endIndex - 1);
        }

    }
}