namespace Serbilis.Helpers
{
    public static class StoredProcedure
    {
        #region Customer

        public const string CustomerBREQSRetrieve = @"[Customer].[up_CustomerBREQS_retrieve]";

        #endregion


        public const string PendingExceptions = "web.up_WebPayments_rptPending";

        //public const string SummaryExceptions = "[web].[up_WebPayments_rptSummaryCollections]";
        public const string pdveup_Death_ExactMatch = "pdve.up_Death_ExactMatch";
        public const string pdveup_Marriage_ExactMatch = "[pdve].[up_Marriage_ExactMatch]";



        public const string up_CheckPaymentDetail_insert = "[Payment].[up_CheckPaymentDetail_insert]";

        public const string up_DeferredPaymentInvoice_setPaymentMode =
            "[invoice].[up_DeferredPaymentInvoice_setPaymentMode]";
        public const string up_OfficeCoverage_retrieveProvince =
            "[admin].[up_OfficeCoverage_retrieveProvince]";

        public const string up_DeferredPaymentInvoice_process = "[invoice].[up_DeferredPaymentInvoice_process]";

        public const string up_DeferredPaymentInvoice_retrieveForORPrinting_SeqOR =
            "[invoice].[up_DeferredPaymentInvoice_retrieveForORPrinting_SeqOR]";

        public const string up_InvoiceRequest_retrieve =
            "[invoice].[up_InvoiceRequest_retrieve]";
        public const string up_BatchPayment_retrieveForBankDeposit =
            "breq.up_BatchPayment_retrieveForBankDeposit";

        public const string up_DeferredPaymentInvoice_reversal = "[invoice].[up_DeferredPaymentInvoice_reversal]";
        public const string up_GetOfficialReceiptsDetailsForDeferredInvoice = "Payment.up_GetOfficialReceiptsDetailsForDeferredInvoice";

        public const string validate_Death_cntralOffice = "vei.up_Death_validateInCentralOffice";
        public const string validate_Marriage_cntralOffice = "vei.up_Marriage_validateInCentralOffice";

        #region Administrative

        public const string SpGetLog = "sp_GetLog";
        public const string SpGetAllUsers = "sp_GetAllUsers";
        public const string SpGetAuthenticatedUsersInfo = "sp_GetAuthenticatedUsersInfo";
        public const string SpInsertUsers = "sp_InsertUsers";
        public const string SpIsUserAuthenticated = "sp_IsUserAuthenticated";
        public const string SpGetPermissionDetails = "sp_GetPermissionDetails";
        public const string TblGetPaymentMode = "PaymentMode";
        public const string GetGeoDetail = @"[Admin].[GetGeoDetail]";
        public const string GetGeoDetailVEI = @"[Admin].[GetGeoDetail]";

        public const string VSSubscriptionLevel = @"[Admin].[up_TVSSubscriptionLevel_retrieve]";
        public const string VSSubscriptionLevelPlan = @"[admin].[up_TVSubscription_retrieve]";
        public const string CheckUserRole = "admin.up_Users_checkRole";
        public const string SetUserRole = "[Admin].[up_MultiRole_Insert]";
        public const string UnsetUserRole = "admin.up_MultiRole_Insert_Unset";
        public const string GetAllUserRoles = "admin.up_UserRole_retrieve";
        public const string CheckUserAccess = "[Admin].[up_Users_checkLevel]";
        public const string GetMasterData = "Admin.GetMasterData";
        public const string UpdateOutletbyQMSSettings = @"[Admin].[UpdateOutletbyQMSSettings]";
        public const string SurveyResult_insert = @"[feedback].[up_SurveyResult_insert]";
        public const string SurveyResult_Referenceinsert = @"[feedback].[up_SurveyResultReference_insert]";
        public const string GetPSALGUOutlet = "[Admin].up_Outlets_retrieve";
        public const string GetQueueTypeByOfficerId = "[Queue].[up_GetQueueTypeByOfficerId]";
        public const string QueueRegister_retrieveDeatils = "[Queue].[up_QueueRegister_retrieve]";
        public const string Queue_generateQueueNo = "[Queue].[up_QueueSequence_generateQueueNo]";
        public const string Queue_retrieveSummary = "[Queue].[up_QueueRegister_retrieveSummary]";
        public const string CloseCounter = "[Queue].[up_Counters_close]";
        public const string OpenCounter = "[Queue].[up_Counters_open]";
        public const string GetNextProcessQueue = "[Encode].[up_Request_GetNext]";
        public const string RSOopenSession = "[Queue].[up_RSOSession_open]";
        public const string RSOcloseSession = "[Queue].[up_RSOSession_close]";
        public const string OutletQueueType_retrieveUserQueue = "Queue.up_OutletQueueType_retrieveUserQueue";
        public const string SurveyCriteria_retrieve = "[feedback].[up_SurveyCriteria_retrieve]";
        //public const string OutletQueueType_retrieveSummary = "[Queue].[up_OutletQueueType_retrieveSummary]";
        public const string OutletQueueType_retrieveSummary = "[Queue].[up_OutletQueue_retrieveMonitorQueue]";
        public const string OutletQueueType_retrieveSummaryDisplay = "[Queue].[up_OutletQueue_retrievePublicDisplay]";

        public const string Queue_MonitorTransactionstatus = "[Queue].[up_MonitorTransactionstatus]";
        public const string Queue_MonitorTransactionstatusRelease = "queue.up_QueueRegister_retrieveMonitorTransaction";
        public const string up_RegistryBookType_retrieve = "[Vei].[up_RegistryBookType_retrieve]";
        public const string up_SOProbonoReason_retrieve = "encode.up_SOProbonoReason_retrieve";
        public const string Queue_MonitorCompliance = "[Queue].[up_QueueRegister_rptCompliance]";
        public const string Queue_MonitorQueueStatistics = "[Queue].[up_QueueRegister_rptQueueStats]";
        public const string Queue_MonitorStaffPerformance = "[Queue].[up_QueueRegister_rptStaffPerformance]";

        public const string Queue_MonitorStaffPerformanceDetail =
            "[Queue].[up_QueueRegister_rptStaffPerformanceDetail]";

        // public const string Queue_AgingTransaction = "[Queue].[up_QueueRegister_rptAging]";
        public const string Queue_AgingTransaction = "queue.up_QueueRegister_rptAging";
        public const string Queue_ValidateQueueNumber = "queue.up_QueueRegister_validate";

        public const string Queue_ViewAnalytics =
            "[feedback].[up_SurveyResult_retrieveAnalytics_Horizontal]";

        public const string Queue_ViewAnalyticsbydate = "[feedback].[up_SurveyResult_retrieveAnalyticsPerDate]";
        public const string Queue_ViewAnalyticscomments = "[feedback].[up_SurveyResult_retrieveAnalyticsComments]";
        public const string Queue_QueueRegister_TagTime = "queue.up_QueueRegister_TagTime";
        public const string up_ApplicationWorkUnit_retrieve = "[admin].[up_ApplicationWorkUnit_retrieve]";
        public const string Log_Audit_Message = "[Admin].[LogAuditMessage]";
        public const string up_Users_retrieve = "[admin].[up_Users_retrieve]";
        public const string up_CityMunicipality_retrieve = "[admin].[up_CityMunicipality_retrieve]";
        public const string up_CustomerCyberOutlet_retrieve = "[customer].[up_CustomerCyberOutlet_retrieve]";
        public const string up_CyberTagPayment_retrieveForPayment = "[encode].[up_CyberTagPayment_retrieveForPayment]";
        public const string up_CyberTagPayment_retrieveDetails = "[encode].[up_CyberTagPayment_retrieveDetails]";
        public const string up_CyberTagPayment_acceptpayment = "[encode].[up_CyberBatch_PaymentProcess]";
        public const string up_BankDeposit_insertCyberClient = "[payment].[up_BankDeposit_insertCyberClient]";
        public const string up_CyberBatch_retrieve = "[encode].[up_CyberBatch_retrieve]";
        public const string RetrieveCertificateImage = "[release].[up_Release_retrieveCertificateImage]";
        public const string up_CyberBatch_reversal = "[breq].[up_CyberBatch_reversal]";
        public const string up_cyberBatch_retrieveORReprint = "[encode].[up_cyberBatch_retrieveORReprint]";
        public const string up_Remittance_insertAPI = "payment.up_Remittance_insertAPI";
        public const string up_CustomerAccess_loginAPI = "customer.up_CustomerAccess_loginAPI";
        public const string GetAllUserRoleDetails = "[Admin].[up_UserRole_retrieve]";
        public const string InsertUserRoleDetails = "[Admin].[up_UserRole_insert]";
        public const string UpdateUserRoleDetails = "[Admin].[up_UserRole_update]";
        public const string DeleteUserRoleDetails = "[Admin].[up_UserRole_delete]";
        public const string GetUserRoleDetails = "[Admin].[up_UserRole_get]";
        public const string up_Users_retrieveOutletSupervisor = "admin.up_Users_retrieveOutletSupervisor";
        public const string InsertUserDetails = "[Admin].[up_Users_insert]";
        public const string UpdateUserDetails = "[Admin].[up_Users_update]";
        public const string GetRoleIdDetails = "[Admin].[up_getRoleID]";
        public const string GetFunctionDetails = "[admin].[up_SecurityMatrix_retrieve_forRole]";
        public const string UpdateFunctionDetails = "admin.up_SecurityMatrix_updateByRole";
        public const string DeleteUserDetails = "admin.up_Users_delete";
        public const string DeleteOutlets = "admin.up_Outlets_delete";
        public const string GetDeviceTypes = "";
        public const string Logout = "admin.up_Users_logout";
        public const string Login = "admin.up_Users_login";


        #endregion

        #region Encoding 

        public const string Getmvreportinfo = "GetMVReportInfo";
        public const string Getmvrequest = "GetRequestDetailsForMV";
        public const string Updaterequeststatus = "UpdateRequestStatus";
        public const string GetMvRequestById = "GetMvRequestById";
        public const string GetMvRequestWithHistoryById = "GetMvRequestWithHistoryById";
        public const string GetRequestByQueueNumber = "sp_GetRequestByQueueNumber";
        public const string SaveRequesterDetail = "SaveRequesterDetail";
        public const string GetRequestSummaryByQueueNumber = "GetRequestSummaryByQueueNumber";
        public const string UpdateRequestDraftStatusByQueueNumber = "UpdateRequestDraftStatusByQueueNumber";

        //New DB SP
        public const string SaveRequest = "SaveRequest"; // Used to Save Request
        public const string GetRequestSummaryByTransactionNo = "GetRequestSummaryByTransactionNo"; // Edit Request from RequestSummaryDraft
        public const string GetRequestSummaryBySeriesNo = "GetRequestSummaryBySeriesNo"; // Display record in RequestSummaryDraft
        public const string UpdateEncodeRequest = "encode.up_Request_update"; // Updating Request
        public const string DeleteRequestByTransactionNo = "DeleteRequestByTransactionNo"; // Delete Request
        public const string SaveRequester = "SaveRequester"; // Used To Save Requester
        public const string GetRequesterByRequestSeriesNo = "GetRequesterByRequestSeriesNo"; // Edit Requester
        public const string up_Request_SearchRework = "encode.up_Request_SearchRework";
        public const string UpdateEncodeRequester = "UpdateRequester"; // Update Requester.
        public const string GetRequestSummaryWithoutQueueNumber = "GetRequestSummaryWithoutQueueNumber"; // RequestSummary Display.
        public const string ConfirmEncoding = @"[Encode].[ConfirmEncoding]"; // Final Confirm Encoding
        public const string GetUnConvertedRequest = @"[Encode].[up_GetUnConvertedRequest]"; // GetConversionFlag and Contact Numberr 
        public const string up_Request_retrieveExactMatch = @"ENCODE.up_Request_retrieveExactMatch"; //get list of records to send Email & SMS

        //public const string GetAll = "GetAll";
        public const string GetRequesterType = "Admin.up_RequesterType_retrieve";
        public const string GetRequesterPurposeAll = "Admin.up_RequesterPurpose_retrieveAll";
        public const string GetAllusers = "Admin.up_GetAllusers";
        public const string GetWorkUnit = "Admin.up_GetWorkUnit";
        public const string GetOffice = "admin.up_Office_retrieve";
        public const string UpdateTemporaryRequestStatusByQueueNumber = "UpdateTemporaryRequestStatusByQueueNumber";
        public const string UpdateTemporaryRequestStatusBySeriesNo = "UpdateTemporaryRequestStatusBySeriesNo";
        public const string GetCustomerList = @"[dbo].[up_customer_retrieve]";
        public const string up_birth_retrievebyBReNNumber = @"[dbo].[up_birth_retrievebyBReNNumber]";
        public const string up_Death_RetrievebyDReNNumber = @"[dbo].[up_Death_RetrievebyDReNNumber]";
        public const string up_Marriage_RetrievebyMReNNumber = @"[dbo].[up_Marriage_RetrievebyMReNNumber]";
        public const string up_Death_RetrievebyDReN = @"[pdve].[up_Death_retrievebyDReN]";
        public const string up_Marriage_RetrievebyMReN = @"[pdve].[up_Marriage_retrievebyMReN]";
        public const string up_Birth_retrievebyBReN = @"[pdve].[up_Birth_retrievebyBReN]";

