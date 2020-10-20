using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public abstract class AbstractEntity
    {
        public int Id { get; }
        private static int nextId = 1;
        public AbstractEntity()
        {
            Id = nextId;
            nextId++;
        }
    }
}
