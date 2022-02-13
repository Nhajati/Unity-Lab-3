using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEnableDisable : MonoBehaviour
{
    public GameObject theObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked(){
        if (theObject.activeInHierarchy)
            theObject.SetActive(false);
        else
            theObject.SetActive(true);
    }
}
