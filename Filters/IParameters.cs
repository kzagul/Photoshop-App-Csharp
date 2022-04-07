using System;
namespace MyPhotoshop
{
    public interface IParameters
    {
        ParameterInfo[] GetDesсription();
        void SetValues(double[] values);
    }
}
