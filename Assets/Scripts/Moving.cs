using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;


public class Moving : MonoBehaviour
{

    public UnityEvent textResetEvent;


    public System.Random rnd = new System.Random();
    public float xSpeed = 0.08f;
    public float ySpeed = 2.0f;
    public float zSpeed = 0.08f;
    public float height = 2.0f;



    private Vector3 tempPosition;
    private Vector3 originalPosition;

    private bool shouldResetPosition = false;



    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        tempPosition = transform.position;
        var sth1 = gameObject.GetComponent<TextMeshPro>();
        sth1.text = Shared.wordsList[0].word;
        Shared.currentWord = Shared.wordsList[0].id;
    }


    // Update is called once per frame
    void FixedUpdate()
    {

        if (shouldResetPosition)
        {
            tempPosition.x = originalPosition.x;
            tempPosition.z = originalPosition.z;
        }
        tempPosition.x += xSpeed;
        // tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * ySpeed) * height;
        tempPosition.z += zSpeed;
        transform.position = tempPosition;

        if (shouldResetPosition)
        {
            var sth1 = gameObject.GetComponent<TextMeshPro>();

            if (sth1)
            {
                var word = Shared.wordsList[rnd.Next(0, Shared.wordsList.Count)];
                Shared.currentWord = word.id;
                sth1.text = word.word;
            }
            shouldResetPosition = false;
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        shouldResetPosition = true;
        textResetEvent.Invoke();

    }
}
