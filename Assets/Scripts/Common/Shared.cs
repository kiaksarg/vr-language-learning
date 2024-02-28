using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Shared
{
   public static string currentWord { get; set; }

   public static int score = 0;



   public static List<WordsType> wordsList = new List<WordsType>()
{
    new WordsType { id = "Milk", word = "Mjölk" },
    new WordsType { id = "Cheese", word = "Ost" },
    new WordsType { id = "Watermelon", word = "Vattenmelon" },
    new WordsType { id = "Beer", word = "Öl" },
    new WordsType { id = "Pie", word = "Paj" },
    new WordsType { id = "Bread", word = "Bröd" },
    new WordsType { id = "Ribs", word = "Revbensspjäll" },
    new WordsType { id = "Cake", word = "Tårta" },
    new WordsType { id = "Hamburger", word = "Hamburgare" },
    new WordsType { id = "Apple", word = "Äpple" },
    new WordsType { id = "Cookie", word = "Kaka" },
    new WordsType { id = "Donut", word = "Munk" },
    new WordsType { id = "Pear", word = "Päron" },
    new WordsType { id = "Avocado", word = "Avocado" },
    new WordsType { id = "Carrot", word = "Morot" },
    new WordsType { id = "Fish", word = "Fisk" },
    new WordsType { id = "Steak", word = "Kött" },
    new WordsType { id = "Tomato", word = "Tomat" },
    new WordsType { id = "Soda", word = "Läsk" },
    new WordsType { id = "Pumpkin", word = "Pumpa" },
    new WordsType { id = "HotDog", word = "Varmkorv" },
    new WordsType { id = "Fries", word = "Pommes frites" },
    new WordsType { id = "Egg", word = "Ägg" },
    new WordsType { id = "IceCream", word = "Glass" },
    new WordsType { id = "IceCream-2", word = "Isglass" },
    new WordsType { id = "Onion", word = "Lök" },
    new WordsType { id = "Pineapple", word = "Ananas" },
    new WordsType { id = "Sausage", word = "Korv" },
    new WordsType { id = "Shrimp", word = "Räka" },
    new WordsType { id = "SweetPepper", word = "Paprika" },
    new WordsType { id = "Toast", word = "Rostat bröd" },
    new WordsType { id = "Wine", word = "Vin" },
    new WordsType { id = "Olive", word = "Oliv" },
    new WordsType { id = "Cherry", word = "Körsbär" },
    new WordsType { id = "Chicken", word = "Kyckling" },
    new WordsType { id = "Peanut", word = "Jordnöt" },
    new WordsType { id = "Strawberry", word = "Jordgubbe" },
    new WordsType { id = "Lemon", word = "Citron" },
    new WordsType { id = "Peach", word = "Persika" },
    new WordsType { id = "Acorn", word = "Ekollon" },
    new WordsType { id = "Candy", word = "Klubba" },
    new WordsType { id = "Pea", word = "Ärta" },
    new WordsType { id = "Grape", word = "Vindruvor" },
    new WordsType { id = "Yam", word = "Sötpotatis" },
    new WordsType { id = "Orange", word = "Apelsin" },
    new WordsType { id = "Garlic", word = "Vitlök" },
    new WordsType { id = "Salad", word = "Sallad" },
    new WordsType { id = "Banana", word = "Banan" },
    new WordsType { id = "Mushroom", word = "Svamp" }
};


   public static List<GameObject> wordGameObjectList = new List<GameObject>();


}
