using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Khizirov_Ismail
{
    class MuziekDB
    {
        private List<MuziekItem> muziekItems = new List<MuziekItem>();

        public MuziekDB()
        {
            for (int i = 0; i < 10; i++)
            {
                muziekItems.Add(new Sample());
            }
        }

        public MuziekDB(bool enkelDigitaleItems)
        {

        }

        public void AddItem(MuziekItem muziekItem)
        {
            
        }

        public void ToonDb()
        {
            foreach (var item in muziekItems)
            {
                // muziekItems.ToonInfo();
            }
        }

        public void ToonDb(bool isFysiek)
        {
            foreach (var item in muziekItems)
            {
                // muziekItems.ToonInfo();
            }
        }

        public void ToonStatistieken()
        {

        }

        public void VerwijderItem(int verwijderenItem)
        {
            muziekItems.RemoveAt(verwijderenItem);
        }

        public void VerplaatsItem(int verplaatsen, MuziekItem nieuweItem)
        {
            muziekItems.Insert(verplaatsen, nieuweItem);
        }

        public void VervangItem(int vervangItem, MuziekItem nieuweItem)
        {
            muziekItems[vervangItem] = nieuweItem;
        }

        public void WijzigNaamVanItemOpIndex(int wijzigNaamVanItem, string nieuweNaam)
        {
            muziekItems[wijzigNaamVanItem].Naam = nieuweNaam;
        }
    }
}
