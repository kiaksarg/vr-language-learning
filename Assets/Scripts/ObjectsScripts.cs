using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectsScripts : MonoBehaviour
{
    public bool shouldUpdateScore = false;
    public bool shouldPlayWrongSound = false;
    public bool shouldPlayCorrectSound = false;


    // Start is called before the first frame update


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {


    }

    void FixedUpdate()
    {
        TextMeshPro scoreComponent = GameObject.Find("Score").GetComponent<TextMeshPro>();
        Debug.Log("Score from fixed update:" + scoreComponent);
        scoreComponent.text = "Score: " + Shared.score;

        shouldUpdateScore = false;

    }
    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("triggered:");


        if (other.name == "FrontText")
        {
            GameObject txtObject = GameObject.Find("FrontText");

            string wordName = "";

            if (other.GetComponent<TextMeshPro>())
            {
                wordName = other.GetComponent<TextMeshPro>().text;
            }

            var res = Shared.wordsList.Find((w) => w.id.ToLower() == gameObject.name.Replace("(Clone)", "").Trim().ToLower());

            GameObject OnTextAndObjectCollideReactionObject = GameObject.Find("Environment");
            OnTextAndObjectCollideReactionScript OnTextAndObjectCollideReactionScript =
            OnTextAndObjectCollideReactionObject.GetComponent<OnTextAndObjectCollideReactionScript>();


            if (res.word == wordName)
            {
                //Debug.Log("Hooray");
                other.gameObject.GetComponent<ParticleSystem>().Play();
                Shared.score++;
                if (OnTextAndObjectCollideReactionScript != null)
                    OnTextAndObjectCollideReactionScript.playCorrectSound();
                shouldPlayCorrectSound = true;
                shouldUpdateScore = true;
            }
            else
            {
                shouldUpdateScore = true;
                Shared.score--;
                shouldPlayWrongSound = true;

                if (OnTextAndObjectCollideReactionScript != null)
                    OnTextAndObjectCollideReactionScript.playWrongSound();
            }

        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Collided");
    }



}
