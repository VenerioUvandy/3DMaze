//using System.Collections;
//using UnityEngine;
//using UnityEngine.UI;

//public class PhoneCameraScreenSpace : MonoBehaviour
//{
//    [SerializeField] RawImage background;
//    Coroutine cameraStarter;
//    WebCamTexture backCamera;
//    private void OnEnable()
//    {
//        if(cameraStarter == null)
//           cameraStarter = StartCoroutine(StartCamera());
//    }

//    private void OnDisable()
//    {
//        StopCoroutine(cameraStarter);
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    IEnumerator StartCamera()
//    {
//        while (UnityEditor.EditorApplication.isRemoteConnected == false)
//            yield return new WaitForEndOfFrame();

//        WebCamDevice[] devices = WebCamTexture.devices;
//        foreach (var device in devices)
//        {
//            if (device.isFrontFacing == false)
//                backCamera = new WebCamTexture(device.name, Screen.width, Screen.height, 60);
//        }

//        if(backCamera == null)
//        {
//            Debug.Log("Back camera not found");
//            yield break;
//        }

//        background.texture = backCamera;
//        backCamera.Play();
//    }
//}
