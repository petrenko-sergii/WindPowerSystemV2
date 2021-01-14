------------------------------- Settings for output ---------------------------------
SET SERVEROUTPUT ON
SET LINESIZE 32767
SET HEADING ON
SET HEADSEP OFF
SET WRAP OFF

------------------------------- Drop table, sequence for table: ADDRESS ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'ADDRESS';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'ADDRESS_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: FLATPART ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'FLATPART';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'FLATPART_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/


------------------------------- Drop table, sequence for table: SNUMBER ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'SNUMBER';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'SNUMBER_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: ADDRESSIMAGE ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'ADDRESSIMAGE';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'ADDRESSIMAGE_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: FLAGIMAGE ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'FLAGIMAGE';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'FLAGIMAGE_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: APPIMAGE ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'APPIMAGE';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'APPIMAGE_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: STREET ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'STREET';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'STREET_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: TOWN ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'TOWN';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'TOWN_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: COUNTRY ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'COUNTRY';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'COUNTRY_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: POSTCODE ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'POSTCODE';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'POSTCODE_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: TURBINE ---------------------------------

BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'TURBINE';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'TURBINE_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

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

------------------------------- Drop table, sequence for table: SHAREHOLDER ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'SHAREHOLDER';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'SHAREHOLDER_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: SHAREHOLDERTYPE ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'SHAREHOLDERTYPE';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'SHAREHOLDERTYPE_SEQ';
EXCEPTION
  WHEN OTHERS THEN
    IF SQLCODE != -2289 THEN
      RAISE;
    END IF;
END;
/

------------------------------- Drop table, sequence for table: STOCKSHARE ---------------------------------
BEGIN
   EXECUTE IMMEDIATE 'DROP TABLE ' || 'STOCKSHARE';
EXCEPTION
   WHEN OTHERS THEN
      IF SQLCODE != -942 THEN
         RAISE;
      END IF;
END;
/

BEGIN
  EXECUTE IMMEDIATE 'DROP SEQUENCE ' || 'STOCKSHARE_SEQ';
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


