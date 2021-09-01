using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositeIron : MonoBehaviour
{
    public int amount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Picked()
    {
        amount++;
        Debug.Log(amount);
    }
}