        public const string SearchValidDocPrintByLastFirstName =
            @"[Encode].[up_SearchValidDocPrintByLastFirstName]";

        public const string ValidateQueueNumber = @"queue.up_QueueRegister_validate";
        public const string up_convstatus_exists = @"[dbo].[up_convstatus_exists]";
        public const string up_BlackList_verify = @"[web].[up_BlackList_verify]";
        public const string pdve_up_Birth_ExactMatch = @"[pdve].[up_Birth_ExactMatch]";
        public const string pdve_up_Death_ExactMatch = @"[pdve].[up_Death_ExactMatch]";
        public const string pdve_up_Marriage_ExactMatch = @"[pdve].[up_Marriage_ExactMatch]";
        public const string admin_up_RequestType_retrieve = @"[admin].[up_RequestType_retrieve]";

        public const string vei_up_Birth_ExactMatch = @"[vei].[up_Birth_ExactMatch]";
        public const string vei_up_Death_ExactMatch = @"[vei].[up_Death_ExactMatch]";
        public const string vei_up_Marriage_ExactMatch = @"[vei].[up_Marriage_ExactMatch]";
        public const string vei_up_crd_ExactMatch = @"[vei].[up_CRD_ExactMatch]";

        public const string UpdateRequestStatus = @"[Encode].[up_UpdateRequestStatus]";


        public const string RequestInProcessHistory = @"[Encode].[up_RequestInProcessLog_retrieveHistory]";
        public const string GenerateSeriesNo = @"[Encode].[up_CRSTxnSeries_generateSeriesNo]";
        public const string InsertRequesterByBREQS = @"[Encode].[up_Requester_insert]";

        public const string Up_AnnotationRequest_retrieveForAnnotation =
            @"[Annotation].[up_AnnotationRequest_retrieveForAnnotation]";

        //New Sp for Long Queue Solutions
        public const string GetRequestCost = "cost.up_CostMatrix_retrieveCurrent";
        public const string WalkInRequestSubmission = "encode.up_Request_confirm";

        #endregion

        #region BREQSs

        public const string RetreiveBatchRequest = @"[breq].[up_BreqsRequest_retrieveForBatching]";
        //public const string RetreiveBatchRequestForTransmittal = @"[breq].[up_BreqsRequest_retrieveByBatch]";
        public const string RetreiveBatchRequestForTransmittal = @"[breq].[up_BreqsBatchInfo_rptTransmittal]";
        public const string RetriveTransmittalReportByPaymentId = @"[breq].[up_BatchPayment_rptTransmittal]";

        public const string BreqsRequestInsertforITP1 = @"breq.up_BatchPayment_updateTotals";
        public const string InsertRequestByBREQS = @"[breq].[up_BatchRequest_insert]";
        public const string BatchInsert = @"[breq].[up_BatchPayment_insert]";
        public const string BatchInfo_Insert = @"[breq].[up_BreqsBatchInfo_insert]";
        public const string BatchRequest_AssignBatch = @"[breq].[up_BreqsRequest_assignBatch]";
        public const string BatchInfo_Submit = @"[breq].[up_BreqsBatchInfo_submit]";
        public const string BatchInfo_Search = @"[breq].[up_BatchPayment_retrieveSearch]";
        public const string BatchRequesterInsert = @"[breq].[up_BreqsRequester_insert]";
        public const string BatchRequestInsert = @"[breq].[up_BreqsRequest_insert]";
        public const string BatchSummaryReport = @"[breq].[up_Request_rptBREQSummaryStats]";
        public const string batchInfo_SearchView = @"[breq].[up_BatchPayment_retrieveByDate]";
        public const string LCRCustomerAccess = @"[customer].up_CustomerAccess_checkAccess";

        #endregion

        #region Payment

        public const string PaymentsCollectionsUpdate = "up_payments_insert";
        public const string CollectionMasterInsertCheck = "up_Collections_insert";
        public const string CollectingOfficerCurrentStatus = "Payment.up_Collections_retrieveForRemittance";
        public const string UnacknowledgedRemittances = "payment.up_Remittance_retrieveForAcknowledgement";
        public const string AcknowledgedRemittances = "Payment.up_Remittance_retrieveForDeposit";
        public const string CertifyRemittance = "Payment.up_Remittance_acknowledge";
        public const string CreateRemittance = "payment.up_Remittance_insert";
        public const string PaymentReversal = "Payment.up_Payments_reversal";
        public const string PaymentReversalBreqs = "[breq].[up_BatchPayment_reversal]";
        public const string paymentbankaccount = "admin.up_Accounts_retrieve";

        public const string GetPaymentbyORnumber = "[Payment].[up_Payments_retrieveByORNo]";
        public const string GetCollectionReportForOfficer = "Payment.GetDailyCollectionReport";
        public const string up_Payments_rptDailyCollection = "Payment.up_Payments_rptDailyCollection";
        public const string DepositToBank = "Payment.CreateBankDeposit";
        public const string DepositTransactionDetails = "Payment.up_Payments_retrieveByRemittance";
        public const string GetAvailableDenominations = "up_denomination_retrieve";
        public const string GetCollectionDetailsForRemittance = "Payment.up_Remittance_RetrieveCollectionDetails";
        public const string InsertViewableOnline = "InsertViewableOnline";
        public const string ValidatePaymentQueueNumber = "queue.up_QueueRegister_validate";
        public const string ValidateQMSQueueNumber = "[QMS].[up_ValidateQueueNumber]";
        public const string ValidateTransaction = "queue.up_Feedback_ValidateRequestNo";

        public const string GetProcessingQueue = "[Encode].[GetProcessingQueue]";
        public const string GetProcessingQueueCount = "encode.up_Request_getFPcount";
        public const string Sp_BREQPaymentQueue = "[breq].[up_BreqsRequest_search]";
        public const string Sp_BREQORPaymentQueue = "[Payment].[up_Payments_search]";
        public const string Sp_BREQORPaymentQueueSearch = "payment.up_Payments_searchBREQs";
        public const string Sp_BREQPaymentQueueReceive = "[breq].[up_BatchRequest_retrieveByBatch]";
        public const string Sp_BREQPaymentReceive = "[breq].[up_BatchPayment_retrieve]";
        public const string Sp_BREQPaymentQueueSearch = "[breq].[up_BatchPayment_retrieveSearch]";

        public const string Sp_PaymentQueue = "encode.up_Request_SearchPayment";
        public const string up_Payments_retrieveLGU = "Payment.up_Payments_retrieveLGU";
        public const string up_Payments_reversalLGU = "Payment.up_Payments_reversalLGU";
        public const string GetUserbywindowhostname = "[Payment].[up_GetUserbywindowsName]";

        public const string GenerateORNumber = "[Payment].[up_CRSORSequence_generateORNo]";
        public const string CardPaymentRetrieve = "up_CardPayment_retrieve";
        public const string CheckPaymentInsert = "Payment.up_CheckPayment_insert";
        public const string CardPaymentInsert = "[Payment].[up_CardPayment_insert]";
        public const string CheckPayment_retrieveByCustomer = "Payment.up_CheckPayment_retrieveByCustomer";
        public const string up_CheckPayment_retrieveByOfficer = "Payment.up_CheckPayment_retrieveByCustomer";
        public const string up_CheckPayment_update = "Payment.up_CheckPayment_update";
        public const string Payment_Collections_insert = "Payment.up_Collections_insert";
        public const string PaymentCollections_retrieve = "Payment.up_Collections_retrieve";
        public const string PaymentCollections_retrieveForRemittance = "Payment.up_Collections_retrieveForRemittance";
        public const string PaymentsinsertbyCash = "Payment.up_Payments_insert";
        public const string PaymentsinsertbyCashLGU = "Payment.up_Payments_insertLGU";
        public const string Payments_retrieveByOfficer = "Payment.up_Payments_retrieveByOfficer";
        public const string Payments_retrieveByORNo = "Payment.up_Payments_retrieveByORNo";
        public const string PaymentByretrieveCreditAdvice = "[payment].[up_CreditAdvice_retrieve]";
        public const string paymentCollections_retrieve = "[payment].[up_Collections_retrieve]";
        public const string paymentRemittance_retrieveVault = "[payment].[up_Remittance_retrieveVault]";
        public const string Remittance_insert = "Payment.up_Remittance_insert";
        public const string card_Payment_retrival = "[Payment].[up_CardPayment_retrieve]";
        public const string PaymentByCreditAdvice = "[payment].[up_CreditAdvice_insert]";
        public const string BankDetails = "[Payment].[GetBankDetails]";
        public const string SaveAccountDetails = "admin.up_Accounts_save";
        public const string DeleteAccountDetails = "admin.up_Accounts_delete";
        public const string up_RemittanceDeposit_insert = "Payment.up_RemittanceDeposit_insert";
        public const string up_BankDeposit_insertOutlet = "Payment.up_BankDeposit_insertOutlet";
        public const string AccountDetails = "admin.up_Accounts_retrieve";
        public const string GetWebAccessSlipInfo = "[Payment].[up_GetWebAccessSlipInfo]";
        public const string GetORDetailsByORNumber = "[Payment].[up_GetORDetails]";
        public const string GetPaymentORDetailsByORNumber = "payment.up_Payments_getORDetails";
        public const string GetORDetailsByORNumberLGU = "[Payment].[up_Payments_retrieveLGU]";
        public const string GetDetailsByOfficialReceiptNumber = "[Payment].[up_GetOfficialReceiptsDetails]";
        public const string LinkQueuenumberWithTransaction = "encode.up_Requester_assignQTN";
        public const string up_BankDeposit_retrieveClient = "[Payment].[up_BankDeposit_retrieveClient]";
        public const string up_BankDeposit_retrieveStatus = "[Payment].[up_BankDeposit_retrieveStatus]";
        public const string up_BankDeposit_ConfirmClient = "[Payment].[up_BankDeposit_ConfirmClient]";
        public const string up_BankDeposit_invalidate = "[Payment].[up_BankDeposit_invalidate]";
        public const string up_BreqsRequest_delete = "[breq].[up_BreqsRequest_delete]";
        public const string up_BreqsRequest_retrieve = "[breq].[up_BreqsRequest_retrieve]";
        public const string up_BatchPayment_process = "[breq].[up_BatchPayment_process]";
        public const string up_BatchPayment_reversal = "[breq].[up_BatchPayment_reversal]";
        public const string up_BatchPayment_retrieveByORDate = "[breq].[up_BatchPayment_retrieveByORDate]";
        public const string up_BatchRequest_retrieveForRelease = "[breq].[up_BatchRequest_retrieveForRelease]";
        public const string GetBREQSDetailsByOfficialReceiptNumbers = "[Payment].[up_payments_retrieveORs]";
        public const string up_DeferredPaymentInvoice_retrieveForORPrinting =
            "[invoice].[up_DeferredPaymentInvoice_retrieveForORPrinting]";

        public const string up_DeferredPaymentInvoice_PaymentProcess =
            "[invoice].[up_DeferredPaymentInvoice_PaymentProcess]";


        public const string up_Customer_retrieveCyberOutlet = "customer.up_Customer_retrieveCyberOutlet";

        public const string up_CyberBatch_retrieveByORDate = "encode.up_CyberBatch_retrieveByORDate";


        public const string up_OrGenerate_retrieveByORDate = "payment.up_Payments_search  ";

        public const string up_Remittance_retrieveBankDeposits = "payment.up_Remittance_retrieveBankDeposits";
        public const string up_BankDeposit_retrieveImage = "payment.up_BankDeposit_retrieveImage";


        public const string up_AsiaPay_Response_Save = "web.up_PaymentResponse_process";
        public const string get_AsiaPay_Response = "[web].[GetSuccessfulPaymentData]";
        public const string up_CardPaymentLog_retrieve = "[web].[up_CardPaymentLog_retrieve]";
        public const string up_payments_retrieveOR = "[payment].[up_payments_retrieveOR]";
        public const string up_Payments_retrieveORLGU = "[payment].[up_Payments_retrieveORLGU]";
        public const string up_Admin_GetPrinter = "[Admin].[GetPrinter]";
        public const string insert_Payment_Data = @"[web].[up_WebPayments_import]";
        public const string Walkin_Payment_Insert = "payment.up_Payments_processPayment";

        #endregion

        #region Processing

        public const string ReleaseGetTransactionForRsoProcessing = "sp_Release_GetTransactionForRSOProcessing";

