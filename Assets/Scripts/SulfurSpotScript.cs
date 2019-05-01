using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SulfurSpotScript : MonoBehaviour
{
    public GameObject KeyElement;

    public GameObject PrizeElement;

	// Use this for initialization
	void Start ()
    {
        PrizeElement.transform.position = new Vector3(0, 100, 0);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(KeyElement))
        {
            PrizeElement.transform.position = new Vector3(-1.646f, 0.587f, -0.012f);
        }
    }
}
