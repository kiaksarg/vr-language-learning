using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ObjectsScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
                Debug.Log("triggered:");


        // if (other.name == "FrontText" && gameObject.transform.childCount > 0)
        if (other.name == "FrontText")
        {
            // other.
            // Debug.Log("hi:" + gameObject.name);
            GameObject txtObject = GameObject.Find("FrontText");
            TextMeshPro txtStatObject = GameObject.Find("StatText").GetComponent<TextMeshPro>();

            string wordName = "";

            //var sth1 = gameObject.GetComponent<TextMeshPro>();
            if (other.GetComponent<TextMeshPro>())
            {
                wordName = other.GetComponent<TextMeshPro>().text;
                Debug.Log("triggered:" + wordName);

                // Debug.Log("wordName:" + wordName);
            }

            var res = Shared.wordsList.Find((w) => w.id == gameObject.name.ToLower());
            // var res = Shared.wordsList.Find((w) => w.id == gameObject.transform.GetChild(0).name.ToLower());
            // Debug.Log("res:" + res);
            // Debug.Log("res:" + res.word);

            if (res.word == wordName)
            {
                //Horray
                Debug.Log("Hooray");
                txtStatObject.text = "Hooray :)";
            }
            else
            {
                txtStatObject.text = "Ops :(";

                Debug.Log("Ops!");
            }

            //tmpPos.x = orgPos.x;
            //tmpPos.y = orgPos.y;
            //tmpPos.z = orgPos.z;
            //transform.position = tmpPos;
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
    }



}