        public const string releaseup_RejectionAddress_retrieve = "release.up_RejectionAddress_retrieve";
        public const string releaseup_RejectionReson_retrieve = "release.up_Release_retrieveRejectReason";

        public const string AnnotationRequestupdateApproverComments =
            "annotation.up_AnnotationRequest_updateApproverComments";

        public const string AnnotationRequestDisapprove = "annotation.up_AnnotationRequest_Disapprove";

        public const string Commentshistory = "annotation.up_AnnotationHistory_retrieve";

        public const string AnnotationRequestRetreiveforApproval =
            "annotation.up_AnnotationRequest_retrieveForApproval";

        //Stored Procedure Entrry that needs to deleted.
        public const string ReleaseGetTransactionForRsoProcessingBySeriesNo =
            "sp_Release_GetTransactionForRSOProcessing_ForSeriesNo";
        public const string up_Request_retrieveResultForDocPrint =
          "encode.up_Request_retrieveResult";
        //Stored procedure that needs to be deleted.
        public const string up_GetNegativeCertDetails = "Encode.up_GetNegativeCertDetails";
        public const string ReleaseUpdateTransactionWhenRsoProcessing = "[Encode].[up_Request_updateStatus]";
        public const string up_queryinfo_log = "pdve.up_QueryInfo_log";
        public const string up_queryinfo_retrievelast = "pdve.up_QueryInfo_RetrieveLast";
        public const string up_unlinkRequest_insert = "unlink.up_unlinkRequest_insert";


        public const string RetrieveRejectReason = "[Release].[up_Retrieve_RejectReason]";
        public const string UpdateRejectreason = "[Release].[up_RejectAccept_CTC_Signature]";
        public const string GenerateCRSCopyNo = "[Release].[up_Request_generateCopyNo]";
        public const string GetAuthorizedSignature = "admin.up_AuthSignature_retrieveCurrent";
        public const string GetReportDetails = "[Release].[up_GetReportDetail]";

        public const string GetManPowerDashboardData = "queue.up_RSOSession_ManpowerMonitor";
        public const string GetTrasnactionMonitorDashboardData = "queue.up_QueueRegister_monitorTransaction";

        #endregion

        #region Releasing
        public const string up_RSOSession_close = "queue.up_RSOSession_close";
        public const string up_birth_retrievebycnml = "up_birth_retrievebycnml";
        public const string BirthRetreiveByChildName = "up_birth_retrievebycn";
        public const string MarriageRetreiveByName = "up_marriage_retrieve";
        public const string DeathRetreiveByName = "up_death_retrieve";

        public const string DeathRetreiveByIndex = "up_death_retrieve_ITP2";
        public const string BirthRetreiveByIndex = "up_birth_retrievebycnml_ITP2";
        public const string MarriageRetreiveByIndex = "up_marriage_retrieve_ITP2";

        public const string GetAllTransactions = @"[Release].[sp_GetAllTransactions]";
        //public const string GetAllTransactionsById = @"[Release].[sp_GetAllTransactionsByTransactionNumber]";
        public const string GetAllTransactionsById = @"encode.up_Request_retrieveDetails";
        public const string UpdateRequesterdetails = @"[Release].[sp_UpdateRequesterDetails]";
        public const string UpdateResultType = @"[Release].[up_UpdateResultType]";
        public const string RequestSearch = @"encode.up_Request_Search";
        public const string SaveTransactionDetails = @"release.up_Release_Print";
        public const string SaveTransactionDetailsForReprint = @"release.up_Release_Reprint";
        public const string InsertSecpaUsageDetails = @"consumable.up_SECPAUsage_insert";
        public const string InsertSecpaSpoilageDetails = @"consumable.up_UsageDetail_insert";



        public const string soundex_birth = "up_birth_retrievebycnsdx";
        public const string SP_retrievebymnsdx = "up_birth_retrievebycnsdx";
        public const string soundex_retrievebycnmlsdx = "up_birth_retrievebycnmlsdx";
        public const string SP_retrievebycnmnsdx = "up_birth_retrievebycnsdx";
        public const string GetPrefillSearchData = "GetPrefillSearchData";
        public const string up_Birth_prelimSearch = "pdve.up_Birth_prelimSearch";
        public const string up_Marriage_prelimSearch = "pdve.up_Marriage_prelimSearch";
        public const string up_Marriage_prelimSearchCE = "pdve.up_Marriage_prelimSearchCE";
        public const string up_Death_prelimSearch = "pdve.up_Death_prelimSearch";
        public const string up_Birth_Search = "pdve.up_Birth_Search";
        public const string up_Marriage_Search = "pdve.up_Marriage_Search";
        public const string up_Death_Search = "pdve.up_Death_Search";
        public const string up_Birth_Search_Vei = "Vei.up_Birth_Search";
        public const string up_Marriage_Search_Vei = "Vei.up_Marriage_Search";
        public const string up_Death_Search_Vei = "Vei.up_Death_Search";
        public const string up_Birth_prelimSearch_Vei = "Vei.up_Birth_prelimSearch";
        public const string up_Marriage_prelimSearch_Vei = "Vei.up_Marriage_prelimSearch";
        public const string up_Death_prelimSearch_Vei = "Vei.up_Death_prelimSearch";
        public const string up_BirthQuery_Retrieve = "pdve.up_BirthQuery_Retrieve";
        public const string up_MarriageQuery_Retrieve = "pdve.up_MarriageQuery_Retrieve";
        public const string up_DeathQuery_Retrieve = "pdve.up_DeathQuery_Retrieve";
        public const string up_BirthQuery_Done = "pdve.up_BirthQuery_Done";
        public const string up_MarriageQuery_Done = "pdve.up_MarriageQuery_Done";
        public const string up_DeathQuery_Done = "pdve.up_DeathQuery_Done";
        public const string up_birthcxn_insert = "up_birthcxn_insert_itp2";
        public const string up_deathcxn_insert = "up_deathcxn_insert_itp2";
        public const string up_marriagecxn_insert = "up_marriagecxn_insert_itp2";
        public const string up_birth_brengen = "up_birth_brengen";

        public const string up_birthcxn_getforapproval = "dbo.up_birthcxn_getforapproval";
        public const string up_deathcxn_getforapproval = "dbo.up_deathcxn_getforapproval";
        public const string up_marriagecxn_getforapproval = "dbo.up_marriagecxn_getforapproval";

        public const string dboup_birthcxn_retrievebyImageID = "dbo.up_BirthCxn_retrievebyImageID";
        public const string dboup_deathcxn_retrievebyImageID = "dbo.up_DeathCxn_retrievebyImageID";
        public const string dboup_marriagecxn_retrievebyImageID = "dbo.up_MarriageCxn_retrievebyImageID";

        public const string up_birthcxn_retrievebyimageid = "pdve.up_Birth_retrieveByImageID";
        public const string up_deathcxn_retrievebyimageid = "pdve.up_Death_retrieveByImageID";
        public const string up_marriagecxn_retrievebyimageid = "pdve.up_Marriage_retrieveByImageID";
        public const string up_birth_assignbren = "up_birth_assignbren";
        public const string up_birth_unassignbren = "unlink.up_Birth_UnlinkBReN";
        public const string up_marriage_assignbren = "up_marriage_assignbren";
        public const string up_marriage_unassignbren = "unlink.up_Marriage_UnlinkBReN";
        public const string up_death_assignbren = "up_death_assignbren";
        public const string up_death_unassigndren = "up_death_unassigndren";
        public const string up_Death_UnlinkDReN = "unlink.up_Death_UnlinkDReN";
        public const string up_Marriage_UnlinkMReN = "unlink.up_Marriage_UnlinkMReN";
        public const string up_marriage_unassignmren = "up_marriage_unassignmren";
        public const string up_death_unassignbren = "unlink.up_Death_UnlinkBReN";
        public const string up_allcxns_retrievebystatus = "pdve.up_allcxns_retrieve";
        public const string up_birth_retrievebyimageid = "up_birth_retrievebyimageid";
        //public const string up_death_retrievebyimageid = "up_death_retrievebyimageid";
        public const string up_death_retrievebyimageid = "pdve.up_Death_retrieveByImageID";
        public const string up_marriage_retrievebyimageid = "up_marriage_retrievebyimageid";
        public const string up_birthcxn_update = "up_birthcxn_update";
        public const string up_MarriageCxn_insert = "pdve.up_MarriageCxn_insert";
        public const string up_BirthCxn_insert = "pdve.up_BirthCxn_insert";
        public const string up_DeathCxn_insert = "pdve.up_DeathCxn_insert";

        public const string up_Birth_retrieveByImageIDActive = "pdve.up_Birth_retrieveByImageIDActive";
        public const string up_Death_retrieveByImageIDActive = "pdve.up_Death_retrieveByImageIDActive";
        public const string up_Marriage_retrieveByImageIDActive = "pdve.up_Marriage_retrieveByImageIDActive";

        public const string up_deathcxn_update = "pdve.up_DeathCxn_update";//"up_deathcxn_update_itp2";
        public const string up_marriagecxn_update = "up_MarriageCxn_update";// "up_marriagecxn_update_itp2";
        public const string up_birthcxn_approve = "up_birthcxn_approve";
        public const string up_deathcxn_approve = "pdve.up_deathcxn_Approve";
        public const string up_marriagecxn_approve = "up_marriagecxn_approve";
        //public const string up_allcxns_inquiryretrieve_itp2 = "up_allcxns_inquiryretrieve_itp2";
        public const string up_allcxns_inquiryretrieve_itp2 = "pdve.up_allcxns_retrieve";
        public const string sp_DetailsForQRCode_retrive = "encode.up_Request_retrieveForQRCode";
        public const string sp_AuthSign_retrive = "sp_AuthSign_retrive";
        public const string sp_ReleaseCertificateImage_insert = "release.up_Release_Processed";
        public const string up_death_assigndren = "up_death_assigndren";
        public const string up_marriage_assignmren = "up_marriage_assignmren";
        public const string up_LCRSubmission_insert = "Lcr.up_LCRSubmission_insert";
        public const string up_LCRSubmission_retrieve = "Lcr.up_LCRSubmission_retrieve";
        public const string up_LCRSubmission_retrievePending = "Lcr.up_LCRSubmission_retrievePending";
        public const string up_LCRTransmittal_receive = "Lcr.up_LCRTransmittal_receive";
        public const string up_LCRSubmission_receive = "Lcr.up_LCRSubmission_receive";
        public const string up_death_getDrenLinkedRequest = "up_death_getDrenLinkedRequest";
        public const string up_birth_getBrenLinkedRequest = "up_birth_getBrenLinkedRequest";
        public const string up_marriage_getMrenLinkedRequest = "up_marriage_getMrenLinkedRequest";
        public const string up_LCRTransmittal_retrieve = "Lcr.up_LCRSubmission_retrieveByTransmittal";
        public const string up_CRDSubmission_retrieve = "crd.up_CRDSubmission_retrieve";
        public const string up_CRDSubmission_retrieve_auth = "[crd].[up_CRDSubmission_retrieve_Authentication]";
        public const string up_CRDTransmittal_retrieve = "crd.up_CRDTransmittal_retrieve";
        public const string up_LCRSubmission_transmit = "Lcr.up_LCRSubmission_transmit";
        public const string up_CRDSubmission_transmit = "crd.up_CRDSubmission_transmit";
        public const string up_CRDSubmission_retrieveByTransmittal = "crd.up_CRDSubmission_retrieveByTransmittal";
        public const string up_CDLISubmission_retrieveByTransmittal = "crd.up_CRDSubmission_retrieveDetailsByTransmittal";
        public const string up_CRDSubmission_update = "crd.up_CRDSubmission_update";
        public const string up_CRDSubmission_delete = "crd.up_CRDSubmission_delete";
        public const string up_LCRSubmission_delete = "lcr.up_LCRSubmission_delete";
        public const string up_LCRSubmission_update = "lcr.up_LCRSubmission_update";
        public const string up_CRDSubmission_receive = "crd.up_CRDSubmission_receive";
        public const string up_LCRSubmission_CDLIinsert = "Lcr.up_LCRSubmission_CDLIinsert";
        public const string up_LCRSubmission_CDLIretrieve = "Lcr.up_LCRSubmission_CDLIretrieve";
        public const string up_LCRCDLISubmission_retrievePending = "Lcr.up_LCRSubmission_CDLIretrievePending";
        public const string up_LCRCDLITransmittal_retrieve = "Lcr.up_LCRSubmission_CDLIretrieveByTransmittal";

        public const string up_LCRSubmission_CDLIretrieveByTransmittal =
            "Lcr.up_LCRSubmission_CDLIretrieveByTransmittal";

