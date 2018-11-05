using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour, InputReciever {

	bool ReceivesInput = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (false == ReceivesInput) return;


	}

	// 
	public void SetReceiveInput(bool Receive) {
		bool ModeChanged = (ReceivesInput != Receive);
		ReceivesInput = Receive;
		if (ModeChanged) ReceiveInputChanged();
	}

	public bool IsReceivingInput() {
		return ReceivesInput;
	}

	void ReceiveInputChanged() {

	}
}
