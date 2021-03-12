using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchController : MonoBehaviour
{
    public Light ligth;
    private Transform enemyPosition;

    // Start is called before the first frame update
    void Start()
    {
        enemyPosition = GameObject.FindGameObjectWithTag("Enemy").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Mathf.Pow(Vector3.Distance(transform.position, enemyPosition.position), 1.5f);
        if (distance >= 50)
            ligth.spotAngle = 50;
        else
        {
            ligth.spotAngle = distance;
            //ligth.innerSpotAngle = ligth.spotAngle - 9f;
        }
            

            
        
    }
}
