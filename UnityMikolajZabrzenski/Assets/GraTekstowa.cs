using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraTekstowa : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    
    void NextGuess()
    {

        guess = (min + max) / 2;
        Debug.Log("Czy twoja liczba jest wieksza od " + guess + "?");

    }
    void StartGame()
    {
        Debug.Log("Witam w grze numer jeden w kategrii ponizej 8kb");
        Debug.Log("Wymysl liczbe od "+ min +" do "+ max);
        Debug.Log("Czy twoja liczba jest wieksza niz " + guess + "?");
        Debug.Log("Jesli jest wieksza, nacisnij strzalke w gore");
        Debug.Log("Jesli nie, strzalke w dol");
        Debug.Log("Jesli komputer podal prawidlowa liczbe, wcisnij enter");
        max++;

    }
    void Start()
    {

        StartGame();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            min = guess;
            NextGuess();


        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

            max = guess;
            NextGuess();

        }
        if (Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log("ZGADLEM BIEDAKU BIOCZLOWIEKU NO KTO JEST NAJLEPSZY");
        }
    }
}
