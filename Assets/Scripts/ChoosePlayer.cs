using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoosePlayer : MonoBehaviour {
    [SerializeField]
    private Transform mPlayerPos;
    [SerializeField]
    private GameObject[] mPlayerPrefabs;
    private string mPlayerName;
    void Start () {
        mPlayerName = PlayerPrefs.GetString("mplayer", mPlayerName);
        if (mPlayerName != null)
        {
            switch (mPlayerName)
            {
                case "Player": { GameObject mpref = Instantiate(mPlayerPrefabs[0], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB1": { GameObject mpref = Instantiate(mPlayerPrefabs[1], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB2": { GameObject mpref = Instantiate(mPlayerPrefabs[2], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB3": { GameObject mpref = Instantiate(mPlayerPrefabs[3], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB4": { GameObject mpref = Instantiate(mPlayerPrefabs[4], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB5": { GameObject mpref = Instantiate(mPlayerPrefabs[5], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB6": { GameObject mpref = Instantiate(mPlayerPrefabs[6], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB7": { GameObject mpref = Instantiate(mPlayerPrefabs[7], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB8": { GameObject mpref = Instantiate(mPlayerPrefabs[8], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB9": { GameObject mpref = Instantiate(mPlayerPrefabs[9], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB10": { GameObject mpref = Instantiate(mPlayerPrefabs[10], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB11": { GameObject mpref = Instantiate(mPlayerPrefabs[11], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB12": { GameObject mpref = Instantiate(mPlayerPrefabs[12], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB13": { GameObject mpref = Instantiate(mPlayerPrefabs[13], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB14": { GameObject mpref = Instantiate(mPlayerPrefabs[14], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                case "PlayerB15": { GameObject mpref = Instantiate(mPlayerPrefabs[15], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break; }
                default: { GameObject mpref = Instantiate(mPlayerPrefabs[0], mPlayerPos.transform.position, mPlayerPos.rotation); mpref.transform.parent = this.gameObject.transform; break;}
            }

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
