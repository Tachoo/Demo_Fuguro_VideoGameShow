using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class FadeBackGroundImage : MonoBehaviour {
    public Image FadeBackGround;
	// Use this for initialization
	void Start ()
    {
        FadeBackGround.CrossFadeAlpha(0.0f, 2.5f, false);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.anyKeyDown)
        {
            Debug.Log("Cargamos el menu prinicipal");
#pragma warning disable CS0618 // El tipo o el miembro están obsoletos
            Application.LoadLevel(1);
#pragma warning restore CS0618 // El tipo o el miembro están obsoletos
        }
	}


}
