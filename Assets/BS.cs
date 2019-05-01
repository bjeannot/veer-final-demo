using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BS : MonoBehaviour {


    public GameObject Time;
    public GameObject Game;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(15);
        Game.SetActive(true);
        Time.SetActive(false);
    }


}
