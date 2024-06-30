ProcedureDLL.s PBFunction()
    MessageRequester("Hello", "This is a PureBasic DLL !", 0)
    ProcedureReturn "This is a PureBasic function"
  EndProcedure

ProcedureDLL.i Add(a.i, b.i)
    ProcedureReturn a + b
EndProcedure

ProcedureDLL.s TestConnection()
    If OpenDatabase(0, "host=localhost port=5432", "postgres", "189MiltonAve!!")
        ProcedureReturn "Connected to PostgreSQL"
    Else 
        ProcedureReturn "Connection Failed"
    EndIf
EndProcedure
    

; IDE Options = PureBasic 6.11 LTS (Windows - x64)
; CursorPosition = 15
; Folding = -
; EnableXP
; DPIAware