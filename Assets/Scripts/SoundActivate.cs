using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activarsonido : MonoBehaviour
{
    public GameObject post;
    public GameObject post1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("velocidad", post.transform.position);
           
        }
       
    }
 
     
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            AudioManager.Instance.Play3D("sound2", post1.transform.position);
           // AudioManager.Instance.Play2D("sound2");
        }
      

      
    }

    
   

}
