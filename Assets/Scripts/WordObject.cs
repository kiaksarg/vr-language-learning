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


    public void initChildObject(string childName)
    {
        // Assuming 'childObject' is the object you want to make a child
        GameObject childObject = GameObject.Find(childName);

        var collider1 = childObject.AddComponent<BoxCollider>();
        var collider2 = childObject.AddComponent<BoxCollider>();
        var rigidBody = childObject.AddComponent<Rigidbody>();
        var xRGrabInteractable = childObject.AddComponent<XRGrabInteractable>();
        var objectsScripts = childObject.AddComponent<ObjectsScripts>();


        collider2.isTrigger = true;
        // rigidBody.isKinematic = true;



        // Check if the child object and the empty object are not null
        if (childObject != null)
        {
            // Set the empty object as the parent of the child object
            childObject.transform.SetParent(gameObject.transform);

            // Optional: You can reset the local position and rotation of the child
            childObject.transform.localPosition = Vector3.zero;
            childObject.transform.localRotation = Quaternion.identity;
        }
        else
        {
            Debug.LogError("Child object not found!");
        }

    }

}
