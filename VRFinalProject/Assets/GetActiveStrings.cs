using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetActiveStrings : MonoBehaviour
{

    //this just activates or deactivates the visual string elements on the ukulele
    //this is so the player knows what strings they are pressing at a glance
    
    public UkuleleChordRegister _Chord;

    public GameObject G;
    public GameObject C;
    public GameObject A;
    public GameObject E;
    
    // Start is called before the first frame update
    void Start()
    {
        _Chord = GameObject.Find("LeftHand Controller").GetComponent<UkuleleChordRegister>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_Chord.cActive)
        {
            C.SetActive(true);
        }
        else
        {
            C.SetActive(false);
        }
        
        if (_Chord.aActive)
        {
            A.SetActive(true);
        }
        else
        {
            A.SetActive(false);
        }
        
        if (_Chord.gActive)
        {
            G.SetActive(true);
        }
        else
        {
            G.SetActive(false);
        }
        
        if (_Chord.eActive)
        {
            E.SetActive(true);
        }
        else
        {
            E.SetActive(false);
        }
    }
}