        public const string up_LCRSubmission_CDLIretrievePending = "Lcr.up_LCRSubmission_CDLIretrievePending ";
        public const string up_LCRSubmission_CDLItransmit = "Lcr.up_LCRSubmission_CDLItransmit";
        public const string VEI_up_DocumentType_retrieve = "admin.up_DocumentType_retrieve";
        public const string up_LCRCDLISubmission_insert = "Lcr.up_LCRSubmission_CDLIinsert";

        public const string up_Birth_retrieveCRD = "[vei].[up_Birth_retrieveCRD]";
        public const string up_Death_retrieveCRD = "[vei].[up_Death_retrieveCRD]";
        public const string up_Marriage_retrieveCRD = "[vei].[up_Marriage_retrieveCRD]";
        public const string BirthIndexCorrectionCancel = "dbo.up_BirthCxn_cancel";
        public const string MarriageIndexCorrectionCancel = "dbo.up_MarriageCxn_cancel";
        public const string DeathIndexCorrectionCancel = "dbo.up_DeathCxn_cancel";



        #endregion

        #region ECensus

        public const string UpBREQSRetrieve = @"[dbo].[up_custbreqs_retrievebyaccessno]";
        public const string GenerateTxnNo = @"[dbo].[up_crstxnseries_generatetxnno]";
        public const string GenerateSerbilisTxnNo = @"encode.up_CRSTxnSeries_generateSeriesNo";
        public const string BREQSUserExists = @"[dbo].up_custbreqs_userexists";
        public const string BatchPaymentExist = @"[dbo].up_batchpymt_exists";
        public const string BatchPaymentSubmit = @"breq.up_BatchPayment_insert";

        public const string bankSubmitproof = @"payment.up_BankDeposit_insertClient";
        public const string RetrieveNews = @"[Admin].[up_news_retrieve]";
        public const string RetrieveScreening = @"[dbo].[up_screening_retrieve]";
        public const string InsertScreening = @"[dbo].[up_screening_insert]";
        public const string UpdateScreening = @"[dbo].[up_screening_update]";
        public const string RetrieveHits = @"[dbo].[up_hits_retrieve]";
        public const string UpdateHits = @"[dbo].[up_hits_update]";
        public const string RetrieveSurveyQuestion = @"[dbo].[up_questions_retrieve]";
        public const string RetrieveTips = @"[dbo].[up_tips_retrieve]";

        public const string RetrieveRequester = @"[dbo].[up_crstxnheader_retrieve]";

        // public const string InsertRequester = @"[dbo].[up_crstxnheader_insert]";
        public const string InsertRequest = @"[Encode].[up_Request_insert]";
        public const string GetWebReferenceNo = @"[Encode].[uf_getWebReferenceNo]";
        public const string InsertRequester = @"[encode].[up_Requester_insert]";
        public const string BreqsInsertRequest = @"[breq].[up_BreqsRequest_insert]";
        public const string BreqsInsertRequester = @"[breq].[up_BreqsRequester_insert]";
        public const string up_Birth_ExactMatch = @"[pdve].[up_Birth_ExactMatch]";
        public const string up_Marriage_ExactMatch = @"[pdve].[up_Marriage_ExactMatch]";
        public const string up_Death_ExactMatch = @"[pdve].[up_Death_ExactMatch]";
        public const string TagRequestAsPaid = @"[encode].[up_CyberTagPayment_tag]";


        public const string UpdateRequester = @"[dbo].[up_crstxnheader_updatewithTIN]";

        public const string RetrieveRequest = @"[dbo].[up_crstransaction_retrievebytxn]";

        //public const string InsertRequest = @"[dbo].[up_crstransaction_insertweb]";
        public const string UpdateRequest = @"[dbo].[up_crsTransaction_webupdate]";
        public const string DeleteRequest = @"[dbo].[up_crstransaction_delete]";
        public const string UpdateTranStatus = @"[dbo].[up_crstransaction_updatestatus]";
        public const string RetrieveByReferenceNo = @"[dbo].[up_crstransaction_retrievebyrefno]";
        public const string RetrieveByRequest = @"[Encode].[up_Request_retrieve]";
        public const string CheckPassword = @"[Customer].[up_custaccess_checkpswd]";
        public const string GetCustomerByAccessNo = @"[Customer].[up_customer_getcustbyaccess_New]";
        public const string SetPassword = @"[Customer].[up_CustomerAccess_setAccessCode]";
        public const string GetRequestPurpose = @"[Admin].[up_RequestPurpose_retrieve]";
        public const string GetCountry = @"[Admin].[GetCountry]";
        public const string GetMunicipality = @"[Admin].[GetMunicipality]";
        public const string GetProvince = @"[admin].[up_province_retrieve]";
        public const string GetRequestRelationship = @"[dbo].[GetRequestRelationship]";
        public const string GetEmbassyDetailsByCode = @"[dbo].[up_deliveryothers_retrieve]";
        public const string GetEmbassyDetails = @"[web].[up_DeliveryOptions_retrieve]";
        //public const string GetViewDocumentDetailsByAccessCode = @"[Release].[sp_GetDetailsByAccessNumber]";
        public const string GetViewDocumentDetailsByAccessCode = @"release.up_Request_retrieveByAccessNo";
        public const string BatchPaymentsetPaymentMode = @"[breq].[up_BatchPayment_setPaymentMode]";
        public const string BatchPaymentsetReversePayment = @"[breq].up_BatchPayment_reversal";
        public const string BatchPaymentretrieveForORPrinting = @"[breq].up_BatchPayment_retrieveForORPrinting";
        public const string BatchPaymentretrieveForBankDeposit = @"[breq].up_BatchPayment_retrieveForBankDeposit";
        public const string up_BankDeposit_retrieveAlert = @"payment.up_BankDeposit_retrieveAlert";
        public const string up_CostMatrix_GetRates = @"Cost.up_CostMatrix_ComputeRequestAmount";
        public const string up_Requester_retrieveByReference = @"web.up_Requester_retrieveByReference";
        public const string up_ValidateRequestRefNum = @"web.up_Request_validateReference";

        #endregion

        #region Asset Management
        public const string up_UsageDetail_insert = "consumable.up_UsageDetail_insert ";
        public const string up_UsageDetail_update = "consumable.up_UsageDetail_update";
        public const string up_UsageDetail_delete = "consumable.up_UsageDetail_delete";
        public const string InsertAssetInventory = "Asset.sp_InsertAssetInventory";
        public const string InsertAsset = "[Consumable].[up_Asset_insert]";
        public const string InsertOutletAsset = "[Consumable].[up_OutletAsset_insert]";
        public const string UpdateAssetInventory = "Asset.sp_UpdateAssetInventory";

        public const string DeletePurchase = "Asset.sp_DeletePurchase";

        public const string ConfirmAllocationDetail = "Asset.sp_ConfirmAllocationDetail";

        public const string ConfirmAllocation = "Asset.sp_ConfirmAllocation";

        public const string DeletePurchaseDetail = "Asset.sp_DeletePurchaseDetail";

        public const string UpdateTotalNoOfBoxes = "Asset.sp_UpdateTotalNoOfBoxes";

        public const string DeleteAllocation = "Asset.sp_DeleteAllocation";

        public const string DeleteAllocationDetail = "Asset.sp_DeleteAllocationDetail";

        public const string DeleteUsageDetail = "Asset.sp_DeleteUsageDetail";
        public const string UsageDetailValidateInsert = "consumable.up_UsageDetail_ValidateInsert";
        public const string UsageDetailValidateUpdate = "consumable.up_UsageDetail_ValidateUpdate";

        #endregion

        #region Signature

        public const string GetAllSignatures = @"pdve.up_signature_retrieve";
        public const string GetMasters = @"[Signature].[GetMasters]";
        public const string GetImageSequenceID = @"[staging].[up_ImageSequence_generateImageID]";
        public const string AuthorizedSignaturesave = @"pdve.up_signature_save";
        public const string retrieveByImageID = @"pdve.up_signature_retrieveByImageID";
        public const string checkExactSignatureMatch = @"pdve.up_Signature_CheckSimilar";

        #endregion

        #region Unlink Request

        //
        public const string GetAllPendingUnlinkingRequests = @"[Unlink].[up_UnlinkRequest_retrievePending]";
        public const string GetAllUnlinkingRequests = @"[Unlink].[up_UnlinkRequest_retrieve]";
        public const string SearchByTransactionUnlinkRequests = @"[Unlink].[up_UnlinkRequest_Search]";
        public const string Disapprove_UnlinkingRequest = @"[unlink].[up_UnlinkRequest_Disapprove]";
        public const string Approve_UnlinkingRequest = @"[unlink].[up_UnlinkRequest_Approve]";
        public const string Approve_Unlinking_UnlockRequest = @"[unlink].[up_UnlinkRequest_unlock]";

        public const string Marriage_RetrieveDetailsbyBReNLink = "pdve.up_Marriage_retrievebyBReN";
        public const string Death_RetrieveDetailsbyBReNLink = "pdve.up_Death_retrievebyBReN";

        #endregion

        #region ScannedCRD

        public const string GetRegistryBookType = @"vei.up_RegBookType_retrievePrimary";
        public const string GetAllEEPendingTransactions = @"encode.up_EERequest_retrievePending";

        public const string GetVEIRecords = @"vei.up_CRD_retrieveByRegInfo";

        public const string GetVEIRecordsQA = @"vei.up_CRD_retrieveByRegInfoQA";

        public const string up_Birth_retrieveCDLI = @"vei.up_Birth_retrieveCDLI";

        public const string up_Death_retrieveCDLI = @"vei.up_Death_retrieveCDLI";

        public const string up_Marriage_retrieveCDLI = @"vei.up_Marriage_retrieveCDLI";

        //@"[Vei].[up_allcert_retrive]";
        public const string GetAllEETransactionsBySearch = @"[encode].[up_Request_EESearch]";
        public const string GetAllEETransactionsByReference = @"[Encode].[up_Request_EEGet]";
        public const string SubmitEETransactionDetails = @"[Encode].[up_EERequest_insert]";
        public const string InsertDocumentImage = @"[Encode].[up_DocumentImage_Insert]";

        public const string RetriveDocumentImage =
            @"[Encode].[up_DocumentImage_retrieveImageByRequestSeriesNo]";

        public const string GenerateImageSequence = @"staging.up_ImageSequence_generateImageID";

        //public const string GetAllVEIDetailsByEERefernceNumber = @"[Vei].[up_allcert_retriveByReferenceNumber]";
        public const string GetAllVEIDetailsByEERefernceNumber = @"[Encode].[up_EERequest_retrieve]";
        public const string UpdateDocumentImage = @"[Encode].[up_Encode_DocumentImage_Update]";
        public const string UpdateEERequestStatus = @"[Encode].[up_Request_updateStatus]";
        public const string GetAllEERequestsByDate = @"[Encode].[up_EERequest_searchByDate]";
        public const string GetAllEERequestsByName = @"[Encode].[up_EERequest_searchByName]";
        public const string GetAllEERequestsByReferenceNumber = @"[Encode].[up_EERequest_searchByReferenceNo]";
        public const string LockEeRequest = @"[Encode].[up_EERequest_getForApproval]";
        public const string UnLockEERequest = @"[Encode].[up_EERequest_abortApproval]";
        public const string GetAllEERequestsByRetrive = @"[Encode].[up_EERequestDetails_retrieve]";
        public const string DisapproveRequest = @"[Encode].[up_EERequest_disapprove]";
        public const string ApproveRequest = @"[Encode].[up_EERequest_approve]";
        public const string InitiateEERequest = @"[Encode].[up_EERequest_Initiate]";
        public const string UpdateEEBRequest = @"[vei].[up_Birth_update_indexonly]";
        public const string UpdateEEDRequest = @"[vei].[up_Death_update_indexonly]";
        public const string UpdateEEMRequest = @"[vei].[up_Marriage_update_indexonly]";
        public const string UpdateApproverCommentEEMRequest = @"encode.up_EERequest_SaveComments";

        public const string UpdateEETransactionLogRequest = @"[Encode].[up_RequestInProcessLog_LogActivity]";
        public const string ReturnForRescanningEERequest = @"[Encode].[up_EERequest_ReturnForRescanning]";

        public const string ViewEEBRequest = @"[vei].[up_Birth_retrieve_indexonly]";
        public const string ViewEEDRequest = @"[vei].[up_Death_retrieve_indexonly]";
        public const string ViewEEMRequest = @"[vei].[up_Marriage_retrieve_indexonly]";

        public const string GetPendingEEApprovalCount = @"[Encode].[up_EERequest_getPendingApprovalCount]";
        public const string GetNextEEApprovalCount = @"[Encode].[up_EERequest_getNextForApproval]";
        public const string GetAllEEStatus = @"[Encode].[up_EEStatus_retrieve]";

