using UnityEngine;
using System.Collections;

public class DestinationConroller : MonoBehaviour
{
	void Awake ()
	{

	}

	void Update ()
	{

	}

	void OnTriggerEnter (Collider other)
	{
		Destroy (other.gameObject);
	}
}
