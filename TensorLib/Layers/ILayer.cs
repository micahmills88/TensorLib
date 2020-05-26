using System;
using System.Collections.Generic;
using System.Text;

namespace TensorLib
{
    public interface ILayer
    {
        public Tensor Forward(Tensor input);
    }
}
