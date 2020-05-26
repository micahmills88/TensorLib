using ILGPU;
using ILGPU.Runtime;
using ILGPU.Runtime.CPU;
using ILGPU.Runtime.Cuda;
using ILGPU.Runtime.OpenCL;
using System;

namespace TensorLib
{
    public static class TensorController
    {
        private static Accelerator _accelerator;

        static TensorController()
        {
            var context = new Context();
            context.EnableAlgorithms();
            if(!CudaAccelerator.CudaAccelerators.IsEmpty)
            {
                _accelerator = new CudaAccelerator(context);
            }
            else if(!CLAccelerator.CLAccelerators.IsEmpty)
            {
                _accelerator = new CLAccelerator(context, CLAccelerator.CLAccelerators[0]);
            }
            else
            {
                _accelerator = new CPUAccelerator(context);
            }
        }

        public static Tensor CreateTensor(int rows, int columns, int layers, int cubes, float[] data)
        {
            Tensor t = new Tensor();
            return t;
        }
    }
}
