using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;


public class Moving : MonoBehaviour
{
    // {
    //     "Handla", "Shopping",
    //     "Mat", "Food",
    //     "Kök", "Kitchen",
    //     "Kylskåp", "Refrigerator",
    //     "Bestick", "Utensils",
    //     "Tallrik", "Plate",
    //     "Glas", "Glass",
    //     "Kaffebryggare", "Coffee maker",
    //     "Mjölk", "Milk",
    //     "Bröd", "Bread",
    //     "Frukt", "Fruit",
    //     "Grönsaker", "Vegetables",
    //     "Kryddor", "Spices",
    //     "Kasse", "Bag",
    //     "Pris", "Price",
    //     "Vara", "Product",
    //     "Kassa", "Checkout",
    //     "Kundvagn", "Shopping cart"
    // }
    // public List<String> wordsList = new List<string>(){
    //   "Handla",
    // "Mat",
    // "Kök",
    // "Kylskåp",
    // "Bestick",
    // "Tallrik",
    // "Glas",
    // "Kaffebryggare",
    // "Mjölk",
    // "Bröd",
    // "Frukt",
    // "Grönsaker",
    // "Kryddor",
    // "Kasse",
    // "Pris",
    // "Vara",
    // "Kassa",
    // "Kundvagn"
    // };

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
                sth1.text = Shared.wordsList[rnd.Next(0, Shared.wordsList.Count)].word;
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
