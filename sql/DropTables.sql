------------------------------- Settings for output ---------------------------------
SET SERVEROUTPUT ON
SET LINESIZE 32767
SET HEADING ON
SET HEADSEP OFF
SET WRAP OFF


------------------------------- Drop table, sequence for table: TURBINETYPE ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'TURBINETYPE';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'TURBINETYPE_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/


----------------------------------------------- Commit ------------------------------------------------
commit;

------------------------------- Print the log-message ---------------------------------

BEGIN
	DBMS_OUTPUT.PUT_LINE('*******************************************************************');
	DBMS_OUTPUT.PUT_LINE('*******************----------------------------********************');
	DBMS_OUTPUT.PUT_LINE('*******************---- TABLES ARE DELETED ----********************');
	DBMS_OUTPUT.PUT_LINE('*******************----------------------------********************');
	DBMS_OUTPUT.PUT_LINE('*******************************************************************');
END;
/

