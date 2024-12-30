using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PintuBuka : MonoBehaviour
{
    public int Rotasi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player")){
            transform.localRotation= Quaternion.Euler(0, Rotasi, 0);
    }
}
}
