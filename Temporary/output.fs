module SpiralExample.Main
let cuda_kernels = """
#include "cub/cub.cuh"

extern "C" {
    typedef float(*FunPointer0)(float, float);
    __global__ void method_17(float * var_0, long long int var_1, float * var_2);
    __global__ void method_19(float * var_0, float * var_1, long long int var_2, float * var_3, long long int var_4);
    __global__ void method_27(float var_0, float var_1, float * var_2, float * var_3, float * var_4, long long int var_5, float * var_6);
    __global__ void method_29(float * var_0, float * var_1, float * var_2, float * var_3, long long int var_4, float * var_5);
    __global__ void method_31(float * var_0, float * var_1);
    __global__ void method_35(float * var_0, float * var_1, float * var_2);
    __device__ void method_18(float * var_0, long long int var_1, float * var_2, long long int var_3, long long int var_4);
    __device__ float method_20(float * var_0, float * var_1, long long int var_2, long long int var_3, float var_4, long long int var_5);
    __device__ float method_21(float var_0, float var_1);
    __device__ void method_28(float var_0, float var_1, float * var_2, float * var_3, float * var_4, long long int var_5, float * var_6, long long int var_7, long long int var_8);
    __device__ void method_30(float * var_0, float * var_1, float * var_2, float * var_3, long long int var_4, float * var_5, long long int var_6, long long int var_7);
    __device__ void method_32(float * var_0, float * var_1, long long int var_2);
    __device__ void method_36(float * var_0, float * var_1, float * var_2, long long int var_3);
    
    __global__ void method_17(float * var_0, long long int var_1, float * var_2) {
        long long int var_3 = threadIdx.x;
        long long int var_4 = threadIdx.y;
        long long int var_5 = threadIdx.z;
        long long int var_6 = blockIdx.x;
        long long int var_7 = blockIdx.y;
        long long int var_8 = blockIdx.z;
        long long int var_9 = gridDim.x;
        long long int var_10 = (var_6 * 128);
        long long int var_11 = (var_10 + var_3);
        long long int var_12 = (var_9 * 128);
        method_18(var_0, var_1, var_2, var_12, var_11);
    }
    __global__ void method_19(float * var_0, float * var_1, long long int var_2, float * var_3, long long int var_4) {
        long long int var_5 = threadIdx.x;
        long long int var_6 = threadIdx.y;
        long long int var_7 = threadIdx.z;
        long long int var_8 = blockIdx.x;
        long long int var_9 = blockIdx.y;
        long long int var_10 = blockIdx.z;
        long long int var_11 = gridDim.x;
        long long int var_12 = (var_8 * 128);
        long long int var_13 = (var_12 + var_5);
        long long int var_14 = (var_11 * 128);
        float var_15 = 0;
        float var_16 = method_20(var_0, var_1, var_2, var_14, var_15, var_13);
        FunPointer0 var_19 = method_21;
        float var_20 = cub::BlockReduce<float,128>().Reduce(var_16, var_19);
        char var_21 = (var_5 == 0);
        if (var_21) {
            char var_22 = (var_8 >= 0);
            char var_24;
            if (var_22) {
                var_24 = (var_8 < var_4);
            } else {
                var_24 = 0;
            }
            char var_25 = (var_24 == 0);
            if (var_25) {
                // unprinted assert;
            } else {
            }
            var_3[var_8] = var_20;
        } else {
        }
    }
    __global__ void method_27(float var_0, float var_1, float * var_2, float * var_3, float * var_4, long long int var_5, float * var_6) {
        long long int var_7 = threadIdx.x;
        long long int var_8 = threadIdx.y;
        long long int var_9 = threadIdx.z;
        long long int var_10 = blockIdx.x;
        long long int var_11 = blockIdx.y;
        long long int var_12 = blockIdx.z;
        long long int var_13 = gridDim.x;
        long long int var_14 = (var_10 * 128);
        long long int var_15 = (var_14 + var_7);
        long long int var_16 = (var_13 * 128);
        method_28(var_0, var_1, var_2, var_3, var_4, var_5, var_6, var_16, var_15);
    }
    __global__ void method_29(float * var_0, float * var_1, float * var_2, float * var_3, long long int var_4, float * var_5) {
        long long int var_6 = threadIdx.x;
        long long int var_7 = threadIdx.y;
        long long int var_8 = threadIdx.z;
        long long int var_9 = blockIdx.x;
        long long int var_10 = blockIdx.y;
        long long int var_11 = blockIdx.z;
        long long int var_12 = gridDim.x;
        long long int var_13 = (var_9 * 128);
        long long int var_14 = (var_13 + var_6);
        long long int var_15 = (var_12 * 128);
        method_30(var_0, var_1, var_2, var_3, var_4, var_5, var_15, var_14);
    }
    __global__ void method_31(float * var_0, float * var_1) {
        long long int var_2 = threadIdx.x;
        long long int var_3 = threadIdx.y;
        long long int var_4 = threadIdx.z;
        long long int var_5 = blockIdx.x;
        long long int var_6 = blockIdx.y;
        long long int var_7 = blockIdx.z;
        long long int var_8 = (var_5 * 128);
        long long int var_9 = (var_8 + var_2);
        method_32(var_0, var_1, var_9);
    }
    __global__ void method_35(float * var_0, float * var_1, float * var_2) {
        long long int var_3 = threadIdx.x;
        long long int var_4 = threadIdx.y;
        long long int var_5 = threadIdx.z;
        long long int var_6 = blockIdx.x;
        long long int var_7 = blockIdx.y;
        long long int var_8 = blockIdx.z;
        long long int var_9 = (var_6 * 128);
        long long int var_10 = (var_9 + var_3);
        method_36(var_0, var_1, var_2, var_10);
    }
    __device__ void method_18(float * var_0, long long int var_1, float * var_2, long long int var_3, long long int var_4) {
        char var_5 = (var_4 < var_1);
        if (var_5) {
            char var_6 = (var_4 >= 0);
            char var_7 = (var_6 == 0);
            if (var_7) {
                // unprinted assert;
            } else {
            }
            if (var_7) {
                // unprinted assert;
            } else {
            }
            float var_8 = var_0[var_4];
            float var_9 = (-var_8);
            float var_10 = exp(var_9);
            float var_11 = (1 + var_10);
            float var_12 = (1 / var_11);
            var_2[var_4] = var_12;
            long long int var_13 = (var_4 + var_3);
            method_18(var_0, var_1, var_2, var_3, var_13);
        } else {
        }
    }
    __device__ float method_20(float * var_0, float * var_1, long long int var_2, long long int var_3, float var_4, long long int var_5) {
        char var_6 = (var_5 < var_2);
        if (var_6) {
            char var_7 = (var_5 >= 0);
            char var_8 = (var_7 == 0);
            if (var_8) {
                // unprinted assert;
            } else {
            }
            float var_9 = var_0[var_5];
            float var_10 = var_1[var_5];
            float var_11 = (var_10 - var_9);
            float var_12 = (var_11 * var_11);
            float var_13 = (var_4 + var_12);
            long long int var_14 = (var_5 + var_3);
            return method_20(var_0, var_1, var_2, var_3, var_13, var_14);
        } else {
            return var_4;
        }
    }
    __device__ float method_21(float var_0, float var_1) {
        return (var_0 + var_1);
    }
    __device__ void method_28(float var_0, float var_1, float * var_2, float * var_3, float * var_4, long long int var_5, float * var_6, long long int var_7, long long int var_8) {
        char var_9 = (var_8 < var_5);
        if (var_9) {
            char var_10 = (var_8 >= 0);
            char var_11 = (var_10 == 0);
            if (var_11) {
                // unprinted assert;
            } else {
            }
            if (var_11) {
                // unprinted assert;
            } else {
            }
            float var_12 = var_2[var_8];
            float var_13 = var_3[var_8];
            float var_14 = var_4[var_8];
            float var_15 = (var_13 - var_14);
            float var_16 = (2 * var_15);
            float var_17 = (var_0 * var_16);
            float var_18 = (var_12 + var_17);
            var_6[var_8] = var_18;
            long long int var_19 = (var_8 + var_7);
            method_28(var_0, var_1, var_2, var_3, var_4, var_5, var_6, var_7, var_19);
        } else {
        }
    }
    __device__ void method_30(float * var_0, float * var_1, float * var_2, float * var_3, long long int var_4, float * var_5, long long int var_6, long long int var_7) {
        char var_8 = (var_7 < var_4);
        if (var_8) {
            char var_9 = (var_7 >= 0);
            char var_10 = (var_9 == 0);
            if (var_10) {
                // unprinted assert;
            } else {
            }
            if (var_10) {
                // unprinted assert;
            } else {
            }
            float var_11 = var_0[var_7];
            float var_12 = var_1[var_7];
            float var_13 = var_2[var_7];
            float var_14 = var_3[var_7];
            float var_15 = (1 - var_14);
            float var_16 = (var_14 * var_15);
            float var_17 = (var_13 * var_16);
            float var_18 = (var_11 + var_17);
            var_5[var_7] = var_18;
            long long int var_19 = (var_7 + var_6);
            method_30(var_0, var_1, var_2, var_3, var_4, var_5, var_6, var_19);
        } else {
        }
    }
    __device__ void method_32(float * var_0, float * var_1, long long int var_2) {
        char var_3 = (var_2 < 7840);
        if (var_3) {
            char var_4 = (var_2 >= 0);
            char var_5 = (var_4 == 0);
            if (var_5) {
                // unprinted assert;
            } else {
            }
            if (var_5) {
                // unprinted assert;
            } else {
            }
            float var_6 = var_0[var_2];
            var_1[var_2] = var_6;
            long long int var_7 = (var_2 + 7936);
            method_32(var_0, var_1, var_7);
        } else {
        }
    }
    __device__ void method_36(float * var_0, float * var_1, float * var_2, long long int var_3) {
        char var_4 = (var_3 < 7840);
        if (var_4) {
            char var_5 = (var_3 >= 0);
            char var_6 = (var_5 == 0);
            if (var_6) {
                // unprinted assert;
            } else {
            }
            if (var_6) {
                // unprinted assert;
            } else {
            }
            float var_7 = var_0[var_3];
            float var_8 = var_1[var_3];
            float var_9 = (0.01 * var_7);
            float var_10 = (var_8 - var_9);
            var_2[var_3] = var_10;
            long long int var_11 = (var_3 + 7936);
            method_36(var_0, var_1, var_2, var_11);
        } else {
        }
    }
}
"""

type Union0 =
    | Union0Case0 of Tuple1
    | Union0Case1
and Tuple1 =
    struct
    val mem_0: ManagedCuda.BasicTypes.CUdeviceptr
    new(arg_mem_0) = {mem_0 = arg_mem_0}
    end
and Env2 =
    struct
    val mem_0: Env6
    val mem_1: int64
    new(arg_mem_0, arg_mem_1) = {mem_0 = arg_mem_0; mem_1 = arg_mem_1}
    end
and Tuple3 =
    struct
    val mem_0: Tuple4
    val mem_1: (uint8 [])
    new(arg_mem_0, arg_mem_1) = {mem_0 = arg_mem_0; mem_1 = arg_mem_1}
    end
and Tuple4 =
    struct
    val mem_0: int64
    val mem_1: int64
    val mem_2: int64
    new(arg_mem_0, arg_mem_1, arg_mem_2) = {mem_0 = arg_mem_0; mem_1 = arg_mem_1; mem_2 = arg_mem_2}
    end
and Tuple5 =
    struct
    val mem_0: int64
    val mem_1: (uint8 [])
    new(arg_mem_0, arg_mem_1) = {mem_0 = arg_mem_0; mem_1 = arg_mem_1}
    end
and Env6 =
    struct
    val mem_0: (Union0 ref)
    new(arg_mem_0) = {mem_0 = arg_mem_0}
    end
and Union7 =
    | Union7Case0 of Tuple8
    | Union7Case1
and Tuple8 =
    struct
    val mem_0: float32
    new(arg_mem_0) = {mem_0 = arg_mem_0}
    end
let rec method_0 ((var_0: System.Diagnostics.DataReceivedEventArgs)): unit =
    let (var_1: string) = var_0.get_Data()
    let (var_2: string) = System.String.Format("{0}",var_1)
    System.Console.WriteLine(var_2)
