using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiamondTimer : MonoBehaviour {
    [SerializeField]
    private Button reward;
    [SerializeField]
    private Text TReward;
    private float TimeToWait=12*60*60*1000;
    private ulong LastTimeOpen;
    private void Start()
    {
        if (PlayerPrefs.GetString("lasttimer")!=null)
        {
            
            LastTimeOpen = ulong.Parse(PlayerPrefs.GetString("lasttimer"));
        }
        if (!IsRewardReady())
        {
            reward.interactable = false;
        }

    }
    public void TimerClick()
    {
        LastTimeOpen = (ulong)DateTime.Now.Ticks;
        PlayerPrefs.SetString("lasttimer", DateTime.Now.Ticks.ToString());
        reward.interactable = false;
        PlayerPrefs.SetInt("dia", PlayerPrefs.GetInt("dia") + 10);

    }
    private void Update()
    {
        if (!reward.IsInteractable())
        {
            if (IsRewardReady())
            {
                reward.interactable = true;
                return;
            }
            //Timer
            ulong diff = (ulong)DateTime.Now.Ticks - LastTimeOpen;
            ulong m = diff / TimeSpan.TicksPerMillisecond;
            float secondsLeft = (float)(TimeToWait - m) / 1000.0f;
            Debug.Log("SEC  " + secondsLeft);
            int tmp = 0;
            string h = "";
            tmp = (int)(secondsLeft / 3600);
            h += tmp + "h:";
            secondsLeft = secondsLeft - tmp * 3600;
            tmp =(int)( secondsLeft / 60);
            h += tmp.ToString("00") + "m:";
            secondsLeft = secondsLeft - tmp * 60;
            h += secondsLeft.ToString("00")+"s";
            TReward.text = h;


        }
    }
    private bool IsRewardReady()
    {
        ulong diff = (ulong)DateTime.Now.Ticks - LastTimeOpen;
        ulong m = diff / TimeSpan.TicksPerMillisecond;
        float secondsLeft = (float)(TimeToWait - m) / 1000.0f;
        if (secondsLeft < 0)
        {
            TReward.text = "00:00:00";

            return true;
        }

        return false;
    }
}
