using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensus_Analyser
{
   public class IndianStateCensusAnalyser
    {
        public class StatesCensusNumberOfRecordsExcption : Exception
        {
            public StatesCensusNumberOfRecordsExcption(string Massage) : base(string.Format("data is mission")) { }
        }
        public class StateCensusTypeExcption : Exception
        {
            public StateCensusTypeExcption(string massage) : base(string.Format("Invalid type Exception")) { }
        }
        public class StateCensusFileExcption : Exception
        {
            public StateCensusFileExcption(string massage) : base(string.Format("Invalid File or File not exist Exception")) { }
        }
        public class HeaderValidationException : Exception
        {
            public HeaderValidationException(string massage) : base(string.Format("Wrong Header Exception")) { }
        }
    }
}
