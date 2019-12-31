# Unity-AVPro-Timeline-Playable
Super basic Unity Timeline Playable for AVPro Video MediaPlayer

## Demo Scene:
1. Create a new Unity project and import AVProVideo from the Unity Asset Store (last tested with Unity 2019.1.x)
2. Import the .unitypackage "avpro-video-timeline-playable.unitypackage"
3. Open the included demo scene "TimelineDemo.unity"
4. Enter Play mode and click on the GameObject "DemoTimeline"
5. Open a Timeline Window in the Unity Editor and either press the play button on the Timeline or manually scrub the Timeline to see the video playback update

## Current Caveats:
- This Unity Playable is super barebones.
- It currently updates the MediaPlayer.Seek() position based on the Timeline time and clip position.
- Only works in Play Mode and Runtime. (not in Edit mode)
- It doesn't automatically set the Timeline Clip length to match the actual video length.
- It doesn't set the target video, it expects the target MediaPlayer to have a video set or other code to set the target video.
- If video playback is choppy the video might not have enough keyframes. (Fix that with ffmpeg or other encoding tools)
- Probably loads of other things...
