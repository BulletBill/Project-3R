using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

	public static GameObject Instance;

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
}
