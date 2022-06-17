# ccf-body-ui
Open the folder "ccf-body-ui" in Unity version 2021.3.4f1.

**This project includes the requirements put forth in the test:**

Scene:
- Main

GameObjects:
- Camera
- Directional Light
- Cube
- URLHandler
- EditorHandler

Scripts:
- Script ```Movement.cs``` to move a 3D cube by .001 scene units every time the user presses the relevant key. Script attached to GameObject ```Cube```.
- Script ```WebRequestHandler.cs``` that uses a coroutine to make a URL call using ```UnityWebRequest```. Script is attached to GameObject ```URLHandler```. 
- Script ```EditorHandler.cs``` to show the captured response in the Unity Inspector. Script attached to GameObject ```EditorHandler```.

# Relevant Screenshots
<p align="center">
<img src="https://user-images.githubusercontent.com/31995443/174252883-e4cfc172-ec15-4eef-b462-4cec3526742f.png" style="width:100%">
Fig.1. URL response in console and inspector.<br><br>
<img src="https://user-images.githubusercontent.com/31995443/174256130-30d58253-6db4-470e-becc-b5f221281818.png" style="width:100%">
Fig.2. URL response showing every field in the inspector.
</p>
