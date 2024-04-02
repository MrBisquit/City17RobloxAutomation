using City17RobloxAutomation.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City17RobloxAutomation
{
    public static class Defaults
    {
        #region Combine Regulations
        public static Regulation[] CombineRegulations =
        {
            // Level 1
            new Regulation()
            {
                Level = 1,
                Code = "1.1",
                Name = "NEGLIGENCE OF STANDARD PROCEDURE",
                Description = "NEGLECTING ANY OUTSTANDING STANDARD PROCEDURE OR REGULATION DETAILED IN DOCUMENTS PUBLISHED BY AFFILIATES ON BEHALF OF THE UNIVERSAL UNION IS PROHIBITED",
                Verdicts = CombineRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.2",
                Name = "UNPROFESSIONAL MANNERISM",
                Description = "NEGLECTING REGULATION & BEHAVIOR ETIQUETTE IS PROHIBITED",
                Verdicts = CombineRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.3",
                Name = "UNNECESSARY CONVERSATION",
                Description = "ENGAGING IN CONVERSATION WITH CITIZENS IS PROHIBITED",
                Verdicts = CombineRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.4",
                Name = "WILFUL DISOBEDIENCE",
                Description = "ENGAGING IN DISOBEDIENCE WITH RANK MEMBERS OF COMMAND, HIGH COMMAND, AND OVERSIGHT ECHELONS IS PROHIBITED",
                Verdicts = CombineRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.5",
                Name = "VIOLATION ENCOURAGEMENT",
                Description = "ENCOURAGING OR PROVOKING OTHERS TO COMMIT A VIOLATION IS PROHIBITED",
                Verdicts = CombineRegulationSL1V
            },
            // Level 2
            new Regulation()
            {
                Level = 2,
                Code = "2.1",
                Name = "FALSE ACCUSATION",
                Description = "ACCUSING OTHERS OF AN UNTRUE VIOLATION IS PROHIBITED",
                Verdicts = CombineRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.2",
                Name = "CRIMINAL TRESPASS",
                Description = "ACCESSING ANY REGION DECLARED TO BE RESTRICTED AT OWN RANK IS PROHIBITED",
                Verdicts = CombineRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.3",
                Name = "ANTI UNIVERSAL UNION RHETORIC",
                Description = "UNDERMINING THE UNIVERSAL UNION, DEFYING THE UNIVERSAL UNION, OR ASSISTING OTHERS IN ANTI CIVIL ACTIVITIES IS PROHIBITED",
                Verdicts = CombineRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.4",
                Name = "OBSTRUCTING SOCIOSTABILITY",
                Description = "INTERFERING WITH THE DUTIES OF RANK MEMBERS OF COMMAND, HIGH COMMAND, AND OVERSIGHT ECHELONS IS PROHIBITED",
                Verdicts = CombineRegulationSL2V
            },
            // Level 3
            new Regulation()
            {
                Level = 3,
                Code = "3.1",
                Name = "UNAUTHORIZED HOMICIDE",
                Description = "CRIMINALLY CAUSING THE DEATH OF OTHERS IS PROHIBITED",
                Verdicts = CombineRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.2",
                Name = "DISRESPECTING A SUPERIOR RANK MEMBER",
                Description = "QUESTIONING, INSULTING, OR SLANDERING A SUPERIOR RANK MEMBER IS PROHIBITED",
                Verdicts = CombineRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.3",
                Name = "EVADING SENTENCING",
                Description = "INTENTIONALLY EVADING A VERDICT BY SWITCHING GAME TEAM, DECEIVING, FLEEING, HIDING, OR RESPAWNING IS PROHIBITED",
                Verdicts = CombineRegulationSL3V
            }
        };

        private static Verdict[] CombineRegulationSL1V =
        {
            new Verdict()
            {
                Level = 1,
                Name = "FIRST WARNING"
            },
            new Verdict()
            {
                Level = 2,
                Name = "SECOND WARNING + ARREST"
            },
            new Verdict()
            {
                Level = 3,
                Name = "FINAL WARNING + 24 HOUR PROHIBITION"
            },
            new Verdict()
            {
                Level = 4,
                Name = "PERMANENT PROHIBITION"
            }
        };

        private static Verdict[] CombineRegulationSL2V =
        {
            new Verdict()
            {
                Level = 1,
                Name = "FIRST WARNING + ARREST"
            },
            new Verdict()
            {
                Level = 2,
                Name = "SECOND WARNING + KICK"
            },
            new Verdict()
            {
                Level = 3,
                Name = "FINAL WARNING + 48 HOUR PROHIBITION"
            },
            new Verdict()
            {
                Level = 4,
                Name = "PERMANENT PROHIBITION"
            }
        };

        private static Verdict[] CombineRegulationSL3V =
        {
            new Verdict()
            {
                Level = 1,
                Name = "FIRST WARNING + ARREST"
            },
            new Verdict()
            {
                Level = 2,
                Name = "168 HOUR PROHIBITION"
            },
            new Verdict()
            {
                Level = 4,
                Name = "PERMANENT PROHIBITION"
            }
        };
        #endregion
    }
}
