module SpiralExample.Main
let cuda_kernels = """

extern "C" {
    
}
"""

let rec method_0((var_0: (int64 [])), (var_1: int64)): unit =
    let (var_2: bool) = (var_1 < 10L)
    if var_2 then
        let (var_3: bool) = (var_1 >= 0L)
        let (var_4: bool) = (var_3 = false)
        if var_4 then
            (failwith "Argument out of bounds.")
        else
            ()
        var_0.[int32 var_1] <- var_1
        let (var_5: int64) = (var_1 + 1L)
        method_0((var_0: (int64 [])), (var_5: int64))
    else
        ()
let (var_0: (int64 [])) = Array.zeroCreate<int64> (System.Convert.ToInt32(10L))
let (var_1: int64) = 0L
method_0((var_0: (int64 [])), (var_1: int64))
var_0.[int32 5L]
