using UnityEngine;

public class GroundFall : MonoBehaviour {
	void Update () {
        if (transform.position.y <= -3)
        {
            Destroy(this.gameObject);
        }
	}
    
}
