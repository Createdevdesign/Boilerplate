﻿using System;
using System.Collections.Generic;
using System.Text;
using BoilerSupplier.DataTransferObject;

namespace BoilerSupplier.Business
{
    public interface ITabVerifyAcceptService
    {
        TabVerifyAccept InsertTabVerifyAccept(TabVerifyAccept input);
    }
}
