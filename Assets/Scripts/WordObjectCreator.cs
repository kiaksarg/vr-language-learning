using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Demonstrative code to showcase calling a function in another script.
// Not essential for current program functionality but illustrates script interaction.
public class WordObjectCreator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Moving MovingScriptComponent = FindObjectOfType<Moving>();
        if (MovingScriptComponent != null)
        {
            MovingScriptComponent.textResetEvent.AddListener(handleTextReset);
        }


        // Find the GameObject with ScriptA attached
        GameObject WordObjectScriptObject = GameObject.Find("WordObject");

        // Call the function from ScriptA
        if (WordObjectScriptObject != null)
        {
            WordObject WordObjectScript = WordObjectScriptObject.GetComponent<WordObject>();
            if (WordObjectScript != null)
            {
                WordObjectScript.initChildObject("Milk");
                WordObjectScript.initChildObject("Beer");
                WordObjectScript.initChildObject("Strawberry");
                WordObjectScript.initChildObject("Wine");
                WordObjectScript.initChildObject("cheese");
            }
        }
    }

    private void handleTextReset()
    {
        // throw new NotImplementedException();
        //Try to populate objects after a new word's coming
    }

    // Update is called once per frame
    void Update()
    {

    }
}
