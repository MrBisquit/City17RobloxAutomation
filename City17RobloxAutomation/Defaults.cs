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
        public static List<Verdict> CombineRegulationSL1V = new List<Verdict>()
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

        public static List<Verdict> CombineRegulationSL2V = new List<Verdict>()
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

        public static List<Verdict> CombineRegulationSL3V = new List<Verdict>()
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
        #endregion

        #region Civilian Regulations
        public static List<Verdict> CivilianRegulationSL1V = new List<Verdict>()
        {
            new Verdict()
            {
                Level = 1,
                Name = "FIRST WARNING"
            },
            new Verdict()
            {
                Level = 2,
                Name = "1 CYCLE OF RE-EDUCATION"
            },
            new Verdict()
            {
                Level = 3,
                Name = "CAPITAL PROSECUTION"
            }
        };

        public static List<Verdict> CivilianRegulationSL2V = new List<Verdict>()
        {
            new Verdict()
            {
                Level = 1,
                Name = "3 CYCLES OF RE-EDUCATION"
            },
            new Verdict()
            {
                Level = 2,
                Name = "CAPITAL PROSECUTION"
            }
        };

        public static List<Verdict> CivilianRegulationSL3V = new List<Verdict>()
        {
            new Verdict()
            {
                Level = 1,
                Name = "CAPITAL PROSECUTION"
            }
        };

        public static Regulation[] CivilianRegulations =
        {
            // Level 1,
            new Regulation()
            {
                Level = 1,
                Code = "1.1",
                Name = "CLIMBING LADDERS AND FENCES",
                Description = "ACCESSING ANY LADDERS AND CLIMBING OVER FENCES IS PROHIBITED",
                Verdicts = CivilianRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.2",
                Name = "CAUSING A DISTURBANCE TO OTHERS",
                Description = "HARASSING, INSULTING, OR SLANDERING OTHERS IS PROHIBITED",
                Verdicts = CivilianRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.3",
                Name = "LOITERING",
                Description = "BEING IN THE PROXIMITY OF AN AREA THAT IS RESTRICTED IS PROHIBITED",
                Verdicts = CivilianRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.4",
                Name = "YELLING",
                Description = "SENDING A MESSAGE WITH A MAJORITY OF LETTERS CAPITALIZED IS PROHIBITED",
                Verdicts = CivilianRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.5",
                Name = "UNCIVIL BEHAVIOR",
                Description = "THROWING OBJECTS AT OTHERS, PUSHING OTHERS, OR HAVING PHYSICAL CONTACT WITH OTHERS IS PROHIBITED",
                Verdicts = CivilianRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.6",
                Name = "MISINFORMING",
                Description = "FALSELY ACCUSING OTHERS, MISINFORMING LOCAL AUTHORITIES, AND DISSIPATING THEIR TIME AND RESOURCES IS PROHIBITED",
                Verdicts = CivilianRegulationSL1V
            },
            // LEVEL 2
            new Regulation()
            {
                Level = 2,
                Code = "2.1",
                Name = "ATTEMPTING TO SOCIOCIDE",
                Description = "PROCLAIMING INTENT TO INCREASE PROBABILITY OF SOCIO DESTABILIZATION, OR INTENT TO CAUSE PHYSICAL HARM TO OTHERS IS PROHIBITED",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.2",
                Name = "COMMUNICATING IN A PROHIBITED LANGUAGE",
                Description = "COMMUNICATING IN ANY LANGUAGE EXCEPT THE 'ENGLISH' LANGUAGE IS PROHIBITED",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.3",
                Name = "OBSTRUCTING LOCAL AUTHORITIES",
                Description = "INTERFERING WITH THE DUTIES OF LOCAL AUTHORITIES",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.4",
                Name = "SURRENDERING CARRIED CONTRABAND TO LOCAL AUTHORITIES",
                Description = "CARRYING CONTRABAND ON YOUR PERSON IS PROHIBITED. SURRENDERING CONTRABAND WITHOUT RESISTANCE, BY DISCARDING, DROPPING, OR BEING SUBJECT TO A SEARCH RESULTS IN A LEVEL 2 VIOLATION RATHER THAN A LEVEL 3 VIOLATION",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.5",
                Name = "ANTI UNIVERSAL UNION RHETORIC",
                Description = "UNDERMINING THE UNIVERSAL UNION, PERSUADING OTHERS TO DEFY THE UNIVERSAL UNION, OR ASSISTING OTHERS IN ANTI CIVIL ACTIVITIES IS PROHIBITED",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.6",
                Name = "INSULTING LOCAL AUTHORITIES",
                Description = "DISRESPECTING LOCAL AUTHORITIES BY VERBALLY INSULTING THEM",
                Verdicts = CivilianRegulationSL2V
            },
            // LEVEL 3
            new Regulation()
            {
                Level = 3,
                Code = "3.1",
                Name = "ENGAGING IN DISOBEDIENCE WITH LOCAL AUTHORITIES",
                Description = "REFUSING, IGNORING, OR NOT IMMEDIATELY RESPONDING TO INSTRUCTIONS GIVEN BY LOCAL AUTHORITIES IS PROHIBITED",
                Verdicts = CivilianRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.2",
                Name = "FAILING TO COMPLY WITH SOCIO STATUS PROTOCOL",
                Description = "REFUSING, IGNORING, OR NOT IMMEDIATELY RESPONDING TO INSTRUCTIONS CONCERNING SOCIOSTABILITY IS PROHIBITED",
                Verdicts = CivilianRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.3",
                Name = "USAGE OF CONTRABAND",
                Description = "USING CONTRABAND TO HARM OWN OR ANOTHER PERSON IS PROHIBITED",
                Verdicts = CivilianRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.4",
                Name = "TRESPASSING ON RESTRICTED TERRITORY",
                Description = "ACCESSING ANY RESTRICTED REGION IS PROHIBITED",
                Verdicts = CivilianRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.5",
                Name = "COMMITTING THEFT",
                Description = "STEALING ANY PROPERTY IS PROHIBITED",
                Verdicts = CivilianRegulationSL3V
            }
        };
        #endregion
    }
}
