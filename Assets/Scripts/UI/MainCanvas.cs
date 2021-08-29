using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace RTSZombie.UI
{
    public class MainCanvas : MonoBehaviour
    {
        private Canvas canvas;

        private CanvasScaler canvasScaler;

        private void Start()
        {
            canvas = GetComponent<Canvas>();
            Debug.Assert(canvas != null);

            canvasScaler = GetComponent<CanvasScaler>();
            Debug.Assert(canvasScaler != null);

            float screenWidth = Screen.width;
            float screenHeight = Screen.height;

            canvasScaler.referenceResolution = new Vector2(screenWidth, screenHeight);
        }
    }

}
