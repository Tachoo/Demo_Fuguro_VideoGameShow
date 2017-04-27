using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Credits : MonoBehaviour {
    public string[] ArrayTxT;
    public string Components;
    public Text [] HeaderSection;
    private Vector3 StartPos = new Vector3(470.0f, 440.0f);
    void Awake() //Lo ponemos antes de el Start del script
    {
        TextAsset textAssets = (TextAsset)Resources.Load("Credits_TXT"); //Busca en el path de recursos 
        Components = textAssets.text; //Asiganamos el Super MegaString 
        ArrayTxT = Components.Split(';');
    }

    void Start () //Aqui manipulamos el string 
    {
        //A todos los acomodamos
     for (int i = 0; i < HeaderSection.Length; i++)
        {
            HeaderSection[i].text=ArrayTxT[i]; //Los hacemos iguales
            HeaderSection[i].rectTransform.position = StartPos;                           
        }
        //Movemos individualmente
        HeaderSection[0].rectTransform.position += new Vector3(+20.0f, 0.0f);//El titulo de Real Evolution Games;
        HeaderSection[4].rectTransform.position = new Vector3(434.1f, 0.0f);//El titulo de Real Evolution Games;

        //A todos los movemos hacia abajo
        for (int i = 0; i < HeaderSection.Length; i++)
        {
            StartPos -= new Vector3(0.0f, 30f);
            HeaderSection[i].rectTransform.position =StartPos;

        }
    }
	
	// Update is called once per frame
	void Update ()
    {
       // Debug.Log(Components);
	}

    string GetDataValue(string data, string index)
    {
        string value = data.Substring(data.IndexOf(index) + index.Length);
        if (value.Contains("|"))
        {
            value = value.Remove(value.IndexOf("|"));
        }
        else if (value.Contains("_"))
        {
            value = value.Remove(value.IndexOf("_"));
            return value + "Generous Donor";
        }
        else
        {
            return value + ":";
        }
        return value;
    }
}
