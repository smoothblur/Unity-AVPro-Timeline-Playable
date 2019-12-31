using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using RenderHeads.Media.AVProVideo;

[Serializable]
public class AVProVideoPlayableBehaviour : PlayableBehaviour
{
    public float startTime = 0;
    public float duration = 0;
    public float inverseDuration = 0;
    [SerializeField]
    private MediaPlayer m_VideoPlayer;

    private FrameData.EvaluationType lastEval;

    public override void OnGraphStart(Playable playable)
    {
        //m_VideoPlayer = m_Theater.GetComponentInChildren<VideoPlayer>();
        //m_VideoPlayer.Prepare();

        duration = (float)playable.GetDuration();
        inverseDuration = 1f / duration;

        //m_VideoPlayer = m_Theater.GetComponentInChildren<VideoPlayer>();
        //m_VideoPlayer.Prepare();
    }

    public override void PrepareFrame(Playable playable, FrameData info)
    {
        if (info.evaluationType == FrameData.EvaluationType.Evaluate)
        {
            //m_videoplayer.prepare();
            //m_videoplayer.time = playable.gettime();
            //m_videoplayer.pause();
        }
        if (lastEval == FrameData.EvaluationType.Evaluate && info.evaluationType == FrameData.EvaluationType.Playback)
        {
            //m_VideoPlayer.Play();
        }
        if (info.evaluationType == FrameData.EvaluationType.Playback)
        {
            //m_VideoPlayer.time = playable.GetTime();
        }

        lastEval = info.evaluationType;
    }

    public override void OnBehaviourPause(Playable playable, FrameData info)
    {
        base.OnBehaviourPause(playable, info);
        /*if (m_VideoPlayer)
        {
            m_VideoPlayer.Prepare();
            m_VideoPlayer.time = playable.GetTime();
            m_VideoPlayer.Pause();
        }*/
        lastEval = FrameData.EvaluationType.Evaluate;
    }
}