and method_1((var_0: (Union0 ref))): ManagedCuda.BasicTypes.CUdeviceptr =
    let (var_1: Union0) = (!var_0)
    match var_1 with
    | Union0Case0(var_2) ->
        var_2.mem_0
    | Union0Case1 ->
        (failwith "A Cuda memory cell that has been disposed has been tried to be accessed.")
and method_2((var_0: string)): Tuple3 =
    let (var_1: System.IO.FileMode) = System.IO.FileMode.Open
    let (var_2: System.IO.FileAccess) = System.IO.FileAccess.Read
    let (var_3: System.IO.FileShare) = System.IO.FileShare.Read
    let (var_4: System.IO.FileStream) = System.IO.File.Open(var_0, var_1, var_2, var_3)
    let (var_5: System.IO.BinaryReader) = System.IO.BinaryReader(var_4)
    let (var_6: int32) = var_5.ReadInt32()
    let (var_7: int32) = System.Net.IPAddress.NetworkToHostOrder(var_6)
    let (var_8: bool) = (var_7 = 2051)
    let (var_9: bool) = (var_8 = false)
    if var_9 then
        (failwith "Expected a 2051i32 magic number.")
    else
        ()
    let (var_10: int32) = var_5.ReadInt32()
    let (var_11: int32) = System.Net.IPAddress.NetworkToHostOrder(var_10)
    let (var_12: int32) = var_5.ReadInt32()
    let (var_13: int32) = System.Net.IPAddress.NetworkToHostOrder(var_12)
    let (var_14: int32) = var_5.ReadInt32()
    let (var_15: int32) = System.Net.IPAddress.NetworkToHostOrder(var_14)
    let (var_16: int64) = (int64 var_11)
    let (var_17: int64) = (int64 var_13)
    let (var_18: int64) = (int64 var_15)
    let (var_19: int32) = (var_11 * var_13)
    let (var_20: int32) = (var_19 * var_15)
    let (var_22: (uint8 [])) = var_5.ReadBytes(var_20)
    var_5.Dispose()
    var_4.Dispose()
    Tuple3(Tuple4(var_16, var_17, var_18), var_22)
and method_3((var_0: (uint8 [])), (var_1: (float32 [])), (var_2: int64)): unit =
    let (var_3: bool) = (var_2 < 10000L)
    if var_3 then
        let (var_4: bool) = (var_2 >= 0L)
        let (var_5: bool) = (var_4 = false)
        if var_5 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_6: int64) = (var_2 * 784L)
        if var_5 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_7: int64) = 0L
        method_4((var_0: (uint8 [])), (var_6: int64), (var_1: (float32 [])), (var_7: int64))
        let (var_8: int64) = (var_2 + 1L)
        method_3((var_0: (uint8 [])), (var_1: (float32 [])), (var_8: int64))
    else
        ()
and method_5((var_0: string)): Tuple5 =
    let (var_1: System.IO.FileMode) = System.IO.FileMode.Open
    let (var_2: System.IO.FileAccess) = System.IO.FileAccess.Read
    let (var_3: System.IO.FileShare) = System.IO.FileShare.Read
    let (var_4: System.IO.FileStream) = System.IO.File.Open(var_0, var_1, var_2, var_3)
    let (var_5: System.IO.BinaryReader) = System.IO.BinaryReader(var_4)
    let (var_6: int32) = var_5.ReadInt32()
    let (var_7: int32) = System.Net.IPAddress.NetworkToHostOrder(var_6)
    let (var_8: bool) = (var_7 = 2049)
    let (var_9: bool) = (var_8 = false)
    if var_9 then
        (failwith "Expected a 2049i32 magic number.")
    else
        ()
    let (var_10: int32) = var_5.ReadInt32()
    let (var_11: int32) = System.Net.IPAddress.NetworkToHostOrder(var_10)
    let (var_12: int64) = (int64 var_11)
    let (var_14: (uint8 [])) = var_5.ReadBytes(var_11)
    var_5.Dispose()
    var_4.Dispose()
    Tuple5(var_12, var_14)
and method_6((var_0: (uint8 [])), (var_1: (float32 [])), (var_2: int64)): unit =
    let (var_3: bool) = (var_2 < 10000L)
    if var_3 then
        let (var_4: bool) = (var_2 >= 0L)
        let (var_5: bool) = (var_4 = false)
        if var_5 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_6: int64) = (var_2 * 10L)
        let (var_7: uint8) = var_0.[int32 var_2]
        let (var_8: int64) = 0L
        method_7((var_7: uint8), (var_1: (float32 [])), (var_6: int64), (var_8: int64))
        let (var_9: int64) = (var_2 + 1L)
        method_6((var_0: (uint8 [])), (var_1: (float32 [])), (var_9: int64))
    else
        ()
and method_8((var_0: (uint8 [])), (var_1: (float32 [])), (var_2: int64)): unit =
    let (var_3: bool) = (var_2 < 60000L)
    if var_3 then
        let (var_4: bool) = (var_2 >= 0L)
        let (var_5: bool) = (var_4 = false)
        if var_5 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_6: int64) = (var_2 * 784L)
        if var_5 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_7: int64) = 0L
        method_4((var_0: (uint8 [])), (var_6: int64), (var_1: (float32 [])), (var_7: int64))
        let (var_8: int64) = (var_2 + 1L)
        method_8((var_0: (uint8 [])), (var_1: (float32 [])), (var_8: int64))
    else
        ()
and method_9((var_0: (uint8 [])), (var_1: (float32 [])), (var_2: int64)): unit =
    let (var_3: bool) = (var_2 < 60000L)
    if var_3 then
        let (var_4: bool) = (var_2 >= 0L)
        let (var_5: bool) = (var_4 = false)
        if var_5 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_6: int64) = (var_2 * 10L)
        let (var_7: uint8) = var_0.[int32 var_2]
        let (var_8: int64) = 0L
        method_7((var_7: uint8), (var_1: (float32 [])), (var_6: int64), (var_8: int64))
        let (var_9: int64) = (var_2 + 1L)
        method_9((var_0: (uint8 [])), (var_1: (float32 [])), (var_9: int64))
    else
        ()
and method_10((var_0: uint64), (var_1: System.Collections.Generic.Stack<Env2>), (var_2: uint64), (var_3: int64)): Env6 =
    let (var_4: int32) = var_1.get_Count()
    let (var_5: bool) = (var_4 > 0)
    if var_5 then
        let (var_6: Env2) = var_1.Peek()
        let (var_7: Env6) = var_6.mem_0
        let (var_8: int64) = var_6.mem_1
        let (var_9: (Union0 ref)) = var_7.mem_0
        let (var_10: Union0) = (!var_9)
        match var_10 with
        | Union0Case0(var_11) ->
            let (var_12: ManagedCuda.BasicTypes.CUdeviceptr) = var_11.mem_0
            method_11((var_12: ManagedCuda.BasicTypes.CUdeviceptr), (var_0: uint64), (var_2: uint64), (var_3: int64), (var_1: System.Collections.Generic.Stack<Env2>), (var_7: Env6), (var_8: int64))
        | Union0Case1 ->
            let (var_14: Env2) = var_1.Pop()
            let (var_15: Env6) = var_14.mem_0
            let (var_16: int64) = var_14.mem_1
            method_10((var_0: uint64), (var_1: System.Collections.Generic.Stack<Env2>), (var_2: uint64), (var_3: int64))
    else
        method_12((var_0: uint64), (var_2: uint64), (var_3: int64), (var_1: System.Collections.Generic.Stack<Env2>))
and method_13((var_0: (Union0 ref))): ManagedCuda.BasicTypes.CUdeviceptr =
    let (var_1: Union0) = (!var_0)
    match var_1 with
    | Union0Case0(var_2) ->
        var_2.mem_0
    | Union0Case1 ->
        (failwith "A Cuda memory cell that has been disposed has been tried to be accessed.")
