using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moving : MonoBehaviour
{
    //private bool isGound = true;
    public Rigidbody ball;
	private GameObject target;
	public float h = 25;
	public float gravity = -18;   
	public bool debugPath;
   private  bool isstart = true;
    private GameObject Far;
    [SerializeField]
    private Transform m_LSpawn;
    [SerializeField]
    private Transform m_RSpawn;
    [SerializeField]
    private Transform m_CSpawn;
    [SerializeField]
    private GameObject m_Player;
    public GameObject []Prefab;
    [SerializeField]
    [Range(1f, 10f)]
    private float m_Distance;
    private bool isHitted = false;
    private bool IsCounting = true;
    private int Counter=0;
    private int mBonuceCounter=0;
    private bool mIsCollide_Trigger = false;
    bool mCanIncrementBonus = true;
    [SerializeField]
    private Text mScore;
    [SerializeField]
    private Text mGewel;
    [SerializeField]
    private int mScoreincre = 1;
    private int mCurrScore = 0;
    private int swip=0; 
    public GameInput gameInput;
    public float mGroundZ = 10.0f;
    public float mGetNewGroundDistance = 2.0f;
    public GameObject GameOverCanvas;
    public GameObject MainGameCanvas;
    private Vector3 displacementXZ = new Vector3(0.0f, 0.0f, 0.0f);
    private Rigidbody rg;
    public float mSwipForce = 150.0f;
    private int mGroundcounter = 0;
    private int mgroundCurrent;
    private bool mBuildDiamond = false;
    /// <summary>
    /// ////////////////Sounds Event
    /// </summary>
    [SerializeField]
    private AudioSource mAudioEvent;
    [SerializeField]
    private AudioClip mItemgot;
    [SerializeField]
    private AudioClip mCenterHit;
    private int highscore;
    public Text mGameOverScore;
    public Text mGameOverHighScore;
    [SerializeField]
    private GameObject Diamond;
    [SerializeField]
    private Slider slider;
    void mGameOver()
    {
        m_Player.SetActive(false);
        MainGameCanvas.SetActive(false);
        GameOverCanvas.SetActive(true);
        mGameOverScore.text = "  Score   : " + mCurrScore;
        if (mCurrScore > PlayerPrefs.GetInt("highscore",highscore))
        {
            PlayerPrefs.SetInt("highscore", mCurrScore);
        }
        mGameOverHighScore.text = "  Highest Score  : "+PlayerPrefs.GetInt("highscore", highscore);
    }
    void Start() {
		ball.useGravity = false;
        mScore.text = "" + mCurrScore;
        target = FindClosestEnemy();
        rg = this.gameInput.GetComponent<Rigidbody>();
        mgroundCurrent = m_RandGround();
        mGewel.text = ""+PlayerPrefs.GetInt("dia");
if (PlayerPrefs.GetInt("vads") >= 5){
            PlayerPrefs.SetInt("vads", 0);

            GoogleMobileVedioAds.Instance.ShowVedio();

        }
        else
        {
            PlayerPrefs.SetInt("vads", PlayerPrefs.GetInt("vads")+1);

        }
    }
    void mChooseNextGround()
    {
        if (mGroundcounter >= 20)
        {
            int tmp = m_RandGround();
            if (mgroundCurrent != tmp)
                mgroundCurrent = tmp;
            else
                mgroundCurrent = m_RandGround();
            mGroundcounter = 0;
            if (gravity > -40)
            {
                gravity += -3;
                mSwipForce += 50;
            }
            mBuildDiamond = true;
        }
    }
	void Update() {
        mChooseNextGround();
        if (  Input.touchCount>0   && isstart==true) {
            //isGound = true;
            Launch();
            isstart = false;
          //  isGound = false;
		}
        if (Input.GetKey(KeyCode.Space) && isstart == true)
        {
            //isGound = true;
            Launch();
            isstart = false;
            //  isGound = false;
        }
        //  isGound = false;


        if (transform.position.y <= -1)
    {
            mGameOver();
    }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        
        if(other.tag != "diamond")
        {
            mIsCollide_Trigger = true;
            if (mBonuceCounter == 0)
            {
                slider.value = 0;
            }
            else
            {
                slider.value += .03f;
            }
            mBonuceCounter++;
            if (mBonuceCounter > 10&& mBonuceCounter<20) { mScoreincre += 2; }
            if (mBonuceCounter == 20&& mBonuceCounter<30) { mScoreincre += 3;  }
            if (mBonuceCounter >= 30 && mCanIncrementBonus) { mScoreincre += 4; mCanIncrementBonus = false; }
            other.enabled = false;
            if (PlayerPrefs.GetString("fx") == "on"&&mAudioEvent.isPlaying==false)
            {
                mAudioEvent.clip = mCenterHit;
                mAudioEvent.Play();
            }
        }
        else
        {
            PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") + 1);
            mGewel.text = "" + PlayerPrefs.GetInt("dia");
            if (PlayerPrefs.GetString("fx") == "on")
            {
                mAudioEvent.clip = mItemgot;
                mAudioEvent.Play();
            }

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.tag = "Untagged";
        target = FindClosestEnemy();
     
            //isGound = true;
            Launch();

            GetNewGround();
            collision.gameObject.GetComponent<Rigidbody>().useGravity = true;

            mCurrScore += mScoreincre;
            mScore.text = "" + mCurrScore;
            if (!mIsCollide_Trigger)
            {
                mIsCollide_Trigger = false;
                mBonuceCounter = 0;
                mCanIncrementBonus = true;
            }
            mIsCollide_Trigger = false;

        mGroundcounter++;
    }
    void Launch() {
        //if (!isGound) { return; }
		Physics.gravity = Vector3.up * gravity;
		ball.useGravity = true;
		ball.velocity = CalculateLaunchData ().initialVelocity;
	}
	LaunchData CalculateLaunchData() {
        displacementXZ = new Vector3(0.01f, 0, target.transform.position.z - ball.position.z);
        float displacementY = target.transform.position.y - ball.position.y;
        float time = Mathf.Sqrt(-2 * h / gravity) + Mathf.Sqrt(2 * (displacementY - h) / gravity);
        Vector3 velocityY = Vector3.up * Mathf.Sqrt(-2 * gravity * h);
        Vector3 velocityXZ = displacementXZ / time;

        return new LaunchData(velocityXZ + velocityY * -Mathf.Sign(gravity), time);
    }
	struct LaunchData {
		public readonly Vector3 initialVelocity;
		public readonly float timeToTarget;

		public LaunchData (Vector3 initialVelocity, float timeToTarget)
		{
			this.initialVelocity = initialVelocity;
			this.timeToTarget = timeToTarget;
		}
		
	}
    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
    public void GetNewGround()
    {
        if (!mBuildDiamond)
        {
            switch (m_RandIntiation())
            {

                case 1: //Left
                    {
                        GameObject mPrefab = Instantiate(Prefab[mgroundCurrent], new Vector3(m_LSpawn.position.x, 0, mGroundZ), m_LSpawn.transform.rotation);

                        break;
                    }
                case 2://Center
                    {
                        GameObject mPrefab = Instantiate(Prefab[mgroundCurrent], new Vector3(m_CSpawn.position.x, 0, mGroundZ), m_LSpawn.transform.rotation);

                        break;
                    }
                case 3://Right
                    {
                        GameObject mPrefab = Instantiate(Prefab[mgroundCurrent], new Vector3(m_RSpawn.position.x, 0, mGroundZ), m_LSpawn.transform.rotation);
                        break;
                    }


            }
        }
        else
        {
            GameObject mPrefab = Instantiate(Diamond, new Vector3(m_CSpawn.position.x, 0, mGroundZ), m_CSpawn.transform.rotation);
            mBuildDiamond = false;
        }
        mGroundZ += mGetNewGroundDistance;

    }
    public int m_RandIntiation()
        {
            return Random.Range(1, 3);
        }

    public int m_RandGround()
    {
        return Random.Range(0, 8);
    }
    IEnumerator mWaiting()
    {


        float timePassed = 0;
        while (timePassed < 1)
        {
            // Code to go left here
            timePassed += Time.deltaTime;

            yield return null;
        }
    }
    private void FixedUpdate()
    {
        if (gameInput.mSwipLeft||Input.GetKey(KeyCode.LeftArrow))
        {
            mSwipLeft();
        }
        else if (gameInput.mSwipRight|| Input.GetKey(KeyCode.RightArrow))
        {
            mSwipRight();
        }
    }
    void mSwipLeft()
    {
        rg.AddForce(new Vector3(-mSwipForce * Time.deltaTime, 0));
    }
    void mSwipRight()
    {
        rg.AddForce(new Vector3(mSwipForce * Time.deltaTime, 0));
    }
}