        public const string RemoveImage = @"encode.up_DocumentImage_retrieveImage";
        public const string CRDDataById = @"vei.up_CRD_retrieveByID";
        public const string DuplicateCheckForBirth = @"[pdve].[up_Birth_retrieveByRegInfo]";
        public const string DuplicateCheckForDeath = @"[pdve].[up_Death_retrieveByRegInfo]";
        public const string DuplicateCheckForMarriage = @"[pdve].[up_Marriage_retrieveByRegInfo]";



        #endregion

        #region Customer 
        public const string up_Customer_retrieveByName = "[Customer].[up_Customer_retrieveByName]";

        public const string GetAllCustomer = @"[Customer].[Customer_retrieve_ByNumberOrName]";
        // public const string sp_Customer_Insert = @"[encode].[sp_Customer_Insert]";
        public const string sp_Customer_Insert = @"customer.up_customer_insert";
        public const string up_UpdateCustomerToInactive = @"[Customer].[up_UpdateCustomerToInactive]";
        public const string up_Retrieve_View_CustomerByNumber = @"[Customer].[up_Retrieve_View_CustomerByNumber]";
        public const string up_Customer_RetrieveByCustomerNo = @"[customer].[up_Customer_RetrieveByCustomerNo]";


        public const string up_CostWaiver_insert = @"[cost].[up_CostWaiver_insert]";
        public const string sp_CustomerAccess_Insert = @"[Customer].[sp_CustomerAccess_Insert]";
        public const string up_CustomerStatus_retrieve = "[Customer].[up_CustomerStatus_retrieve]";
        public const string up_CustomerAccessStatus_retrieve = "[admin].[up_CustomerAccessStatus_retrieve]";
        public const string up_CustomerAccess_insert = "customer.up_CustomerAccess_insert";
        public const string up_CostWaiver_retrieve = "[Cost].[up_CostWaiver_retrieve]";
        public const string up_Customer_retrieve = "[Customer].[up_Customer_retrieve]";
        public const string up_CustomerAccess_retrieve = "[customer].[up_CustomerAccess_retrieve]";
        public const string up_CustomerAccess_update = "customer.up_CustomerAccess_update";
        public const string up_customer_update = "customer.up_customer_update";
        public const string up_CostWaiver_delete = "cost.up_CostWaiver_delete";
        public const string up_CustomerAccess_delete = "[Customer].[up_CustomerAccess_delete]";
        public const string up_Customer_retrieveForDeferred = "[Customer].[up_Customer_retrieveForDeferred]";
        public const string up_DeferredPaymentInvoice_generate = "[invoice].[up_DeferredPaymentInvoice_generate]";
        public const string up_Payments_rptMonitorCollection = "payment.up_Payments_rptMonitorCollection";
        public const string up_DeferredPaymentInvoice_retrieve = "[invoice].[up_DeferredPaymentInvoice_retrieve]";
        public const string up_DeferredPaymentInvoice_rptDetails = "[invoice].[up_DeferredPaymentInvoice_rptDetails]";
        public const string up_DeferredPaymentInvoice_rptSummary = "[invoice].[up_DeferredPaymentInvoice_rptSummary]";
        public const string up_DeferredPaymentInvoice_retrieveForReversal = "[invoice].[up_DeferredPaymentInvoice_retrieveForReversal]";

        public const string up_Payments_RCDGenerateAll = "payment.[up_Payments_RCDGenerateAll]";
        public const string up_Payments_RCDGenerate = "payment.[up_Payments_RCDGenerate]";
        public const string up_RCDRegister_retrieveSummary = "payment.up_RCDRegister_retrieveSummary";
        public const string up_Users_retrieveByRole = "admin.up_Users_retrieveByRole";
        public const string up_RCDRegister_retrieveDeposits = "payment.up_RCDRegister_retrieveDeposits";
        public const string up_RCDRegister_retrieveDetails = "payment.up_RCDRegister_retrieveDetails";
        public const string up_RCDRegister_rptSubsidiaryLedger = "payment.up_RCDRegister_rptSubsidiaryLedger";
        public const string up_RCDRegister_rptCashReceiptsRecord = "payment.up_RCDRegister_rptCashReceiptsRecord";
        public const string up_Payments_rptConsolidatedCollection = "payment.up_Payments_rptConsolidatedCollection";
        public const string up_CustomerBREQS_insert = "customer.up_CustomerBREQS_insert";
        public const string up_CustomerBREQS_delete = "customer.up_CustomerBREQS_delete";
        public const string p_CustomerBREQS_update = "customer.up_CustomerBREQS_update";
        public const string up_CustomerBREQS_retrieve = "customer.up_CustomerBREQS_retrieve";
        public const string up_CustomerBREQS_save = "customer.up_CustomerBREQS_save";
        public const string up_CheckPayment_rptDishonoredChecks = "[payment].[up_CheckPayment_rptDishonoredChecks]";
        public const string up_GLCodes_retrieve = "[Admin].[up_GLCodes_retrieve]";

        public const string Release_Verification = @"release.up_Release_Verification";


        // invoice.up_DeferredPaymentInvoice_retrieve

        #endregion

        #region Processing Linking

        public const string Birth_LinkBReN = "[link].[up_Birth_LinkBReN]";
        public const string Marriage_LinkBReN = "[link].[up_Marriage_LinkBReN]";
        public const string Death_LinkBReN = "[link].[up_Death_LinkBReN]";
        public const string Marriage_LinkMReN = "[link].[up_Marriage_LinkMReN]";
        public const string Death_LinkDReN = "[link].[up_Death_LinkDReN]";
        public const string Review_PendingReview = "[link].[up_LinkLog_retrieveForReview]";
        public const string Review_SearchByTransaction = "[link].[up_LinkLog_retrieveByRequestNo]";
        public const string Review_UnlockByTransaction = "link.up_LinkLog_unlock";
        public const string Death_RetreiveByImage = "[pdve].[up_Death_retrieveByImageID]";
        public const string Birth_RetreiveByImage = "[pdve].[up_Birth_retrieveByImageID]";
        public const string Marriage_RetreiveByImage = "[pdve].[up_Marriage_retrieveByImageID]";
        public const string Marriage_GetMrenLockReason = "[dbo].[up_marriage_GetMrenLockReason]";
        public const string Review_LinkReviewInsert = "[link].[up_LinkReview_insert]";

        public const string Birth_RetrievebyBReNLink = "[pdve].[up_Birth_retrievebyBReNLink]";
        public const string Marriage_RetrievebyMReNLink = "[pdve].[up_Marriage_retrievebyMReNLink]";
        public const string Death_RetrievebyDReNLink = "[pdve].[up_Death_retrievebyDReNLink]";
        public const string Birth_RetrieveLinkbyBReNLink = "[pdve].[up_Birth_retrievebyBReNLink]";
        public const string Marriage_RetrieveLinkbyMReNLink = "[pdve].[up_Marriage_retrievebyMReNLink]";
        public const string Death_RetrieveLinkbyDReNLink = "[pdve].[up_Death_retrievebyDReNLink]";
        public const string ValidateLinking = "link.up_AllDocuments_LinkValidate";
        #endregion

        #region AnnotationProcessing

        public const string up_AnnotationRequest_getNotation = "[annotation].[up_AnnotationRequest_getNotation]";

        public const string Annotation_Approve = "[annotation].[up_AnnotationRequest_Approve]";
        public const string BirthTag_For_EEApproval = "[vei].[up_Birth_tag_forEEapproval]";
        public const string MarriageTag_For_EEApproval = "[vei].[up_Marriage_tag_forEEapproval]";
        public const string DeathTag_For_EEApproval = "[vei].[up_Death_tag_forEEapproval]";
        public const string TransferProduction = "[annotation].[up_AnnotationRequest_TransferProduction]";

        public const string GetStoredAnnotationHeader =
            "[annotation].[up_Request_validateForAnnotationApproval]";

        public const string GetStoredAnnotation =
            "[annotation].[up_AnnotationRequest_retrieveForApproval]";

        public const string UnlockAnnotation = "[annotation].[up_Request_cancel]";
        public const string BirthRetrieveIndexOnly = "[vei].[up_Birth_retrieve_indexonly]";
        public const string DeathRetrieveIndexOnly = "[vei].[up_Death_retrieve_indexonly]";
        public const string MarriageRetrieveIndexOnly = "[vei].[up_Marriage_retrieve_indexonly]";
        public const string BirthRetrieveCRDDetails = "[pdve].[up_Birth_retrieveByImageID]";
        public const string DeathRetrieveCRDDetails = "[pdve].[up_Death_retrieveByImageID]";
        public const string MarriageRetrieveCRDDetails = "[pdve].[up_Marriage_retrieveByImageID]";
        public const string RetrieveAnnotationImage = "[annotation].[up_AnnotationRequest_retrieveImage]";
        public const string up_Templates_replace = "annotation.up_Templates_replace";
        public const string up_Request_validateForAnnotation = "[annotation].[up_Request_validateForAnnotation]";

        public const string up_AnnotationRequest_retrieveForAnnotation =
            "annotation.up_AnnotationRequest_retrieveForAnnotation";

        public const string up_AnnotationRequest_updateVEI = "annotation.up_AnnotationRequest_updateVEI";
        public const string up_AnnotationRequest_setStatus = "[annotation].[up_AnnotationRequest_setStatus]";
        public const string up_AnnotationRequest_updateAnnotation = "annotation.up_AnnotationRequest_updateAnnotation";
        public const string up_AnnotationRequest_updateImage = "annotation.up_AnnotationRequest_updateImage";

        public const string up_AnnotationRequest_replaceImageID = "[annotation].[up_AnnotationRequest_replaceImageID]";
        public const string up_AnnotationRequest_tagTopSheet = "[annotation].[up_AnnotationRequest_tagTopSheet]";

        public const string up_AnnotationRequest_submit = "[annotation].[up_AnnotationRequest_submit]";

        public const string up_CDLIRequirements_retrieveTypes = "annotation.up_CDLIRequirements_retrieveTypes";


        public const string up_CDLIRequirements_retrieve = "annotation.up_CDLIRequirements_retrieve";
        public const string up_RequestCDLIDocuments_retrieveByTransactionNo = "annotation.up_RequestCDLIDocuments_retrieveByTransactionNo";

        public const string up_RequestCDLIDocuments_insert = "annotation.up_RequestCDLIDocuments_insert";
        public const string up_Templates_retrieve = "[annotation].[up_Templates_retrieve]";
        public const string up_ra9048_generateannotation = "[annotation].[up_ra9048_generateannotation]";
        public const string up_ra9048_savefinality = "[annotation].[up_ra9048_savefinality]";
        public const string up_RouteHistory_retrieveByRequestNo = "[odds].[up_RouteHistory_retrieveByRequestNo]";
        public const string up_AnnotationRequest_retrieveForReprint = "[annotation].[up_AnnotationRequest_retrieveForReprint]";
        public const string up_Request_validateForAnnotationReprint = "[annotation].[up_Request_validateForAnnotationReprint]";
        public const string up_Request_updateStatus = "[Encode].[up_Request_updateStatus]";
        public const string up_Release_Processed = "[Release].[up_Release_Processed]";
        public const string up_AnnotationRequest_Cancel = "[annotation].[up_annotationRequest_cancel]";
        public const string up_RequestCDLIDocuments_retrieveTransmittal = "annotation.up_RequestCDLIDocuments_retrieveTransmittal";

        public const string up_Annotation_WizardCheck = "[annotation].[up_WizardValidation_check]";
        #endregion

        #region CRD Submission ECensus

        public const string up_CRDSubmission_insert = "crd.up_CRDSubmission_insert";
        public const string up_CRDTransmittalList_insert = "crd.up_CRDTransmittalList_insert";
        public const string Eup_CDLIRequirements_retrieve = "lcr.up_CDLIRequirements_retrieve";

        #endregion

        #region VEI

        public const string GetAllBarangayList = "[Admin].[up_Barangay_retrieve]";
        public const string GetMasterDetailsByEntity = "vei.up_MasterTables_retrieveAll";
        public const string EncodeVEIRequest = "crd.up_CRDSubmission_insert";
        public const string GetVEIDetails = "crd.up_CRDSubmission_insert";
        public const string GetAllVEIRecords = "crd.up_CRDSubmission_insert";
        public const string GetCompletenessCheckReport = "crd.up_CRDSubmission_rptCompletenessCheck";
        public const string GetRecordListReport = "crd.up_CRDSubmission_rptRecordList";
        public const string GetCertificationPassReport = "vei.up_CRD_certificationpass_batch";
        public const string GetEditListReport = "crd.up_CRDSubmission_insert";

