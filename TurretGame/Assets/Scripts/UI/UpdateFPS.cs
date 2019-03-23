using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class UpdateFPS : MonoBehaviour
{
    // Prefix for the FPS counter text.
    public string Prefix = "FPS: ";
    // How often does the FPS get refreshed? (in seconds)
    public float RefreshTime = 0.5f;

    private Text mText;
    private int mFrameCounter;
    private float mTimeCounter;
    private float mLastFramerate;

    void Start()
    {
        mText = GetComponent<Text>();
        mFrameCounter = 0;
        mTimeCounter = 0.0f;
        mLastFramerate = 0.0f;
    }
    
    void Update()
    {
        if(mTimeCounter < RefreshTime)
        {
            mTimeCounter += Time.deltaTime;
            mFrameCounter++;
        }
        else
        {
            mLastFramerate = mFrameCounter / mTimeCounter;
            mFrameCounter = 0;
            mTimeCounter = 0.0f;
            mText.text = $"{Prefix}{mLastFramerate:n2}";
        }
    }
}
