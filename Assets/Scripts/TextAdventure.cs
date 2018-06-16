using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAdventure : MonoBehaviour {

    //available within inspector
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    State currentState;

    // Use this for initialization
    void Start () {
        currentState = startingState;
        textComponent.text = currentState.GetStateStory();
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        State[] NextStates = currentState.GetNextStates();

        //If option 1 is selected
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            currentState = NextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            currentState = NextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            currentState = NextStates[2];
        }
        textComponent.text = currentState.GetStateStory();
    }
}
