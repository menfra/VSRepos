using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.psuedocodes
{
    public class platformIdependence
    {
        private void InitializeComponents()
        {
#if UNITY_ANDROID
            var androidComponents = InitAdroidComponents();
#elif UNITY_IOS
            var iosComponents = InitIosComponents();
#elif UNITY_WSA
            var holoLensComponents = InitHoloLensComponents();
#else
            return;
#endif
        }
    }
}