        //Preliminary Statistical Report
        //public const string GetAllVEIReports = "[Admin].[up_VieStatsReports]";
        public const string GetAllVEIReports = "admin.up_Reports_retrieve";
        public const string GetMarriagesByPlaceAndMonth = "vei.up_CRD_rptMarriageByPlace";
        public const string GetMarriagesByRegStatus = "vei.up_CRD_rptMarriageByCeremony";
        public const string GetMarriagesByNationality = "vei.up_CRD_rptMarriageByNationality";
        public const string GetDeathsByPlaceAndSex = "vei.up_CRD_rptDeathByPlace";
        public const string GetInfantDeathsbyResidenceAndSex = "vei.up_CRD_rptInfantDeathByResidence";
        public const string GetInfantDeathsbyPlaceAndSex = "vei.up_CRD_rptInfantDeathByPlace";
        public const string GetMaternalDeathByResidence = "vei.up_CRD_rptMaternalDeathByResidence";
        public const string GetDeathsBySexAndMonth = "vei.up_CRD_rptDeathByResidence";
        public const string GetLiveBirthByNationality = "vei.up_CRD_rptLiveBirthByNationality";
        public const string GetVolumeByMonthReport = "vei.up_CRD_rptVolumeByMonth";
        public const string GetTimelyLateByMonthReport = "vei.up_CRD_rptTimelyLateByMonth";
        public const string GetLiveBirthByReligion = "vei.up_CRD_rptLiveBirthByReligion";
        public const string GetLiveBirthByType = "vei.up_CRD_rptLiveBirthByBirthType";
        public const string GetLiveBirthByPlace = "vei.up_CRD_rptLiveBirthByPlace";
        public const string ResBirthsMotherSexMonth = "vei.up_CRD_rptLiveBirthByResidence";
        public const string VEIBirthInsert = @"[vei].[up_Birth_insert]";
        public const string VEIDeathInsert = @"[vei].[up_Death_insert]";
        public const string VEIMarriageInsert = @"[vei].[up_Marriage_insert]";

        public const string VEIBirthUpdate = @"[vei].[up_Birth_update]";
        public const string VEIDeathUpdate = @"[vei].[up_Death_update]";
        public const string VEIMarriageUpdate = @"[vei].[up_Marriage_update]";

        public const string VEIBirthGetById = @"[vei].[up_Birth_get]";
        public const string VEIDeathGetById = @"[vei].[up_Death_get]";
        public const string VEIMarriageGetById = @"[vei].[up_Marriage_get]";

        public const string VEIBirthSearch = @"[vei].[up_Birth_searchByRegInfo]";
        public const string VEIDeathSearch = @"[vei].[up_Death_searchByRegInfo]";
        public const string VEIMarriageSearch = @"[vei].[up_Marriage_searchByRegInfo]";

        public const string VEIBirthDelete = @"[vei].[up_Birth_Delete]";
        public const string VEIDeathDelete = @"[vei].[up_Death_Delete";
        public const string VEIMarriageDelete = @"[vei].[up_Marriage_Delete]";
        public const string GetAllBatches = @"vei.up_CRD_retrieveListByBatch";


        public const string VEICDLIBirthInsert = @"[vei].[up_BirthCDLI_insert]";
        public const string VEICDLIDeathInsert = @"[vei].[up_DeathCDLI_insert]";
        public const string VEICDLIMarriageInsert = @"[vei].[up_MarriageCDLI_insert]";

        public const string VEICDLIBirthUpdate = @"[vei].[up_BirthCDLI_update]";
        public const string VEICDLIDeathUpdate = @"[vei].[up_DeathCDLI_update]";
        public const string VEICDLIMarriageUpdate = @"[vei].[up_MarriageCDLI_update]";

        public const string VEICDLIBirthGetById = @"[vei].[up_BirthCDLI_get]";
        public const string VEICDLIDeathGetById = @"[vei].[up_DeathCDLI_get]";
        public const string VEICDLIMarriageGetById = @"[vei].[up_MarriageCDLI_get]";

        // public const string VEICRDBirthInsertForIndexFields = @"[vei].[up_Birth_insert_indexonly]";

        public const string VEICRDBirthInsertForIndexFields = @"[vei].[up_Birth_insert_indexonly]";
        public const string VEICRDDeathInsertForIndexFields = @"[vei].[up_Death_insert_indexonly]";
        public const string VEICRDMarriageInsertForIndexFields = @"[vei].[up_Marriage_insert_indexonly]";
        public const string VEICRDBirthUpdateForIndexFields = @"[vei].[up_Birth_update_indexonly]";
        public const string VEICRDDeathUpdateForIndexFields = @"[vei].[up_Death_update_indexonly]";
        public const string VEICRDMarriageUpdateForIndexFields = @"[vei].[up_Marriage_update_indexonly]";
        // public const string VEICRDMarriageUpdateForIndexFields = @"[vei].[up_Marriage_update_indexonlyforDC]";
        public const string VEICRDBirthUpdateForIndexFieldsforDC = @"[vei].[up_Birth_update_indexonlyforDC]";
        public const string VEICRDMarriageUpdateForIndexFieldsforDC = @"[vei].[up_Marriage_update_indexonlyforDC]";
        public const string VEICRDDeathUpdateForIndexFieldsforDC = @"[vei].[up_Death_update_indexonlyforDC]";


        public const string GETGENERALENCODEBIRTHMASTER = @"[vei].[up_GetGeneralEncodeBirthMaster]";
        public const string PetitionRelationship = "[vei].[up_Relationship_retrieve]";
        public const string PetitionReasonBirth = "[vei].[up_PetitionReasonBirth_retrieve]";
        public const string PetitionReasonMrg = "[vei].[up_PetitionReasonMarriage_retrieve]";
        public const string PetitionReasonDeath = "[vei].[up_PetitionReasonDeath_retrieve]";

        public const string PetitionReasonBirthNew = "vei.up_PetitionReasonBirth_retrievenew";
        public const string PetitionReasonMrgNew = "vei.up_PetitionReasonMarriage_retrievenew";
        public const string PetitionReasonDeathNew = "vei.up_PetitionReasonDeath_retrievenew";

        public const string PetitionGround = "[vei].[up_PetitionGround_retrieve]";
        public const string PetitionType = "[vei].[up_PetitionTypeBirth_retrieve]";
        public const string CourtName = "[vei].[up_CourtName_retrieve]";
        public const string GetDeathByUsualResidenceAndSex = "vei.up_CRD_rptFoetalDeathByResidence";
        public const string VEIPhilCrisBirth = "[vei].[up_Birth_importPhilCRIS]";
        public const string VEIPhilCrisDeath = "[vei].[up_Death_importPhilCRIS]";
        public const string VEIPhilCrisMarriage = "[vei].[up_Marriage_importPhilCRIS]";

        public const string GetAllVEIRecordsByBatch = "[vei].[up_CRD_searchByBatch]";
        public const string GetAllVEIRecordsByDocumentOwner = "[vei].[up_CRD_searchByDocumentOwner]";
        public const string GetAllVEIRecordsByRegInfo = "[vei].[up_CRD_searchByRegInfo]";


        public const string TagAsProblemDocumentForBirth = "[vei].[up_Birth_tag_problemdocument]";
        public const string TagAsProblemDocumentForMarriage = "[vei].[up_Marriage_tag_problemdocument]";
        public const string TagAsProblemDocumentForDeath = "[vei].[up_Death_tag_problemdocument]";


        #endregion

        #region DataCleaning

        public const string VSDBirthUpdate = @"[vei].[up_Birth_update]";
        public const string VSDDeathUpdate = @"[vei].[up_Death_update]";
        public const string VSDMarriageUpdate = @"[vei].[up_Marriage_update]";
        public const string GetAllVSDRecords = @"[crd].[up_CRDSubmission_retrieveForDataCleaning]";
        public const string RetriveRegNoListByBatch = @"[crd].[up_CRDSubmission_retrieveRegNoList]";

        public const string VSDCDLIBirthUpdate = @"[vei].[up_Birth_update_indexonly]";
        public const string VSDCDLIDeathUpdate = @"[vei].[up_Death_update_indexonly]";
        public const string VSDCDLIMarriageUpdate = @"[vei].[up_Marriage_update_indexonly]";

        #endregion

        #region SupervisorOverride

        public const string SupervisorOverrideRequest_insert = @"[Encode].[up_SORequest_insert]";
        public const string SupervisorOverride_Retreive = @"[Encode].[up_SORequest_retrieve]";
        public const string SupervisorOverride_RetreivePending = @"[Encode].[up_SORequest_retrievePending]";
        public const string SupervisorOverride_approve = @"[Encode].[up_SORequest_approve]";
        public const string SupervisorOverride_disapprove = @"[Encode].[up_SORequest_disapprove]";
        public const string SupervisorOverride_withdrawal = @"[Encode].[up_SORequest_withdraw]";
        public const string SupervisorOverride_AllRequests = @"[Encode].[up_SORequest_retrieveCurrent]";
        #endregion

        #region RCC
        public const string GetRequestValidateForPA = @"[encode].[up_Request_validateForPA]";
        public const string GetRccBatchType = @"[Rcc].[up_RCCBatchType_retrieve]";
        public const string up_RCCBatchInfo_insert = @"[rcc].[up_RCCBatchInfo_insert]";
        public const string ReceiptRegister_insert = "[RCC].[up_ReceiptRegister_insert]";
        public const string up_ReceiptRegister_retrieveByBatch = "[rcc].[up_ReceiptRegister_retrieveByBatch]";
        public const string up_RCCBatchInfo_retrieve = "[Rcc].[up_RCCBatchInfo_retrieve]";
        public const string up_RCCBatchInfo_searchByBatch = "[Rcc].[up_RCCBatchInfo_searchByBatch]";

        public const string up_RCCBatchInfo_retrieveSearch = "[Rcc].[up_ReceiptRegister_searchByName]";

        public const string up_RCCBatchInfo_retrieveSearchCourier = "[Rcc].[up_ReceiptRegister_searchByCourier]";

        public const string up_RCCBatchInfo_retrieveSearchCourierRetrive = "[Rcc].[up_ReceiptRegister_retrieve]";

        public const string up_RCCBatchInfo_retrieveSearchUpdate = "[Rcc].[up_ReceiptRegister_update]";

        public const string up_StageBatchInfo = "[staging].[up_StagingBatch_retrieve]";

        public const string BirthStaging_exception = "[staging].[up_BirthStaging_exception]";

        public const string up_MarriageStaging_exception = "[staging].[up_MarriageStaging_exception]";

        public const string up_DeathStaging_exception = "[staging].[up_DeathStaging_exception]";


        public const string BirthStaging_setQAResult = "[staging].[up_BirthStaging_setQAResult]";

        public const string DeathStaging_setQAResult = "[staging].[up_DeathStaging_setQAResult]";

        public const string MarriageStaging_setQAResult = "[staging].[up_MarriageStaging_setQAResult]";

        public const string StagingBatchQAReject = "[staging].[up_StagingBatch_QAReject]";

        public const string retrieveActiveItems = "staging.up_StagingBatch_retrieveActiveItems";

        //public const string ViE_match_RetriveForQA = "[staging].[up_ViE_match_RetriveForQA]";

        public const string VEI_match_RetriveForQA = "[staging].[up_ViE_match_RetriveForQA]";
        public const string up_BirthStaging_undoMatch = "staging.up_BirthStaging_undoMatch";
        public const string up_MarriageStaging_undoMatch = "staging.up_MarriageStaging_undoMatch";
        public const string up_DeathStaging_undoMatch = "staging.up_DeathStaging_undoMatch";

        public const string up_Staging_ImageTransfer = "[staging].[up_Staging_ImageTransfer]";

        public const string up_BirthStaging_Tag_Image = "staging.up_BirthStaging_tag_ImageTransfer";
        public const string up_MarriageStaging_Tag_Image = "staging.up_MarriageStaging_tag_ImageTransfer";
        public const string up_DeathStaging_Tag_Image = "staging.up_DeathStaging_tag_ImageTransfer";

        public const string up_StagingBatch_lock = "staging.up_StagingBatch_lock";

        public const string BirthStaging_retrieveByPhase = "[staging].[up_BirthStaging_retrieveByPhase]";

        public const string MarriageStaging_retrieveByPhase = "[staging].[up_MarriageStaging_retrieveByPhase]";
        public const string DeathStaging_retrieveByPhase = "[staging].[up_DeathStaging_retrieveByPhase]";

        #endregion

        #region DocumentConversion

        public const string StagingBatch_register_insert = "[staging].[up_StagingBatch_register]";
        public const string StagingBatch_insert_image = "[staging].[up_StagingBatch_insertimage]";
        public const string StagingBatch_retrieve_image = "[staging].[up_StagingBatch_retrieveimage]";

        public const string ExceptionTypeRetrive = "[staging].[up_ExceptionType_retrieve]";

        public const string ExceptionType_QaResult = "[staging].[up_ExceptionType_QaResult]";


        public const string BirthStaging_match = "[staging].[up_BirthStaging_match]";
        public const string MarriageStaging_match = "[staging].[up_MarriageStaging_match]";
        public const string DeathStaging_match = "[staging].[up_DeathStaging_match]";

