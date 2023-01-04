using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//se activa o no con cada click)

public class MagicBtn : MonoBehaviour
{
    public GameObject activeGameObject;
    
    public void ActivateObject ()
    {
        if (activeGameObject.activeSelf != true)
        {
            activeGameObject.SetActive(true);
        }

    }


    /*
     * 
     * 
     *  public GameObject activeGameObject;
    
    public void ActivateObject ()
    {
        if (activeGameObject.activeSelf != true)
        {
            activeGameObject.SetActive(true);
        }
        else
        {
            activeGameObject.SetActive(false);
        }
    } */


}