and method_14((var_0: ManagedCuda.CudaContext), (var_1: ManagedCuda.BasicTypes.CUmodule), (var_2: ManagedCuda.CudaStream), (var_3: uint64), (var_4: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_7: (Union0 ref)), (var_8: (Union0 ref)), (var_9: (Union0 ref)), (var_10: (Union0 ref)), (var_11: int64)): float =
    let (var_12: bool) = (var_11 < 60000L)
    if var_12 then
        let (var_13: int64) = (var_11 + 128L)
        let (var_14: bool) = (var_13 > 60000L)
        let (var_15: int64) =
            if var_14 then
                60000L
            else
                var_13
        let (var_16: bool) = (var_11 < var_15)
        let (var_17: bool) = (var_16 = false)
        if var_17 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_18: int64) = (var_15 - var_11)
        let (var_19: bool) = (var_11 >= 0L)
        let (var_20: bool) = (var_19 = false)
        if var_20 then
            (failwith "Lower boundary out of bounds.")
        else
            ()
        let (var_21: bool) = (var_15 > 0L)
        let (var_23: bool) =
            if var_21 then
                (var_15 <= 60000L)
            else
                false
        let (var_24: bool) = (var_23 = false)
        if var_24 then
            (failwith "Higher boundary out of bounds.")
        else
            ()
        let (var_25: int64) = (var_11 * 784L)
        if var_17 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        if var_20 then
            (failwith "Lower boundary out of bounds.")
        else
            ()
        let (var_27: bool) =
            if var_21 then
                (var_15 <= 60000L)
            else
                false
        let (var_28: bool) = (var_27 = false)
        if var_28 then
            (failwith "Higher boundary out of bounds.")
        else
            ()
        let (var_29: int64) = (var_11 * 10L)
        let (var_30: bool) = (var_18 > 0L)
        let (var_31: bool) = (var_30 = false)
        if var_31 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_32: int64) = (var_18 * 10L)
        let (var_33: int64) = (var_32 * 4L)
        let (var_34: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_33: int64))
        let (var_35: (Union0 ref)) = var_34.mem_0
        let (var_36: bool) = (var_18 = 1L)
        if var_36 then
            let (var_37: int32) = 784
            let (var_38: int32) = 10
            let (var_39: float32) = 1.000000f
            let (var_40: int64) = 0L
            let (var_41: int64) = 0L
            let (var_42: int64) = 10L
            let (var_43: int64) = 1L
            let (var_44: int64) = 0L
            let (var_45: int64) = 784L
            let (var_46: int64) = 0L
            let (var_47: int64) = 10L
            let (var_48: int32) = 784
            let (var_49: int64) = 0L
            let (var_50: int64) = 784L
            let (var_51: int64) = 1L
            let (var_52: int64) = 0L
            let (var_53: int64) = 0L
            let (var_54: int64) = 784L
            let (var_55: int32) = 1
            let (var_56: float32) = 0.000000f
            let (var_57: int64) = 0L
            let (var_58: int64) = 0L
            let (var_59: int64) = 10L
            let (var_60: int64) = 1L
            let (var_61: int64) = 0L
            let (var_62: int64) = 0L
            let (var_63: int64) = 10L
            let (var_64: int32) = 1
            method_15((var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_37: int32), (var_38: int32), (var_39: float32), (var_8: (Union0 ref)), (var_40: int64), (var_41: int64), (var_42: int64), (var_43: int64), (var_44: int64), (var_45: int64), (var_46: int64), (var_47: int64), (var_48: int32), (var_9: (Union0 ref)), (var_25: int64), (var_49: int64), (var_50: int64), (var_51: int64), (var_52: int64), (var_18: int64), (var_53: int64), (var_54: int64), (var_55: int32), (var_56: float32), (var_35: (Union0 ref)), (var_57: int64), (var_58: int64), (var_59: int64), (var_60: int64), (var_61: int64), (var_62: int64), (var_63: int64), (var_64: int32))
        else
            let (var_65: int32) = (int32 var_18)
            let (var_66: int32) = 10
            let (var_67: int32) = 784
            let (var_68: float32) = 1.000000f
            let (var_69: int64) = 0L
            let (var_70: int64) = 784L
            let (var_71: int64) = 1L
            let (var_72: int64) = 0L
            let (var_73: int64) = 0L
            let (var_74: int64) = 784L
            let (var_75: int64) = 0L
            let (var_76: int64) = 0L
            let (var_77: int64) = 10L
            let (var_78: int64) = 1L
            let (var_79: int64) = 0L
            let (var_80: int64) = 784L
            let (var_81: int64) = 0L
            let (var_82: int64) = 10L
            let (var_83: int32) = 784
            let (var_84: float32) = 0.000000f
            let (var_85: int64) = 0L
            let (var_86: int64) = 0L
            let (var_87: int64) = 10L
            let (var_88: int64) = 1L
            let (var_89: int64) = 0L
            let (var_90: int64) = 0L
            let (var_91: int64) = 10L
            method_16((var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_65: int32), (var_66: int32), (var_67: int32), (var_68: float32), (var_9: (Union0 ref)), (var_25: int64), (var_69: int64), (var_70: int64), (var_71: int64), (var_72: int64), (var_18: int64), (var_73: int64), (var_74: int64), (var_8: (Union0 ref)), (var_75: int64), (var_76: int64), (var_77: int64), (var_78: int64), (var_79: int64), (var_80: int64), (var_81: int64), (var_82: int64), (var_83: int32), (var_84: float32), (var_35: (Union0 ref)), (var_85: int64), (var_86: int64), (var_87: int64), (var_88: int64), (var_89: int64), (var_90: int64), (var_91: int64))
        let (var_92: bool) = (0L < var_18)
        let (var_93: bool) = (var_92 = false)
        if var_93 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_94: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_33: int64))
        let (var_95: (Union0 ref)) = var_94.mem_0
        let (var_96: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_95: (Union0 ref)))
        if var_93 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_97: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        let (var_98: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_33)
        var_0.ClearMemoryAsync(var_96, 0uy, var_98, var_97)
        if var_93 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_103: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_33: int64))
        let (var_104: (Union0 ref)) = var_103.mem_0
        let (var_105: bool) = (var_32 > 0L)
        let (var_106: bool) = (var_105 = false)
        if var_106 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_107: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_35: (Union0 ref)))
        if var_106 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_108: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_104: (Union0 ref)))
        let (var_109: int64) = (var_32 - 1L)
        let (var_110: int64) = (var_109 / 128L)
        let (var_111: int64) = (var_110 + 1L)
        let (var_112: bool) = (64L > var_111)
        let (var_113: int64) =
            if var_112 then
                var_111
            else
                64L
        // Cuda join point
        // method_17((var_107: ManagedCuda.BasicTypes.CUdeviceptr), (var_32: int64), (var_108: ManagedCuda.BasicTypes.CUdeviceptr))
        let (var_115: (System.Object [])) = [|var_107; var_32; var_108|]: (System.Object [])
        let (var_116: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_17", var_1, var_0)
        let (var_117: uint32) = (uint32 var_113)
        let (var_118: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(var_117, 1u, 1u)
        var_116.set_GridDimensions(var_118)
        let (var_119: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_116.set_BlockDimensions(var_119)
        let (var_120: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_116.RunAsync(var_120, var_115)
        if var_93 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_121: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_33: int64))
        let (var_122: (Union0 ref)) = var_121.mem_0
        let (var_123: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_122: (Union0 ref)))
        if var_93 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_124: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        let (var_125: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_33)
        var_0.ClearMemoryAsync(var_123, 0uy, var_125, var_124)
        if var_106 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_126: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_104: (Union0 ref)))
        let (var_127: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_10: (Union0 ref)))
        let (var_128: int64) =
            if var_112 then
                var_111
            else
                64L
        let (var_131: bool) = (var_128 > 0L)
        let (var_132: bool) = (var_131 = false)
        if var_132 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_133: int64) = (var_128 * 4L)
        let (var_134: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_133: int64))
        let (var_135: (Union0 ref)) = var_134.mem_0
        let (var_136: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_135: (Union0 ref)))
        // Cuda join point
        // method_19((var_126: ManagedCuda.BasicTypes.CUdeviceptr), (var_127: ManagedCuda.BasicTypes.CUdeviceptr), (var_32: int64), (var_136: ManagedCuda.BasicTypes.CUdeviceptr), (var_128: int64))
        let (var_138: (System.Object [])) = [|var_126; var_127; var_32; var_136; var_128|]: (System.Object [])
        let (var_139: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_19", var_1, var_0)
        let (var_140: uint32) = (uint32 var_128)
        let (var_141: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(var_140, 1u, 1u)
        var_139.set_GridDimensions(var_141)
        let (var_142: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_139.set_BlockDimensions(var_142)
        let (var_143: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_139.RunAsync(var_143, var_138)
        let (var_145: (Union7 ref)) = (ref Union7Case1)
        let (var_146: (float32 ref)) = (ref 0.000000f)
        let (var_148: (Union7 ref)) = (ref Union7Case1)
        let (var_149: (float32 ref)) = (ref 0.000000f)
        let (var_150: float32) = method_26((var_18: int64), (var_135: (Union0 ref)), (var_128: int64), (var_0: ManagedCuda.CudaContext), (var_145: (Union7 ref)), (var_148: (Union7 ref)))
        let (var_151: string) = System.String.Format("{0}",var_15)
        let (var_152: string) = System.String.Format("{0} = {1}","near_to",var_151)
        let (var_153: string) = System.String.Format("{0}",var_11)
        let (var_154: string) = System.String.Format("{0} = {1}","from",var_153)
        let (var_155: string) = String.concat "; " [|var_154; var_152|]
        let (var_156: string) = System.String.Format("{0}{1}{2}","{",var_155,"}")
        let (var_157: string) = System.String.Format("On minibatch {0}. Error = {1}",var_156,var_150)
        let (var_158: string) = System.String.Format("{0}",var_157)
        System.Console.WriteLine(var_158)
        System.Console.WriteLine("Running the backwards phase...")
        var_149 := 1.000000f
        let (var_159: float32) = method_26((var_18: int64), (var_135: (Union0 ref)), (var_128: int64), (var_0: ManagedCuda.CudaContext), (var_145: (Union7 ref)), (var_148: (Union7 ref)))
        let (var_160: float32) = (!var_149)
        let (var_161: float32) = method_25((var_135: (Union0 ref)), (var_128: int64), (var_0: ManagedCuda.CudaContext), (var_145: (Union7 ref)))
        let (var_162: float32) = (float32 var_18)
        let (var_163: float32) = (var_160 / var_162)
        let (var_164: float32) = (!var_146)
        let (var_165: float32) = (var_164 + var_163)
        var_146 := var_165
        let (var_166: float32) = method_25((var_135: (Union0 ref)), (var_128: int64), (var_0: ManagedCuda.CudaContext), (var_145: (Union7 ref)))
        let (var_167: float32) = (!var_146)
        if var_106 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_168: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_122: (Union0 ref)))
        let (var_169: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_104: (Union0 ref)))
        let (var_170: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_10: (Union0 ref)))
        if var_106 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_171: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_122: (Union0 ref)))
        let (var_172: int64) =
            if var_112 then
                var_111
            else
                64L
        // Cuda join point
        // method_27((var_167: float32), (var_166: float32), (var_168: ManagedCuda.BasicTypes.CUdeviceptr), (var_169: ManagedCuda.BasicTypes.CUdeviceptr), (var_170: ManagedCuda.BasicTypes.CUdeviceptr), (var_32: int64), (var_171: ManagedCuda.BasicTypes.CUdeviceptr))
        let (var_174: (System.Object [])) = [|var_167; var_166; var_168; var_169; var_170; var_32; var_171|]: (System.Object [])
        let (var_175: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_27", var_1, var_0)
        let (var_176: uint32) = (uint32 var_172)
        let (var_177: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(var_176, 1u, 1u)
        var_175.set_GridDimensions(var_177)
        let (var_178: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_175.set_BlockDimensions(var_178)
        let (var_179: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_175.RunAsync(var_179, var_174)
        if var_106 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_180: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_95: (Union0 ref)))
        let (var_181: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_35: (Union0 ref)))
        let (var_182: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_122: (Union0 ref)))
        let (var_183: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_104: (Union0 ref)))
        if var_106 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_184: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_95: (Union0 ref)))
        let (var_185: int64) =
            if var_112 then
                var_111
            else
                64L
        // Cuda join point
        // method_29((var_180: ManagedCuda.BasicTypes.CUdeviceptr), (var_181: ManagedCuda.BasicTypes.CUdeviceptr), (var_182: ManagedCuda.BasicTypes.CUdeviceptr), (var_183: ManagedCuda.BasicTypes.CUdeviceptr), (var_32: int64), (var_184: ManagedCuda.BasicTypes.CUdeviceptr))
        let (var_187: (System.Object [])) = [|var_180; var_181; var_182; var_183; var_32; var_184|]: (System.Object [])
        let (var_188: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_29", var_1, var_0)
        let (var_189: uint32) = (uint32 var_185)
        let (var_190: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(var_189, 1u, 1u)
        var_188.set_GridDimensions(var_190)
        let (var_191: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_188.set_BlockDimensions(var_191)
        let (var_192: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_188.RunAsync(var_192, var_187)
        if var_36 then
            let (var_193: bool) = (var_18 > 784L)
            let (var_194: int64) =
                if var_193 then
                    var_18
                else
                    784L
            let (var_195: bool) = (var_18 > 10L)
            let (var_196: int64) =
                if var_195 then
                    var_18
                else
                    10L
            let (var_197: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_7: (Union0 ref)))
            let (var_198: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_7: (Union0 ref)))
            // Cuda join point
            // method_31((var_197: ManagedCuda.BasicTypes.CUdeviceptr), (var_198: ManagedCuda.BasicTypes.CUdeviceptr))
            let (var_200: (System.Object [])) = [|var_197; var_198|]: (System.Object [])
            let (var_201: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_31", var_1, var_0)
            let (var_202: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(62u, 1u, 1u)
            var_201.set_GridDimensions(var_202)
            let (var_203: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
            var_201.set_BlockDimensions(var_203)
            let (var_204: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
            var_201.RunAsync(var_204, var_200)
            let (var_205: int32) = (int32 var_194)
            let (var_206: int32) = (int32 var_196)
            let (var_207: float32) = 1.000000f
            let (var_208: int64) = 0L
            let (var_209: int64) = 784L
            let (var_210: int64) = 1L
            let (var_211: int64) = 0L
            let (var_212: int64) = 0L
            let (var_213: int64) = 784L
            let (var_214: int32) = 1
            let (var_215: int64) = 0L
            let (var_216: int64) = 0L
            let (var_217: int64) = 10L
            let (var_218: int64) = 1L
            let (var_219: int64) = 0L
            let (var_220: int64) = 0L
            let (var_221: int64) = 10L
            let (var_222: int32) = 1
            let (var_223: int64) = 0L
            let (var_224: int64) = 0L
            let (var_225: int64) = 10L
            let (var_226: int64) = 1L
            let (var_227: int64) = 0L
            let (var_228: int64) = 784L
            let (var_229: int64) = 0L
            let (var_230: int64) = 10L
            method_33((var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_205: int32), (var_206: int32), (var_207: float32), (var_9: (Union0 ref)), (var_25: int64), (var_208: int64), (var_209: int64), (var_210: int64), (var_211: int64), (var_18: int64), (var_212: int64), (var_213: int64), (var_214: int32), (var_95: (Union0 ref)), (var_215: int64), (var_216: int64), (var_217: int64), (var_218: int64), (var_219: int64), (var_220: int64), (var_221: int64), (var_222: int32), (var_7: (Union0 ref)), (var_223: int64), (var_224: int64), (var_225: int64), (var_226: int64), (var_227: int64), (var_228: int64), (var_229: int64), (var_230: int64))
        else
            let (var_231: int32) = (int32 var_18)
            let (var_232: int32) = 784
            let (var_233: int32) = 10
            let (var_234: float32) = 1.000000f
            let (var_235: int64) = 0L
            let (var_236: int64) = 784L
            let (var_237: int64) = 1L
            let (var_238: int64) = 0L
            let (var_239: int64) = 0L
            let (var_240: int64) = 784L
            let (var_241: int64) = 0L
            let (var_242: int64) = 0L
            let (var_243: int64) = 10L
            let (var_244: int64) = 1L
            let (var_245: int64) = 0L
            let (var_246: int64) = 0L
            let (var_247: int64) = 10L
            let (var_248: float32) = 1.000000f
            let (var_249: int64) = 0L
            let (var_250: int64) = 0L
            let (var_251: int64) = 10L
            let (var_252: int64) = 1L
            let (var_253: int64) = 0L
            let (var_254: int64) = 784L
            let (var_255: int64) = 0L
            let (var_256: int64) = 10L
            let (var_257: int32) = 784
            method_34((var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_232: int32), (var_233: int32), (var_231: int32), (var_234: float32), (var_9: (Union0 ref)), (var_25: int64), (var_235: int64), (var_236: int64), (var_237: int64), (var_238: int64), (var_18: int64), (var_239: int64), (var_240: int64), (var_95: (Union0 ref)), (var_241: int64), (var_242: int64), (var_243: int64), (var_244: int64), (var_245: int64), (var_246: int64), (var_247: int64), (var_248: float32), (var_7: (Union0 ref)), (var_249: int64), (var_250: int64), (var_251: int64), (var_252: int64), (var_253: int64), (var_254: int64), (var_255: int64), (var_256: int64), (var_257: int32))
        let (var_258: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_7: (Union0 ref)))
        let (var_259: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_8: (Union0 ref)))
        let (var_260: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_8: (Union0 ref)))
        // Cuda join point
        // method_35((var_258: ManagedCuda.BasicTypes.CUdeviceptr), (var_259: ManagedCuda.BasicTypes.CUdeviceptr), (var_260: ManagedCuda.BasicTypes.CUdeviceptr))
        let (var_262: (System.Object [])) = [|var_258; var_259; var_260|]: (System.Object [])
        let (var_263: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_35", var_1, var_0)
        let (var_264: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(62u, 1u, 1u)
        var_263.set_GridDimensions(var_264)
        let (var_265: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_263.set_BlockDimensions(var_265)
        let (var_266: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_263.RunAsync(var_266, var_262)
        let (var_267: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_7: (Union0 ref)))
        let (var_268: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        let (var_269: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(31360L)
        var_0.ClearMemoryAsync(var_267, 0uy, var_269, var_268)
        let (var_270: float) = (float var_150)
        let (var_271: float) = (float var_18)
        let (var_272: float) = (var_270 * var_271)
        var_135 := Union0Case1
        var_122 := Union0Case1
        var_104 := Union0Case1
        var_95 := Union0Case1
        var_35 := Union0Case1
        method_37((var_0: ManagedCuda.CudaContext), (var_1: ManagedCuda.BasicTypes.CUmodule), (var_2: ManagedCuda.CudaStream), (var_3: uint64), (var_4: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_7: (Union0 ref)), (var_8: (Union0 ref)), (var_9: (Union0 ref)), (var_10: (Union0 ref)), (var_272: float), (var_13: int64))
    else
        0.000000
and method_4((var_0: (uint8 [])), (var_1: int64), (var_2: (float32 [])), (var_3: int64)): unit =
    let (var_4: bool) = (var_3 < 784L)
    if var_4 then
        let (var_5: bool) = (var_3 >= 0L)
        let (var_6: bool) = (var_5 = false)
        if var_6 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_7: int64) = (var_1 + var_3)
        if var_6 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_8: uint8) = var_0.[int32 var_7]
        let (var_9: float32) = (float32 var_8)
        let (var_10: float32) = (var_9 / 255.000000f)
        var_2.[int32 var_7] <- var_10
        let (var_11: int64) = (var_3 + 1L)
        method_4((var_0: (uint8 [])), (var_1: int64), (var_2: (float32 [])), (var_11: int64))
    else
        ()
and method_7((var_0: uint8), (var_1: (float32 [])), (var_2: int64), (var_3: int64)): unit =
    let (var_4: bool) = (var_3 < 10L)
    if var_4 then
        let (var_5: bool) = (var_3 >= 0L)
        let (var_6: bool) = (var_5 = false)
        if var_6 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_7: int64) = (var_2 + var_3)
        let (var_8: uint8) = (uint8 var_3)
        let (var_9: bool) = (var_8 = var_0)
        let (var_10: float32) =
            if var_9 then
                1.000000f
            else
                0.000000f
        var_1.[int32 var_7] <- var_10
        let (var_11: int64) = (var_3 + 1L)
        method_7((var_0: uint8), (var_1: (float32 [])), (var_2: int64), (var_11: int64))
    else
        ()
and method_11((var_0: ManagedCuda.BasicTypes.CUdeviceptr), (var_1: uint64), (var_2: uint64), (var_3: int64), (var_4: System.Collections.Generic.Stack<Env2>), (var_5: Env6), (var_6: int64)): Env6 =
    let (var_7: ManagedCuda.BasicTypes.SizeT) = var_0.Pointer
    let (var_8: uint64) = uint64 var_7
    let (var_9: uint64) = uint64 var_6
    let (var_10: uint64) = (var_8 - var_1)
    let (var_11: uint64) = (var_10 + var_9)
    let (var_12: uint64) = uint64 var_3
    let (var_13: uint64) = (var_12 + var_11)
    let (var_14: bool) = (var_13 <= var_2)
    let (var_15: bool) = (var_14 = false)
    if var_15 then
        (failwith "Cache size has been exceeded in the allocator.")
    else
        ()
    let (var_16: uint64) = (var_8 + var_9)
    let (var_17: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_16)
    let (var_18: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_17)
    let (var_19: (Union0 ref)) = (ref (Union0Case0(Tuple1(var_18))))
    var_4.Push((Env2((Env6(var_19)), var_3)))
    (Env6(var_19))
and method_12((var_0: uint64), (var_1: uint64), (var_2: int64), (var_3: System.Collections.Generic.Stack<Env2>)): Env6 =
    let (var_4: uint64) = uint64 var_2
    let (var_5: bool) = (var_4 <= var_1)
    let (var_6: bool) = (var_5 = false)
    if var_6 then
        (failwith "Cache size has been exceeded in the allocator.")
    else
        ()
    let (var_7: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_0)
    let (var_8: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_7)
    let (var_9: (Union0 ref)) = (ref (Union0Case0(Tuple1(var_8))))
    var_3.Push((Env2((Env6(var_9)), var_2)))
    (Env6(var_9))
and method_15((var_0: ManagedCuda.CudaBlas.CudaBlasHandle), (var_1: int32), (var_2: int32), (var_3: float32), (var_4: (Union0 ref)), (var_5: int64), (var_6: int64), (var_7: int64), (var_8: int64), (var_9: int64), (var_10: int64), (var_11: int64), (var_12: int64), (var_13: int32), (var_14: (Union0 ref)), (var_15: int64), (var_16: int64), (var_17: int64), (var_18: int64), (var_19: int64), (var_20: int64), (var_21: int64), (var_22: int64), (var_23: int32), (var_24: float32), (var_25: (Union0 ref)), (var_26: int64), (var_27: int64), (var_28: int64), (var_29: int64), (var_30: int64), (var_31: int64), (var_32: int64), (var_33: int32)): unit =
    let (var_34: ManagedCuda.CudaBlas.Operation) = ManagedCuda.CudaBlas.Operation.Transpose
    let (var_35: (float32 ref)) = (ref var_3)
    let (var_36: bool) = (var_9 < var_10)
    let (var_37: bool) = (var_36 = false)
    if var_37 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_38: bool) = (var_11 < var_12)
    let (var_39: bool) = (var_38 = false)
    if var_39 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_40: int64) = (var_12 - var_11)
    let (var_41: int64) = (var_10 - var_9)
    let (var_42: int64) = (var_41 * var_40)
    let (var_43: bool) = (0L = var_6)
    let (var_44: bool) = (var_43 = false)
    if var_44 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_45: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_4: (Union0 ref)))
    let (var_46: ManagedCuda.BasicTypes.SizeT) = var_45.Pointer
    let (var_47: uint64) = uint64 var_46
    let (var_48: uint64) = (uint64 var_5)
    let (var_49: uint64) = (var_47 + var_48)
    let (var_50: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_49)
    let (var_51: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_50)
    let (var_52: bool) = (var_19 < var_20)
    let (var_53: bool) = (var_52 = false)
    if var_53 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_54: bool) = (var_21 < var_22)
    let (var_55: bool) = (var_54 = false)
    if var_55 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_56: int64) = (var_22 - var_21)
    let (var_57: int64) = (var_20 - var_19)
    let (var_58: int64) = (var_57 * var_56)
    let (var_59: bool) = (0L = var_16)
    let (var_60: bool) = (var_59 = false)
    if var_60 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_61: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_14: (Union0 ref)))
    let (var_62: ManagedCuda.BasicTypes.SizeT) = var_61.Pointer
    let (var_63: uint64) = uint64 var_62
    let (var_64: uint64) = (uint64 var_15)
    let (var_65: uint64) = (var_63 + var_64)
    let (var_66: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_65)
    let (var_67: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_66)
    let (var_68: (float32 ref)) = (ref var_24)
    let (var_69: bool) = (var_30 < var_20)
    let (var_70: bool) = (var_69 = false)
    if var_70 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_71: bool) = (var_31 < var_32)
    let (var_72: bool) = (var_71 = false)
    if var_72 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_73: int64) = (var_32 - var_31)
    let (var_74: int64) = (var_20 - var_30)
    let (var_75: int64) = (var_74 * var_73)
    let (var_76: bool) = (0L = var_27)
    let (var_77: bool) = (var_76 = false)
    if var_77 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_78: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_25: (Union0 ref)))
    let (var_79: ManagedCuda.BasicTypes.SizeT) = var_78.Pointer
    let (var_80: uint64) = uint64 var_79
    let (var_81: uint64) = (uint64 var_26)
    let (var_82: uint64) = (var_80 + var_81)
    let (var_83: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_82)
    let (var_84: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_83)
    let (var_85: ManagedCuda.CudaBlas.CublasStatus) = ManagedCuda.CudaBlas.CudaBlasNativeMethods.cublasSgemv_v2(var_0, var_34, var_1, var_2, var_35, var_51, var_13, var_67, var_23, var_68, var_84, var_33)
    if var_85 <> ManagedCuda.CudaBlas.CublasStatus.Success then raise <| new ManagedCuda.CudaBlas.CudaBlasException(var_85)
