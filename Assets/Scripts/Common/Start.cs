using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SerializableList<T>
{
    public List<T> list;
}

[System.Serializable]
public class wordObjectsTypes
{
    public string id;
    public string word;
}

public class ObjectIterator : MonoBehaviour
{
    public GameObject parentObject; // Assign this in the Inspector

    [SerializeField] private SerializableList<wordObjectsTypes> sampleWordObjects;

    // public static List<WordsType> wordsList = new List<WordsType>() { new WordsType { id = "Milk", word = "" }, new WordsType { id = "Cheese", word = "" }, new WordsType { id = "Watermelon", word = "" }, new WordsType { id = "Beer", word = "" }, new WordsType { id = "Pie", word = "" }, new WordsType { id = "Bread", word = "" }, new WordsType { id = "Ribs", word = "" }, new WordsType { id = "Cake", word = "" }, new WordsType { id = "Hamburger", word = "" }, new WordsType { id = "Apple", word = "" }, new WordsType { id = "Cookie", word = "" }, new WordsType { id = "Donut", word = "" }, new WordsType { id = "Pear", word = "" }, new WordsType { id = "Avocado", word = "" }, new WordsType { id = "Carrot", word = "" }, new WordsType { id = "Fish", word = "" }, new WordsType { id = "Steak", word = "" }, new WordsType { id = "Tomato", word = "" }, new WordsType { id = "Soda", word = "" }, new WordsType { id = "Pumpkin", word = "" }, new WordsType { id = "HotDog", word = "" }, new WordsType { id = "Fries", word = "" }, new WordsType { id = "Egg", word = "" }, new WordsType { id = "IceCream", word = "" }, new WordsType { id = "IceCream-2", word = "" }, new WordsType { id = "Onion", word = "" }, new WordsType { id = "Pineapple", word = "" }, new WordsType { id = "Sausage", word = "" }, new WordsType { id = "Shrimp", word = "" }, new WordsType { id = "SweetPepper", word = "" }, new WordsType { id = "Toast", word = "" }, new WordsType { id = "Wine", word = "" }, new WordsType { id = "Olive", word = "" }, new WordsType { id = "Cherry", word = "" }, new WordsType { id = "Chicken", word = "" }, new WordsType { id = "Peanut", word = "" }, new WordsType { id = "Strawberry", word = "" }, new WordsType { id = "Lemon", word = "" }, new WordsType { id = "Peach", word = "" }, new WordsType { id = "Acorn", word = "" }, new WordsType { id = "Candy", word = "" }, new WordsType { id = "Onion", word = "" }, new WordsType { id = "Pea", word = "" }, new WordsType { id = "Egg", word = "" }, new WordsType { id = "Grape", word = "" }, new WordsType { id = "Yam", word = "" }, new WordsType { id = "Orange", word = "" }, new WordsType { id = "Garlic", word = "" }, new WordsType { id = "Salad", word = "" }, new WordsType { id = "Banana", word = "" }, new WordsType { id = "Mushroom", word = "" } };
    // {
    // new WordsType { id = "Milk", word = "" },
    // new WordsType { id = "Cheese", word = "" },
    // new WordsType { id = "Watermelon", word = "" },
    // new WordsType { id = "Beer", word = "" },
    // new WordsType { id = "Pie", word = "" },
    // new WordsType { id = "Bread", word = "" },
    // new WordsType { id = "Ribs", word = "" },
    // new WordsType { id = "Cake", word = "" },
    // new WordsType { id = "Hamburger", word = "" },
    // new WordsType { id = "Apple", word = "" },
    // new WordsType { id = "Cookie", word = "" },
    // new WordsType { id = "Donut", word = "" },
    // new WordsType { id = "Pear", word = "" },
    // new WordsType { id = "Avocado", word = "" },
    // new WordsType { id = "Carrot", word = "" },
    // new WordsType { id = "Fish", word = "" },
    // new WordsType { id = "Steak", word = "" },
    // new WordsType { id = "Tomato", word = "" },
    // new WordsType { id = "Soda", word = "" },
    // new WordsType { id = "Pumpkin", word = "" },
    // new WordsType { id = "HotDog", word = "" },
    // new WordsType { id = "Fries", word = "" },
    // new WordsType { id = "Egg", word = "" },
    // new WordsType { id = "IceCream", word = "" },
    // new WordsType { id = "IceCream-2", word = "" },
    // new WordsType { id = "Onion", word = "" },
    // new WordsType { id = "Pineapple", word = "" },
    // new WordsType { id = "Sausage", word = "" },
    // new WordsType { id = "Shrimp", word = "" },
    // new WordsType { id = "SweetPepper", word = "" },
    // new WordsType { id = "Toast", word = "" },
    // new WordsType { id = "Wine", word = "" },
    // new WordsType { id = "Olive", word = "" },
    // new WordsType { id = "Cherry", word = "" },
    // new WordsType { id = "Chicken", word = "" },
    // new WordsType { id = "Peanut", word = "" },
    // new WordsType { id = "Strawberry", word = "" },
    // new WordsType { id = "Lemon", word = "" },
    // new WordsType { id = "Peach", word = "" },
    // new WordsType { id = "Acorn", word = "" },
    // new WordsType { id = "Candy", word = "" },
    // new WordsType { id = "Onion", word = "" },
    // new WordsType { id = "Pea", word = "" },
    // new WordsType { id = "Egg", word = "" },
    // new WordsType { id = "Grape", word = "" },
    // new WordsType { id = "Yam", word = "" },
    // new WordsType { id = "Orange", word = "" },
    // new WordsType { id = "Garlic", word = "" },
    // new WordsType { id = "Salad", word = "" },
    // new WordsType { id = "Banana", word = "" },
    // new WordsType { id = "Mushroom", word = "" }
// }



    void Start()
    {
        // Check if the parent object is assigned
        if (parentObject != null)
        {
            // Iterate through all child objects of the parent
            foreach (Transform child in parentObject.transform)
            {
                // Access each child game object here
                GameObject childObject = child.gameObject;

                // Do something with the child object, e.g., print its name
                // Debug.Log("Child Object: " + childObject.name);
                sampleWordObjects.list.Add(new wordObjectsTypes() { id = childObject.name, word = "" });
            }
            Debug.Log("Json:): " + JsonUtility.ToJson(sampleWordObjects));

        }
        else
        {
            Debug.LogError("Parent Object is not assigned!");
        }


    }
}
