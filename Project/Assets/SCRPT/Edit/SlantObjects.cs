﻿using UnityEngine;

public class SlantObjects : MonoBehaviour
{
    public ChoiceObjects choiceObjects;
    public GeneralManager generalManager;

    public float speed = 10f;

    void Update()
    {
        if (!generalManager.isSlantObjects || !generalManager.edit || !choiceObjects.condition)
        {
            return;
        }

        GameObject body = choiceObjects.body;

        float movX = Input.GetAxis("Horizontal") * speed;
        float movZ = Input.GetAxis("Vertical") * speed;
        float movY = Input.GetAxis("Submit") * speed;

        body.transform.localEulerAngles += new Vector3(movZ, movX, movY) * Time.deltaTime;
    }
}