and method_16((var_0: ManagedCuda.CudaBlas.CudaBlasHandle), (var_1: int32), (var_2: int32), (var_3: int32), (var_4: float32), (var_5: (Union0 ref)), (var_6: int64), (var_7: int64), (var_8: int64), (var_9: int64), (var_10: int64), (var_11: int64), (var_12: int64), (var_13: int64), (var_14: (Union0 ref)), (var_15: int64), (var_16: int64), (var_17: int64), (var_18: int64), (var_19: int64), (var_20: int64), (var_21: int64), (var_22: int64), (var_23: int32), (var_24: float32), (var_25: (Union0 ref)), (var_26: int64), (var_27: int64), (var_28: int64), (var_29: int64), (var_30: int64), (var_31: int64), (var_32: int64)): unit =
    let (var_33: ManagedCuda.CudaBlas.Operation) = ManagedCuda.CudaBlas.Operation.NonTranspose
    let (var_34: ManagedCuda.CudaBlas.Operation) = ManagedCuda.CudaBlas.Operation.NonTranspose
    let (var_35: (float32 ref)) = (ref var_4)
    let (var_36: bool) = (var_10 < var_11)
    let (var_37: bool) = (var_36 = false)
    if var_37 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_38: bool) = (var_12 < var_13)
    let (var_39: bool) = (var_38 = false)
    if var_39 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_40: int64) = (var_13 - var_12)
    let (var_41: int64) = (var_11 - var_10)
    let (var_42: int64) = (var_41 * var_40)
    let (var_43: bool) = (0L = var_7)
    let (var_44: bool) = (var_43 = false)
    if var_44 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_45: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_5: (Union0 ref)))
    let (var_46: ManagedCuda.BasicTypes.SizeT) = var_45.Pointer
    let (var_47: uint64) = uint64 var_46
    let (var_48: uint64) = (uint64 var_6)
    let (var_49: uint64) = (var_47 + var_48)
    let (var_50: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_49)
    let (var_51: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_50)
    let (var_52: bool) = (var_19 < var_20)
    let (var_53: bool) = (var_52 = false)
    if var_53 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_54: bool) = (var_21 < var_22)
    let (var_55: bool) = (var_54 = false)
    if var_55 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_56: int64) = (var_22 - var_21)
    let (var_57: int64) = (var_20 - var_19)
    let (var_58: int64) = (var_57 * var_56)
    let (var_59: bool) = (0L = var_16)
    let (var_60: bool) = (var_59 = false)
    if var_60 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_61: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_14: (Union0 ref)))
    let (var_62: ManagedCuda.BasicTypes.SizeT) = var_61.Pointer
    let (var_63: uint64) = uint64 var_62
    let (var_64: uint64) = (uint64 var_15)
    let (var_65: uint64) = (var_63 + var_64)
    let (var_66: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_65)
    let (var_67: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_66)
    let (var_68: (float32 ref)) = (ref var_24)
    let (var_69: bool) = (var_30 < var_11)
    let (var_70: bool) = (var_69 = false)
    if var_70 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_71: bool) = (var_31 < var_32)
    let (var_72: bool) = (var_71 = false)
    if var_72 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_73: int64) = (var_32 - var_31)
    let (var_74: int64) = (var_11 - var_30)
    let (var_75: int64) = (var_74 * var_73)
    let (var_76: bool) = (0L = var_27)
    let (var_77: bool) = (var_76 = false)
    if var_77 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_78: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_25: (Union0 ref)))
    let (var_79: ManagedCuda.BasicTypes.SizeT) = var_78.Pointer
    let (var_80: uint64) = uint64 var_79
    let (var_81: uint64) = (uint64 var_26)
    let (var_82: uint64) = (var_80 + var_81)
    let (var_83: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_82)
    let (var_84: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_83)
    let (var_85: ManagedCuda.CudaBlas.CublasStatus) = ManagedCuda.CudaBlas.CudaBlasNativeMethods.cublasSgemm_v2(var_0, var_33, var_34, var_1, var_2, var_3, var_35, var_51, var_1, var_67, var_23, var_68, var_84, var_1)
    if var_85 <> ManagedCuda.CudaBlas.CublasStatus.Success then raise <| new ManagedCuda.CudaBlas.CudaBlasException(var_85)
