using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyText : MonoBehaviour
{
    public float destroyTextTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTextTime); 
    }

}
