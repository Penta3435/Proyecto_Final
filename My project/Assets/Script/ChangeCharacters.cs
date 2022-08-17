using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCharacters : MonoBehaviour
{
    //mi idea de este juego es que el jugador controle dos personajes a la vez, el prota es con el que se identifica, y el acompa�ante es como el compa�ero.
    //en un instante solo puede controlar un personaje pero con los controles puede cambiar a otro personaje, y cada personaje tendr� sus propias estad�sticas.
    //el prota y el acompa�ante son hijos del player, as� al mover el player, los hijos o sea prota y acompa�ante mover�n de la misma manera.
    GameObject prota;
    GameObject companion;
    void Start()
    {
        prota = gameObject.transform.GetChild(0).gameObject;
        companion = gameObject.transform.GetChild(1).gameObject;
    }

    void Update()
    {
        //cambiar personajes con una tecla.
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (prota.activeInHierarchy)//�que diferencia hay entre activeIHierarchy y activeSelf?
            {
                prota.SetActive(false);
                companion.SetActive(true);
            }
            else
            {
                prota.SetActive(true);
                companion.SetActive(false);
            }
        }

        //cambiar personaje con teclas 1 y 2.
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            prota.SetActive(true);
            companion.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            prota.SetActive(false);
            companion.SetActive(true);
        }
    }
}