        public const string StagingBatch_retrieveMatchingStatus = "[staging].[up_StagingBatch_retrieveMatchingStatus]";
        public const string StagingBatch_completephase = "[staging].[up_StagingBatch_completephase]";
        public const string StagingBatch_updaterework = "[staging].[up_StagingBatch_UpdateRework]";
        public const string NonAnnotatedCRDetrieveforQA = "staging.up_CRD_retrieveForQA";
        public const string StagingBatch_unlock = "staging.up_StagingBatch_unlock";

        #endregion

        #region Monitor Data Cleaning

        public const string up_StagingBatch_Monitor = "[staging].[up_StagingBatch_Monitor]";
        public const string up_StagingBatch_rptMonthly = "[staging].[up_StagingBatch_rptMonthly]";
        public const string up_ErrorLog_rptException = "[staging].[up_ErrorLog_rptException]";

        public static string BatchInfo_SearchView => batchInfo_SearchView;

        #endregion

        #region ODDS

        public const string up_JobRequest_retrieveNew = "[odds].[up_JobRequest_retrieveNew]";
        public const string up_JobRequest_retrieveIn = "[odds].[up_JobRequest_retrieveIn]";
        public const string up_MVReason_retrieve = "[odds].[up_MVReason_retrieve]";
        public const string up_MVReason_update = "[odds].[up_MVReason_update]";
        public const string up_JobResultType_retrieve = "[odds].[up_JobResultType_retrieve]";
        public const string up_JobRequest_routeOutValidate = "[odds].[up_JobRequest_routeOutValidate]";
        public const string up_JobRequest_routeOut = "[odds].[up_JobRequest_routeOut]";
        public const string up_JobRequest_tagFeedbackValidate = "[odds].[up_JobRequest_tagFeedbackValidate]";
        public const string up_JobRequest_tagFeedback = "[odds].[up_JobRequest_tagFeedback]";
        public const string up_JobRequest_routeInValidate = "[odds].[up_JobRequest_routeInValidate]";
        public const string up_JobRequest_routeIn = "[odds].[up_JobRequest_routeIn]";
        public const string up_JobRequest_retrieveDetails = "[odds].[up_JobRequest_retrieveDetail]";
        public const string up_JobRequest_tagNegative = "[odds].[up_JobRequest_tagNegative]";
        public const string up_JobRequest_tagNegativeValidate = "[odds].[up_JobRequest_tagNegativeValidate]";

        public const string up_feedbackemailandphone_details = "release.up_FeedbackContacts_retrieve";

        public const string up_JobRequest_tagasunresolved = "[odds].[up_JobRequest_tagUnresolved]";
        public const string up_JobRequest_tagResolved = "[odds].[up_JobRequest_tagResolved]";

        public const string up_JobRequest_tagasunresolvedValidate = "[odds].[up_JobRequest_tagUnresolvedValidate]";
        public const string up_JobRequest_tagResolvedValidate = "[odds].[up_JobRequest_tagResolvedValidate]";

        public const string up_JobRequest_tagPositive = "[odds].[up_JobRequest_tagPositive]";
        public const string up_JobRequest_tagPositiveValidate = "[odds].[up_JobRequest_tagPositiveValidate]";
        public const string up_JobRequest_routeHistoryRetrieve = "[odds].[up_RouteHistory_retrieve]";
        public const string up_JobRequest_retrieveApplicationForm = "[odds].[up_JobRequest_retrieveApplicationForm]";
        public const string up_JobRequest_insert = "[odds].[up_JobRequest_insert]";
        public const string up_JobRequest_tagPrint = "[odds].[up_JobRequest_tagPrint]";
        public const string updateOtherResultImage = "release.up_Release_updateOtherResultImage";
        public const string up_JobRequest_validateMV = "odds.up_JobRequest_validateMV";

        public const string saveMvAdvisory = "release.up_Release_save";
        public const string getMvAdvisiory = "release.up_Request_MVAdvisory";

        #endregion

        #region UMID
        /// <summary>
        /// This inserts the file information. 
        /// </summary>
        public const string umid_loadumidFile = "umid.up_InputFile_insert";

        /// <summary>
        /// This inserts the records of a file. Record by record. 
        /// </summary>
        public const string umid_loadCRNData = "umid.up_CRNInput_insert";

        /// <summary>
        /// This procedure matches the record and returns the result. Does the processing on PDVE. 
        /// </summary>
        public const string umid_pdveMatchBirthRecordforCRN = "umid.up_Birth_CRNMatch";

        /// <summary>
        /// This procedure matches the records of a file and processes them. 
        /// </summary>
        public const string umid_processCRNInput = "umid.up_CRNInput_process";

        /// <summary>
        /// This procedure retrieves the output of the monitoring. 
        /// </summary>
        public const string umid_retrieveCRNProcessingOutput = "umid.up_CRNInput_retrieveOutput";

        /// <summary>
        /// This procedure is for the monitoring of UMID process. Called during the UI reporting. 
        /// </summary>
        public const string umid_monitorUMIDInputFile = "umid.up_InputFile_monitor";
        #endregion

        #region Secpa
        public const string GET_SPOILAGE_ASSETS = @"[Asset].[sp_GetSpoilageAssets]";
        public const string GET_ALLOCATED_ASSETS = @"[Asset].[sp_GetAllocatedAssets]";
        public const string GET_CONSUMPTION_REPORT = @"[consumable].[up_AssetInventory_retrieve]";
        public const string GET_MIN_INVENTORY_LEVEL_REPORT = @"[Asset].[sp_GetMinInventoryLevelAssets]";
        public const string GetSecpaRanges = @"[consumable].[up_SECPAUsage_rptSECPAranges]";
        public const string TRACE_SECPA_REPORT = @"[release].[up_Release_retrieveBySECPA]";
        public const string GET_USAGE_ASSETS = @"[consumable].[up_UsageDetail_rptUsage]";
        public const string GET_ASSET_DETAILS = @"consumable.up_Purchase_retrieve";
        public const string DELETE_ASSET_DETAILS = @"consumable.up_PurchaseDetail_validateDelete";

        public const string GetPurchaseDetails = @"consumable.up_Purchase_retrieve";
        public const string PurchaseDetail_Insert_Validate = @"consumable.up_PurchaseDetail_ValidateInsert";
        public const string Purchase_Insert = @"consumable.up_Purchase_insert";
        public const string PurchaseDetail_Insert = @"consumable.up_PurchaseDetail_insert";
        public const string PurchaseDetail_Update_Validate = @"consumable.up_PurchaseDetail_ValidateUpdate";
        public const string PurchaseDetail_Update = @"consumable.up_PurchaseDetail_update";
        public const string PurchaseDetail_Delete = @"consumable.up_PurchaseDetail_delete";
        public const string Purchase_Delete = @"consumable.up_Purchase_delete";
        public const string GetAllocationDetails = @"consumable.up_Allocation_retrieve";
        public const string AllocationDetail_Insert_Validate = @"consumable.up_AllocationDetail_ValidateInsert";
        public const string Allocation_Insert = @"consumable.up_Allocation_insert";
        public const string AllocationDetail_Insert = @"consumable.up_AllocationDetail_insert";
        public const string AllocationDetail_Dispatch = @"consumable.up_Allocation_dispatch";
        public const string AllocationDetail_Update_Validate = @"consumable.up_AllocationDetail_ValidateUpdate";
        public const string AllocationDetail_Update = @"consumable.up_AllocationDetail_update";
        public const string AllocationDetail_Delete = @"consumable.up_AllocationDetail_delete";
        public const string Allocation_Delete = @"consumable.up_Allocation_delete";

        public const string Allocation_Detail_Confirm = @"consumable.up_AllocationDetail_confirm";
        public const string Allocation_Detail_Spoil = @"consumable.up_AllocationDetail_spoil";



        //private const string TRACE_SECPA_REPORT = @"[Asset].[sp_TraceDetailsBySecpa]";
        // private const string GET_USAGE_ASSETS = @"[Asset].[sp_GetUsageAssets]";

        #endregion

        #region EIS Reports
        public const string up_MonthlyRevenue_rptRevenueByOutlet = @"eis.up_MonthlyRevenue_rptRevenueByOutlet";
        public const string up_MonthlyRevenue_rptAnnual = @"[eis].[up_MonthlyRevenue_rptAnnual]";
        public const string up_MonthlyRevenue_Insert = @"[eis].[up_MonthlyRevenue_Insert]";
        //public const string up_MonthlyRevenue_rptRevenueShare = @"[eis].[up_MonthlyRevenue_rptRevenueShare1]";
        public const string up_MonthlyRevenue_rptRevenueShare = @"[eis].[up_MonthlyRevenue_rptRevenueShare]";
        public const string up_MonthlyVolume_rptVolumeByOutlet = @"[eis].[up_MonthlyVolume_rptVolumeByOutlet]";
        public const string up_MonthlyVolume_rptAnnual = @"eis.up_MonthlyVolume_rptAnnual";
        public const string up_MonthlyVolumePurpose_rptVolumeByOutlet = @"[eis].[up_MonthlyVolumePurpose_rptVolumeByOutlet]";
        //public const string up_MonthlyRevenue_rptAnnual = @"[eis].[up_MonthlyRevenue_rptAnnual]";
        public const string up_MonthlyRevenue_Transactionvolume = @"eis.up_MonthlyRevenue_rptVolumeRevenueByOutlet";
        public const string up_Payments_rptCollectionsDeposits = @"eis.up_Payments_rptCollectionsDeposits";
        public const string up_MonthlyVolumeNegative_rptVolume = @"eis.up_MonthlyVolumeNegative_rptVolume";
        public const string up_Request_rptPendingRequest = @"[eis].[up_Request_rptPendingRequest]";
        public const string up_MonthlyVolumeRequesterType_rptVolume = @"eis.up_MonthlyVolumeRequesterType_rptVolume";
        public const string up_LCRSubmission_rptVolume = @"[lcr].[up_LCRSubmission_rptVolume]";
        public const string up_Request_rptBackOut = @"eis.up_Request_rptBackOut";

        public const string up_CRD_rptTimelyLateEIS = @"vei.up_CRD_rptTimelyLateEIS";
        public const string Request_rptVolumeChannel = @"eis.up_Request_rptVolumeChannel";
        public const string up_MonthlyRevenue_rptRevenueDetail = @"eis.up_MonthlyRevenue_rptRevenueDetail";
        public const string up_CRDSubmission_rptPerformance = @"[crd].[up_CRDSubmission_rptPerformance]";
        public const string up_MonthlyRevenue_rptRevenueSummary = @"eis.up_MonthlyRevenue_rptRevenueSummary";
        public const string up_MonthlyRevenue_BREQsSubmission = @"eis.up_BatchPayment_rptSubmissions";
        public const string up_MonthlyRevenue_Pronobo = @"[eis].[up_Request_rptProbono]";

        public const string KPIServiceLevel_getPivot = @"eis.up_KPIServiceLevel_getPivot";
        public const string MonthlyVolume_getPivot = @"eis.up_MonthlyVolume_getPivot";
        public const string MonthlyRevenue_getPivot = @"eis.up_MonthlyRevenue_getPivot";

        public const string KPIOutletFacilities_getResults = @"eis.up_KPIOutletFacilities_getResults";
        public const string up_KPIOutletAvailability_rptSummary = @"eis.up_KPIOutletAvailability_rptSummary";
        public const string up_KPIDataCenterAvailability_getPercentage = @"eis.up_KPIDataCenterAvailability_getPercentage";
        public const string up_KPIOutletFacilities_getResults = @"eis.up_KPIOutletFacilities_getResults";

        public const string KPIOutletTemperature_insert = @"eis.up_KPIOutletTemperature_insert";
        public const string KPIOutletRestroom_insert = @"eis.up_KPIOutletRestroom_insert";

        public const string up_OperatingOutlets_saveSeats = @"eis.up_OperatingOutlets_saveSeats";

        public const string KPIServiceLevel_insert = @"eis.up_KPIServiceLevel_insert";
        public const string up_KPIEndorsement_getPercentage = @"eis.up_KPIEndorsement_getPercentage";
        public const string LGUForms = @"[eis].[up_MonthlyLGUSubsidy_rptOndemand]";

        #endregion

        #region CollectionTarcking

