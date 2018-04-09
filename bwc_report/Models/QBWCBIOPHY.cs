using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.Models
{
    public class QBWCBIOPHY
    {
        public int ID { get; set; }
        public long QUESPAAdmDR { get; set; }
        public int QUESPAPatMasDR { get; set; }
        public DateTime QUESDate { get; set; }
        public TimeSpan QUESTime { get; set; }
        public string QUESScore { get; set; }
        public int QUESSSUserDefWindowDR { get; set; }
        public int QUESUserDR { get; set; }
        public string QUESOEOrdExecDR { get; set; }
        public string QUESMRClinicalPathWaysDR { get; set; }
        public DateTime QUESCreateDate { get; set; }
        public TimeSpan QUESCreateTime { get; set; }
        public int QUESCreateUserDR { get; set; }
        public int QUESStatusDR { get; set; }
        public string QUESTextResultDR { get; set; }
        public int QUESOperRoomDR { get; set; }
        public int QUESFHResidentDR { get; set; }
        public string QUESPathwayItemDR { get; set; }
        public int QUESPAWaitingListDR { get; set; }
        public int QMHR { get; set; }
        public int QModerateZone6 { get; set; }
        public int QModerateZone7 { get; set; }
        public int QModerateZone8 { get; set; }
        public int QMileWalkTime { get; set; }
        public int QMileWalkHR { get; set; }
        public string QMileWalkSpeed { get; set; }
        public string QPhMuscleStrength { get; set; }
        public int QPhFlexibility { get; set; }
        public int QPhMuscleEndurance { get; set; }
        public string QPhAnaerobicPower { get; set; }
        public int QPhAgility { get; set; }
        public int QPhVitalCapacity { get; set; }
        public int QIsoTrunkFlexion { get; set; }
        public int QIsoTrunkExtension { get; set; }
        public int QHIP { get; set; }
        public int QWaist { get; set; }
        public int QUESCopiedEpDR { get; set; }
        public int QUESCopiedUserDR { get; set; }
        public DateTime QUESCopiedDate { get; set; }
        public TimeSpan QUESCopiedTime { get; set; }
        public string QUESCopiedComments { get; set; }
        public int QUESReasonForCorrectionDR { get; set; }
        public int QUESErrorReasonDR { get; set; }
        public string QUESNRCarePlanIssuesDR { get; set; }
        public string QUESRBAppointmentDR { get; set; }
        public string QUESAnaDR { get; set; }
        public string QUESAnaOperationDR { get; set; }
        public int QUESCopiedSourceDR { get; set; }
        public string QUESTransactionDR { get; set; }
        public string QUESObsEntryDR { get; set; }
        public int QUESPAPregnancyDR { get; set; }
        public string QUESPrePostExamOEOrdItemDR { get; set; }
    }
}