using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoonCollision : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
       Destroy(gameObject);
   }
}
