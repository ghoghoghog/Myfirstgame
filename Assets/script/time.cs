using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class time : MonoBehaviour
{
   private float mytime=60;
   private float minus;
   [SerializeField] private TextMeshProUGUI scrollbar;
   public float timedown = 1f;
   public Slider slider;

   private void Awake()
   {
      mytime = 60;
      
   }

   private void Update()
   {
      slider.value = mytime / 60;
      if (mytime==0)
      {
         SceneManager.LoadScene("finish");
      }
      scrollbar.text ="time: "+ mytime.ToString();
      minus += Time.deltaTime;
      if (minus>1)
      {
         mytime -=1;
         minus = 0;
      }

   }
   
   
   
   
}
