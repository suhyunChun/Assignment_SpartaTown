using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    // Start is called before the first frame update

   public GameObject target; 
   public float moveSpeed = 5f; 
   private Vector3 tmpPosition; 

    void Start()
    {

    }

    void Update()
    {
        tmpPosition.Set(target.transform.position.x, target.transform.position.y, this.transform.position.z);
        this.transform.position = Vector3.Lerp(this.transform.position, tmpPosition, moveSpeed * Time.deltaTime);            
    }
}