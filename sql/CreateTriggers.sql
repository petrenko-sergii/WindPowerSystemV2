------------------------------------- Create trigger for ADDRESSIMAGE ---------------------------------------
create or replace trigger trg_addressimage
   before insert on addressimage for each row
declare
   v_id number;
begin
   if (:new.id is null or :new.id = 0) then
      select addressimage_seq.nextval into v_id from dual;
      :new.id := v_id;
   end if;
end;
/

------------------------------------- Create trigger for FLAGIMAGE ---------------------------------------
create or replace trigger trg_flagimage
   before insert on flagimage for each row
declare
   v_id number;
begin
   if (:new.id is null or :new.id = 0) then
      select flagimage_seq.nextval into v_id from dual;
      :new.id := v_id;
   end if;
end;
/

------------------------------------- Create trigger for APPIMAGE ---------------------------------------
create or replace trigger trg_appimage
   before insert on appimage for each row
declare
   v_id number;
begin
   if (:new.id is null or :new.id = 0) then
      select appimage_seq.nextval into v_id from dual;
      :new.id := v_id;
   end if;
end;
/

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

------------------------------------- Create trigger for TURBINE ---------------------------------------
create or replace trigger trg_turbine
   before insert on turbine for each row
declare
   v_id number;
begin
   if (:new.id is null or :new.id = 0) then
      select turbine_seq.nextval into v_id from dual;
      :new.id := v_id;
   end if;
end;
/

------------------------------------- Create trigger for SHAREHOLDERTYPE ---------------------------------------
create or replace trigger trg_shareholdertype
   before insert on shareholdertype for each row
declare
   v_id number;
begin
   if (:new.id is null or :new.id = 0) then
      select shareholdertype_seq.nextval into v_id from dual;
      :new.id := v_id;
   end if;
end;
/

------------------------------------- Create trigger for SHAREHOLDER ---------------------------------------
create or replace trigger trg_shareholder
   before insert on shareholder for each row
declare
   v_id number;
begin
   if (:new.id is null or :new.id = 0) then
      select shareholder_seq.nextval into v_id from dual;
      :new.id := v_id;
   end if;
end;
/

------------------------------------- Create trigger for STOCKSHARE ---------------------------------------
create or replace trigger trg_stockshare
   before insert on stockshare for each row
declare
   v_id number;
begin
   if (:new.id is null or :new.id = 0) then
      select stockshare_seq.nextval into v_id from dual;
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


