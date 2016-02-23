using UnityEngine;
using System.Collections;

public class Manager : NNMonoBehaviour {

	public GameObject brick_prefab;

	// Use this for initialization
	void Start () {
		Brick brick = createInstance<Brick> (brick_prefab);
		brick.transform.localPosition = new Vector3 ();
		brick.shout ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
