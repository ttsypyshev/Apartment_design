﻿using UnityEngine;

public class SlantObjects : MonoBehaviour
{
    public ChoiceObjects choiceObjects;
    public GeneralManager generalManager;
    public string[] text = new string[1] { "Объект не выбран" };

    public float speed = 10f;

    void Update()
    {
        if (!generalManager.isSlantObjects || !generalManager.edit)
        {
            return;
        }
        if (!choiceObjects.condition)
        {
            generalManager.time = 3;
            generalManager.notificftionText.text = text[0];
            return;
        }

        GameObject body = choiceObjects.body;

        float movX = Input.GetAxis("Horizontal") * speed;
        float movZ = Input.GetAxis("Vertical") * speed;
        float movY = Input.GetAxis("Submit") * speed;

        body.transform.localEulerAngles += new Vector3(movZ, movX, movY) * Time.deltaTime;
    }
}