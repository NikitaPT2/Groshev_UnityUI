using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour{
    public string teksts, vecums;
    public GameObject ievadesLauks;
    public GameObject ievadesLauks2;
    public GameObject tekstaAttelosana;

    public void uzglabatTekstu()
    {

        teksts = ievadesLauks.GetComponent<Text>().text;
        vecums = ievadesLauks2.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Supervaronis " + teksts + " ir " + vecums + " gadus vecs!";

    }




}
