﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGenerator.Datamodel;

namespace CommonInterfaces
{
    public interface IReader
    {
        CodeGenerator.Datamodel.Datamodel getDatamodel(string filePath);
    }
}