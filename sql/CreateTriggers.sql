

------------------------------------- Create trigger for TURBINETYPE ---------------------------------------
create or replace trigger trg_turbinetype
   before insert on turbinetype for each row
declare
   v_id number;
begin
   if (:new.id is null or :new.id = 0) then
      select turbinetype_seq.nextval into v_id from dual;
      :new.id := v_id;
   end if;
end;
/

---------------------------------------------------- Commit -----------------------------------------------
commit;

-------------------------------------------- Print the log-message ----------------------------------------

BEGIN
	DBMS_OUTPUT.PUT_LINE('*******************************************************************');
	DBMS_OUTPUT.PUT_LINE('*******************----------------------------********************');
	DBMS_OUTPUT.PUT_LINE('************---- TRIGGERS ARE CREATED SUCCESSFULLY ----************');
	DBMS_OUTPUT.PUT_LINE('*******************----------------------------********************');
	DBMS_OUTPUT.PUT_LINE('*******************************************************************');
END;
/


