using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasPoint : MonoBehaviour {
    private bool isHitted = false;
    private void onTriggerEnter(Collider collision)
    {
        if (isHitted)
        {
            collision.gameObject.tag = "Untagged";
            isHitted = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        isHitted = false;
    }
    public bool  GetIsHitted()
    {
        return isHitted;
    }
}
