using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using RenderHeads.Media.AVProVideo;

public class AVProVideoPlayableMixerBehaviour : PlayableBehaviour
{
    MediaPlayer m_TrackBinding;
    bool m_FirstFrameHappened;
    float m_DefaultStartTime;
    float normalizedTime;

    // NOTE: This function is called at runtime and edit time.  Keep that in mind when setting the values of properties.
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        m_TrackBinding = playerData as MediaPlayer;

        if (m_TrackBinding == null)
            return;

        if (!m_FirstFrameHappened)
        {
            m_DefaultStartTime = 0; //m_TrackBinding.Control.GetCurrentTimeMs();
            m_FirstFrameHappened = true;
        }

        int inputCount = playable.GetInputCount();
        for (int i = 0; i < inputCount; i++)
        {
            // use for blending between clips
            //float inputWeight = playable.GetInputWeight(i);

            ScriptPlayable<AVProVideoPlayableBehaviour> playableInput = (ScriptPlayable<AVProVideoPlayableBehaviour>)playable.GetInput(i);
            //AVProVideoPlayableBehaviour input = playableInput.GetBehaviour();

            // Use the above variables to process each frame of this playable.

            //normalizedTime = (float)(playableInput.GetTime() * input.inverseDuration);
            normalizedTime = ((float)playableInput.GetTime()) * 1000f;

            if (m_TrackBinding.Control != null) m_TrackBinding.Control.Seek(normalizedTime);
        }

    }

    public override void OnGraphStop(Playable playable)
    {
        if (m_TrackBinding == null)
            return;

        //if (m_TrackBinding.Control != null) m_TrackBinding.Control.Seek(m_DefaultStartTime);
        m_FirstFrameHappened = false;
    }
}
