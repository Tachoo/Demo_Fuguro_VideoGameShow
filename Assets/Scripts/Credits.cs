using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class Credits : MonoBehaviour {
    public string[] ArrayTxT;
    public string Components;
    public Text [] HeaderSection;
   // private Vector3 StartPos = new Vector3(470.0f, 440.0f);
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
            HeaderSection[i].text = GetDataValue(ArrayTxT[i]);
            HeaderSection[i].rectTransform.position -= new Vector3(0, -30);
                                   
        }
 
    }
	
	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < HeaderSection.Length; i++)
        {
            HeaderSection[i].rectTransform.position += new Vector3(0, 1.5f);
        }
    }

    string GetDataValue(string data)
    {
        string value = data;
        if (value.Contains("|"))
        {
            value = value.Remove(value.IndexOf("|"), 1);
            return value;
        }
        else if (value.Contains("_"))
        {
            value = value.Remove(value.IndexOf("_"),1);
            return "Donor "+value;
        }
        else
        {
           return value+":";
        }
        
    }
}
