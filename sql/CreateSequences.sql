
------------------------------------- Create sequence for TURBINETYPE ID ---------------------------------------
create sequence turbinetype_seq
start with 1
increment by 1
minvalue 1
maxvalue 9223372036854775807
nocache
nocycle 
noorder;

------------------------------------- Create sequence for TURBINE ID ---------------------------------------
create sequence turbine_seq
start with 1
increment by 1
minvalue 1
maxvalue 9223372036854775807
nocache
nocycle 
noorder;

------------------------------------- Create sequence for STOCKSHARE ID ---------------------------------------
create sequence stockshare_seq
start with 1
increment by 1
minvalue 1
maxvalue 9223372036854775807
nocache
nocycle 
noorder;

------------------------------------------------------ Commit ------------------------------------------------
commit;

----------------------------------------------- Print the log-message ----------------------------------------

BEGIN
	DBMS_OUTPUT.PUT_LINE('*******************************************************************');
	DBMS_OUTPUT.PUT_LINE('*******************----------------------------********************');
	DBMS_OUTPUT.PUT_LINE('***********---- SEQUENCES ARE CREATED SUCCESSFULLY ----************');
	DBMS_OUTPUT.PUT_LINE('*******************----------------------------********************');
	DBMS_OUTPUT.PUT_LINE('*******************************************************************');
END;
/
