﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makit.Library.Responses
{
    //Création de la classe de reponse au requèttes.
    public class ServiceResponse
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
