using UnityEngine;

public class Final : MonoBehaviour
{
    public Timer ourNewTimer;

    // Alternative method to initialize timer without using the inspector.
    public Timer alternative = new() { initialTime = 5f };

    // Update is called once per frame
    void Update()
    {
        Debug.Log(ourNewTimer.GetCurrentTime);
        
        // So many ways to tick our timer!

        ourNewTimer.TickUntilFinish(() => {
            Debug.Log("Hello World");
        }, false);

        // or -------------------

        ourNewTimer.TickUntilFinish(OnTimerFinish, false);

        // or -------------------

        if (ourNewTimer.TickUntilFinish(false))
        {
            Debug.Log("Hello World");
        }

        // or -------------------

        if (ourNewTimer.IsFinished(false))
        {
            Debug.Log("Hello World");
        }
        else
        {
            ourNewTimer.Tick();
        }
    }

    void OnTimerFinish()
    {
        Debug.Log("Hello World");
    }
}
