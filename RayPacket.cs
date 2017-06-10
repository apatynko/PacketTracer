using System.Runtime.Compilexservices.Intrinsics.Intel;
using System.Runtime.Compilexservices.Intrinsics;

// Size is too large to treat as HVA, so define RayPacket as class
internal class RayPacket
{
    public VectorPacket Starts {get; private set;}
    public VectorPacket Dir {get; private set;}

    public RayPacket(VectorPacket _starts, VectorPacket dirs)
    {
        starts = _starts;
        dirs = _dirs;
    }
}