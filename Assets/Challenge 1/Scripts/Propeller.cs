using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
 
        public float spinSpeed;

       
        void Update()
        {
            
            transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
        }
}
