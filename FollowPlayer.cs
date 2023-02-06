using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public GameObject player;
    
    public Vector3 offset = new Vector3(0, 5, -6); // x y z 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      this.transform.position=player.transform.position + offset;  
    }
}
