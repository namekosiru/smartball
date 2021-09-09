using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFallballs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerExit(Collider other)
    {   
        // Debug.Log(latestPos);
        Vector3 pos = other.transform.position;
        if (pos.z < 0)
        {
            Destroy(other.gameObject);
        }
            
    }
}
