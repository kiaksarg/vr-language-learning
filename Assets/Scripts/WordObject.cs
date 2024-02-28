using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class WordObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Update is called once per frame


    public void initChildObject(string childName, Vector3 pos)
    {
        // Assuming 'childObject' is the object you want to make a child
        GameObject childObjectSample = GameObject.Find(childName);
        GameObject childObject = Instantiate(childObjectSample);

        childObject.AddComponent<BoxCollider>();
        var collider2 = childObject.AddComponent<BoxCollider>();
        childObject.AddComponent<Rigidbody>();
        childObject.AddComponent<XRGrabInteractable>();
        childObject.AddComponent<ObjectsScripts>();
        // var audioSource = childObject.AddComponent<AudioSource>();


        collider2.isTrigger = true;
        // rigidBody.isKinematic = true;

        if (childObject != null)
        {
            childObject.transform.SetParent(gameObject.transform);

            childObject.transform.localPosition = pos;
            childObject.transform.localRotation = Quaternion.identity;

            Shared.wordGameObjectList.Add(childObject);
        }
        else
        {
            Debug.LogError("Child object not found!");
        }


    }

}
