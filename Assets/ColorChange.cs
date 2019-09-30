using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	float time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		time += Time.deltaTime;

		if(time >= 1f)
		{
			Vector3 color = new Vector3(Random.value,Random.value,Random.value);
			this.GetComponent<Renderer>().material.color = new Color(color.x,color.y,color.z);
			time = 0;
			
		}

		Debug.Log(time);
		
	}
}
