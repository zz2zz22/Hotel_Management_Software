﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerDTO
{
    public class ManagerDTO
    {
        private int iDM;
        private string nAME;
        private string gENDER;
        private string bIRTHDAY;
        private string aDDRESS;
        private string phoneNUMBER;
        private string eMAIL;
        private string identifyCARD;

        public int IDM { get => iDM; set => iDM = value; }
        public string NAME { get => nAME; set => nAME = value; }
        public string GENDER { get => gENDER; set => gENDER = value; }
        public string BIRTHDAY { get => bIRTHDAY; set => bIRTHDAY = value; }
        public string ADDRESS { get => aDDRESS; set => aDDRESS = value; }
        public string PhoneNUMBER { get => phoneNUMBER; set => phoneNUMBER = value; }
        public string EMAIL { get => eMAIL; set => eMAIL = value; }
        public string IdentifyCARD { get => identifyCARD; set => identifyCARD = value; }
    }
}