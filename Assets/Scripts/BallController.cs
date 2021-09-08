using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    GameObject GameController;
    // Start is called before the first frame update
    void Start()
    {
        GameController = GameObject.Find("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "area5")
        {
            GameController.GetComponent<GameController>().countscore(5);
            Destroy(gameObject);
        }else if(other.gameObject.tag == "area10"){
            GameController.GetComponent<GameController>().countscore(10);
            Destroy(gameObject);
        }else if(other.gameObject.tag == "area15"){
            GameController.GetComponent<GameController>().countscore(15);
            Destroy(gameObject);
        }
            
     }


}
