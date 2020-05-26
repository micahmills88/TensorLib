using System;
using System.Collections.Generic;
using System.Text;

namespace TensorLib
{
    public interface IDataSource
    {
        //the datasource is a generic wrapper for any input data
        //the user provides the samples and labels in a collection of floats
        //the datasource stores those values and convertes them into batches of sample and label tensors

    }
}
