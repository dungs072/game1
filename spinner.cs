using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] int xD = 1;
    [SerializeField] int yD = 1;
    [SerializeField] int zD = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate(xD,yD,zD);
    }
    void Rotate(int xD,int yD,int zD)
    {
        transform.Rotate(xD,yD,zD);
    }
}
