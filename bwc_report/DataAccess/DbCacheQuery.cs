using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.DataAccess
{
    public static class DbCacheQuery
    {
        public static string CmdQBWCBIOPHYByPAAdmDR_()
        {
            const string cmd = @"
                SELECT ID, QUESPAAdmDR, QUESPAPatMasDR, QUESDate, QUESTime, QUESScore, 
	                QUESSSUserDefWindowDR, QUESUserDR, QUESOEOrdExecDR, QUESMRClinicalPathWaysDR, 
	                QUESCreateDate, QUESCreateTime, QUESCreateUserDR, QUESStatusDR, QUESTextResultDR, 
	                QUESConsultDR, QUESOperRoomDR, QUESFHResidentDR, QUESPathwayItemDR, QUESPAWaitingListDR, 
	                QMHR, QModerateZone6, QModerateZone7, QModerateZone8, QMileWalkTime, QMileWalkHR, QMileWalkSpeed, 
	                QPhMuscleStrength, QPhFlexibility, QPhMuscleEndurance, QPhAnaerobicPower, QPhAgility, QPhVitalCapacity, 
	                QIsoTrunkFlexion, QIsoTrunkExtension, QHIP, QWaist, QUESCopiedEpDR, QUESCopiedUserDR, QUESCopiedDate, 
	                QUESCopiedTime, QUESCopiedComments, QUESReasonForCorrectionDR, QUESErrorReasonDR, QUESNRCarePlanIssuesDR, 
	                QUESRBAppointmentDR, QUESAnaDR, QUESAnaOperationDR, QUESCopiedSourceDR, QUESTransactionDR, QUESObsEntryDR, 
	                QUESPAPregnancyDR, QUESPrePostExamOEOrdItemDR
                FROM questionnaire.QBWCBIOPHY
                Where QUESPAAdmDR = ?
            ";

            return cmd;
        }

        public static string CmdQBWCBIOPHYByPAAdmDR()
        {
            const string cmd = @"
                SELECT ID, QUESPAAdmDR, QMHR, QModerateZone6, QModerateZone7, QModerateZone8, 
	                QMileWalkTime, QMileWalkHR, QMileWalkSpeed, QPhMuscleStrength,
	                QPhFlexibility, QPhMuscleEndurance, QPhAnaerobicPower,
	                QPhAgility, QPhVitalCapacity, QIsoTrunkFlexion, QIsoTrunkExtension
                FROM questionnaire.QBWCBIOPHY
                WHERE QUESPAAdmDR = ? 
            ";

            return cmd;
        }

        public static string ProcedureBWCEprObservation(long paadmRowId)
        {
            return "{CALL \"Custom\".\"BWC\".\"Store\".\"BWCEprObservation\".('" + paadmRowId + "')}";
        }
    }
}