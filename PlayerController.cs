using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
//[HideInInspector]
   
   [Range(0,20)]
   [SerializeField]
   [Tooltip("Velocidad actual del coche")]
    private float speed=10.0f;
    private float turnSpeed=45f;
    private float horizontalInput;
    private float verticalInput;

    // Start is called before the first frame update
    void Start()
    {
     Debug.Log("Método Start del PLayerController"+gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        // TENEMOS QUE MOVER EL VEHICULO HACIA ADELANTE
        transform.Translate(speed*Time.deltaTime*Vector3.forward*verticalInput); // (x=0,y=0,z=1)
        transform.Rotate(turnSpeed*Time.deltaTime*Vector3.up*horizontalInput);
    }
}
