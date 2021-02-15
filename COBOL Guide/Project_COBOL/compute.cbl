       IDENTIFICATION DIVISION.
       PROGRAM-ID. HELLO.
       author. KL.Cheng.

       DATA DIVISION.
           WORKING-STORAGE SECTION.
           01 WS-NUM1 PIC 9(5).
           01 WS-NUM2 PIC 9(5).
           01 WS-RESULT pic 9(5).
           01 ABC pic x(1).
      
       PROCEDURE DIVISION.
           DISPLAY "INPUT NUM1 : ".
           ACCEPT WS-NUM1. 
           DISPLAY "INPUT NUM2 : ".
           ACCEPT WS-NUM2.
           MULTIPLY WS-NUM1 BY WS-NUM2 giving WS-RESULT.
           DISPLAY "RESULT IS : " , WS-RESULT.
           
       STOP RUN.
