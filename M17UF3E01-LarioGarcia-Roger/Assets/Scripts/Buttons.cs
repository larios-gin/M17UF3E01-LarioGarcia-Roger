using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public KeyCode key;
    bool isActive = false;
    GameObject note;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(key) && isActive)
        {
            Destroy(note);
            isActive = false;

        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        isActive = true;
        if (collision.gameObject.tag == "Note")
        {
            note = collision.gameObject;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        isActive = false;
    }


    public void sumarPuntuacion()
    {
        PlayerPrefs.SetInt("Puntuacion", PlayerPrefs.GetInt("Puntuacion") + 100);
    }
}
