﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGI
{
    public class CEnum
    {
        public enum State
        {
            VIEW,
            ADD,
            UPDATE,
            DELETE
        }

        public enum InventoryTransactionType
        {
            IN,
            OUT
        }
    }
}
