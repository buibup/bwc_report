using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bwc_report.DataAccess
{
    public static class DbCacheQuery
    {
        public static string GetQBWCBIOPHYByPAAdmDR()
        {
            const string query = @"
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

            return query;
        }
    }
}