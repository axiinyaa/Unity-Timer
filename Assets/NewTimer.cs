using System;
using UnityEngine;

[Serializable]
public class Timer
{
    public float initialTime; // Initial time for the timer
    private float currentTime; // Current time remaining

    public float GetCurrentTime => currentTime; // Property to get current time

    public void Reset()
    {
        currentTime = initialTime; // Reset to initial time
    }

    public void Tick()
    {
        currentTime -= Time.deltaTime; // Update timer based on frame time
    }

    public bool IsFinished(bool reset = true)
    {
        if (currentTime <= 0)
        {
            if (reset) Reset(); // Reset if specified
            return true; // Timer finished
        }
        return false; // Timer still running
    }

    public void IsFinished(Action action, bool reset = true)
    {
        if (IsFinished(reset)) action.Invoke(); // Invoke action if finished
    }

    public void TickUntilFinish(Action action, bool reset = true)
    {
        Tick(); // Update timer
        IsFinished(action, reset); // Check if finished and invoke action
    }

    public bool TickUntilFinish(bool reset = true)
    {
        Tick(); // Update timer
        return IsFinished(reset); // Check if finished
    }
}
