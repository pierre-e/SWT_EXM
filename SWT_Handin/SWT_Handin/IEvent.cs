using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SWT_Handin
{
    public interface IEvent
    {
        void HookToDetector();
        void AttachToAtc(ref ATC airTrafficControl);
        void CheckEventConditions(List<ITrack> tracks);
    }
}
