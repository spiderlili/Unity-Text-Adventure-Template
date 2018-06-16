using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject {

    //min size, amount of lines before starting to scroll
    [TextArea(14, 10)][SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    

    public string GetStateStory() {
        return storyText;
    }

    public State[] GetNextStates() {
        return nextStates;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
