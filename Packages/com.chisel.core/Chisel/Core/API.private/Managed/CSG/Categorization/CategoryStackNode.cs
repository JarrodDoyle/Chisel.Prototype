using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace Chisel.Core 
{
    internal struct CategoryStackNode
    { 
        public CategoryRoutingRow   routingRow;
        public int                  nodeIndex;
        public CSGOperationType     operation;
        public CategoryGroupIndex   input;
    }
}