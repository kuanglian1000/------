           IDENTIFICATION DIVISION.
           PROGRAM-ID. USERINPUT.
           DATA DIVISION.
               WORKING-STORAGE SECTION.
               01 n binary-long.
               01 i binary-long.
               01 s binary-long value 0.
           PROCEDURE DIVISION.
               display "enter a positive integer".
               accept n.
               display "Your input is " n.
                                     