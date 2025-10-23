﻿using Ejerecicio1.Models.Exportadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerecicio1.Models
{
    
    public interface IExportable
    {
        public bool Importar(string data,IExportador exportador);
        public string Exportar(IExportador exportador);
    }
}
