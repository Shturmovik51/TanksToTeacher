using System;
using UnityEngine;

namespace TANKS.Start
{
    public interface IUserInputProxy
    {
        event Action<float> AxisOnChang;

        void GetAxis();
    }
}