and method_26((var_0: int64), (var_1: (Union0 ref)), (var_2: int64), (var_3: ManagedCuda.CudaContext), (var_4: (Union7 ref)), (var_5: (Union7 ref))): float32 =
    let (var_6: Union7) = (!var_5)
    match var_6 with
    | Union7Case0(var_7) ->
        var_7.mem_0
    | Union7Case1 ->
        let (var_9: float32) = method_24((var_0: int64), (var_1: (Union0 ref)), (var_2: int64), (var_3: ManagedCuda.CudaContext), (var_4: (Union7 ref)))
        var_5 := (Union7Case0(Tuple8(var_9)))
        var_9
and method_25((var_0: (Union0 ref)), (var_1: int64), (var_2: ManagedCuda.CudaContext), (var_3: (Union7 ref))): float32 =
    let (var_4: Union7) = (!var_3)
    match var_4 with
    | Union7Case0(var_5) ->
        var_5.mem_0
    | Union7Case1 ->
        let (var_7: float32) = method_22((var_0: (Union0 ref)), (var_1: int64), (var_2: ManagedCuda.CudaContext))
        var_3 := (Union7Case0(Tuple8(var_7)))
        var_7
and method_33((var_0: ManagedCuda.CudaBlas.CudaBlasHandle), (var_1: int32), (var_2: int32), (var_3: float32), (var_4: (Union0 ref)), (var_5: int64), (var_6: int64), (var_7: int64), (var_8: int64), (var_9: int64), (var_10: int64), (var_11: int64), (var_12: int64), (var_13: int32), (var_14: (Union0 ref)), (var_15: int64), (var_16: int64), (var_17: int64), (var_18: int64), (var_19: int64), (var_20: int64), (var_21: int64), (var_22: int32), (var_23: (Union0 ref)), (var_24: int64), (var_25: int64), (var_26: int64), (var_27: int64), (var_28: int64), (var_29: int64), (var_30: int64), (var_31: int64)): unit =
    let (var_32: (float32 ref)) = (ref var_3)
    let (var_33: bool) = (var_9 < var_10)
    let (var_34: bool) = (var_33 = false)
    if var_34 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_35: bool) = (var_11 < var_12)
    let (var_36: bool) = (var_35 = false)
    if var_36 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_37: int64) = (var_12 - var_11)
    let (var_38: int64) = (var_10 - var_9)
    let (var_39: int64) = (var_38 * var_37)
    let (var_40: bool) = (0L = var_6)
    let (var_41: bool) = (var_40 = false)
    if var_41 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_42: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_4: (Union0 ref)))
    let (var_43: ManagedCuda.BasicTypes.SizeT) = var_42.Pointer
    let (var_44: uint64) = uint64 var_43
    let (var_45: uint64) = (uint64 var_5)
    let (var_46: uint64) = (var_44 + var_45)
    let (var_47: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_46)
    let (var_48: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_47)
    let (var_49: bool) = (var_19 < var_10)
    let (var_50: bool) = (var_49 = false)
    if var_50 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_51: bool) = (var_20 < var_21)
    let (var_52: bool) = (var_51 = false)
    if var_52 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_53: int64) = (var_21 - var_20)
    let (var_54: int64) = (var_10 - var_19)
    let (var_55: int64) = (var_54 * var_53)
    let (var_56: bool) = (0L = var_16)
    let (var_57: bool) = (var_56 = false)
    if var_57 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_58: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_14: (Union0 ref)))
    let (var_59: ManagedCuda.BasicTypes.SizeT) = var_58.Pointer
    let (var_60: uint64) = uint64 var_59
    let (var_61: uint64) = (uint64 var_15)
    let (var_62: uint64) = (var_60 + var_61)
    let (var_63: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_62)
    let (var_64: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_63)
    let (var_65: bool) = (var_28 < var_29)
    let (var_66: bool) = (var_65 = false)
    if var_66 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_67: bool) = (var_30 < var_31)
    let (var_68: bool) = (var_67 = false)
    if var_68 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_69: int64) = (var_31 - var_30)
    let (var_70: int64) = (var_29 - var_28)
    let (var_71: int64) = (var_70 * var_69)
    let (var_72: bool) = (0L = var_25)
    let (var_73: bool) = (var_72 = false)
    if var_73 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_74: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_23: (Union0 ref)))
    let (var_75: ManagedCuda.BasicTypes.SizeT) = var_74.Pointer
    let (var_76: uint64) = uint64 var_75
    let (var_77: uint64) = (uint64 var_24)
    let (var_78: uint64) = (var_76 + var_77)
    let (var_79: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_78)
    let (var_80: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_79)
    let (var_81: ManagedCuda.CudaBlas.CublasStatus) = ManagedCuda.CudaBlas.CudaBlasNativeMethods.cublasSger_v2(var_0, var_1, var_2, var_32, var_48, var_13, var_64, var_22, var_80, var_1)
    if var_81 <> ManagedCuda.CudaBlas.CublasStatus.Success then raise <| new ManagedCuda.CudaBlas.CudaBlasException(var_81)
and method_34((var_0: ManagedCuda.CudaBlas.CudaBlasHandle), (var_1: int32), (var_2: int32), (var_3: int32), (var_4: float32), (var_5: (Union0 ref)), (var_6: int64), (var_7: int64), (var_8: int64), (var_9: int64), (var_10: int64), (var_11: int64), (var_12: int64), (var_13: int64), (var_14: (Union0 ref)), (var_15: int64), (var_16: int64), (var_17: int64), (var_18: int64), (var_19: int64), (var_20: int64), (var_21: int64), (var_22: float32), (var_23: (Union0 ref)), (var_24: int64), (var_25: int64), (var_26: int64), (var_27: int64), (var_28: int64), (var_29: int64), (var_30: int64), (var_31: int64), (var_32: int32)): unit =
    let (var_33: ManagedCuda.CudaBlas.Operation) = ManagedCuda.CudaBlas.Operation.Transpose
    let (var_34: ManagedCuda.CudaBlas.Operation) = ManagedCuda.CudaBlas.Operation.NonTranspose
    let (var_35: (float32 ref)) = (ref var_4)
    let (var_36: bool) = (var_10 < var_11)
    let (var_37: bool) = (var_36 = false)
    if var_37 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_38: bool) = (var_12 < var_13)
    let (var_39: bool) = (var_38 = false)
    if var_39 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_40: int64) = (var_13 - var_12)
    let (var_41: int64) = (var_11 - var_10)
    let (var_42: int64) = (var_41 * var_40)
    let (var_43: bool) = (0L = var_7)
    let (var_44: bool) = (var_43 = false)
    if var_44 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_45: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_5: (Union0 ref)))
    let (var_46: ManagedCuda.BasicTypes.SizeT) = var_45.Pointer
    let (var_47: uint64) = uint64 var_46
    let (var_48: uint64) = (uint64 var_6)
    let (var_49: uint64) = (var_47 + var_48)
    let (var_50: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_49)
    let (var_51: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_50)
    let (var_52: bool) = (var_19 < var_11)
    let (var_53: bool) = (var_52 = false)
    if var_53 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_54: bool) = (var_20 < var_21)
    let (var_55: bool) = (var_54 = false)
    if var_55 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_56: int64) = (var_21 - var_20)
    let (var_57: int64) = (var_11 - var_19)
    let (var_58: int64) = (var_57 * var_56)
    let (var_59: bool) = (0L = var_16)
    let (var_60: bool) = (var_59 = false)
    if var_60 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_61: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_14: (Union0 ref)))
    let (var_62: ManagedCuda.BasicTypes.SizeT) = var_61.Pointer
    let (var_63: uint64) = uint64 var_62
    let (var_64: uint64) = (uint64 var_15)
    let (var_65: uint64) = (var_63 + var_64)
    let (var_66: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_65)
    let (var_67: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_66)
    let (var_68: (float32 ref)) = (ref var_22)
    let (var_69: bool) = (var_28 < var_29)
    let (var_70: bool) = (var_69 = false)
    if var_70 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_71: bool) = (var_30 < var_31)
    let (var_72: bool) = (var_71 = false)
    if var_72 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_73: int64) = (var_31 - var_30)
    let (var_74: int64) = (var_29 - var_28)
    let (var_75: int64) = (var_74 * var_73)
    let (var_76: bool) = (0L = var_25)
    let (var_77: bool) = (var_76 = false)
    if var_77 then
        (failwith "The inner dimensions much have offsets of 0. They must not be 'view'ed. Consider reshaping a copy of the tensor instead")
    else
        ()
    let (var_78: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_23: (Union0 ref)))
    let (var_79: ManagedCuda.BasicTypes.SizeT) = var_78.Pointer
    let (var_80: uint64) = uint64 var_79
    let (var_81: uint64) = (uint64 var_24)
    let (var_82: uint64) = (var_80 + var_81)
    let (var_83: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_82)
    let (var_84: ManagedCuda.BasicTypes.CUdeviceptr) = ManagedCuda.BasicTypes.CUdeviceptr(var_83)
    let (var_85: ManagedCuda.CudaBlas.CublasStatus) = ManagedCuda.CudaBlas.CudaBlasNativeMethods.cublasSgemm_v2(var_0, var_33, var_34, var_1, var_2, var_3, var_35, var_51, var_3, var_67, var_3, var_68, var_84, var_32)
    if var_85 <> ManagedCuda.CudaBlas.CublasStatus.Success then raise <| new ManagedCuda.CudaBlas.CudaBlasException(var_85)
