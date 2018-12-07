using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
    State state;

	// Use this for initialization
	void Start () {
        state = startingState;
		textComponent.text = state.GetStateStory();
        Debug.Log(daysOfTheWeek[1]);
	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStates[1];
        }
        else 
        {
           
        }
        textComponent.text = state.GetStateStory();
    }
}
