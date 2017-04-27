using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameMenu : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

   //Creo que esta opcion solo aparecera cuando termine el juego
    public void GoToQuickToPlay() //Lo mandamos a la sala de creacion de su partida rapida
    {
#pragma warning disable CS0618 
        Application.LoadLevel(2);
#pragma warning restore CS0618 
    }
    //Lo mandamos a la seccion normal del juego
    public void GoToNewGame()
    {
#pragma warning disable CS0618        
        Application.LoadLevel(2);
#pragma warning restore CS0618        
    }
    // Solo cuando tenga partidas guardadas
    public void GoToLoadGame()
    {
#pragma warning disable CS0618 
        Application.LoadLevel(2);
#pragma warning restore CS0618 
    }
    // En cualquiera de los casos
    public void GoToOpcions()
    {
#pragma warning disable CS0618  
        Application.LoadLevel(2);
#pragma warning restore CS0618  
    }
    // Puede ser que  al final del demo o juego aparezcan los creditos
    public void GoToCredits()
    {
#pragma warning disable CS0618  
        Application.LoadLevel(2);
#pragma warning restore CS0618 
    }
}
