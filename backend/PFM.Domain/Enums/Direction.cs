﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace PFM.Domain.Enums
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Direction
    {
        d,
        c
    }
}
