using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City17RobloxAutomation.Types
{
    public class Regulation
    {
        public int Level { get; set; } = -1; // E.g. 1
        public string Code { get; set; } = null; // E.g. 1.1
        public string Name { get; set; } = null; // E.g. Climbing ladders and fences
        public string Description { get; set; } = null; // E.g. Accessing any ladders and climbing over fences is prohibited.

        public Verdict[] Verdicts { get; set; } = null; // E.g. First Warning, 1 Cycle of Re-Education and Capital Prosecution
    }
}
