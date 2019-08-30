using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class advantureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] Text errorComponent;
    [SerializeField] GameStates state1;

    GameStates currentState;

    //string StoryText = "Ramesh is a father of son and daughter named Vismay and Ankita. They were going to their river house for the vacation. But on the way, a pack of tigers attacked them and they have to fight their way to home. While fighting with tigers Rameh is died and 2 sibilings split away. Your objective is to find your other sibling and make your way to river home.";

    // Start is called before the first frame update
    void Start()
    {
        currentState = state1;
        textComponent.text = currentState.GetStateStory();
        errorComponent.text = null;
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = currentState.GetNextStates();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = nextStates[0];
            errorComponent.text = null;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = nextStates[1];
            errorComponent.text = null;
        }
        else if (Input.anyKeyDown)
        {
            errorComponent.text = ("PLEASE SELECT A VALID OPTION !");
            Debug.Log("from else part");
        }

        textComponent.text = currentState.GetStateStory();
    }
}
