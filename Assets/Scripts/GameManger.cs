using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour {
    [SerializeField]
    private Transform m_LSpawn;
    [SerializeField]
    private Transform m_RSpawn;
    [SerializeField]
    private Transform m_CSpawn;
    [SerializeField]
    private GameObject m_Player;
    [SerializeField]
    private GameObject Prefab;
    [SerializeField][Range(1f,5f)]
    private float m_Distance;
/// //////////////////
    [SerializeField]
    private GameObject CamParticle;

    private void Start()
    {
        m_Player = GameObject.FindGameObjectWithTag("Player");
        string appId = "ca-app-pub-9336535284372672~3377970400";

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);
        if (PlayerPrefs.GetString("grahp") == "med"|| PlayerPrefs.GetString("grahp") == "low" )
        {
            CamParticle.SetActive(false);
        }
    }

    public void GetNewGround (Transform LastGround) {
        
            Debug.Log("Rand   ");
            switch (m_RandIntiation()){
                
                case 1: //Left
                    {
                        Debug.Log("L   ");

                        GameObject mPrefab = Instantiate(Prefab, new Vector3(m_LSpawn.position.x, 0, m_Player.transform.position.z+ m_Distance), m_Player.transform.rotation);
                        break;
                    }
                case 2://Center
                    {
                        Debug.Log("C   ");

                        GameObject mPrefab = Instantiate(Prefab, new Vector3(m_CSpawn.position.x, 0, m_Player.transform.position.z+ m_Distance), m_Player.transform.rotation);

                        break;
                    }
                case 3://Right
                    {
                        Debug.Log("R   ");

                        GameObject mPrefab = Instantiate(Prefab, new Vector3(m_RSpawn.position.x, 0, m_Player.transform.position.z+ m_Distance), m_Player.transform.rotation);

                        break;
                    }


            
        }
	}
   public    int m_RandIntiation()
    {
       return Random.Range(1, 3); 
    }
}
