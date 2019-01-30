using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture.Farming
{
    public interface ISingable
    {
        string Name { get; set; }
        string MakeSoundOnce();
        string MakeSoundTwice();
    }
}
