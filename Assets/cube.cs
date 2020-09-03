using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    private PlacementIndicator placementIndicator;

    void start()
    {
        placementIndicator = FindObjectofType<PlacementIndicator>();

    }
    void Update()
    {
        if(Input.touchCount > 0  && Input.touches[0].phase == TouchPhase.Began)
        {
            GameObject obj = Instantitate(objectToSpawn,placementIndicator.transform.position,placementIndicator.transform.rotation);
            
        }
    }

}
