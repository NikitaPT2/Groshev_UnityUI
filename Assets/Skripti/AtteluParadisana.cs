using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour
{
    public GameObject pets;
    public GameObject skin;
    public GameObject head;
    public GameObject mainigaisAttels;
    public Sprite[] atteluMasivs;
    public GameObject slaideris;
    public GameObject slaideris2;
    public float x;
    public float y;

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
    public void izkritosais(int skaitlis){
        if (skaitlis == 0)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[0];

        }
        else if (skaitlis == 1)
        {
            mainigaisAttels.GetComponent<Image>().sprite = atteluMasivs[1];

        }
    }
    public void fandx()
    {
        float pasreizejaVertiba = slaideris.GetComponent<Slider>().value;
        x = 1F * pasreizejaVertiba;
        float pasreizejaVertiba2 = slaideris2.GetComponent<Slider>().value;
        y = 1F * pasreizejaVertiba2;
    }
    public void mainitLielumu()
    {
        fandx();
        mainigaisAttels.transform.localScale = new Vector2(x, y);
    }

    public void mainitLielumu2()
    {
        fandx();
        mainigaisAttels.transform.localScale = new Vector2(x, y);

    }
}
