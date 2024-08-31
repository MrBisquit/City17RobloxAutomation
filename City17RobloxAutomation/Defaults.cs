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
                Name = "VERBAL WARNING"
            },
            new Verdict()
            {
                Level = 2,
                Name = "ARREST/ADMINISTRATIVE WARNING"
            },
            new Verdict()
            {
                Level = 3,
                Name = "48 HOUR PROHIBITATION"
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
                Name = "FIRST WARNING/ADMINSTRATIVE WARNING"
            },
            new Verdict()
            {
                Level = 2,
                Name = "SECOND ARREST/KICK"
            },
            new Verdict()
            {
                Level = 3,
                Name = "72 HOUR PROHIBITION"
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
                Name = "ARREST/ADMINISTRATIVE WARNING"
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
                Description = "NEGLECTING ANY OUTSTANDING STANDARD PROCEDURE OR REGULATION DETAILED IN DOCUMENTS PUBLISHED BY AFFILIATES ON BEHALF OF THE UNIVERSAL UNION IS PROHIBITED.",
                Verdicts = CombineRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.2",
                Name = "UNPROFESSIONAL MANNERISM",
                Description = "NEGLECTING REGULATION & BEHAVIOR ETIQUETTE IS PROHIBITED.",
                Verdicts = CombineRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.3",
                Name = "UNNECESSARY CONVERSATION",
                Description = "ENGAGING IN CONVERSATION WITH CITIZENS OR OTHER COMBINE UNITS OUTSIDE OF ROLEPLAYING CIRCUMSTANCES IS PROHIBITED.",
                Verdicts = CombineRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.4",
                Name = "APPARATUS MISHANDLING",
                Description = "MISUSING ANY INVENTORY TOOK OR PHYISCAL OBJECTS, SUCH AS THE RADIO, FIREARMS, PROPS, AND DOORS."
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.5",
                Name = "WILFUL DISOBEDIENCE",
                Description = "ENGAGING IN DISOBEDIENCE WITH RANK MEMBERS OF COMMAND, HIGH COMMAND, AND OVERSIGHT ECHELONS IS PROHIBITED",
                Verdicts = CombineRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.6",
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
                Name = "ANTI UNIVERSAL UNION RHETORIC",
                Description = "UNDERMINING THE UNIVERSAL UNION, DEFYING THE UNIVERSAL UNION, OR ASSISTING OTHERS IN ANTI CIVIL ACTIVITIES IS PROHIBITED.",
                Verdicts = CombineRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.3",
                Name = "OBSTRUCTING SOCIOSTABILITY",
                Description = "INTERFERING WITH THE DUTIES OF RANK MEMBERS OF COMMAND, HIGH COMMAND, AND OVERSIGHT ECHELONS IS PROHIBITED.",
                Verdicts = CombineRegulationSL2V
            },
            // Level 3
            new Regulation()
            {
                Level = 3,
                Code = "3.1",
                Name = "UNAUTHORIZED VIOLENCE",
                Description = "ATTEMPTING OR SUCCESSFULLY ASSAULTING/(DIRECLY/INDIRECTLY) CAUSING THE DEATH OF CITIZENS CITIZENS WITHOUT PROBABLE CAUSE, THIS DOES NOT APPLY TO CROSSFIRE.",
                Verdicts = CombineRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.2",
                Name = "DISRESPECTING A SUPERIOR RANK MEMBER",
                Description = "QUESTIONING, INSULTING, OR SLANDERING A SUPERIOR RANK MEMBER IS PROHIBITED.",
                Verdicts = CombineRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.3",
                Name = "EVADING SENTENCING",
                Description = "INTENTIONALLY EVADING A VERDICT BY SWITCHING GAME TEAM, DECEIVING, FLEEING, HIDING, OR RESPAWNING IS PROHIBITED.",
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
                Name = "ONE CYCLE OF RE-EDUCATION"
            },
            new Verdict()
            {
                Level = 2,
                Name = "TWO CYCLES OF RE-EDUCATION"
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
                Name = "THREE CYCLES OF RE-EDUCATION"
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
                Name = "MOVEMENT TRANSGRESSION",
                Description = "FOUND STANDING ON OBJECTS TO GAIN ELEVATION ADVANTAGE AND CLIMBING ON LADDERS, STANDING ON FENCES.",
                Verdicts = CivilianRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.2",
                Name = "CIVIC DISUNITY",
                Description = "VERBALLY HARASSING, INSULTING, OR SLANDERING OTHERS IS PROHIBITED.",
                Verdicts = CivilianRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.3",
                Name = "LOITERING",
                Description = "BEING IN THE PROXIMITY OF AN AREA THAT IS RESTRICTED IS PROHIBITED.",
                Verdicts = CivilianRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.4",
                Name = "VERBAL INDISCRETION",
                Description = "SENDING A MESSAGE WITH A MAJORITY OF LETTERS CAPITALIZED IS PROHIBITED.",
                Verdicts = CivilianRegulationSL1V
            },
            new Regulation()
            {
                Level = 1,
                Code = "1.5",
                Name = "UNCIVIL BEHAVIOR",
                Description = "THROWING OBJECTS AT OTHERS, PUSHING OTHERS, OR HAVING PHYSICAL CONTACT WITH OTHERS IS PROHIBITED, REPEATEDLY USING VOICELINES OR TRESPASSING IN SOMEONE'S RESIDENCE.",
                Verdicts = CivilianRegulationSL1V
            },
            // LEVEL 2
            new Regulation()
            {
                Level = 2,
                Code = "2.1",
                Name = "ANTI-CIVIL RHETORIC",
                Description = "DECLARING INTENT TO INCREASE THE PROBABILITY OF SOCIO DESTABILISATION, INTENDING TO CAUSE PHYSICAL HARM TO OTHERS, UNDERMINING OR GLORIFYING FACTIONS OTHERS THAN THOSE AFFILIATED WITH THE UNIVERSAL UNION.",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.2",
                Name = "COMMUNICATING IN A PROHIBITED LANGUAGE",
                Description = "COMMUNICATING IN ANY LANGUAGE EXCEPT THE 'ENGLISH' LANGUAGE IS PROHIBITED.",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.3",
                Name = "OBSTRUCTING LOCAL AUTHORITIES",
                Description = "WILLFULLY OBSTRUCTING LOCAL AUTHORITIES IN THE EXECUTION OF THEIR DUTIES.",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.4",
                Name = "POSSESSION OF CONTRABAND",
                Description = "POSSESING CONTRABAND DURING A FRISK, WITHOUT SURRENDERING IT TO A LOCAL PROTECTION UNIT. CITIZENS THAT INDEPENDENTLY SURRENDER OR VOLUNTEER FOR A FRISK ARE EXEMPT FROM LIABILITY UNDER THIS ARTICLE.",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.5",
                Name = "MISLEADING LOCAL AUTHORITIES",
                Description = "MAKING FALSE REPORTS CONCERNING SOCIOSTABILITY, MISINFORMING LOCAL AUTHORITIES, OR WASTING THEIR TIME AND RESOURCES.",
                Verdicts = CivilianRegulationSL2V
            },
            new Regulation()
            {
                Level = 2,
                Code = "2.6",
                Name = "DISRESPECTING LOCAL AUTHORITIES",
                Description = "VERBALLY HARASSING, QUESTIONING, OR SLANDERING LOCAL AUTHORITIES.",
                Verdicts = CivilianRegulationSL2V
            },
            // LEVEL 3
            new Regulation()
            {
                Level = 3,
                Code = "3.1",
                Name = "DISOBEDIENCE WITH LOCAL AUTHORITIES",
                Description = "REFUSING, IGNORING, OR NOT IMMEDIATELY RESPONDING TO INSTRUCTIONS GIVEN BY LOCAL AUTHORITIES IMMIDIATELY IS PROHIBITED.",
                Verdicts = CivilianRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.2",
                Name = "RESISTING PROESECUTION",
                Description = "INTENTIONALLY EVADING RE-EDUCATION OR STANDARD FRISKING PROCEDURE BY FLEEING, HIDING, OR MOVING WHILE BEING ADMINISTERED A VERDICT OR BEING SUBJECT TO A SEARCH.",
                Verdicts = CivilianRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.3",
                Name = "MALCOMPLIANCE WITH SOCIOSTATUS PROTOCOL",
                Description = "REFUSING, IGNORING, OR FAILING TO IMMIDIATELY RESPOND TO INSTRUCTIONS CONCERNING SOCIOSTABILITY"
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.4",
                Name = "USAGE OF CONTRABAND",
                Description = "USING OR EQUIPPING ILLEGALLY ACQUIRED CONTRABAND ITEMS.",
                Verdicts = CivilianRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.5",
                Name = "CRIMINAL TRESPASS",
                Description = "ACCESSING ANY RESTRICTED REGION IS PROHIBITED.",
                Verdicts = CivilianRegulationSL3V
            },
            new Regulation()
            {
                Level = 3,
                Code = "3.6",
                Name = "COMMITTING THEFT",
                Description = "STEALING ANY PROPERTY (INCLUDING TOKENS FROM CASH REGISTERS) IS PROHIBITED.",
                Verdicts = CivilianRegulationSL3V
            }
        };
        #endregion
    }
}
