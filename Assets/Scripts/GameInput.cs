using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour {

    private bool swipLeft, swipRight;
    private bool isDraging = false;
    private Vector2 startTouchPos, endTouchPos,swipDelta;
    private float distance = 0.0f;
    private bool bFirstTime = true;

    private void Update()
    {
        swipLeft = swipRight = false;
        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                isDraging = true;
                if(bFirstTime)
                startTouchPos = Input.touches[0].position;
              

            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDraging = false;
                Clear();
            }

        }
        swipDelta = Vector2.zero;
        if (isDraging)
        {
            if(Input.touches.Length > 0)
            {
                swipDelta = Input.touches[0].position - startTouchPos;
                if(startTouchPos.x > Input.touches[0].position.x)
                {
                    swipLeft = true;
                    distance = startTouchPos.x - Input.touches[0].position.x;
                }
                else
                {
                    swipRight = true;
                    distance = startTouchPos.x - Input.touches[0].position.x;
                }
            }
        }
    }
    private void Reset()
    {
        startTouchPos = endTouchPos;
        isDraging = false;
    }
    private void Clear()
    {
        startTouchPos = endTouchPos;
        isDraging = false;

    }
    public Vector2 mSwipDelta { get { return swipDelta; } }
    public bool mSwipRight { get { return swipRight; } }
    public bool mSwipLeft { get { return swipLeft; } }
    public float mDistance{ get { return distance; } }

    
}
