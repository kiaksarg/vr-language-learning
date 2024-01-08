using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Shared
{
   public static string currentWord { get; set; }

   public static List<WordsType> wordsList = new List<WordsType>()

    {
       new WordsType(){id="Milk",word="Mjölk"},
       new WordsType(){id="Cheese",word="Ost"},
       new WordsType(){id="Wine",word="Vin"},
      //  new WordsType(){id="Water",word="Vatten"},
       new WordsType(){id="Strawberry",word="jordgubbe"},
       new WordsType(){id="Beer", word="öl"},
       new WordsType(){id="IceCream", word="glass"},
       new WordsType(){id="Egg", word="ägg"}


    };

   public static List<GameObject> wordGameObjectList = new List<GameObject>();


}
