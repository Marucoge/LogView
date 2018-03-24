using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEditor;
using UnityEngine;
using System;


namespace Labo{
    public class LogUserTest : MonoBehaviour{
        private float lastUpdatedTime = 0.00f;

        private void Awake() {
            LogView.Log("Awake");
        }

        private void Start() {
            LogView.Log("Start");
        }

        private void Update() {
            // 1秒ごとにログを出す。
            if (Time.time < lastUpdatedTime + 1.00f) { return; }
            float flooredTime = Mathf.Floor(Time.time);
            LogView.Log("Time.time: " + flooredTime.ToString());
            lastUpdatedTime += 1.00f;
        }
    }
}