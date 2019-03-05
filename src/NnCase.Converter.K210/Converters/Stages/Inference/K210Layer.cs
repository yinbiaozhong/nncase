﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NnCase.Converter.K210.Converters.Stages.Inference
{
    public enum K210LayerType
    {
        Invalid = 0,
        Add,
        QuantizedAdd,
        GlobalAveragePool2d,
        Quantize,
        Dequantize,
        L2Normalization,
        Softmax,
        K210Conv = 10240,
        K210AddPadding,
        K210RemovePadding,
        K210Upload
    }

    public class K210LayerHeader
    {
        public K210LayerType Type { get; set; }

        public uint BodySize { get; set; }
    }

    public class K210Layer
    {
        public K210LayerHeader Header { get; set; }

        public object Body { get; set; }
    }
}
