using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OldTimer : MonoBehaviour
{
    [SerializeField] float waitTime = 5f;
    private float currentWaitTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentWaitTime = waitTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentWaitTime -= Time.deltaTime;
        if (currentWaitTime <= 0f)
        {
            currentWaitTime = waitTime;
            Debug.Log("Hello World");
        }
        Debug.Log(currentWaitTime);
    }
}
