﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    interface IEvaluarProyectos
    {
         List<Proyecto> getProjectsById(int id);
    }
}
