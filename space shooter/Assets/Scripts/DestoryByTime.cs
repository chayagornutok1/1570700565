using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByTime : MonoBehaviour {

	public float Lifetime;
	void Start ()
	{
		Destroy (gameObject, Lifetime);
	}
}
