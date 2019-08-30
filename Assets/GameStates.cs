using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "GameStates")]
public class GameStates : ScriptableObject 
{
    [TextArea(14, 10)] [SerializeField] string storyText;
    [SerializeField] GameStates[] comingStates;

    public string GetStateStory ()
    {
        return storyText;
    }

    public GameStates[] GetNextStates ()
    {
        return comingStates;
    }
}
