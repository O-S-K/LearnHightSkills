using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnitySevicesLocator;
 
public class PlayerTest : MonoBehaviour
{
     private ILocalization localization;
     private ISerializer serializer;
     private IAudioServices audioServices;
     private IGameServies gameServices;

     private void Awake()
     {
          ServiceLocator.Global.Register<ILocalization>(localization = new MockLocalization());
          ServiceLocator.ForSceneOf(this).Register<IGameServies>(gameServices = new MockGameServices());
          ServiceLocator.For(this).Register<ISerializer>(serializer = new MockSerializer());
          ServiceLocator.For(this).Register<IAudioServices>(audioServices = new MockAudioServices());
     }

     private void Start()
     {
          ServiceLocator.For(this)
               .Get(out serializer)
               .Get(out localization)
               .Get(out gameServices)
               .Get(out audioServices);

          Debug.Log(localization.GetLocalizeWorld("Hello"));
          serializer.Serialize();
          audioServices.Play();
          gameServices.StartGame();
     }
}