and method_37((var_0: ManagedCuda.CudaContext), (var_1: ManagedCuda.BasicTypes.CUmodule), (var_2: ManagedCuda.CudaStream), (var_3: uint64), (var_4: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_7: (Union0 ref)), (var_8: (Union0 ref)), (var_9: (Union0 ref)), (var_10: (Union0 ref)), (var_11: float), (var_12: int64)): float =
    let (var_13: bool) = (var_12 < 60000L)
    if var_13 then
        let (var_14: int64) = (var_12 + 128L)
        let (var_15: bool) = (var_14 > 60000L)
        let (var_16: int64) =
            if var_15 then
                60000L
            else
                var_14
        let (var_17: bool) = (var_12 < var_16)
        let (var_18: bool) = (var_17 = false)
        if var_18 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_19: int64) = (var_16 - var_12)
        let (var_20: bool) = (var_12 >= 0L)
        let (var_21: bool) = (var_20 = false)
        if var_21 then
            (failwith "Lower boundary out of bounds.")
        else
            ()
        let (var_22: bool) = (var_16 > 0L)
        let (var_24: bool) =
            if var_22 then
                (var_16 <= 60000L)
            else
                false
        let (var_25: bool) = (var_24 = false)
        if var_25 then
            (failwith "Higher boundary out of bounds.")
        else
            ()
        let (var_26: int64) = (var_12 * 784L)
        if var_18 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        if var_21 then
            (failwith "Lower boundary out of bounds.")
        else
            ()
        let (var_28: bool) =
            if var_22 then
                (var_16 <= 60000L)
            else
                false
        let (var_29: bool) = (var_28 = false)
        if var_29 then
            (failwith "Higher boundary out of bounds.")
        else
            ()
        let (var_30: int64) = (var_12 * 10L)
        let (var_31: bool) = (var_19 > 0L)
        let (var_32: bool) = (var_31 = false)
        if var_32 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_33: int64) = (var_19 * 10L)
        let (var_34: int64) = (var_33 * 4L)
        let (var_35: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_34: int64))
        let (var_36: (Union0 ref)) = var_35.mem_0
        let (var_37: bool) = (var_19 = 1L)
        if var_37 then
            let (var_38: int32) = 784
            let (var_39: int32) = 10
            let (var_40: float32) = 1.000000f
            let (var_41: int64) = 0L
            let (var_42: int64) = 0L
            let (var_43: int64) = 10L
            let (var_44: int64) = 1L
            let (var_45: int64) = 0L
            let (var_46: int64) = 784L
            let (var_47: int64) = 0L
            let (var_48: int64) = 10L
            let (var_49: int32) = 784
            let (var_50: int64) = 0L
            let (var_51: int64) = 784L
            let (var_52: int64) = 1L
            let (var_53: int64) = 0L
            let (var_54: int64) = 0L
            let (var_55: int64) = 784L
            let (var_56: int32) = 1
            let (var_57: float32) = 0.000000f
            let (var_58: int64) = 0L
            let (var_59: int64) = 0L
            let (var_60: int64) = 10L
            let (var_61: int64) = 1L
            let (var_62: int64) = 0L
            let (var_63: int64) = 0L
            let (var_64: int64) = 10L
            let (var_65: int32) = 1
            method_15((var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_38: int32), (var_39: int32), (var_40: float32), (var_8: (Union0 ref)), (var_41: int64), (var_42: int64), (var_43: int64), (var_44: int64), (var_45: int64), (var_46: int64), (var_47: int64), (var_48: int64), (var_49: int32), (var_9: (Union0 ref)), (var_26: int64), (var_50: int64), (var_51: int64), (var_52: int64), (var_53: int64), (var_19: int64), (var_54: int64), (var_55: int64), (var_56: int32), (var_57: float32), (var_36: (Union0 ref)), (var_58: int64), (var_59: int64), (var_60: int64), (var_61: int64), (var_62: int64), (var_63: int64), (var_64: int64), (var_65: int32))
        else
            let (var_66: int32) = (int32 var_19)
            let (var_67: int32) = 10
            let (var_68: int32) = 784
            let (var_69: float32) = 1.000000f
            let (var_70: int64) = 0L
            let (var_71: int64) = 784L
            let (var_72: int64) = 1L
            let (var_73: int64) = 0L
            let (var_74: int64) = 0L
            let (var_75: int64) = 784L
            let (var_76: int64) = 0L
            let (var_77: int64) = 0L
            let (var_78: int64) = 10L
            let (var_79: int64) = 1L
            let (var_80: int64) = 0L
            let (var_81: int64) = 784L
            let (var_82: int64) = 0L
            let (var_83: int64) = 10L
            let (var_84: int32) = 784
            let (var_85: float32) = 0.000000f
            let (var_86: int64) = 0L
            let (var_87: int64) = 0L
            let (var_88: int64) = 10L
            let (var_89: int64) = 1L
            let (var_90: int64) = 0L
            let (var_91: int64) = 0L
            let (var_92: int64) = 10L
            method_16((var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_66: int32), (var_67: int32), (var_68: int32), (var_69: float32), (var_9: (Union0 ref)), (var_26: int64), (var_70: int64), (var_71: int64), (var_72: int64), (var_73: int64), (var_19: int64), (var_74: int64), (var_75: int64), (var_8: (Union0 ref)), (var_76: int64), (var_77: int64), (var_78: int64), (var_79: int64), (var_80: int64), (var_81: int64), (var_82: int64), (var_83: int64), (var_84: int32), (var_85: float32), (var_36: (Union0 ref)), (var_86: int64), (var_87: int64), (var_88: int64), (var_89: int64), (var_90: int64), (var_91: int64), (var_92: int64))
        let (var_93: bool) = (0L < var_19)
        let (var_94: bool) = (var_93 = false)
        if var_94 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_95: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_34: int64))
        let (var_96: (Union0 ref)) = var_95.mem_0
        let (var_97: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_96: (Union0 ref)))
        if var_94 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_98: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        let (var_99: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_34)
        var_0.ClearMemoryAsync(var_97, 0uy, var_99, var_98)
        if var_94 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_104: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_34: int64))
        let (var_105: (Union0 ref)) = var_104.mem_0
        let (var_106: bool) = (var_33 > 0L)
        let (var_107: bool) = (var_106 = false)
        if var_107 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_108: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_36: (Union0 ref)))
        if var_107 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_109: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_105: (Union0 ref)))
        let (var_110: int64) = (var_33 - 1L)
        let (var_111: int64) = (var_110 / 128L)
        let (var_112: int64) = (var_111 + 1L)
        let (var_113: bool) = (64L > var_112)
        let (var_114: int64) =
            if var_113 then
                var_112
            else
                64L
        // Cuda join point
        // method_17((var_108: ManagedCuda.BasicTypes.CUdeviceptr), (var_33: int64), (var_109: ManagedCuda.BasicTypes.CUdeviceptr))
        let (var_116: (System.Object [])) = [|var_108; var_33; var_109|]: (System.Object [])
        let (var_117: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_17", var_1, var_0)
        let (var_118: uint32) = (uint32 var_114)
        let (var_119: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(var_118, 1u, 1u)
        var_117.set_GridDimensions(var_119)
        let (var_120: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_117.set_BlockDimensions(var_120)
        let (var_121: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_117.RunAsync(var_121, var_116)
        if var_94 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_122: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_34: int64))
        let (var_123: (Union0 ref)) = var_122.mem_0
        let (var_124: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_123: (Union0 ref)))
        if var_94 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_125: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        let (var_126: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_34)
        var_0.ClearMemoryAsync(var_124, 0uy, var_126, var_125)
        if var_107 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_127: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_105: (Union0 ref)))
        let (var_128: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_10: (Union0 ref)))
        let (var_129: int64) =
            if var_113 then
                var_112
            else
                64L
        let (var_132: bool) = (var_129 > 0L)
        let (var_133: bool) = (var_132 = false)
        if var_133 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_134: int64) = (var_129 * 4L)
        let (var_135: Env6) = method_10((var_3: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_4: uint64), (var_134: int64))
        let (var_136: (Union0 ref)) = var_135.mem_0
        let (var_137: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_136: (Union0 ref)))
        // Cuda join point
        // method_19((var_127: ManagedCuda.BasicTypes.CUdeviceptr), (var_128: ManagedCuda.BasicTypes.CUdeviceptr), (var_33: int64), (var_137: ManagedCuda.BasicTypes.CUdeviceptr), (var_129: int64))
        let (var_139: (System.Object [])) = [|var_127; var_128; var_33; var_137; var_129|]: (System.Object [])
        let (var_140: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_19", var_1, var_0)
        let (var_141: uint32) = (uint32 var_129)
        let (var_142: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(var_141, 1u, 1u)
        var_140.set_GridDimensions(var_142)
        let (var_143: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_140.set_BlockDimensions(var_143)
        let (var_144: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_140.RunAsync(var_144, var_139)
        let (var_146: (Union7 ref)) = (ref Union7Case1)
        let (var_147: (float32 ref)) = (ref 0.000000f)
        let (var_149: (Union7 ref)) = (ref Union7Case1)
        let (var_150: (float32 ref)) = (ref 0.000000f)
        let (var_151: float32) = method_26((var_19: int64), (var_136: (Union0 ref)), (var_129: int64), (var_0: ManagedCuda.CudaContext), (var_146: (Union7 ref)), (var_149: (Union7 ref)))
        let (var_152: string) = System.String.Format("{0}",var_16)
        let (var_153: string) = System.String.Format("{0} = {1}","near_to",var_152)
        let (var_154: string) = System.String.Format("{0}",var_12)
        let (var_155: string) = System.String.Format("{0} = {1}","from",var_154)
        let (var_156: string) = String.concat "; " [|var_155; var_153|]
        let (var_157: string) = System.String.Format("{0}{1}{2}","{",var_156,"}")
        let (var_158: string) = System.String.Format("On minibatch {0}. Error = {1}",var_157,var_151)
        let (var_159: string) = System.String.Format("{0}",var_158)
        System.Console.WriteLine(var_159)
        System.Console.WriteLine("Running the backwards phase...")
        var_150 := 1.000000f
        let (var_160: float32) = method_26((var_19: int64), (var_136: (Union0 ref)), (var_129: int64), (var_0: ManagedCuda.CudaContext), (var_146: (Union7 ref)), (var_149: (Union7 ref)))
        let (var_161: float32) = (!var_150)
        let (var_162: float32) = method_25((var_136: (Union0 ref)), (var_129: int64), (var_0: ManagedCuda.CudaContext), (var_146: (Union7 ref)))
        let (var_163: float32) = (float32 var_19)
        let (var_164: float32) = (var_161 / var_163)
        let (var_165: float32) = (!var_147)
        let (var_166: float32) = (var_165 + var_164)
        var_147 := var_166
        let (var_167: float32) = method_25((var_136: (Union0 ref)), (var_129: int64), (var_0: ManagedCuda.CudaContext), (var_146: (Union7 ref)))
        let (var_168: float32) = (!var_147)
        if var_107 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_169: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_123: (Union0 ref)))
        let (var_170: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_105: (Union0 ref)))
        let (var_171: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_10: (Union0 ref)))
        if var_107 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_172: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_123: (Union0 ref)))
        let (var_173: int64) =
            if var_113 then
                var_112
            else
                64L
        // Cuda join point
        // method_27((var_168: float32), (var_167: float32), (var_169: ManagedCuda.BasicTypes.CUdeviceptr), (var_170: ManagedCuda.BasicTypes.CUdeviceptr), (var_171: ManagedCuda.BasicTypes.CUdeviceptr), (var_33: int64), (var_172: ManagedCuda.BasicTypes.CUdeviceptr))
        let (var_175: (System.Object [])) = [|var_168; var_167; var_169; var_170; var_171; var_33; var_172|]: (System.Object [])
        let (var_176: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_27", var_1, var_0)
        let (var_177: uint32) = (uint32 var_173)
        let (var_178: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(var_177, 1u, 1u)
        var_176.set_GridDimensions(var_178)
        let (var_179: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_176.set_BlockDimensions(var_179)
        let (var_180: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_176.RunAsync(var_180, var_175)
        if var_107 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_181: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_96: (Union0 ref)))
        let (var_182: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_36: (Union0 ref)))
        let (var_183: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_123: (Union0 ref)))
        let (var_184: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_105: (Union0 ref)))
        if var_107 then
            (failwith "Tensor needs to be at least size 1.")
        else
            ()
        let (var_185: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_96: (Union0 ref)))
        let (var_186: int64) =
            if var_113 then
                var_112
            else
                64L
        // Cuda join point
        // method_29((var_181: ManagedCuda.BasicTypes.CUdeviceptr), (var_182: ManagedCuda.BasicTypes.CUdeviceptr), (var_183: ManagedCuda.BasicTypes.CUdeviceptr), (var_184: ManagedCuda.BasicTypes.CUdeviceptr), (var_33: int64), (var_185: ManagedCuda.BasicTypes.CUdeviceptr))
        let (var_188: (System.Object [])) = [|var_181; var_182; var_183; var_184; var_33; var_185|]: (System.Object [])
        let (var_189: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_29", var_1, var_0)
        let (var_190: uint32) = (uint32 var_186)
        let (var_191: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(var_190, 1u, 1u)
        var_189.set_GridDimensions(var_191)
        let (var_192: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_189.set_BlockDimensions(var_192)
        let (var_193: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_189.RunAsync(var_193, var_188)
        if var_37 then
            let (var_194: bool) = (var_19 > 784L)
            let (var_195: int64) =
                if var_194 then
                    var_19
                else
                    784L
            let (var_196: bool) = (var_19 > 10L)
            let (var_197: int64) =
                if var_196 then
                    var_19
                else
                    10L
            let (var_198: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_7: (Union0 ref)))
            let (var_199: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_7: (Union0 ref)))
            // Cuda join point
            // method_31((var_198: ManagedCuda.BasicTypes.CUdeviceptr), (var_199: ManagedCuda.BasicTypes.CUdeviceptr))
            let (var_201: (System.Object [])) = [|var_198; var_199|]: (System.Object [])
            let (var_202: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_31", var_1, var_0)
            let (var_203: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(62u, 1u, 1u)
            var_202.set_GridDimensions(var_203)
            let (var_204: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
            var_202.set_BlockDimensions(var_204)
            let (var_205: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
            var_202.RunAsync(var_205, var_201)
            let (var_206: int32) = (int32 var_195)
            let (var_207: int32) = (int32 var_197)
            let (var_208: float32) = 1.000000f
            let (var_209: int64) = 0L
            let (var_210: int64) = 784L
            let (var_211: int64) = 1L
            let (var_212: int64) = 0L
            let (var_213: int64) = 0L
            let (var_214: int64) = 784L
            let (var_215: int32) = 1
            let (var_216: int64) = 0L
            let (var_217: int64) = 0L
            let (var_218: int64) = 10L
            let (var_219: int64) = 1L
            let (var_220: int64) = 0L
            let (var_221: int64) = 0L
            let (var_222: int64) = 10L
            let (var_223: int32) = 1
            let (var_224: int64) = 0L
            let (var_225: int64) = 0L
            let (var_226: int64) = 10L
            let (var_227: int64) = 1L
            let (var_228: int64) = 0L
            let (var_229: int64) = 784L
            let (var_230: int64) = 0L
            let (var_231: int64) = 10L
            method_33((var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_206: int32), (var_207: int32), (var_208: float32), (var_9: (Union0 ref)), (var_26: int64), (var_209: int64), (var_210: int64), (var_211: int64), (var_212: int64), (var_19: int64), (var_213: int64), (var_214: int64), (var_215: int32), (var_96: (Union0 ref)), (var_216: int64), (var_217: int64), (var_218: int64), (var_219: int64), (var_220: int64), (var_221: int64), (var_222: int64), (var_223: int32), (var_7: (Union0 ref)), (var_224: int64), (var_225: int64), (var_226: int64), (var_227: int64), (var_228: int64), (var_229: int64), (var_230: int64), (var_231: int64))
        else
            let (var_232: int32) = (int32 var_19)
            let (var_233: int32) = 784
            let (var_234: int32) = 10
            let (var_235: float32) = 1.000000f
            let (var_236: int64) = 0L
            let (var_237: int64) = 784L
            let (var_238: int64) = 1L
            let (var_239: int64) = 0L
            let (var_240: int64) = 0L
            let (var_241: int64) = 784L
            let (var_242: int64) = 0L
            let (var_243: int64) = 0L
            let (var_244: int64) = 10L
            let (var_245: int64) = 1L
            let (var_246: int64) = 0L
            let (var_247: int64) = 0L
            let (var_248: int64) = 10L
            let (var_249: float32) = 1.000000f
            let (var_250: int64) = 0L
            let (var_251: int64) = 0L
            let (var_252: int64) = 10L
            let (var_253: int64) = 1L
            let (var_254: int64) = 0L
            let (var_255: int64) = 784L
            let (var_256: int64) = 0L
            let (var_257: int64) = 10L
            let (var_258: int32) = 784
            method_34((var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_233: int32), (var_234: int32), (var_232: int32), (var_235: float32), (var_9: (Union0 ref)), (var_26: int64), (var_236: int64), (var_237: int64), (var_238: int64), (var_239: int64), (var_19: int64), (var_240: int64), (var_241: int64), (var_96: (Union0 ref)), (var_242: int64), (var_243: int64), (var_244: int64), (var_245: int64), (var_246: int64), (var_247: int64), (var_248: int64), (var_249: float32), (var_7: (Union0 ref)), (var_250: int64), (var_251: int64), (var_252: int64), (var_253: int64), (var_254: int64), (var_255: int64), (var_256: int64), (var_257: int64), (var_258: int32))
        let (var_259: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_7: (Union0 ref)))
        let (var_260: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_8: (Union0 ref)))
        let (var_261: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_8: (Union0 ref)))
        // Cuda join point
        // method_35((var_259: ManagedCuda.BasicTypes.CUdeviceptr), (var_260: ManagedCuda.BasicTypes.CUdeviceptr), (var_261: ManagedCuda.BasicTypes.CUdeviceptr))
        let (var_263: (System.Object [])) = [|var_259; var_260; var_261|]: (System.Object [])
        let (var_264: ManagedCuda.CudaKernel) = ManagedCuda.CudaKernel("method_35", var_1, var_0)
        let (var_265: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(62u, 1u, 1u)
        var_264.set_GridDimensions(var_265)
        let (var_266: ManagedCuda.VectorTypes.dim3) = ManagedCuda.VectorTypes.dim3(128u, 1u, 1u)
        var_264.set_BlockDimensions(var_266)
        let (var_267: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        var_264.RunAsync(var_267, var_263)
        let (var_268: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_7: (Union0 ref)))
        let (var_269: ManagedCuda.BasicTypes.CUstream) = var_2.get_Stream()
        let (var_270: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(31360L)
        var_0.ClearMemoryAsync(var_268, 0uy, var_270, var_269)
        let (var_271: float) = (float var_151)
        let (var_272: float) = (float var_19)
        let (var_273: float) = (var_271 * var_272)
        let (var_274: float) = (var_11 + var_273)
        var_136 := Union0Case1
        var_123 := Union0Case1
        var_105 := Union0Case1
        var_96 := Union0Case1
        var_36 := Union0Case1
        method_37((var_0: ManagedCuda.CudaContext), (var_1: ManagedCuda.BasicTypes.CUmodule), (var_2: ManagedCuda.CudaStream), (var_3: uint64), (var_4: uint64), (var_5: System.Collections.Generic.Stack<Env2>), (var_6: ManagedCuda.CudaBlas.CudaBlasHandle), (var_7: (Union0 ref)), (var_8: (Union0 ref)), (var_9: (Union0 ref)), (var_10: (Union0 ref)), (var_274: float), (var_14: int64))
    else
        var_11
and method_24((var_0: int64), (var_1: (Union0 ref)), (var_2: int64), (var_3: ManagedCuda.CudaContext), (var_4: (Union7 ref))): float32 =
    let (var_5: float32) = method_25((var_1: (Union0 ref)), (var_2: int64), (var_3: ManagedCuda.CudaContext), (var_4: (Union7 ref)))
    let (var_6: float32) = (float32 var_0)
    (var_5 / var_6)
and method_22((var_0: (Union0 ref)), (var_1: int64), (var_2: ManagedCuda.CudaContext)): float32 =
    let (var_3: bool) = (0L < var_1)
    let (var_4: bool) = (var_3 = false)
    if var_4 then
        (failwith "Tensor needs to be at least size 1.")
    else
        ()
    let (var_5: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_0: (Union0 ref)))
    let (var_6: (float32 [])) = Array.zeroCreate<float32> (System.Convert.ToInt32(var_1))
    var_2.CopyToHost(var_6, var_5)
    var_2.Synchronize()
    let (var_7: float32) = 0.000000f
    let (var_8: int64) = 0L
    method_23((var_6: (float32 [])), (var_1: int64), (var_7: float32), (var_8: int64))
and method_23((var_0: (float32 [])), (var_1: int64), (var_2: float32), (var_3: int64)): float32 =
    let (var_4: bool) = (var_3 < var_1)
    if var_4 then
        let (var_5: bool) = (var_3 >= 0L)
        let (var_6: bool) = (var_5 = false)
        if var_6 then
            (failwith "Argument out of bounds.")
        else
            ()
        let (var_7: float32) = var_0.[int32 var_3]
        let (var_8: float32) = (var_2 + var_7)
        let (var_9: int64) = (var_3 + 1L)
        method_23((var_0: (float32 [])), (var_1: int64), (var_8: float32), (var_9: int64))
    else
        var_2
let (var_0: string) = cuda_kernels
let (var_1: ManagedCuda.CudaContext) = ManagedCuda.CudaContext(false)
var_1.Synchronize()
let (var_2: string) = System.Environment.get_CurrentDirectory()
let (var_3: string) = System.IO.Path.Combine(var_2, "nvcc_router.bat")
let (var_4: System.Diagnostics.ProcessStartInfo) = System.Diagnostics.ProcessStartInfo()
var_4.set_RedirectStandardOutput(true)
var_4.set_RedirectStandardError(true)
var_4.set_UseShellExecute(false)
var_4.set_FileName(var_3)
let (var_5: System.Diagnostics.Process) = System.Diagnostics.Process()
var_5.set_StartInfo(var_4)
let (var_7: (System.Diagnostics.DataReceivedEventArgs -> unit)) = method_0
var_5.OutputDataReceived.Add(var_7)
var_5.ErrorDataReceived.Add(var_7)
let (var_8: string) = System.IO.Path.Combine("C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community", "VC\\Auxiliary\\Build\\vcvars64.bat")
let (var_9: string) = System.IO.Path.Combine("C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community", "VC\\Tools\\MSVC\\14.11.25503\\bin\\Hostx64\\x64")
let (var_10: string) = System.IO.Path.Combine("C:\\Program Files\\NVIDIA GPU Computing Toolkit\\CUDA\\v9.0", "include")
let (var_11: string) = System.IO.Path.Combine("C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community", "VC\\Tools\\MSVC\\14.11.25503\\include")
let (var_12: string) = System.IO.Path.Combine("C:\\Program Files\\NVIDIA GPU Computing Toolkit\\CUDA\\v9.0", "bin\\nvcc.exe")
let (var_13: string) = System.IO.Path.Combine(var_2, "cuda_kernels.ptx")
let (var_14: string) = System.IO.Path.Combine(var_2, "cuda_kernels.cu")
let (var_15: bool) = System.IO.File.Exists(var_14)
if var_15 then
    System.IO.File.Delete(var_14)
else
    ()
System.IO.File.WriteAllText(var_14, var_0)
let (var_16: bool) = System.IO.File.Exists(var_3)
if var_16 then
    System.IO.File.Delete(var_3)
else
    ()
let (var_17: System.IO.FileStream) = System.IO.File.OpenWrite(var_3)
let (var_18: System.IO.StreamWriter) = System.IO.StreamWriter(var_17)
var_18.WriteLine("SETLOCAL")
let (var_19: string) = String.concat "" [|"CALL "; "\""; var_8; "\""|]
var_18.WriteLine(var_19)
let (var_20: string) = String.concat "" [|"SET PATH=%PATH%;"; "\""; var_9; "\""|]
var_18.WriteLine(var_20)
let (var_21: string) = String.concat "" [|"\""; var_12; "\" -gencode=arch=compute_30,code=\\\"sm_30,compute_30\\\" --use-local-env --cl-version 2017 -I\""; var_10; "\" -I\"C:\\cub-1.7.4\" -I\""; var_11; "\" --keep-dir \""; var_2; "\" -maxrregcount=0  --machine 64 -ptx -cudart static  -o \""; var_13; "\" \""; var_14; "\""|]
var_18.WriteLine(var_21)
var_18.Dispose()
var_17.Dispose()
let (var_22: System.Diagnostics.Stopwatch) = System.Diagnostics.Stopwatch.StartNew()
let (var_23: bool) = var_5.Start()
let (var_24: bool) = (var_23 = false)
if var_24 then
    (failwith "NVCC failed to run.")
else
    ()
var_5.BeginOutputReadLine()
var_5.BeginErrorReadLine()
var_5.WaitForExit()
let (var_25: int32) = var_5.get_ExitCode()
let (var_26: bool) = (var_25 = 0)
let (var_27: bool) = (var_26 = false)
if var_27 then
    let (var_28: string) = System.String.Format("{0}",var_25)
    let (var_29: string) = String.concat ", " [|"NVCC failed compilation."; var_28|]
    let (var_30: string) = System.String.Format("[{0}]",var_29)
    (failwith var_30)
else
    ()
let (var_31: System.TimeSpan) = var_22.get_Elapsed()
printfn "The time it took to compile the Cuda kernels is: %A" var_31
let (var_32: ManagedCuda.BasicTypes.CUmodule) = var_1.LoadModulePTX(var_13)
var_5.Dispose()
let (var_33: string) = String.concat "" [|"Compiled the kernels into the following directory: "; var_2|]
let (var_34: string) = System.String.Format("{0}",var_33)
System.Console.WriteLine(var_34)
let (var_35: ManagedCuda.CudaDeviceProperties) = var_1.GetDeviceInfo()
let (var_36: ManagedCuda.BasicTypes.SizeT) = var_35.get_TotalGlobalMemory()
let (var_37: int64) = int64 var_36
let (var_38: float) = float var_37
let (var_39: float) = (0.700000 * var_38)
let (var_40: int64) = int64 var_39
let (var_41: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(var_40)
let (var_42: ManagedCuda.BasicTypes.CUdeviceptr) = var_1.AllocateMemory(var_41)
let (var_43: (Union0 ref)) = (ref (Union0Case0(Tuple1(var_42))))
let (var_44: System.Collections.Generic.Stack<Env2>) = System.Collections.Generic.Stack<Env2>()
let (var_45: ManagedCuda.BasicTypes.CUdeviceptr) = method_1((var_43: (Union0 ref)))
let (var_46: ManagedCuda.BasicTypes.SizeT) = var_45.Pointer
let (var_47: uint64) = uint64 var_46
let (var_48: uint64) = uint64 var_40
let (var_49: ManagedCuda.CudaStream) = ManagedCuda.CudaStream()
let (var_50: ManagedCuda.CudaRand.GeneratorType) = ManagedCuda.CudaRand.GeneratorType.PseudoDefault
let (var_51: ManagedCuda.CudaRand.CudaRandDevice) = ManagedCuda.CudaRand.CudaRandDevice(var_50)
let (var_52: ManagedCuda.BasicTypes.CUstream) = var_49.get_Stream()
var_51.SetStream(var_52)
let (var_53: ManagedCuda.CudaBlas.PointerMode) = ManagedCuda.CudaBlas.PointerMode.Host
let (var_54: ManagedCuda.CudaBlas.AtomicsMode) = ManagedCuda.CudaBlas.AtomicsMode.Allowed
let (var_55: ManagedCuda.CudaBlas.CudaBlas) = ManagedCuda.CudaBlas.CudaBlas(var_53, var_54)
let (var_56: ManagedCuda.CudaBlas.CudaBlasHandle) = var_55.get_CublasHandle()
let (var_57: ManagedCuda.BasicTypes.CUstream) = var_49.get_Stream()
var_55.set_Stream(var_57)
let (var_58: string) = System.IO.Path.Combine("C:\\ML Datasets\\Mnist", "t10k-images.idx3-ubyte")
let (var_59: Tuple3) = method_2((var_58: string))
let (var_60: Tuple4) = var_59.mem_0
let (var_61: (uint8 [])) = var_59.mem_1
let (var_62: int64) = var_60.mem_0
let (var_63: int64) = var_60.mem_1
let (var_64: int64) = var_60.mem_2
let (var_65: bool) = (10000L = var_62)
let (var_69: bool) =
    if var_65 then
        let (var_66: bool) = (28L = var_63)
        if var_66 then
            (28L = var_64)
        else
            false
    else
        false
let (var_70: bool) = (var_69 = false)
if var_70 then
    (failwith "Mnist dimensions do not match the expected values.")
else
    ()
let (var_71: int64) = var_61.LongLength
let (var_72: bool) = (var_71 > 0L)
let (var_73: bool) = (var_72 = false)
if var_73 then
    (failwith "Tensor needs to be at least size 1.")
else
    ()
let (var_74: bool) = (7840000L = var_71)
let (var_75: bool) = (var_74 = false)
if var_75 then
    (failwith "The product of given dimensions does not match the product of tensor dimensions.")
else
    ()
let (var_79: (float32 [])) = Array.zeroCreate<float32> (System.Convert.ToInt32(7840000L))
let (var_80: int64) = 0L
method_3((var_61: (uint8 [])), (var_79: (float32 [])), (var_80: int64))
let (var_81: string) = System.IO.Path.Combine("C:\\ML Datasets\\Mnist", "t10k-labels.idx1-ubyte")
let (var_82: Tuple5) = method_5((var_81: string))
let (var_83: int64) = var_82.mem_0
let (var_84: (uint8 [])) = var_82.mem_1
let (var_85: bool) = (10000L = var_83)
let (var_86: bool) = (var_85 = false)
if var_86 then
    (failwith "Mnist dimensions do not match the expected values.")
else
    ()
let (var_90: (float32 [])) = Array.zeroCreate<float32> (System.Convert.ToInt32(100000L))
let (var_91: int64) = 0L
method_6((var_84: (uint8 [])), (var_90: (float32 [])), (var_91: int64))
let (var_92: string) = System.IO.Path.Combine("C:\\ML Datasets\\Mnist", "train-images.idx3-ubyte")
let (var_93: Tuple3) = method_2((var_92: string))
let (var_94: Tuple4) = var_93.mem_0
let (var_95: (uint8 [])) = var_93.mem_1
let (var_96: int64) = var_94.mem_0
let (var_97: int64) = var_94.mem_1
let (var_98: int64) = var_94.mem_2
let (var_99: bool) = (60000L = var_96)
let (var_103: bool) =
    if var_99 then
        let (var_100: bool) = (28L = var_97)
        if var_100 then
            (28L = var_98)
        else
            false
    else
        false
let (var_104: bool) = (var_103 = false)
if var_104 then
    (failwith "Mnist dimensions do not match the expected values.")
else
    ()
let (var_105: int64) = var_95.LongLength
let (var_106: bool) = (var_105 > 0L)
let (var_107: bool) = (var_106 = false)
if var_107 then
    (failwith "Tensor needs to be at least size 1.")
else
    ()
let (var_108: bool) = (47040000L = var_105)
let (var_109: bool) = (var_108 = false)
if var_109 then
    (failwith "The product of given dimensions does not match the product of tensor dimensions.")
else
    ()
let (var_113: (float32 [])) = Array.zeroCreate<float32> (System.Convert.ToInt32(47040000L))
let (var_114: int64) = 0L
method_8((var_95: (uint8 [])), (var_113: (float32 [])), (var_114: int64))
let (var_115: string) = System.IO.Path.Combine("C:\\ML Datasets\\Mnist", "train-labels.idx1-ubyte")
let (var_116: Tuple5) = method_5((var_115: string))
let (var_117: int64) = var_116.mem_0
let (var_118: (uint8 [])) = var_116.mem_1
let (var_119: bool) = (60000L = var_117)
let (var_120: bool) = (var_119 = false)
if var_120 then
    (failwith "Mnist dimensions do not match the expected values.")
else
    ()
let (var_124: (float32 [])) = Array.zeroCreate<float32> (System.Convert.ToInt32(600000L))
let (var_125: int64) = 0L
method_9((var_118: (uint8 [])), (var_124: (float32 [])), (var_125: int64))
let (var_126: int64) = var_79.LongLength
let (var_127: int64) = (var_126 * 4L)
let (var_128: Env6) = method_10((var_47: uint64), (var_44: System.Collections.Generic.Stack<Env2>), (var_48: uint64), (var_127: int64))
let (var_129: (Union0 ref)) = var_128.mem_0
let (var_130: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_129: (Union0 ref)))
var_1.CopyToDevice(var_130, var_79)
let (var_131: int64) = var_90.LongLength
let (var_132: int64) = (var_131 * 4L)
let (var_133: Env6) = method_10((var_47: uint64), (var_44: System.Collections.Generic.Stack<Env2>), (var_48: uint64), (var_132: int64))
let (var_134: (Union0 ref)) = var_133.mem_0
let (var_135: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_134: (Union0 ref)))
var_1.CopyToDevice(var_135, var_90)
let (var_136: int64) = var_113.LongLength
let (var_137: int64) = (var_136 * 4L)
let (var_138: Env6) = method_10((var_47: uint64), (var_44: System.Collections.Generic.Stack<Env2>), (var_48: uint64), (var_137: int64))
let (var_139: (Union0 ref)) = var_138.mem_0
let (var_140: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_139: (Union0 ref)))
var_1.CopyToDevice(var_140, var_113)
let (var_141: int64) = var_124.LongLength
let (var_142: int64) = (var_141 * 4L)
let (var_143: Env6) = method_10((var_47: uint64), (var_44: System.Collections.Generic.Stack<Env2>), (var_48: uint64), (var_142: int64))
let (var_144: (Union0 ref)) = var_143.mem_0
let (var_145: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_144: (Union0 ref)))
var_1.CopyToDevice(var_145, var_124)
let (var_146: int64) = 31360L
let (var_147: Env6) = method_10((var_47: uint64), (var_44: System.Collections.Generic.Stack<Env2>), (var_48: uint64), (var_146: int64))
let (var_148: (Union0 ref)) = var_147.mem_0
let (var_149: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_148: (Union0 ref)))
let (var_150: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(7840L)
var_51.GenerateNormal32(var_149, var_150, 0.000000f, 0.050189f)
let (var_151: int64) = 31360L
let (var_152: Env6) = method_10((var_47: uint64), (var_44: System.Collections.Generic.Stack<Env2>), (var_48: uint64), (var_151: int64))
let (var_153: (Union0 ref)) = var_152.mem_0
let (var_154: ManagedCuda.BasicTypes.CUdeviceptr) = method_13((var_153: (Union0 ref)))
let (var_155: ManagedCuda.BasicTypes.CUstream) = var_49.get_Stream()
let (var_156: ManagedCuda.BasicTypes.SizeT) = ManagedCuda.BasicTypes.SizeT(31360L)
var_1.ClearMemoryAsync(var_154, 0uy, var_156, var_155)
let (var_157: int64) = 0L
let (var_158: float) = method_14((var_1: ManagedCuda.CudaContext), (var_32: ManagedCuda.BasicTypes.CUmodule), (var_49: ManagedCuda.CudaStream), (var_47: uint64), (var_48: uint64), (var_44: System.Collections.Generic.Stack<Env2>), (var_56: ManagedCuda.CudaBlas.CudaBlasHandle), (var_153: (Union0 ref)), (var_148: (Union0 ref)), (var_139: (Union0 ref)), (var_144: (Union0 ref)), (var_157: int64))
System.Console.WriteLine("-----")
System.Console.WriteLine("Batch done.")
let (var_159: float) = (var_158 / 60000.000000)
let (var_160: string) = System.String.Format("Average of batch costs is {0}.",var_159)
let (var_161: string) = System.String.Format("{0}",var_160)
System.Console.WriteLine(var_161)
System.Console.WriteLine("-----")
var_153 := Union0Case1
var_148 := Union0Case1
var_55.Dispose()
var_51.Dispose()
var_49.Dispose()
let (var_162: ManagedCuda.BasicTypes.CUdeviceptr) = method_1((var_43: (Union0 ref)))
var_1.FreeMemory(var_162)
var_43 := Union0Case1
var_1.Dispose()

