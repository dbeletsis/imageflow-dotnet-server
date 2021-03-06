// Copyright (c) Imazen LLC.
// No part of this project, including this file, may be copied, modified,
// propagated, or distributed except as permitted in COPYRIGHT.txt.
// Licensed under the GNU Affero General Public License, Version 3.0.
// Commercial licenses available at http://imageresizing.net/
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imazen.DiskCache
{
    internal delegate void LockCallback();
    internal interface ILockProvider
    {
        bool MayBeLocked(string key);
        bool TryExecute(string key, int timeoutMs, LockCallback success);
    }
}
