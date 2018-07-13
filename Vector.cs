// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//

internal struct Vector
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }

    public Vector(float _x, float _y, float _z)
    {
        X = _x;
        Y = _y;
        Z = _z;
    }
}
