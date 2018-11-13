using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour, InputReciever {

	public float MovementSpeed;

	public bool ReceivesInput = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (false == ReceivesInput) return;

		Vector2 InputVector;

		InputVector.x = Input.GetAxis("Horizontal");
		InputVector.y = Input.GetAxis("Vertical");

		// limit diagonal speed
		if (InputVector.x != 0 && InputVector.y != 0) {
			InputVector *= 0.70707f;
		}

		Vector2 MovementDelta = (InputVector * MovementSpeed) * Time.deltaTime;
		transform.position += new Vector3(MovementDelta.x, MovementDelta.y, 0.0f);
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