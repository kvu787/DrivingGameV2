using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace DrivingGameV2 {
    public class UI : MonoBehaviour {
        public static string LapTimesFilePath;

        void Awake() {
            //Screen.fullScreenMode = FullScreenMode.ExclusiveFullScreen;
            string prefix = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss-fff");
            LapTimesFilePath = $"{Application.persistentDataPath}/{prefix} LapTimes.txt".Replace("/", "\\");
        }

        //void OnEnable() {
        //    string debugLogFilePath = $"{Application.persistentDataPath}/Player.log".Replace("/", "\\");
        //    string text =
        //        $"DEBUG LOG:\n" +
        //        $"{debugLogFilePath}\n" +
        //        $"\n" +
        //        $"LAP TIMES:\n" +
        //        $"{LapTimesFilePath}";
        //    this.GetComponent<UIDocument>().rootVisualElement.Q<Label>("topLeftText").text = text;
        //}

        void Update() {
            float fps = 1f / Time.deltaTime;
            List<string> lines = new() {
                $"FPS: {fps}",
                $"Screen.fullScreen: {Screen.fullScreen}",
                $"Screen.fullScreenMode: {Screen.fullScreenMode}",
            };
            this.GetComponent<UIDocument>().rootVisualElement.Q<Label>("topLeftText").text = string.Join("\n", lines);
        }
    }
}
