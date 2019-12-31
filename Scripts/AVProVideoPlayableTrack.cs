using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using RenderHeads.Media.AVProVideo;

[Serializable]
[TrackColor(0.855f, 0.8623f, 0.87f)]
[TrackBindingType(typeof(MediaPlayer))]
[TrackClipType(typeof(AVProVideoPlayableClip))]
public class AVProVideoPlayableTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        return ScriptPlayable<AVProVideoPlayableMixerBehaviour>.Create(graph, inputCount);
    }
}
