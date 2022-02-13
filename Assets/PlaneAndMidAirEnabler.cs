using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneAndMidAirEnabler : MonoBehaviour
{
    public GameObject theObject;
    public GameObject theFinder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked(){
        if (theObject.activeInHierarchy){
            theObject.SetActive(false);
            theFinder.SetActive(false);
        }
        else {
            theObject.SetActive(true);
            theFinder.SetActive(true);
        }
            
    }
}
