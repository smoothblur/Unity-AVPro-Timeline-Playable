using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

[Serializable]
public class AVProVideoPlayableClip : PlayableAsset, ITimelineClipAsset
{
    public AVProVideoPlayableBehaviour template = new AVProVideoPlayableBehaviour();

    public ClipCaps clipCaps
    {
        get { return ClipCaps.None; }
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<AVProVideoPlayableBehaviour>.Create(graph, template);
        return playable;
    }
}
