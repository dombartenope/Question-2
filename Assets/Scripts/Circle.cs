using System;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    public string appId = "ab48aad2-e656-4249-af49-52fd2b91d75c";
    public string externalUserId = "123456789";
    // Start is called before the first frame update
    void Start()
    {    
        OneSignal.StartInit(appId).EndInit();
        OneSignal.SetEmail("dominickbartenope@yahoo.com");
        OneSignal.SetExternalUserId(externalUserId);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() 
    {
        Destroy(gameObject);
    }

    // Gets called when the player opens a OneSignal notification.
    private static void OneSignalHandleNotificationOpened(OSNotificationOpenedResult result) {
    // Place your app specific notification opened logic here.
    }

    // iOS - Fires when the user anwser the notification permission prompt.
    private void OneSignalPromptForPushNotificationsReponse(bool accepted) {
    // Optional callback if you need to know when the user accepts or declines notification permissions.
    }
}

