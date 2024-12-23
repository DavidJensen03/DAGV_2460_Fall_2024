﻿using System;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using System.Globalization;
using System.Collections;

[RequireComponent(typeof(TextMeshProUGUI))]
public class TextMeshProBehaviour : MonoBehaviour
{
    [SerializeField] private GameAction gameActionObj;
    [SerializeField] private UnityEvent awakeEvent, raiseEvent;

    private TextMeshProUGUI textObj;
    private WaitForSeconds waitForFixedUpdate;

    private int currentNum;

    private void Start()
    {
        waitForFixedUpdate = new WaitForSeconds(0.1f); // Set delay time for UpdateNumberCount
        Awake();
        awakeEvent.Invoke();
    }

    private void OnDestroy()
    {
        gameActionObj.RaiseNoArgs -= Raise;
    }

    protected void Awake()
    {
        textObj = GetComponent<TextMeshProUGUI>();
        gameActionObj.RaiseNoArgs += Raise;
    }

    private void Raise() => raiseEvent.Invoke();
    public void UpdateText(intData intDataObj) => textObj.text = intDataObj.value.ToString();

    public void UpdateText(string obj) => textObj.text = obj;

    public void UpdateText(FloatData obj) => textObj.text = obj.Value.ToString(CultureInfo.CurrentCulture);

    public void UpdateTextWithTime(FloatData obj)
    {
        TimeSpan timeSpanObj = TimeSpan.FromSeconds(obj.Value);
        textObj.text = $"{timeSpanObj.Minutes}:{timeSpanObj.Seconds:d2}";
    }

    public void UpdateTextAsMoney(intData obj)
    {
        textObj.text = obj.value.ToString("C0");
    }

    public void StoreIntDataValue(intData obj)
    {
        currentNum = obj.value;
    }

    public void StartUpdateNumberCount(intData obj)
    {
        StartCoroutine(UpdateNumberCount(obj));
    }

    private IEnumerator UpdateNumberCount(intData intData)
    {
        while (intData.value != currentNum)
        {
            currentNum -= 5; // You may want to adjust the decrement value here
            textObj.text = currentNum.ToString("C0");
            yield return waitForFixedUpdate;
        }
    }
}