        public const string GetPaymentSource = "web.up_PaymentSource_retrieve";
        public const string GetPaymentExceptionStatus = "web.up_PaymentExceptionStatus_retrieve";
        public const string GetPaymentExceptionType = "web.up_PaymentExceptionType_retrieve";
        public const string Sp_WebPayments_retrieve = "web.up_WebPayments_retrieve";
        public const string Sp_WebPayments_Search = "web.up_WebPayments_search";
        public const string Sp_WebPayments_searchForPayment = "web.up_WebPayments_searchForPayment";
        public const string Sp_PaymentGroupRetrieveDetails = "web.up_PaymentGroup_retrieveDetails";
        public const string Sp_WebPayments_AddPayment = "web.up_WebPayments_addPayment";
        public const string Sp_WebPayments_RemovePayment = "web.up_WebPayments_removePayment";
        public const string sp_WebPayments_RefundPayment_RetrieveByGroup = "web.up_PaymentRequest_retrieveByGroup";
        public const string sp_WebPayments_RefundPayment = "web.up_WebPayments_refund";
        public const string sp_Webpayments_RateDeviationUpdate = "web.up_RateDeviation_update";
        public const string sp_Webpayments_RateDeviationRetrieve = "web.up_RateDeviation_retrieve";
        public const string sp_WebPayments_AddRemarks = "web.up_WebPayments_addRemarks";
        public const string sp_WebPaymentGroup_Approve = "web.up_PaymentGroup_approve";
        public const string sp_WebRequestSearch = "web.up_Request_Search";
        public const string sp_WebRequestAddRequest = "web.up_PaymentRequest_addRequest";
        public const string sp_WebRequestRemoveRequest = "web.up_PaymentRequest_removeRequest";
        public const string sp_WebpaymentCurrencyDeviationRetrieve = "web.up_RateDeviation_retrieve";
        public const string Sp_Retrieve_Pending_Exceptions = "web.up_WebPayments_rptPending";

        public const string Sp_Retrieve_Summary_Exceptions = "web.up_WebPayments_rptSummaryCollections";

        public const string SummaryExceptions = "web.up_WebPayments_rptSummaryCollections";

        public const string sp_WebpaymentAddRequestValidate = "web.up_PaymentRequest_addRequestValidate";
        public const string sp_WebPaymentGroup_retrieveforEmail = "web.up_PaymentGroup_retrieveforEmail";

        #endregion

        #region Print Acknowledgement
        public const string up_Request_retrieveAcknowledgement = @"[Encode].[up_Request_retrieveAcknowledgement]";
        #endregion

        #region HelpDesk

        public const string up_files_filetoactions_insert = @"[dbo].[up_files_filetoactions_insert]";
        public const string up_usractions_insert = @"[dbo].[up_usractions_insert]";
        public const string up_usr_insert = @"[dbo].[up_appusers_insert]";
        public const string up_usr_update = @"[dbo].[up_appusers_update]";
        public const string up_usr_retrieve = @"[dbo].[up_appusers_retrievebyuserid]";

        #endregion

        #region Public Assistance
        public const string pa_up_PAQuery_rptComplaints = @"[pa].[up_PAQuery_rptComplaints]";
        public const string pa_up_PAQuery_rptAging = @"[pa].[up_PAQuery_rptAging]";

        public const string pa_up_ModeOfQuery_retrieve = @"[pa].[up_ModeOfQuery_retrieve]";
        public const string pa_up_PACategory_retrieve = @"[pa].[up_PACategory_retrieve]";
        public const string pa_up_PASubCategory_retrieve = @"[pa].[up_PASubCategory_retrieve]";
        public const string pa_up_PASeverity_retrieve = @"[pa].[up_PASeverity_retrieve]";
        public const string pa_up_PAQuery_insert = @"[pa].[up_PAQuery_insert]";

        public const string pa_up_PAStatus_retrieve = @"[pa].[up_PAStatus_retrieve]";
        public const string pa_up_PAQuery_Update = @"[pa].[up_PAQuery_update]";
        public const string pa_up_PAResponse_Insert = @"[pa].[up_PAResponse_insert]";
        public const string pa_up_PAQuery_search = @"[pa].[up_PAQuery_search]";
        public const string pa_up_PAQuery_retrieve = @"[pa].[up_PAQuery_retrieve]";
        public const string pa_up_PAQuery_reopen = @"[pa].[up_PAQuery_reopen]";
        #endregion

        #region OS Feedback
        public const string hd_up_OSFeedback_retrieveWeekendDates = @"[dbo].[up_OSFeedback_retrieveWeekendDates]";
        #endregion

        #region KioskAdmin
        public const string InsertKioskAdmin = @"[Admin].[up_Kiosk_insert]";
        public const string UpdateKioskAdmin = @"[Admin].[up_Kiosk_update]";
        public const string RetriveKioskAdmin = @"[Admin].[up_Kiosk_retrieve]";
        #endregion

        #region AssetManagement

        public const string assetup_AssetTypes_retrieve = "[Asset].[up_AssetTypes_retrieve]";
        public const string assetup_Location_retrieve = "[asset].[up_Location_retrieve]";
        public const string assetup_Asset_retrieveRefresh = "[asset].[up_AssetMaster_retrieveRefresh]";
        public const string assetup_up_AssetTypes_retrieve = "[asset].[up_AssetTypes_retrieve]";
        public const string assetup_up_AssetProjectNo_retrieve = "[asset].[up_Project_retrieve]";
        public const string assetup_up_AssetStatus_retrieve = "[asset].[up_AssetStatus_retrieve]";
        public const string assetup_up_retrieveInventoryByType = "[asset].[up_AssetMaster_retrieveInventoryByType]";
        public const string assetup_up_retrieveInventoryByLocation = "[asset].[up_AssetMaster_retrieveInventoryByLocation]";
        public const string assetup_Supplier_insert = "[Asset].[up_Supplier_insert]";
        public const string assetup_Supplier_search = "[Asset].[up_Supplier_search]";
        public const string assetup_Supplier_update = "[Asset].[up_Supplier_update]";
        public const string assetup_Supplier_Delete = "[asset].[up_Supplier_delete]";
        public const string assetup_up_Supplier_retrieve = "[Asset].[up_Supplier_retrieve]";
        public const string asset_up_AssetMaster_insert = "[Asset].[up_AssetMaster_insert]";
        public const string asset_up_AssetMaster_update = "[Asset].[up_AssetMaster_update]";
        public const string asset_up_AssetMaster_validate = "[Asset].[up_AssetMaster_validate]";
        public const string asset_up_AssetMaster_retrieve = "[Asset].[up_AssetMaster_retrieve]";
        public const string asset_up_AssetMaster_search_serialno = "[Asset].[up_AssetMaster_search_serialno]";
        public const string asset_up_AssetMaster_search_tag = "[Asset].[up_AssetMaster_search_tag]";
        public const string assetup_AssetMaster_search_Deployment = "asset.up_AssetMaster_search_Deployment";
        public const string assetup_AssetMaster_search_Supplier = "asset.up_AssetMaster_search_Supplier";
        public const string asset_up_AssetMaster_search_Location = "asset.up_AssetMaster_search_Location";
        public const string asset_up_AssetHistory_retrieve = "[Asset].[up_AssetHistory_retrieve]";
        public const string asset_up_AssetMaster_retrieveAll = "[asset].[up_AssetMaster_retrieveAll]";
        public const string asset_up_AssetMaster_retrievelist = "[Asset].[up_AssetMaster_retrievelist]";
        public const string asset_up_AssetMaster_retrievelistByType = "asset.up_AssetMaster_retrievelistByType";
        #endregion
        #region EPos
        public const string Epos_Origin_retrieve = "web.up_Requester_retrieveOrigin";
        public const string Epos_OR_Cancellation = "web.up_GTAPayments_cancel";
        public const string Epos_GTAOR_retrieve = "web.up_Request_retrieveForGTAOR";
        public const string Epos_GTAPayments_generateOR = "web.up_GTAPayments_generateOR";
        public const string up_GTAPayments_rptPaymentDetails = "web.up_GTAPayments_rptPaymentDetails";
        public const string up_GTAPayments_rptRevenue = "web.up_GTAPayments_rptRevenue";
        public const string up_GTAPayments_retrieveManualOR = "web.up_GTAPayments_retrieveManualOR";
        public const string up_GTAPayments_manualOR = "web.up_GTAPayments_manualOR";
        public const string up_GTAPayments_Orcancellationserch = "web.up_GTAPayments_search";
        public const string up_ORType_Retrieve = "web.up_ORType_retrieveSource";
        public const string up_ORStatus_Retrieve = "web.up_ORStatus_retrieve";
        #endregion

        #region OrderTracking

        public const string OTS_DeliveryAddress_retrieve = "web.up_DeliveryAddress_retrieve";
        public const string OTS_DeliveryOptions_retrieve = "web.up_DeliveryOptions_retrieve ";
        public const string OTS_ConversionStatus_retrieve = "web.up_ConversionStatus_retrieve";
        public const string OTS_up_Request_retrieveForOTS = "web.up_Request_retrieveForOTS";
        public const string OTS_up_RegisteredMail_export = "web.up_RegisteredMail_export";
        public const string OTS_web_up_Requester_retrieveDetail = "web.up_Requester_retrieveDetail";
        public const string OTS_web_up_Request_Search_OTS = "web.up_Request_Search_OTS";
        public const string OTS_up_Courier_retrieve = "web.up_Courier_retrieve";
        public const string OTS_up_RegisteredMail_import = "web.up_RegisteredMail_import";
        public const string OTS_up_UpdateRequester = "encode.up_Requester_update";
        public const string OTS_up_RegisterMail_updateStatus = "web.up_RegisterMail_updateStatus";
        public const string OTS_up_InsertRequesterHistory = " encode.up_RequesterHistory_insert";
        public const string OTS_web_up_RegisteredMail_dispatch = "web.up_RegisteredMail_dispatch";




        public const string OTS_up_RegisteredMail_printTransmittal = "web.up_RegisteredMail_printTransmittal";
        public const string OTS_up_RegisteredMail_printMailingLabels = "web.up_RegisteredMail_printLabels";
        public const string OTS_up_PrintApplicationForm = "web.up_RegisteredMail_printApplicationForm";
        public const string OTS_up_PrintIndividualApplicationForm = "web.up_RegisteredMail_printApplicationForm";
        public const string OTS_up_PrintReturnReceipts = "web.up_RegisteredMail_printReturnReceipt";
        public const string OTS_up_EmailTemplate_retrieve = "web.up_EmailTemplate_retrieve";
        public const string OTS_up_RegisteredMail_sendEmail = "web.up_RegisteredMail_sendEmail";




        #endregion

        #region CRSAdmin
        public const string RetrieveWebAnnouncements = "web.up_News_retrieve";
        public const string DeleteWebAnnouncements = "web.up_News_delete";
        public const string UpdateWebAnnouncements = "web.up_News_update";
        public const string InsertWebAnnouncements = "web.up_News_insert";
        public const string RetriveBlockListUsers = "web.up_BlackListReason_retrieve";
        public const string DeleteBlockListUser = "web.up_BlackList_delete";
        public const string UpdateBlockListUser = "web.up_BlackList_updateStatus";
        public const string UpdateBREQSRecord = "breq.up_BreqsRequest_update";
        public const string InsertBlockListUser = "web.up_BlackList_insert";
        public const string SearchBlockListUsers = "web.up_BlackList_search";
        #endregion
        #region DeferredPaymentClient
        public const string up_DepositInvoices_insert = @"payment.up_DepositInvoices_insert";
        public const string up_DeferredPaymentInvoice_retrieveForBankDeposit = @"invoice.up_DeferredPaymentInvoice_retrieveForBankDeposit";
        #endregion

        #region RequestStatusInquiry
        public const string RetrieveRequeststatusInquiry = @"[web].[up_Request_statusInquiry]";
        public const string RequestStatusInquiryByDocOwner = @"[web].[up_request_statusInquiryByName]";
        public const string RetrieveOtherResultImage = @"[release].[up_Release_retrieveOtherResultImage]";
        #endregion

        #region CyberOutlet

        public const string RemittanceCollections = @"payment.up_Remittance_retrieveForDepositAPI";

        public const string BankDepositInsert = @"payment.up_BankDeposit_insertOutletAPI";


        public const string UpdateImageForBankDeposit = @"payment.up_BankDeposit_updateImage";

        #endregion

        #region InfoImage
        public const string getInfoImageStagingDomain = @"dbo.up_StagingDomain_getDomain";
        public const string getInfoImageLocatorDomain = @"dbo.up_Locator_getDomain";
        public const string getReleasetblImageData = @"release.up_Release_retrieve";

        #endregion     

        #region DC New SP
        public const string up_StagingBatch_retrieveimages = @"staging.up_StagingBatch_retrieveimages";
        #endregion
        #region long queue
        public const string up_Request_validateForDP = @"encode.up_Request_validateForDP";
        public const string up_Requester_insertWalkIn = @"encode.up_Requester_insertWalkIn";
        public const string up_Request_insertWalkIn = @"encode.up_Request_insertWalkIn";
        public const string GetConversionStatus = @"pdve.up_ConvStatus_check";
        #endregion
        public const string Request_SearchPASlip = "encode.up_Request_SearchPA";
        public const string Request_SearchEEForm = "encode.up_Request_SearchEE";
    }
}
