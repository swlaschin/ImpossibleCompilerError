module MyModule

[<LiteralAttribute>]
let sample = """"C","ID","ClientID","ExtractDate","ColID","ExtColId","PFMstrID","PFPeriod","PFFinStTyp","PFKey","PFLineItmID","PFMAnalDt","PFMAnalCmpl","PFSortOrd","PFDtNxtFinDue","PFNxtFinDueFrq","PFNxtFinDueFrqTyp","PFMReqdQualTyp","PFMRecvdQualTyp","PFMInpTplTyp","PFMFiscYrEndDt","PFMBegDt","PFMAnnMeth","PFAmt","PFAdjAmt","PFNormAmt","PFAnnAmt","PFRptAmt","PFDesc","PFNt","PFMSourceTyp","PFMDSCRCmt","PFMIncmCmt","PFMExpnsCmt","PFMCapCmt","PFNotes","EffGrossIncm","TotOpExpns","NetOpIncm","TotCapItms","NetCshFlow","NOIDebtSvc","NCFDebtSvc","OpExpRatio","DebtSvc","DebtSvcB","DebtSvcC","NOIDebtSvcAB","NCFDebtSvcAB","NOIDebtSvcABC","NCFDebtSvcABC","FSREVFstName","FSREVLstName","FSREVRExtID","SLILineItmNo","DeltaReason","FSCNTCTFstName","FSCNTCTLstName","FSCNTCTRExtID","PFMSendToInv","PFMDtSentToInv","PFMDtReqdToInv","PFMRecvdDt","PFUpdatedBy","PFMAnalCmplDtUpdated","PFMAnalCmplUpdatedBy","PFMAnalDtUpdatedBy","PFMAnalDtUpdatedDt","PFMCapCmtDtUpdated","PFMCapCmtUpdatedBy","PFMDSCRCmtDtUpdated","PFMDSCRCmtUpdatedBy","PFMExpnsCmtDtUpdated","PFMExpnsCmtUpdatedBy","PFMIncmCmtDtUpdated","PFMIncmCmtUpdatedBy","PFMUpdatedBy","PFMWaiverCd","PFMWaiverNotes"
"D",2523108141,1,04/06/2015 21:38:20,20161,"144296",3399423,09/30/2005 00:00:00,"QTR",5340024,266,12/20/2005 00:00:00,True,4,09/30/2005 00:00:00,0,"D","","","CMSAMF",12/31/2005 00:00:00,04/01/2005 00:00:00,"Actual",595.0000,0.0000,1190.0000,1190.0000,595.0000,"late",,"BORR",,"","","","",196939.8000,92535.4400,104404.3600,6449.0300,97955.3300,0.00000000,0.00000000,0.46990000,0.0000,0.0000,0.0000,0.00000000,0.00000000,0.00000000,0.00000000,"Joseph","Rohlena","",1050,,,,,True,,,,,,,,,,,,,,,,,"KJMcRoy",,
"""

type PropertyOperatingStatementTP = FSharp.Data.CsvProvider<sample,Separators=",",HasHeaders=true >

/// Change this comment to a double slash and it compiles without error! Otherwise you get "parameter error FS0192: error : impossible"
let toUpdateCommand (source:PropertyOperatingStatementTP.Row)  =
    ()

