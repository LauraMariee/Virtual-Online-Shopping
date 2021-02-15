﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace Model
{
    public class ModelSliders : MonoBehaviour
    {
        public int minSize;
        public int maxSize;

        private GameObject startPoint;
        private GameObject endPoint;

        public GameObject physicalHandle;

        public Text handleText;

        private int PositionToValue(Vector3 position)
        {
            var startPosition = startPoint.GetComponent<Transform>().position;
            var endPosition = endPoint.GetComponent<Transform>().position;
            var fraction = (position - startPosition).magnitude / (endPosition - startPosition).magnitude;

            var value = minSize + fraction * (maxSize - minSize);
            return (int)Math.Round(value);
        }

        private Vector3 ValueToPosition(float value)
        {
            var fraction = (value - minSize) / (maxSize - minSize);

            var startPosition = startPoint.GetComponent<Transform>().position;
            var endPosition = endPoint.GetComponent<Transform>().position;
            var position = startPosition + (endPosition - startPosition) * fraction;
            return position;
        }
    
        private void Start()
        {
            startPoint = GameObject.Find("Start");
            endPoint = GameObject.Find("End");
        }

        private Vector3 GetHandlePosition()
        {
            var handlePosition = physicalHandle.GetComponent<Transform>().position;
            return handlePosition;
        }

        private void Update()
        {
            AssignText();
        }

        public int AssignText()
        {
            handleText.text = PositionToValue(GetHandlePosition()).ToString();
            return Convert.ToInt32(handleText.text);
        }

    }
}
