using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    public GameObject pets;
    public GameObject skin;
    public GameObject head;

    public void petsAttelosana(bool vertiba)
    {
        pets.SetActive(vertiba);
    }

    public void skinAttelosana(bool vertiba)
    {
        skin.SetActive(vertiba);
    }

    public void headAttelosana(bool vertiba)
    {
        head.SetActive(vertiba);
    }
}
