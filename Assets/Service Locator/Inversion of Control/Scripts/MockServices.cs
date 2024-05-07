using System.Collections.Generic;
using UnityEngine;

namespace UnitySevicesLocator
{
    interface ILocalization
    {
        string GetLocalizeWorld(string key);
    }
    
    
    
    public class MockLocalization : ILocalization
    {
        readonly List<string> words = new List<string>
        {
            "Hello",
            "World",
            "Unity",
            "Service",
            "Locator"
        };

        private readonly System.Random _random = new System.Random();
        
        public string GetLocalizeWorld(string key)
        {
            return words[_random.Next(words.Count)];
        }  
    }
    
    
    public interface ISerializer
    {
        void Serialize();
    }
    
    public class MockSerializer : ISerializer
    {
        public void Serialize()
        {
            Debug.Log("MockSerializer.Serialize");
        }
    }
        
        
    public interface IAudioServices
    {   
        void Play();
    }
        
    public class MockAudioServices : IAudioServices
    {
        public void Play()
        {
            Debug.Log("MockAudioServices.Play");
        }
    }
        
    public interface IGameServies
    {
        void StartGame();
    }
        
    public class MockGameServices : IGameServies
    {
        public void StartGame()
        {
            Debug.Log("MockGameServices.StartGame");
        }
    }
}
