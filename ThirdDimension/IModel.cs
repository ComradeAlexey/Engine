﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Icosahedron.ThirdDimension
{
    public interface IModel
    {
        List<PolyLine3D> GetLines();
        void SetEdgeLenght(float edgeLenght);
    }
}
