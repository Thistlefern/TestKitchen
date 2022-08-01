using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Timeline;
using UnityEngine.Playables;
public class ContextMenuAdditions
{
    [MenuItem("CONTEXT/PlayableDirector/test")]
    public static void TestFunction(MenuCommand command)
    {

        PlayableDirector director = (PlayableDirector)command.context;

        Debug.Log(director.playableAsset);
    }
}