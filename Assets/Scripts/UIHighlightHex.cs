using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIHighlightHex : MonoBehaviour
{

    public GameObject spawnOne;
    public GameObject spawnTwo;
    public GameObject spawnThree;
    public GameObject spawnFour;

    public RawImage lightRing;
    public RawImage darkRing;
    public RawImage lighteningRing;
    public RawImage fireRing;
    public RawImage iceRing;
    public RawImage windRing;


    public void Typical()
    {
        Debug.Log("Working Hard");
        darkRing.enabled = true;
    }

    public void hexFinding()
    {
      
            darkRing.enabled = true;

    }
}
