﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Thinktecture.IdentityServer.Web.ViewModels
{
    public class RPCertInputModel
    {
        public HttpPostedFileBase EncryptingCertificate { get; set; }
        public bool? RemoveCert { get; set; }
    }
}