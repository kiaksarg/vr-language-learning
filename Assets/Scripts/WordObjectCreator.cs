using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using UnityEngine;


// Demonstrative code to showcase calling a function in another script.
// Not essential for current program functionality but illustrates script interaction.
public class WordObjectCreator : MonoBehaviour
{
    public System.Random rnd = new System.Random();

    // Start is called before the first frame update

    private bool eventCalled = false;



    void Start()
    {

        Moving MovingScriptComponent = FindObjectOfType<Moving>();
        if (MovingScriptComponent != null)
        {
            MovingScriptComponent.textResetEvent.AddListener(handleTextReset);
        }


        // Find the GameObject with ScriptA attached
        GameObject WordObjectScriptObject = GameObject.Find("WordObject");

        createWordObjects();
    }

    private void handleTextReset()
    {
        eventCalled = true;

    }

    // Update is called once per frame
    void Update()
    {

    }


    void FixedUpdate()
    {
        if (eventCalled)
        {
            destroyExistedWordObjects();
            createWordObjects();
            eventCalled = false;
        }
    }

    void createWordObjects()
    {
        GameObject WordObjectScriptObject = GameObject.Find("WordObject");

        if (WordObjectScriptObject != null)
        {
            WordObject WordObjectScript = WordObjectScriptObject.GetComponent<WordObject>();

            if (WordObjectScript != null)
            {
                HashSet<string> wordObjects = new HashSet<string>() { Shared.currentWord };


                int rndOrder = rnd.Next(0, 4);
                for (int i = 0; i < 4; i++)
                {
                    while (!wordObjects.Add(Shared.wordsList[rnd.Next(0, Shared.wordsList.Count)].id));
                }


                foreach (var item in wordObjects.OrderBy(x => Guid.NewGuid()).Select((val, i) => (val, i)))
                {
                    WordObjectScript.initChildObject(item.val, GenerateVector(item.i));
                }

            }
        }
    }

    void destroyExistedWordObjects()
    {
        foreach (var item in Shared.wordGameObjectList)
        {
            Destroy(item);
        }

        Shared.wordGameObjectList = new List<GameObject>();
    }

    Vector3 GenerateVector(int i)
    {
        return new Vector3(.39f * i, 0f, 0f);
    }
}
