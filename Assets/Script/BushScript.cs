using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushScript : MonoBehaviour,IClicked
{
    public GameObject Dog;
    public void onClickAction()
    {
        if (Dog.activeInHierarchy == true)
            Dog.SetActive(false);
        else
            Dog.SetActive(true);
        
    }
}
