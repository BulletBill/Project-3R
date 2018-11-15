using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public static GameObject Instance;

	bool Paused;

	// Use this for initialization
	void Start () {

		if (null == Instance) {
			Instance = this.gameObject;
		} else {
			Destroy(this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool IsPaused() {
		return Paused;
	}

	public static int Sign(float number) {
		return number < 0 ? -1 : (number > 0 ? 1 : 0);
	}
}
