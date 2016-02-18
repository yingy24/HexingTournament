using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class UI_Hexes : MonoBehaviour {

    //Public Members Variables
    public GameObject spawnOne;
    public GameObject spawnTwo;
    public GameObject spawnThree;
    public GameObject spawnFour;

    public RawImage lightHex;       
    public RawImage darkHex;        
    public RawImage lighteningHex;  
    public RawImage fireHex;       
    public RawImage iceHex;         
    public RawImage windHex;

    public RawImage lightRing;
    public RawImage darkRing;
    public RawImage lighteningRing;
    public RawImage fireRing;
    public RawImage iceRing;
    public RawImage windRing;


    // Use this for initialization
    void Start() {

                for(int i = 0; i < 4; ++i)
        {
            if (i == 1)
                One();
            else if (i == 2)
                Two();
            else if (i == 3)
                Three();
            else
                Four();               
        }

    }
    public void One()
    {
        RawImage hex;
        //int randomHex = Random.Range(1, 6);
        int randomHex = 2;
        switch(randomHex)
        {
            case 1:
                 hex = Instantiate(lightHex) as RawImage;
                hex.transform.SetParent(spawnOne.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 2:
                 hex = Instantiate(darkHex) as RawImage;
                hex.transform.SetParent(spawnOne.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 3:
                 hex = Instantiate(windHex) as RawImage;
                hex.transform.SetParent(spawnOne.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 4:
                 hex = Instantiate(fireHex) as RawImage;
                hex.transform.SetParent(spawnOne.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;
                
            case 5:
                 hex = Instantiate(iceHex) as RawImage;
                hex.transform.SetParent(spawnOne.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 6:
                 hex = Instantiate(lighteningHex) as RawImage;
                hex.transform.SetParent(spawnOne.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break; 
        }
       
    }

    public void Two()
    {
        RawImage hex;
        int randomHex = Random.Range(1, 6);
        switch (randomHex)
        {
            case 1:
                hex = Instantiate(lightHex) as RawImage;
                hex.transform.SetParent(spawnTwo.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 2:
                hex = Instantiate(darkHex) as RawImage;
                hex.transform.SetParent(spawnTwo.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 3:
                hex = Instantiate(windHex) as RawImage;
                hex.transform.SetParent(spawnTwo.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 4:
                hex = Instantiate(fireHex) as RawImage;
                hex.transform.SetParent(spawnTwo.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 5:
                hex = Instantiate(iceHex) as RawImage;
                hex.transform.SetParent(spawnTwo.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 6:
                hex = Instantiate(lighteningHex) as RawImage;
                hex.transform.SetParent(spawnTwo.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;
        }
    }

    public void Three()
    {
        RawImage hex;
        int randomHex = Random.Range(1, 6);
        switch (randomHex)
        {
            case 1:
                hex = Instantiate(lightHex) as RawImage;
                hex.transform.SetParent(spawnThree.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 2:
                hex = Instantiate(darkHex) as RawImage;
                hex.transform.SetParent(spawnThree.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 3:
                hex = Instantiate(windHex) as RawImage;
                hex.transform.SetParent(spawnThree.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 4:
                hex = Instantiate(fireHex) as RawImage;
                hex.transform.SetParent(spawnThree.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 5:
                hex = Instantiate(iceHex) as RawImage;
                hex.transform.SetParent(spawnThree.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 6:
                hex = Instantiate(lighteningHex) as RawImage;
                hex.transform.SetParent(spawnThree.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;
        }
    }

    public void Four()
    {
        RawImage hex;
        int randomHex = Random.Range(1, 6);
        switch (randomHex)
        {
            case 1:
                hex = Instantiate(lightHex) as RawImage;
                hex.transform.SetParent(spawnFour.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 2:
                hex = Instantiate(darkHex) as RawImage;
                hex.transform.SetParent(spawnFour.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 3:
                hex = Instantiate(windHex) as RawImage;
                hex.transform.SetParent(spawnFour.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 4:
                hex = Instantiate(fireHex) as RawImage;
                hex.transform.SetParent(spawnFour.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 5:
                hex = Instantiate(iceHex) as RawImage;
                hex.transform.SetParent(spawnFour.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;

            case 6:
                hex = Instantiate(lighteningHex) as RawImage;
                hex.transform.SetParent(spawnFour.transform, false);
                hex.rectTransform.localPosition = new Vector3(0, 0, 0);
                break;
        }
    }

    public void MouseOver()
    {
        Debug.Log("Working Hard");
    }
    public void OnPointerEnter(PointerEventData dataName)
    {
        Debug.Log("Working Hard");
    }
    // Update is called once per frame
    void Update () {
	
	}
}
